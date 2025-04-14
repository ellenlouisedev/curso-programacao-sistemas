using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class Form1 : Form
    {
        int defesaJ1 = 0;
        int defesaJ2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAtaqueJ1_Click(object sender, EventArgs e)
        {
            // Diminuir os pontos de vida do jogador 2
            // Dano= Ataque
            int dano = 15 - defesaJ2;

            // Vida J2 = VidaJ2 - dano
            int vidaJ2 = Convert.ToInt32(tbxVidaJ2.Text);
            tbxVidaJ2.Text = (vidaJ2 - dano).ToString();

            // Bloquear os botões do jogador 1
            btnAtaqueJ1.Enabled = false;
            btnDefesaJ1.Enabled = false;

            // Desbloquear os botões do jogador 2
            btnAtaqueJ2.Enabled = true;
            btnDefesaJ2.Enabled = true;

            // Defesa do jogador 2 volta ao padrão
            defesaJ1 = 0;
        }

        private void btnAtaqueJ2_Click(object sender, EventArgs e)
        {
            // Diminuir os pontos de vida do jogador 2
            // Dano = Ataque
            int dano = 12 - defesaJ1;

            // Vida J1 = VidaJ1 - dano
            int vidaJ1 = Convert.ToInt32(tbxVidaJ1.Text);
            tbxVidaJ1.Text = (vidaJ1 - dano).ToString();

            // Bloquear os botões do jogador 1
            btnAtaqueJ2.Enabled = false;
            btnDefesaJ2.Enabled = false;

            // Desbloquear os botões do jogador 2
            btnAtaqueJ1.Enabled = true;
            btnDefesaJ1.Enabled = true;

            // Defesa do jogador 1 volta ao padrão
            defesaJ1 = 0;
        }

        private void btnDefesaJ1_Click(object sender, EventArgs e)
        {
            // Mudar a defesa do jogador 1
            defesaJ1 = 5;

            // Bloquear os botões do jogador 1
            btnAtaqueJ1.Enabled = false;
            btnDefesaJ1.Enabled = false;

            // Desbloquear os botões do jogador 2
            btnAtaqueJ2.Enabled = true;
            btnDefesaJ2.Enabled = true;

            // Defesa do jogador 2 volta ao padrão
            defesaJ2 = 0;
        }

        private void btnDefesaJ2_Click(object sender, EventArgs e)
        {
            // Mudar a defesa do jogador 2
            defesaJ2 = 10;

            // Bloquear os botões do jogador 2
            btnAtaqueJ2.Enabled = false;
            btnDefesaJ2.Enabled = false;

            // Desbloquear os botões do jogador 1
            btnAtaqueJ1.Enabled = true;
            btnDefesaJ1.Enabled = true;
        }
    }
}
