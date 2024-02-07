using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT
{
    
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }
        private void Warning_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 500;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lblWarning.BackColor == Color.OrangeRed)
            {
                lblWarning.BackColor = Color.LightGray;
            }
            else
            {
                lblWarning.BackColor = Color.OrangeRed;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Warning_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticClass.Count = 0;
            //DialogResult = DialogResult.OK;
        }

    }
    

}
