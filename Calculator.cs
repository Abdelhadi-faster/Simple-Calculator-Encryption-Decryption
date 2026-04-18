using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        //private string Operation()
        //{
        //  switch(int char)
        //        {
            
        //    }
          
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Tag; 
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Tag;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Tag;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Tag;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Tag;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Tag;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Tag;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Tag;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Tag;
        }

        private void btn0_Click(object sender, EventArgs e)
        {      
            textBox1.Text += btn0.Tag;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text= "";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnplus.Tag;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnminus.Tag;
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnmulti.Tag;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += btndivide.Tag;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            try
           { 
            string expression = textBox1.Text;
         
            var result = new System.Data.DataTable().Compute(expression, "");
                textBox1.Text += btnequal.Text;
               textBox2.Text = result.ToString();

                textBox1.Text = textBox2.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في العملية الحسابية: " + ex.Message,"خطأ");
            }
        }

    }

   
}
