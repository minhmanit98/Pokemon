using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class frmDiff : Form
    {
       
        public frmDiff()
        {
            InitializeComponent();
         
        }

        public void btnNew_Click(object sender, EventArgs e)
        {
            //if (rbEasy.Checked == true)
            //{
            //    frmTroChoi.level = 1;
                
            //}
            //else if (rbMedium.Checked == true)
            //{
            //    frmTroChoi.level = 4;
            //}
            //else
            //{
            //    frmTroChoi.level = 7;
            //}
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            frmTroChoi.level = 1;
            btnNew.PerformClick();
            //this.btnNew_Click(sender, e);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmTroChoi.level = 4;
            btnNew.PerformClick();
           // btnNew_Click(sender, e);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmTroChoi.level = 7;
            btnNew.PerformClick();
            //btnNew_Click(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
