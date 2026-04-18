using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

       




        private string EncryptionText(string text)
            {
            short encryptionKey = (short)numericUpDown2.Value;

            char[] encryptedChars = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                encryptedChars[i] = (char)(text[i] + encryptionKey);
            }

            return new string(encryptedChars);
        }

        private string DecryptionText(string text)
        {
            short DecryptionKey = (short)numericUpDown1.Value;

            char[] encryptedChars = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                encryptedChars[i] = (char)(text[i] - DecryptionKey);
            }

            return new string(encryptedChars);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string txt1 = textBox1.Text.Trim();

          txtEnc.Text =  EncryptionText(txt1);

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt2 = textBox2.Text.Trim();
            txtDec.Text = DecryptionText(txt2);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox1.Text = Clipboard.GetText();
            }
          
        }

        private void txtEnc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
