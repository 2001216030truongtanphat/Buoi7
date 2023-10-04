using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if( ctr.Text.Trim().Length >= 4)
            {
                e.Handled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            textBox2.Text = NumberToWords(Convert.ToInt32(textBox1.Text));
        }
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "Không";
            if (number < 0)
                return "Âm " + NumberToWords(Math.Abs(number));
            string words = "";
            if((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + "trăm ";
                number %= 100;
            }
            if ((number / 10) > 0)
            {
                words += NumberToWords(number / 10) + "mươi ";
                if((number / 10) < 20 && (number / 10) > 10)
                {
                    words += NumberToWords(number/10) + "mười ";
                }
                number %= 10;
            }
            if( number > 0)
            {
                var so = new[] { "Không ", "Một ", "Hai ", "Ba ", "Bốn ", "Năm ", "Sáu ", "Bảy ", "Tám ", "Chín "};
                words += so[number / 1];
            }
            return words;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
