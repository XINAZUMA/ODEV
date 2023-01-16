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
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dogru = 0;
            if (radioButton3.Checked == true)
            {
                dogru = dogru + 1;
            }

            if (radioButton6.Checked == true)
            {
                dogru = dogru + 1;
            }

            if (radioButton9.Checked == true)
            {
                dogru = dogru + 1;
            }

            if (radioButton16.Checked == true)
            {
                dogru = dogru + 1;
            }

            if (radioButton17.Checked == true)
            {
                dogru = dogru + 1;
            }
            int yanlıs = 5 - dogru;
            int oran = dogru * 20;

            textBox3.Text = Convert.ToString(dogru);
            textBox2.Text = Convert.ToString(yanlıs);
            textBox1.Text = Convert.ToString(oran);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
