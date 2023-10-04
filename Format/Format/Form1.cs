using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (chRegular.Checked == true)
                label1.Font = new Font(label1.Font, FontStyle.Regular);
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked == true)
                label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked == true)
                label1.Font = new Font(label1.Font, FontStyle.Italic);
        }

        private void chBI_CheckedChanged(object sender, EventArgs e)
        {
            if (chBI.Checked == true)
                label1.Font = new Font(label1.Font,(FontStyle)(FontStyle.Bold|FontStyle.Italic));
        }

        private void rdAutoColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAutoColor.Checked == true)
                label1.ForeColor = Color.Black;
        }

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRed.Checked == true)
                label1.ForeColor = Color.Red;
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGreen.Checked == true)
                label1.ForeColor = Color.Green;
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlue.Checked == true)
                label1.ForeColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
