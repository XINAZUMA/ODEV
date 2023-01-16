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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Marka Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox8.Visible = false;
                    textBox1.Text = ("5");
                    textBox2.Text = ("CHALENGER");
                    textBox3.Text = ("3.750.000");
                    textBox4.Text = ("Couper");
                    textBox5.Text = ("Gri");
                    textBox6.Text = ("Otomatik");
                    textBox7.Text = ("benzin");
                    textBox8.Text = ("2022");



                }
                if (comboBox1.SelectedIndex == 1)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox8.Visible = false;
                    textBox1.Text = ("10");
                    textBox2.Text = ("Automobiles");
                    textBox3.Text = ("17.900.000");
                    textBox4.Text = ("Coupe");
                    textBox5.Text = ("Turuncu");
                    textBox6.Text = ("Yarı Otomatik");
                    textBox7.Text = ("Benzin");
                    textBox8.Text = ("2020");



                }
                if (comboBox1.SelectedIndex == 2)
                {
                    pictureBox3.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox8.Visible = false;
                    textBox1.Text = ("15");
                    textBox2.Text = ("S8");
                    textBox3.Text = ("15.000.000");
                    textBox4.Text = ("Sedan");
                    textBox5.Text = ("Koyu Beyaz");
                    textBox6.Text = ("Otomatik");
                    textBox7.Text = ("Benzin");
                    textBox8.Text = ("2022");



                }
                if (comboBox1.SelectedIndex == 3)
                {
                    pictureBox4.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox8.Visible = false;
                    textBox1.Text = ("20");
                    textBox2.Text = ("Camaro");
                    textBox3.Text = ("5.250.000");
                    textBox4.Text = ("Coupe");
                    textBox5.Text = ("Siyah");
                    textBox6.Text = ("Yarı Otomatik");
                    textBox7.Text = ("Benzin");
                    textBox8.Text = ("2022");

                }
                if (comboBox1.SelectedIndex == 4)
                {
                    pictureBox8.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    textBox1.Text = ("25");
                    textBox2.Text = ("GT-R35");
                    textBox3.Text = ("5.980.000");
                    textBox4.Text = ("Coupe");
                    textBox5.Text = ("Siyah");
                    textBox6.Text = ("Yarı Otomatik");
                    textBox7.Text = ("Benzin");
                    textBox8.Text = ("2011");

                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox8.Visible = false;

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
