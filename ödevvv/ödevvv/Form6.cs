using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödevvv
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Ürün Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double aurun = 0, burun = 0, curun = 0, sonuc = 0, indir = 0;
                if (comboBox1.SelectedIndex == 0)
                {
                    aurun = +100;
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    aurun = +150;
                }
                else if (comboBox3.SelectedIndex == 2)
                {
                    aurun = +200;
                }
                if (comboBox2.SelectedIndex == 0)
                {
                    burun = +100;
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    burun = +150;
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    burun = +200;
                }
                if (comboBox3.SelectedIndex == 0)
                {
                    curun = +100;
                }
                else if (comboBox3.SelectedIndex == 1)
                {
                    curun = +150;
                }
                else if (comboBox3.SelectedIndex == 2)
                {
                    curun = +200;
                }
                sonuc = aurun + burun + curun;
                label1.Text = Convert.ToString(sonuc);
                if (radioButton1.Checked == true)
                {
                    indir = sonuc * 0.10;
                }
                if (radioButton2.Checked == true)
                {
                    indir = sonuc * 0.30;
                }
                if (radioButton3.Checked == true)
                {
                    indir = sonuc * 0.50;
                }
                if (radioButton4.Checked == true)
                {
                    indir = sonuc * 0.70;
                }
                label2.Text = Convert.ToString(indir);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Ürün Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form7 form7 = new Form7();
                form7.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
