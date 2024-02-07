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
using System.Diagnostics;

namespace OJT
{
    public partial class Ng_codes : Form
    {
        string path = Application.StartupPath + @"\ng_code.txt";
        public Ng_codes()
        {
            InitializeComponent();
        }

        private void Ng_codes_Load(object sender, EventArgs e)
        {
            //Debug.WriteLine("0");

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] data = line.Split(',');
                    if (!IsItemAlreadyExists(data[2]))
                    {
                        lvwClassification.Items.Add(data[2]); // 중분류 이름
                    }
                }
            }
            lvwClassification.Sorting = SortOrder.Ascending; // 오름차순으로 정렬
        }

        private bool IsItemAlreadyExists(string itemName)
        {
            foreach (ListViewItem item in lvwClassification.Items)
            {
                if (item.Text == itemName) 
                {
                    return true; // 중복된 아이템 발견
                }
            }

            return false; // 중복된 아이템 없음
        }

        private void lvwClassification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwClassification.SelectedItems.Count > 0)
            {
                lvwNgCode.Clear();
                lvwNgCode.Columns.Add("불량코드", 70);
                lvwNgCode.Columns.Add("불량명", -2);
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] data = line.Split(',');
                        if (data[2] == lvwClassification.SelectedItems[0].Text)
                        {
                            ListViewItem item = new ListViewItem(data[0]);
                            lvwNgCode.Items.Add(item);
                            item.SubItems.Add(data[4]);
                        }
                        
                    }
                    lvwNgCode.Sorting = SortOrder.Ascending;
                }
            }
        }

        private void lvwNgCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwNgCode.SelectedItems.Count > 0)
            {
                lblNgCode.Text = lvwNgCode.SelectedItems[0].Text;
                lblNgCodeInfo.Text = lvwNgCode.SelectedItems[0].SubItems[1].Text; // SubItems[0]으로 하면 상세정보 말고 코드가 나옴
            }
        }
    }
}
