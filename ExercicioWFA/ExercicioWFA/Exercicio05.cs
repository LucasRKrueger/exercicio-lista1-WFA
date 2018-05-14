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
    public partial class Exercicio05 : Form
    {
        string nomeCarro = "";
        double valorCarro = 0;
        double valorCadaParcela = 0;
        int quantidadeParcelas = 0;
        int quantidadeMesesFinanciado = 0;

        public Exercicio05()
        {
            InitializeComponent();
        }

        private void Exercicio05_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelInformeOvalorDoCarro_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            nomeCarro = (txtNomeDoCarro.Text);

            try
            {
             valorCarro = Convert.ToDouble(txtValorDoCarro.Text);
            }
            catch (Exception)
            {                
                MessageBox.Show("Leid, Nur Zahlen");
                txtValorDoCarro.Focus();
                return;
            }

            try
            {
             valorCadaParcela = Convert.ToDouble(txtValorDeCadaParcela.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtValorDeCadaParcela.Focus();
                return;
            }

            try
            {
             quantidadeParcelas = Convert.ToInt32(txtQuantidadeDeParcelas.Text);

            }
            catch (Exception)
            {
                
                MessageBox.Show("Leid, Nur Zahlen");
                txtQuantidadeDeParcelas.Focus();
                return;
            }

            try
            {
             quantidadeMesesFinanciado = Convert.ToInt32(txtQuantidadeDeMesesFinanciado.Text);
            }
            catch (Exception)
            {
                
                MessageBox.Show("Leid, Nur Zahlen");
                txtQuantidadeDeMesesFinanciado.Focus();
                return;
            }
            string show = "Nome do carro: " + nomeCarro + "\r\nValor do carro: " + valorCarro + "\r\nValor de cada parcela: " + valorCadaParcela + "\r\nQuantidade de parcelas: " + quantidadeParcelas + 
                "\r\nValor total do financiamento: " + (valorCadaParcela * quantidadeParcelas) + "\r\nDiferença entre o valor total do financiamento e o valor do carro: " + (valorCarro - (valorCadaParcela * quantidadeParcelas));
            txtResultado.Text = show;
        }
    }
}
