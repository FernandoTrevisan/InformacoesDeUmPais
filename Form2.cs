using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texto1.Text = "Brasil";
            texto2.Text = "212,6 milhões";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            texto1.Text = "Angola";
            texto2.Text = "32,8 milhões";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            texto1.Text = "Uganda";
            texto2.Text = "45,7 milhões";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            texto1.Text = "";
            texto2.Text = "";
        }
    }
}
