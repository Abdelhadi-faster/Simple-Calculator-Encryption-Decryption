using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            for (int i = 1; i <= 20; i++) 
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(1000);
                    progressBar1.Value += 5;
                    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                    progressBar1.Refresh();
                    label1.Refresh();
                }
                else
                {
                button1.Enabled = false;
                }

            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = numericUpDown1.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm1 = new frm2();
            frm1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm1 = new Calculator();
            frm1.ShowDialog();
        }
    }
}
