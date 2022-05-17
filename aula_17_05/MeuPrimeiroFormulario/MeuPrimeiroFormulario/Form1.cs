using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "Clique aqui!!!";
            button1.Text = "Clique ali...";
            button1.BackColor = Color.Aqua;
            label1.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "Clique aqui!!!";
            button2.Text = "Clique ali...";
            label1.Visible = true;
            label1.Text = $"O texto do button 1 é {button1.Text}";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = $"Seja bem vindo {textBox1.Text}";
        }
    }
}
