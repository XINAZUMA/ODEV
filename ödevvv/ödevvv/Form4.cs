using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödevvv
{
    public partial class Form4 : Form
    {
        
           
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                label11.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                label8.Visible = false;
                label7.Visible = false;
                label6.Visible = false;
                label11.Text = textBox1.Text;
                label6.Text = textBox2.Text;
                label7.Text = textBox3.Text;
                int s1, s2, s3, toplam;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);
                s3 = Convert.ToInt16(textBox3.Text);
                toplam = s1 + s2 + s3;
                label12.Text = toplam.ToString();
            }
            if (radioButton2.Checked == true)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;

                label8.Text = textBox1.Text;
                label9.Text = textBox2.Text;
                label10.Text = textBox3.Text;
                double s1, s2, s3, toplam;
                s1 = Convert.ToDouble(textBox1.Text);
                s2 = Convert.ToDouble(textBox2.Text);
                s3 = Convert.ToDouble(textBox3.Text);
                toplam = (1 / s1) + (1 / s2) + (1 / s3);
                label12.Text = toplam.ToString();
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
