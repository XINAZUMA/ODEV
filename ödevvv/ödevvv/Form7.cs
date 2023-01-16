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
    public partial class Form7 : Form
    {
        int sayac;
        public Form7()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            progressBar1.Value = sayac;
            if(sayac==100)
            {
                timer1.Stop();
                Form8 form8 = new Form8();
                form8.Show();
                this.Hide();
            }
        }
    }
}
