using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosWFA
{
    public partial class Exercicio02 : Form
    {
        double quantidadeLitrosConsumidos = 0, valorPagoLitro = 0, quantidadeTotalLitrosConsumidos = 0;
        int quantidadeAnosConsumidos = 0;
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidadeLitros_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exercicio02_Load(object sender, EventArgs e)
        {

        }

        private void btGerarResultado_Click(object sender, EventArgs e)
        {
            try
            {
              quantidadeLitrosConsumidos = Convert.ToDouble(txtQuantidadeLitros.Text);

            }
            catch (Exception)
            {                
               MessageBox.Show("Leid, Nur Zahlen");
               txtQuantidadeLitros.Focus();
               return;
            }

            try
            {
                quantidadeAnosConsumidos = Convert.ToInt32(txtQuantidadeAnosConsumidos.Text);
            }
            catch (Exception)
            {

              MessageBox.Show("Leid, Nur Zahlen");
              txtQuantidadeAnosConsumidos.Focus();
              return;
            }

            try
            {
                valorPagoLitro = Convert.ToDouble(mtbValorPagoLitro.Text);
            }
            catch (Exception)
            {
                
              MessageBox.Show("Leid, Nur Zahlen");
            }
            quantidadeTotalLitrosConsumidos = (quantidadeLitrosConsumidos * quantidadeAnosConsumidos * 365);
            MessageBox.Show("A quantidade total de litros consumidos é: " + quantidadeTotalLitrosConsumidos);

        }
        
        public void Armazenar()
        {
            quantidadeLitrosConsumidos = Convert.ToDouble(txtQuantidadeLitros.Text);
            quantidadeAnosConsumidos = Convert.ToInt32(txtQuantidadeAnosConsumidos.Text);
            valorPagoLitro = Convert.ToDouble(mtbValorPagoLitro.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Armazenar();
            double valorTotalPago = quantidadeLitrosConsumidos * quantidadeAnosConsumidos * valorPagoLitro * 365;
            MessageBox.Show("O valor total pago é: " + valorTotalPago);
        }
    }
}
