using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dikdörtgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kısak, uzunk, cevre, alan;
            kısak=Convert.ToInt32(textBox1.Text);
            uzunk=Convert.ToInt32(textBox2.Text);
            cevre = 2*(kısak * uzunk);
            alan = kısak + uzunk;
            label3.Text = "Alan: " + alan;
            label4.Text = "Çevre: " + cevre;

        }
    }
}
