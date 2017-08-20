using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosNaPratica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(NovoMetodo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão");
        }

        private void NovoMetodo(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão só uma vez");
        }
    }
}
