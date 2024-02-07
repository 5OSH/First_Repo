using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace OJT
{
    public partial class Manual_Test : Form
    {
        // 최대 : 0x 0003 FFFF (4Byte)
        private int LedData = 0;
        public Manual_Test()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }


        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox[] boxes = { CH1, CH2, CH3, CH4, CH5, CH6, CH7, CH8, CH9, CH10, CH11, CH12, CH13, CH14, CH15, CH16, CH17, CH18 };
            if (SelectAll.Checked == true)
            {
                for (int i = 0; i < 18; i++)
                {
                    boxes[i].Checked = true;
                }
            }
            else if (SelectAll.Checked == false)
            {
                for (int i = 0; i < 18; i++)
                {
                    boxes[i].Checked = false;
                }
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            // UV LED ON 요청 명령 생성

            //byte STX = 0x02;
            //byte ETX = 0x03;
            double.TryParse(txtCurrent.Text, out double a);
            int outputSelection = 0; // OUTPUT 선택: 0, 1, 2, 3 중 하나
            double out0Current =  a * 1000; // OUT0 전류 값
            int out1Current = 0; // OUT1 전류 값
            int ledOnTime = 500; // LED ON Time

            // UV LED ON 요청 명령을 생성
            string onrCommand = $"\x02ONR,{LedData:X8},{outputSelection},{out0Current},{out1Current},{ledOnTime}\x03";

            SendCommandToServer(onrCommand);


        }

        static void SendCommandToServer(string command)
        {
            try
            {
                    byte[] data = Encoding.ASCII.GetBytes(command);
                    Form1.stream.Write(data, 0, data.Length); // 메인 폼에서 통신했던 Tcpclient, NetStream 이용

                    Console.WriteLine("패킷을 서버로 전송했습니다.");
                    Console.WriteLine($"보낸 명령: {command}");

                    // 서버로부터의 응답 처리 (필요에 따라)
                    byte[] responseBuffer = new byte[1024];
                    int bytesRead = Form1.stream.Read(responseBuffer, 0, responseBuffer.Length);
                    string response = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);
                    Console.WriteLine($"서버 응답: {response}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"오류 발생: {ex.Message}");
            }
        }
        

        private void btnOff_Click(object sender, EventArgs e)
        {
            uint OFRData = 0xFFFFFFFF;
            string OFRCommand = $"\x02OFR,{OFRData:X8}\x03";
            SendCommandToServer(OFRCommand);
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // sender : 이벤트를 발생시킨 컨트롤을 참조. object 형식이라 as CheckBox로 형변환 해줘야한다. as로 형변환 실패 시 null 반환되어 예외 x
            int index = GetCheckboxIndex(checkBox);

            if (index > 0)
            {
                LedData = LedData & ~(1 << (index - 1)) | (checkBox.Checked ? (1 << (index - 1)) : 0);
                // 1. LedData의 기존 값과 체크된 체크박스의 인덱스를 이용해서 And시켜서 LedData의 (index)번째 비트를 0으로 만듦(나머지 비트들은 1과 & 하므로 그대로)
                // 2. 체크박스가 체크된 상태이면 (index)번째 비트와 Or 시켜서 그 비트 자리만 1로 만듦.
                // 3. 체크박스가 체크되지 않았다면 0000 0000과 Or 하므로 값은 그대로. 1번에서 해당하는 (index)번쨰 비트를 0으로 만들었기 때문에 그대로 0이 된다.
            }
        }
        private int GetCheckboxIndex(CheckBox checkBox)
        {
            int index;
            // 체크박스의 이름에서 인덱스를 추출.
            if (int.TryParse(checkBox.Name.Replace("CH", ""), out index))
            {
                return index;
            }
            return -1;
        }

        private void Manual_Test_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.O)
                btnOn_Click(sender,e);
            if (e.KeyData == Keys.F)
                btnOff_Click(sender, e);

        }

    }
    
}
