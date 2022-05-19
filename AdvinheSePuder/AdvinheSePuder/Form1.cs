using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvinheSePuder
{
    public partial class Form1 : Form
    {
        int numeroSecreto;
        int tentativa;
        int numeroTentativa;
        int numeroMaximoTentativas = 5;

        public Form1()
        {
            InitializeComponent();
            CarregarConfiguraçãoInicial();

        }

        private void CarregarConfiguraçãoInicial()
        {
            textBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarJogo();

        }

        private void CarregarJogo()
        {
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = true;
            textBox1.Focus();
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label4.Text = "";
            tentativa = 1;
            DefinirNumeroSecreto();
        }

        private void DefinirNumeroSecreto()
        {
            Random rnd = new Random();
            numeroSecreto = rnd.Next(0, 51);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Saiu");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void AvaliarTentativa(int numeroTentativa)
        {
            if (tentativa <= numeroMaximoTentativas)
            {
                if (numeroSecreto > numeroTentativa)
                {

                    MessageBox.Show("O número secreto é mais alto...");
                }
                else if (numeroSecreto < numeroTentativa)
                {
                    MessageBox.Show("O número secreto é menor...");
                }
                else
                {
                    MessageBox.Show($"Você acertou!!!\n O número secreto é {numeroSecreto}");
                    FinalizarJogo();
                }
            } else
            {
                MessageBox.Show("Tentativas esgotadas... Game Over... \n" +
                    $"O número secreto era {numeroSecreto}");
                FinalizarJogo();
            }
        }

        private void FinalizarJogo()
        {
            button1.Visible = true;
            button2.Visible = true;
            textBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tentativa++;
                label4.Text = label4.Text + textBox1.Text + ", ";
                numeroTentativa = int.Parse(textBox1.Text);
                AvaliarTentativa(numeroTentativa);
                e.Handled = true;
                textBox1.Clear();
            }
        }


    }
}
