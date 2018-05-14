using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioWFA
{
    public partial class Exercicio08 : Form
    {
        double contaLuz = 0;
        double contaAgua = 0;
        double valorNet = 0;
        double valorOi = 0;
        double valorVivo = 0;
        double valorIptu = 0;
        double valorIpva = 0;
        double valorSeguroCarro = 0;

        public Exercicio08()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelContaAgua_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btZeigen_Click(object sender, EventArgs e)
        {
            try
            {
                contaLuz = Convert.ToDouble(txtContaDeLuz.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtContaDeLuz.Focus();
                return;
            }

            try
            {
                contaAgua = Convert.ToDouble(txtContaDeAgua.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtContaDeAgua.Focus();
                return;
            }

            try
            {
                valorNet = Convert.ToDouble(txtValorDaNet.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtValorDaNet.Focus();
                return;
            }

            try
            {
                valorOi = Convert.ToDouble(txtValorDaOi.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtValorDaOi.Focus();
                return;
            }

            try
            {
                valorVivo = Convert.ToDouble(txtValorDaVivo.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtValorDaVivo.Focus();
                return;
            }

            try
            {
                valorIptu = Convert.ToDouble(txtValorIptu.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtValorIptu.Focus();
                return;
            }

            try
            {
                valorIpva = Convert.ToDouble(txtValorIpva.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtValorIpva.Focus();
                return;
            }

            try
            {
                valorSeguroCarro = Convert.ToDouble(txtValorSeguroDoCarro.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtValorSeguroDoCarro.Focus();
                return;
            }

            double valorContasTelefone = (valorOi + valorNet + valorVivo);
            double valorImpostos = (valorIptu + valorIpva);
            double valorRestante = (valorSeguroCarro + contaLuz + contaAgua);
            double valorTotal = (valorContasTelefone + valorImpostos + valorRestante);

            string show = "Valor das contas de telefone: " + valorContasTelefone + "\r\nValor dos Impostos: " + valorImpostos + "\r\nValor das contas restantes: " +
                valorRestante + "\r\nValor Total: " + valorTotal;
            txtResultado.Text = show;

        }
    }
}
