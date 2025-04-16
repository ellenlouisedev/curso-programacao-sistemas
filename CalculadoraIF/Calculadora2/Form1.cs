using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ler os dois números
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);

            // Ler o operador
            string operador = cbxOperador.Text;

            // Calcular os operadores
            if (operador == "Somar")
            {
                double soma = n1 + n2;
                tbxResultado.Text = soma.ToString();
            }
            if (operador == "Subtrair")
            {
                double subtracao = n1 - n2;
                tbxResultado.Text = subtracao.ToString();
            }
            if (operador == "Multiplicar")
            {
                double multiplicacao = n1 * n2;
                tbxResultado.Text = multiplicacao.ToString();
            }
            if (operador == "Dividir")
            {
                double divisao = n1 / n2;
                tbxResultado.Text = divisao.ToString();
            }
            if (operador == "Potência")
            {
                double potenciacao = Math.Pow(n1, n2);
                tbxResultado.Text = potenciacao.ToString();
            }
            if (operador == "")
            {
                MessageBox.Show("O campo Operador é obrigatório*", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
