using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(tbxPreco.Text);
            double qtd = Convert.ToDouble(tbxQtd.Text);

            double faturamento = preco * qtd;
            tbxFaturamento.Text = faturamento.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}