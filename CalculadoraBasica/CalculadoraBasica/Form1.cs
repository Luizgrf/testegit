using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);

            double resultado;
            resultado = valor1 + valor2;

            lblResultado.Text = ("A soma dos Valores é: ") + System.Convert.ToString(resultado);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);

            double resultado;
            resultado = valor1 - valor2;

            lblResultado.Text = ("A subtração dos Valores é: ") + System.Convert.ToString(resultado);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);

            double resultado;
            resultado = valor1 * valor2;

            lblResultado.Text = ("A Multiplicação dos Valores é: ") + System.Convert.ToString(resultado);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);
            double resultado;

            if (valor2 == 0)
            {
                lblResultado.Text = ("O dividendo não pode ser 0!!");
            }
            else{
                resultado = valor1 / valor2;

                lblResultado.Text = ("A Divisão dos Valores é: ") + System.Convert.ToString(resultado);
            }
        }
    }
}
