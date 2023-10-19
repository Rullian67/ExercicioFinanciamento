using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularJurosFinanciamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblemprestimo_Click(object sender, EventArgs e)
        {

        }

        private void btlCalcularJuros_Click(object sender, EventArgs e)
        {
            try
            {
                int principal = int.Parse(textEmprestimo.Text);
                double taxaDeJurosAnual = double.Parse(textTaxa.Text);
                int numeroDeParcelas = int.Parse(textParcelas.Text);

                double taxaDeJurosMensal = taxaDeJurosAnual / 12.0 / 100.0;

                double valorDaParcela = principal * (taxaDeJurosMensal / (1 - Math.Pow(1 + taxaDeJurosMensal, -numeroDeParcelas)));
                double totalJuros = (valorDaParcela * numeroDeParcelas) - principal;
                double totalPago = principal + totalJuros;


                lbltotal.Text = "Valor da Parcela: " + valorDaParcela.ToString("C");
                lbltotaljuros.Text = "Total em Juros: " + totalJuros.ToString("C");
                lbltotalpago.Text = "Total Pago: " + totalPago.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Certifique-se de que todos os campos estejam preenchidos com valores numéricos válidos.");
            }

        }

        private void textTaxa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmprestimo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
