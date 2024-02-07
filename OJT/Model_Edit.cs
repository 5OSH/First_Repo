using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OJT
{

    public partial class Model_Edit : Form
    {
        DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\Model");

        
        public Model_Edit()
        {
            InitializeComponent();
            //프로그램 실행시 Model 폴더 확인 및 없을경우 Model 폴더 생성
            if (!di.Exists) { di.Create(); } 
        }
        private void RenewModelListView()
        {
            string filePath = @di.ToString();
            var files = Directory.GetFiles(filePath, "*.amf");
            ModelListView.Items.Clear();
            foreach (var file in files)
            {
                ModelListView.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }
        private void TimingSettingClean()
        {
            ClockTB.Text = "";
            H_Total.Text = "";
            H_Active.Text = "";
            H_FrontPorch.Text = "";
            H_SyncWidth.Text = "";
            H_BackPorch.Text = "";
            V_Total.Text = "";
            V_Active.Text = "";
            V_FrontPorch.Text = "";
            V_SyncWidth.Text = "";
            V_BackPorch.Text = "";
            H_Frequency.Text = "";
            V_Frequency.Text = "";
        }
        private char TimingSettingCheck()
        {
            uint hActive, hFrontPorch, hSyncWidth, hBackPorch, vActive, vFrontPorch, vSyncWidth, vBackPorch;

            if (!uint.TryParse(H_Active.Text, out hActive) ||
                !uint.TryParse(H_FrontPorch.Text, out hFrontPorch) ||
                !uint.TryParse(H_SyncWidth.Text, out hSyncWidth) ||
                !uint.TryParse(H_BackPorch.Text, out hBackPorch) ||
                !uint.TryParse(V_Active.Text, out vActive) ||
                !uint.TryParse(V_FrontPorch.Text, out vFrontPorch) ||
                !uint.TryParse(V_SyncWidth.Text, out vSyncWidth) ||
                !uint.TryParse(V_BackPorch.Text, out vBackPorch) ||
                !double.TryParse(ClockTB.Text, out double clockValue))
            {
                MessageBox.Show("올바른 숫자 형식이 아닙니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 'n';
            }

            uint hTotal = hActive + hFrontPorch + hSyncWidth + hBackPorch;
            H_Total.Text = hTotal.ToString();

            uint vTotal = vActive + vFrontPorch + vSyncWidth + vBackPorch;
            V_Total.Text = vTotal.ToString();

            double hFrequency = (clockValue * 1000000) / hTotal / 1000;
            hFrequency = Math.Round(hFrequency, 2);
            H_Frequency.Text = hFrequency.ToString();

            double vFrequency = (clockValue * 1000000) / (hTotal * vTotal);
            vFrequency = Math.Round(vFrequency, 2);
            V_Frequency.Text = vFrequency.ToString();

            return 'y';
        }
        private void FileSave()
        {
            char isChecked = TimingSettingCheck();
            if (isChecked == 'n')
                return;
            else
            {
                if (ModelListView.SelectedItems.Count > 0)
                {
                    string SelectedFile = (di + @"\" + ModelListView.SelectedItems[0].Text + ".amf");
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(SelectedFile, FileMode.Truncate)))
                    {
                        double Clock = double.Parse(ClockTB.Text);
                        Clock *= 1000000;
                        //MHz -> Hz
                        bw.Write(Clock);
                        bw.Write($"{H_Total.Text}");
                        bw.Write($"{H_Active.Text}");
                        bw.Write($"{H_FrontPorch.Text}");
                        bw.Write($"{H_SyncWidth.Text}");
                        bw.Write($"{H_BackPorch.Text}");
                        bw.Write($"{V_Total.Text}");
                        bw.Write($"{V_Active.Text}");
                        bw.Write($"{V_FrontPorch.Text}");
                        bw.Write($"{V_SyncWidth.Text}");
                        bw.Write($"{V_BackPorch.Text}");
                        MessageBox.Show($"{ModelListView.SelectedItems[0].Text}.amf에 저장되었습니다.");
                    }
                }
                else { MessageBox.Show("저장할 파일을 선택하세요."); }

                RenewModelListView();
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            string newFileName = di + @"\" + $"{ModelNameTB.Text}.amf";
            if (File.Exists(newFileName))
                MessageBox.Show("이미 존재하는 파일 이름입니다.");
            else
                File.Create(di + @"\"+$"{ModelNameTB.Text}.amf").Close();
            RenewModelListView();
            TimingSettingClean();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // 선택된 아이템이 하나 이상인 경우에만 진행
            if (ModelListView.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show($"{ModelNameTB.Text}.amf를 정말로 삭제하시겠습니까?","확인",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                File.Delete(di + @"\" + $"{ModelNameTB.Text}.amf");
                ModelNameTB.Text = "";
                TimingSettingClean();
            }
            RenewModelListView();
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (ModelListView.SelectedItems.Count > 0)
            {
                string oldFileName = di + @"\" + $"{ModelListView.SelectedItems[0].Text}.amf";
                string newFileName = di + @"\" + $"{ModelNameTB.Text}.amf";
                if (oldFileName == newFileName)
                    MessageBox.Show("기존 이름과 같습니다.");
                else if(File.Exists(newFileName))
                    MessageBox.Show("이미 존재하는 파일 이름입니다.");
                else
                {
                    File.Move(oldFileName, newFileName);
                    MessageBox.Show("이름이 변경되었습니다.");
                }
                RenewModelListView();
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (ModelListView.SelectedItems.Count > 0)
            {
                string SelectedFileName = di + @"\" + $"{ModelListView.SelectedItems[0].Text}.amf";
                string newFileName = di + @"\" + $"{ModelNameTB.Text}.amf";
                if (SelectedFileName == newFileName)
                    MessageBox.Show("기존 이름과 같습니다.");
                else if (File.Exists(newFileName))
                    MessageBox.Show("이미 존재하는 파일 이름입니다.");
                else
                {
                    File.Copy(SelectedFileName, newFileName);
                    MessageBox.Show($"{ModelNameTB.Text}.amf에 복사했습니다.");
                }
                RenewModelListView();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            FileSave();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            TimingSettingCheck();
        }

        private void Model_Edit_Load(object sender, EventArgs e)
        {
            RenewModelListView();
        }

        private void ModelListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ModelListView.SelectedItems.Count > 0)
            {
                ModelNameTB.Text = ModelListView.SelectedItems[0].Text;
                string SelectedFile = (di + @"\" + ModelListView.SelectedItems[0].Text + ".amf");
                using (BinaryReader br = new BinaryReader(new FileStream(SelectedFile, FileMode.Open)))
                {
                    FileInfo fi = new FileInfo(SelectedFile);
                    if (fi.Length > 0) // 파일이 비어 있지 않음
                    {
                        double Clock = br.ReadDouble();
                        ClockTB.Text = (Clock / 1000000).ToString();
                        H_Total.Text = br.ReadString();
                        H_Active.Text = br.ReadString();
                        H_FrontPorch.Text = br.ReadString();
                        H_SyncWidth.Text = br.ReadString();
                        H_BackPorch.Text = br.ReadString();
                        V_Total.Text = br.ReadString();
                        V_Active.Text = br.ReadString();
                        V_FrontPorch.Text = br.ReadString();
                        V_SyncWidth.Text = br.ReadString();
                        V_BackPorch.Text = br.ReadString();
                        
                        TimingSettingCheck();
                    }                       
                    else
                    {
                        TimingSettingClean();
                    }



                }

            }
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            FileManage fm = new FileManage();

            fm.SaveFile();
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class FileManage : Model_Edit
        {
            public void SaveFile()
            {
                char isChecked = TimingSettingCheck();
                if (isChecked == 'n')
                    return;
                else
                {
                    if (ModelListView.SelectedItems.Count > 0)
                    {
                        string SelectedFile = (di + @"\" + ModelListView.SelectedItems[0].Text + ".amf");
                        using (BinaryWriter bw = new BinaryWriter(new FileStream(SelectedFile, FileMode.Truncate)))
                        {
                            double Clock = double.Parse(ClockTB.Text);
                            Clock *= 1000000;
                            //MHz -> Hz
                            bw.Write(Clock);
                            bw.Write($"{H_Total.Text}");
                            bw.Write($"{H_Active.Text}");
                            bw.Write($"{H_FrontPorch.Text}");
                            bw.Write($"{H_SyncWidth.Text}");
                            bw.Write($"{H_BackPorch.Text}");
                            bw.Write($"{V_Total.Text}");
                            bw.Write($"{V_Active.Text}");
                            bw.Write($"{V_FrontPorch.Text}");
                            bw.Write($"{V_SyncWidth.Text}");
                            bw.Write($"{V_BackPorch.Text}");
                            MessageBox.Show($"{ModelListView.SelectedItems[0].Text}.amf에 저장되었습니다.");
                        }
                    }
                    else { MessageBox.Show("저장할 파일을 선택하세요."); }
                    
                    RenewModelListView();
                }
            }
        }
    }
}
