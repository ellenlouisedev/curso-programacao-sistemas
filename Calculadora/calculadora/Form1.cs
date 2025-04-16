using System;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botão de soma
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);
            double soma = n1 + n2;
            tbxResultado.Text = Convert.ToString(soma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botão de adição
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);
            double subtracao = n1 - n2;
            tbxResultado.Text = Convert.ToString(subtracao);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Botão de multiplicação
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);
            double multiplicacao = n1 * n2;
            tbxResultado.Text = Convert.ToString(multiplicacao);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Botão de divisão
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);
            double divisao = n1 / n2;
            tbxResultado.Text = Convert.ToString(divisao);
        }
    }
}
