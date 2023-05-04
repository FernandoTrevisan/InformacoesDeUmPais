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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void texto_Click(object sender, EventArgs e)
        {

        }

        private void inserir_Click(object sender, EventArgs e)
        {
            texto.Text = "coxinha";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texto.Text = "";
        }
    }
}
