using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0 && numericUpDown2.Value > 0)
            {
                double sayi1, sayi2, sonuc;
                sayi1 = Convert.ToDouble(numericUpDown1.Text);
                sayi2 = Convert.ToDouble(numericUpDown2.Text);

                if (radioButton1.Checked)
                {
                    sonuc = sayi1 + sayi2;
                }
                else if (radioButton2.Checked)
                {
                    sonuc = sayi1 - sayi2;
                }
                else if (radioButton3.Checked)
                {
                    sonuc = sayi1 * sayi2;
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                }

                label4.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("sayı giriniz", "dikkat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
