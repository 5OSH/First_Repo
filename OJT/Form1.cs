using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net.NetworkInformation;

//C:\osh\winform\OJT\OJT\bin\Debug    실행파일 생성되는 디렉토리
namespace OJT
{
    public partial class Form1 : Form
    {
        public static TcpClient tcpClient = null;
        public static NetworkStream stream = null;
        private string _iniPath = Application.StartupPath + @"\\setup.ini";
        
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string section, string key, string val, string filePath);
        
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // KeyDown 이벤트 받을 때 필요
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="valueCapacity"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public string GetIniValue(string section, string key, int valueCapacity, string filePath)
        {
            string ReturnValue; StringBuilder tmp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", tmp, 255, filePath);
            ReturnValue = tmp.ToString();
            return ReturnValue;
        }
        public static void SetIniValue(string section, string key, string value, string filePath)
        {
            WritePrivateProfileString(section, key, value, filePath);
        }

        private void GetIniValues()
        {
            txtIP.Text = GetIniValue("COMMUNICATIUON", "IP", 30, _iniPath);
            txtPort.Text = GetIniValue("COMMUNICATIUON", "Port", 30, _iniPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            GetIniValues();
            ConnectToServer();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (tcpClient != null)
            {
                try
                {
                    CheckPacket();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"타이머에서 오류 : {ex.Message}");
                }
            }
            //ConnectToServer();
            //CloseTcpClient();
            
        }

        private void AutoManual_CheckedChanged(object sender, EventArgs e)
        {
            AutoManual.BackColor = Color.White;
            AutoManual.Visible = false;
            BtnManual.Visible = true;
            BtnRun.Visible = true;
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyData == (Keys.F6))
            {
                Model_Edit F6form = new Model_Edit();
                F6form.StartPosition = FormStartPosition.CenterScreen;
                F6form.ShowDialog(); //modal 창(다른 폼은 이용 불가) 띄우기. modaless 창 띄우기는 폼이름.Show()
            }
            else if(e.KeyData == (Keys.Control | Keys.Shift | Keys.F8))
            {
                Manual_Test F8form = new Manual_Test();
                F8form.StartPosition = FormStartPosition.CenterScreen;
                F8form.ShowDialog();
            }
            else if(e.KeyData == Keys.F7)
            {
                Ng_codes ng_Codes = new Ng_codes();
                ng_Codes.StartPosition = FormStartPosition.CenterParent;
                ng_Codes.ShowDialog();
            }
            else if (e.KeyData == (Keys.Control | Keys.Shift | Keys.F4))
            {
                
                Application.Exit();

            }
        }

        private void BtnManual_CheckedChanged(object sender, EventArgs e)
        {
            BtnManual.BackColor = Color.White;
            AutoManual.Visible = true;
            BtnManual.Visible = false;
            BtnRun.Visible = false;
        }

        private void BtnRun_CheckedChanged(object sender, EventArgs e)
        {
            BtnRun.BackColor = Color.White;
        }

        private void chkSettings_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btniniSave_Click(object sender, EventArgs e)
        {
            SetIniValue("COMMUNICATIUON", "IP", txtIP.Text, _iniPath);
            SetIniValue("COMMUNICATIUON", "PORT", txtPort.Text, _iniPath);
        }
        private void ConnectToServer()
        {
            try
            {
                // 기존 연결이 있으면 닫기
                if (tcpClient != null && tcpClient.Connected)
                {
                    return;
                }
                else
                {
                    tcpClient = new TcpClient(txtIP.Text, Int32.Parse(txtPort.Text));
                    stream = tcpClient.GetStream();
                    ErrMessage.Text = "UvServer Connected!";
                    picControllerState.Image = Properties.Resources.on;
                }
                
            }
            catch (Exception ex)
            {
                txtResponse.Text = $"Error connecting to server: {ex.Message}";
                ErrMessage.Text = "UvServer DisConnected";
                picControllerState.Image = Properties.Resources.off;
            }
            

            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectToServer();
                if (tcpClient == null || !tcpClient.Connected)
                {
                    ConnectToServer();
                    picControllerState.Image = Properties.Resources.off;
                    ErrMessage.Text = "UvServer DisConnected";
                }
                else if(tcpClient != null)
                {
                    ErrMessage.Text = "UvServer Connected";
                    picControllerState.Image = Properties.Resources.on;

                }
            }
            catch (Exception ex)
            {
                ErrMessage.Text = $"Error: {ex.Message}";
            }
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient != null)
                {
                    tcpClient.Close();
                    tcpClient = null;
                    stream.Close();
                    picControllerState.Image = Properties.Resources.off;
                    ErrMessage.Text = "UvServer DisConnected";
                    txtResponse.Text = "";
                }
            }
            catch (Exception ex)
            {
                ErrMessage.Text = $"Error: {ex.Message}";
            }
        }
        private void CloseTcpClient()
        {
            try
            {
                if (tcpClient != null && stream != null)
                {
                    byte[] responseBuffer = new byte[1024];
                    int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                    string response = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);

                    if (string.IsNullOrEmpty(response))
                    {
                        tcpClient.Close();
                        stream.Close();
                        picControllerState.Image = Properties.Resources.off;
                        MessageBox.Show("Server disconnected");
                        tcpClient = null;
                        stream = null;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"오류 : {ex.Message}");
            }
        }
        
        private void CheckPacket()
        {
            if (tcpClient != null)
            {
                byte[] responseBuffer = new byte[1024];
                int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                string response = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);
                txtResponse.Text = $"서버 응답 : {response}";
                string[] packets = response.Split('\x03');
                int ErrCount = 0;
                int FaultCount = 0;
                foreach (string packet in packets)
                {
                    if (packet.StartsWith("\x02UMA"))
                    {
                        string[] UMApacket = packet.Split(',');
                        txtPSUStatusTemp0.Text = (double.Parse(UMApacket[2]) / 10).ToString();
                        txtPSUStatusTemp1.Text = (double.Parse(UMApacket[3]) / 10).ToString();

                        PictureBox[] picFan = { picFan1, picFan2, picFan3, picFan4, picFan5, picFan6, picFan7, picFan8, picFan9, picFan10 };
                        PictureBox[] picBdFan = { picBdFan1, picBdFan2, picBdFan3, picBdFan4 };
                        int.TryParse(UMApacket[6], System.Globalization.NumberStyles.HexNumber, null, out int FanData);
                        for (int i = 0; i < 10; i++)
                        {
                            int ErrorFanData = FanData & (1 << i);
                            if (ErrorFanData == (1<<i)) // FAN 상태 (0x0000 16개중 10개 사용)
                            {
                                ErrCount += 1;
                                picFan[i].Image = Properties.Resources.fan_error;
                                ErrMessage.Text = "I/O Fan error!";
                            }
                            else if(ErrorFanData != (1<<i))
                            {
                                picFan[i].Image = Properties.Resources.fan;
                            }
                        }
                        
                        switch (UMApacket[7])
                        {
                            case "00":
                                picFrontDr.Image = Properties.Resources.door;
                                picBackDr.Image = Properties.Resources.door;
                                break;
                            case "01":
                                picFrontDr.Image = Properties.Resources.openeddoor;
                                picBackDr.Image = Properties.Resources.door;
                                ErrMessage.Text = "FrontDoor Opened!";
                                ErrCount += 1;
                                break;
                            case "02":
                                picFrontDr.Image = Properties.Resources.door;
                                picBackDr.Image = Properties.Resources.openeddoor;
                                ErrMessage.Text = "BackDoor Opened!";
                                ErrCount += 1;
                                break;
                            case "03":
                                picFrontDr.Image = Properties.Resources.openeddoor;
                                picBackDr.Image = Properties.Resources.openeddoor;
                                ErrMessage.Text = "Front, Back Door Opened!";
                                ErrCount += 1;
                                break;
                        }

                        int.TryParse(UMApacket[8], System.Globalization.NumberStyles.HexNumber, null, out int IOinput);
                        for (int i = 0; i < 4; i++)
                        {
                            int ErrorFanData = IOinput & (1 << i);
                            if(ErrorFanData == (1<<i))
                            {
                                ErrCount += 1;
                                picBdFan[i].Image = Properties.Resources.fan_error;
                                ErrMessage.Text = "B'd Fan error!";
                            }
                            else if (ErrorFanData != (1 << i))
                            {
                                picBdFan[i].Image = Properties.Resources.fan;
                            }
                        }
                        int TempError = IOinput & (1 << 4);
                        if (TempError != 0)
                        {
                            ErrCount += 1;
                            lblBdTemp.BackColor = Color.OrangeRed;
                            ErrMessage.Text = "(S/W Board) Temperature Alarm!";
                        }
                        else
                        {
                            lblBdTemp.BackColor = Color.LightGray;
                        }
                        int EMO = IOinput & (1 << 5);
                        if (EMO != 0)
                        {
                            FaultCount += 1;
                            ErrMessage.Text = "Emergency!";
                            lblFault.BackColor = Color.OrangeRed;
                            
                            if (StaticClass.Count == 0)
                            {
                                Warning EMOform = new Warning();
                                EMOform.StartPosition = FormStartPosition.CenterScreen;
                                EMOform.lblWarning.Text = "[EMO S/W] Emergency!";
                                EMOform.Show();
                                StaticClass.Count += 1;
                            }
                        }
                        else
                        {
                            lblFault.BackColor = Color.LightGray;
                        }

                        txtPCBTemp.Text = (double.Parse(UMApacket[10]) / 10).ToString();
                        txtLedTemp0.Text = (double.Parse(UMApacket[10]) / 10).ToString();
                        txtLedTemp1.Text = (double.Parse(UMApacket[11]) / 10).ToString();
                        txtLedTemp2.Text = (double.Parse(UMApacket[12]) / 10).ToString();
                        txtLedTemp3.Text = (double.Parse(UMApacket[13]) / 10).ToString();
                        txtLedTemp4.Text = (double.Parse(UMApacket[14]) / 10).ToString();
                        txtLedTemp5.Text = (double.Parse(UMApacket[15]) / 10).ToString();
                        txtLedTemp6.Text = (double.Parse(UMApacket[16]) / 10).ToString();
                        txtLedTemp7.Text = (double.Parse(UMApacket[17]) / 10).ToString();
                        txtLedTemp8.Text = (double.Parse(UMApacket[18]) / 10).ToString();
                        txtPCWFlow.Text = (double.Parse(UMApacket[20]) / 10).ToString();
                        txtPCWTempIn.Text = (double.Parse(UMApacket[40]) / 10).ToString();
                        txtPCWTempOut.Text = (double.Parse(UMApacket[41]) / 10).ToString();
                        txtPCWPressure0.Text = (double.Parse(UMApacket[60]) / 10).ToString();
                        txtPCWPressure1.Text = (double.Parse(UMApacket[61]) / 10).ToString();
                        if (UMApacket[62] != "00")
                        {
                            FaultCount += 1;
                            ErrMessage.Text = "Water Leak Alarm!";
                            if (StaticClass.Count == 0)
                            {
                                Warning WaterLeakform = new Warning();
                                WaterLeakform.lblWarning.Text = "[LCP] Water Leak Alarm!";
                                WaterLeakform.StartPosition = FormStartPosition.CenterScreen;
                                WaterLeakform.Show();
                                StaticClass.Count += 1;
                            }
                        }

                    }


                    else if(packet.StartsWith("\x02PMA"))
                    {
                        string[] PMApacket = packet.Split(',');
                        
                        switch (PMApacket[6])
                        {
                            case "0":
                                lblVolt.BackColor = Color.LightGray;
                                lblShort.BackColor = Color.LightGray;
                                break;

                            case "1":
                                ErrMessage.Text = "[PSU-17] Voltage Low Error [12.3V]";
                                lblVolt.BackColor = Color.OrangeRed;
                                lblShort.BackColor = Color.LightGray;
                                ErrCount += 1;
                                break;
                            case "2":
                                ErrMessage.Text = "[PSU-17] Voltage High Error [12.3V]";
                                lblVolt.BackColor = Color.OrangeRed;
                                lblShort.BackColor = Color.LightGray;
                                ErrCount += 1;
                                break;
                            case "3":
                                ErrMessage.Text = "[PSU-17] LED Short Error!";
                                lblShort.BackColor = Color.OrangeRed;
                                lblVolt.BackColor = Color.LightGray;
                                ErrCount += 1;
                                break;
                            case "4":
                                ErrMessage.Text = "[PSU-17] Nominal Voltage Low Error!";
                                lblVolt.BackColor = Color.OrangeRed;
                                lblShort.BackColor = Color.LightGray;
                                ErrCount += 1;
                                break;
                            case "5":
                                ErrMessage.Text = "[PSU-17] Nominal Voltage High Error!";
                                lblVolt.BackColor = Color.OrangeRed;
                                lblShort.BackColor = Color.LightGray;
                                ErrCount += 1;
                                break;
                        }
                        switch (PMApacket[7])
                        {
                            case "0":
                                lblOpen.BackColor = Color.LightGray;
                                lblCurr.BackColor = Color.LightGray;
                                break;
                            case "1":
                                lblOpen.BackColor = Color.LightGray;
                                lblCurr.BackColor = Color.OrangeRed;
                                ErrMessage.Text = "[PSU-17] Current Low Error [0.8A]";
                                ErrCount += 1;
                                break;
                            case "2":
                                lblOpen.BackColor = Color.LightGray;
                                lblCurr.BackColor = Color.OrangeRed;
                                ErrMessage.Text = "[PSU-17] Current High Error [0.8A]";
                                ErrCount += 1;
                                break;
                            case "3":
                                lblOpen.BackColor = Color.OrangeRed;
                                lblCurr.BackColor = Color.LightGray;
                                ErrMessage.Text = "[PSU-17] LED Open Error!";
                                ErrCount += 1;
                                break;
                        }
                        if (PMApacket[8] != "00")
                        {
                            ErrCount += 1;
                            ErrMessage.Text = "[PSU-17] FAN Error!";
                            lblFan.BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            lblFan.BackColor = Color.LightGray;
                           
                        }


                    }
                }
                if(ErrCount > 0 && FaultCount <=0)
                {
                    lblAlarm.BackColor = Color.OrangeRed;
                    lblFault.BackColor = Color.LightGray;
                }
                else if(ErrCount <= 0 && FaultCount > 0)
                {
                    lblAlarm.BackColor = Color.LightGray;
                    lblFault.BackColor = Color.OrangeRed;
                }
                else if(ErrCount > 0 && FaultCount > 0)
                {
                    lblAlarm.BackColor = Color.OrangeRed;
                    lblFault.BackColor = Color.OrangeRed;
                }
                else if(ErrCount <= 0 && FaultCount <= 0)
                {
                    lblAlarm.BackColor = Color.LightGray;
                    lblFault.BackColor = Color.LightGray;
                    ErrMessage.Text = "";
                }
                

            }
            else
            {
                return;
            }
        }

    }
    public static class StaticClass
    {
        public static int Count = 0;
    }
}
