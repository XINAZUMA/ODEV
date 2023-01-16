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
    public partial class Form8 : Form
    {
        Form9 form9 = new Form9();
        public Form8()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("") | textBox2.Text == ("") || textBox3.Text == ("") || textBox4.Text == ("") || checkBox1.Checked == false)
            {
                MessageBox.Show("Bilgileri Ekiksiz Giriniz ve Kullanıcı Sözleşmesini Onayayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkBox1.Checked == true)
            {
                MessageBox.Show("Ödeme Başarılı Bir Şekilde Gerçekleştirmiştir", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            form9.Show();
            this.Hide();
        }
    }
}
