using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SezarSifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked== true )
            {
                string sifresiz = richTextBox1.Text;
                string sifrele = string.Empty;
                List<char> karakter1 = sifresiz.ToCharArray().ToList();

                for(int i = 0; i < karakter1.Count; i++)
                {
                    sifrele = sifrele + (char)(karakter1[i] + 1);
                }
                richTextBox2.Text = (sifrele);
            }
            else if (radioButton2.Checked == true)
            {
                string sifreli = richTextBox1.Text;
                string sifrecoz = string.Empty;
                List<char> karakter1 = sifreli.ToCharArray().ToList();

                for (int i = 0; i < karakter1.Count; i++)
                {
                    sifrecoz = sifrecoz + (char)(karakter1[i] - 1);
                }
                richTextBox2.Text = (sifrecoz);
            }
            else
            {
                MessageBox.Show("Bir seçenek seçin");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/dogukan-uraz-260597141/");
        }
    }
}
