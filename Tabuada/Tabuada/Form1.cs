using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(tbxNumero.Text);
            lblResultado.Text = 
                n.ToString() + " + 1 = " + (n + 1).ToString() + "\n" +
                n.ToString() + " + 2 = " + (n + 2).ToString() + "\n" +
                n.ToString() + " + 3 = " + (n + 3).ToString() + "\n" +
                n.ToString() + " + 4 = " + (n + 4).ToString() + "\n" +
                n.ToString() + " + 5 = " + (n + 5).ToString() + "\n" +
                n.ToString() + " + 6 = " + (n + 6).ToString() + "\n" +
                n.ToString() + " + 7 = " + (n + 7).ToString() + "\n" +
                n.ToString() + " + 8 = " + (n + 8).ToString() + "\n" +
                n.ToString() + " + 9 = " + (n + 9).ToString() + "\n" +
                n.ToString() + " + 10 = " + (n + 10).ToString() ;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(tbxNumero.Text);
            lblResultado.Text =
                n.ToString() + " - 1 = " + (n - 1).ToString() + "\n" +
                n.ToString() + " - 2 = " + (n - 2).ToString() + "\n" +
                n.ToString() + " - 3 = " + (n - 3).ToString() + "\n" +
                n.ToString() + " - 4 = " + (n - 4).ToString() + "\n" +
                n.ToString() + " - 5 = " + (n - 5).ToString() + "\n" +
                n.ToString() + " - 6 = " + (n - 6).ToString() + "\n" +
                n.ToString() + " - 7 = " + (n - 7).ToString() + "\n" +
                n.ToString() + " - 8 = " + (n - 8).ToString() + "\n" +
                n.ToString() + " - 9 = " + (n - 9).ToString() + "\n" +
                n.ToString() + " - 10 = " + (n - 10).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(tbxNumero.Text);
            lblResultado.Text =
                n.ToString() + " x 1 = " + (n * 1).ToString() + "\n" +
                n.ToString() + " x 2 = " + (n * 2).ToString() + "\n" +
                n.ToString() + " x 3 = " + (n * 3).ToString() + "\n" +
                n.ToString() + " x 4 = " + (n * 4).ToString() + "\n" +
                n.ToString() + " x 5 = " + (n * 5).ToString() + "\n" +
                n.ToString() + " x 6 = " + (n * 6).ToString() + "\n" +
                n.ToString() + " x 7 = " + (n * 7).ToString() + "\n" +
                n.ToString() + " x 8 = " + (n * 8).ToString() + "\n" +
                n.ToString() + " x 9 = " + (n * 9).ToString() + "\n" +
                n.ToString() + " x 10 = " + (n * 10).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(tbxNumero.Text);
            lblResultado.Text =
                n.ToString() + " ÷ 1 = " + Math.Round(n / 1, 1).ToString() + "\n" +
                n.ToString() + " ÷ 2 = " + Math.Round(n / 2, 1).ToString() + "\n" +
                n.ToString() + " ÷ 3 = " + Math.Round(n / 3, 1).ToString() + "\n" +
                n.ToString() + " ÷ 4 = " + Math.Round(n / 4, 1).ToString() + "\n" +
                n.ToString() + " ÷ 5 = " + Math.Round(n / 5, 1).ToString() + "\n" +
                n.ToString() + " ÷ 6 = " + Math.Round(n / 6, 1).ToString() + "\n" +
                n.ToString() + " ÷ 7 = " + Math.Round(n / 7, 1).ToString() + "\n" +
                n.ToString() + " ÷ 8 = " + Math.Round(n / 8, 1).ToString() + "\n" +
                n.ToString() + " ÷ 9 = " + Math.Round(n / 9, 1).ToString() + "\n" +
                n.ToString() + " ÷ 10 = " + Math.Round(n / 10, 1).ToString();
        }
    }
}
