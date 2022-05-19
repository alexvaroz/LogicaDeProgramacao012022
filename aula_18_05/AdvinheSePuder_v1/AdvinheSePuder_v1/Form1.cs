using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvinheSePuder_v1
{
    public partial class Form1 : Form
    {
        int numeroSecreto;
        int chute;
        int chances;
        public Form1()
        {
            InitializeComponent();
            lblInfo.Visible = false;
            txbTentativa.Visible = false;
            lblTentativas.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            IncializarJogo();
        }

        private void IncializarJogo()
        {
            btnSair.Visible = false;
            btnJogar.Visible = false;
            lblInfo.Visible = true;
            txbTentativa.Visible = true;
            txbTentativa.Focus();
            Random rnd = new Random();
            numeroSecreto = rnd.Next(0, 51);
            chances = 5;
            lblGameOver.Visible = false;
            lblTentativas.Visible = true;
        }

        private void txbTentativa_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                chances--;
                chute = int.Parse(txbTentativa.Text);
                lblTentativas.Text = lblTentativas.Text + 
                    txbTentativa.Text + ", ";
                txbTentativa.Clear();
                AvaliarChute(chute);
                VerificarSeGameOver();
            }
        }

        private void VerificarSeGameOver()
        {
            if (chances <= 0)
            {
                MessageBox.Show("Você não conseguiu adivinhar o número \n" +
                    $"nas suas 5 chances... \n Era {numeroSecreto} \n Que pena... \n GAME OVER!!!");
                lblGameOver.Visible = true;
                btnSair.Visible = true;
                btnJogar.Visible = true;
                lblInfo.Visible = false;
                txbTentativa.Visible = false;
                lblTentativas.Text = "Tentativas: ";
                lblTentativas.Visible = false;
            } 
        }

        private void AvaliarChute(int chute)
        {
            if (chute > numeroSecreto)
            {
                MessageBox.Show($"O número secreto é menor que {chute} ");
            }
            else if (chute < numeroSecreto)
            {
                MessageBox.Show($"O número secreto é maior que {chute} ");
            }
            else
            {
                MessageBox.Show($"O número secreto é {chute} \n" +
                   "Parabéns, você adivinhou!!");
            }
        }
    }
}
