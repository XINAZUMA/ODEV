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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;

            if (ad == "" || sifre == "")
            {
                MessageBox.Show(" Boş Bilgi Girmeyiniz");
            }
            else if (ad == "admin" && sifre == "admin")
            {
                MessageBox.Show("İşlem Başarılı Lütfen Bekleyiniz");
                form2.Show();
                this.Hide();
            }
            

        }
    }
}
