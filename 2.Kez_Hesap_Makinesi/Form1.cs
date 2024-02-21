using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Kez_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        bool ekrantemizlencekmi = false;
        private char _islem;
        int sayi1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text=="0")
            {
                label_ekran.Text = "1";
            }
            else
            {
                label_ekran.Text += "1";
            }

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text == "0")
            {
                label_ekran.Text = "2";
            }
            else
            {
                label_ekran.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text == "0")
            {
                label_ekran.Text = "3";
            }
            else
            {
                label_ekran.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text == "0")
            {
                label_ekran.Text = "4";
            }
            else
            {
                label_ekran.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text == "0")
            {
                label_ekran.Text = "5";
            }
            else
            {
                label_ekran.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text == "0")
            {
                label_ekran.Text = "6";
            }
            else
            {
                label_ekran.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text == "0")
            {
                label_ekran.Text = "7";
            }
            else
            {
                label_ekran.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text == "0")
            {
                label_ekran.Text = "8";
            }
            else
            {
                label_ekran.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text == "0")
            {
                label_ekran.Text = "9";
            }
            else
            {
                label_ekran.Text += "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (ekrantemizlencekmi)
            {
                label_ekran.Text = "0";
            }
            ekrantemizlencekmi = false;
            if (label_ekran.Text == "0")
            {
                label_ekran.Text = "0";
            }
            else
            {
                label_ekran.Text += "0";
            }
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            sayi1 = Convert.ToInt32(label_ekran.Text);
            ekrantemizlencekmi = true;
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt32(label_ekran.Text);
            if (_islem == '+')
            {
                label_ekran.Text =Convert.ToString(sayi1 + sayi2);
                
            }
            else if (_islem =='-')
            {
                label_ekran.Text = Convert.ToString(sayi1 - sayi2);
            }
            else if (_islem == '/')
            {
                label_ekran.Text = Convert.ToString(sayi1 / sayi2);
            }
            else if (_islem == '*')
            {
                label_ekran.Text = Convert.ToString(sayi1 * sayi2);
            }

        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            _islem = '-';
            sayi1 = Convert.ToInt32(label_ekran.Text);
            ekrantemizlencekmi = true;
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            sayi1 = Convert.ToInt32(label_ekran.Text);
            ekrantemizlencekmi = true;
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            sayi1 = Convert.ToInt32(label_ekran.Text);
            ekrantemizlencekmi = true;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            ekrantemizlencekmi = true;
            label_ekran.Text = "0";
        }
    }
}
