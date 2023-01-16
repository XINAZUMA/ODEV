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
    public partial class Form2 : Form
    {
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        Form6 form6 = new Form6();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("BAŞARI TESTİ AÇILIYOR...", "Onay Verildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form3.Show();
                this.Hide();
            }
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("DİRENÇ HESAPLAMA AÇILIYOR...", "Onay Verildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form4.Show();
                this.Hide();
            }
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("OTO GALERİ AÇILIYOR...", "Onay Verildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form5.Show();
                this.Hide();
            }
            if (radioButton4.Checked == true)
            {
                MessageBox.Show("MAĞZAMIZ YÜKLENİYOR...", "Onay Verildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form6.Show();
                this.Hide();
            }
        }
    }
}
