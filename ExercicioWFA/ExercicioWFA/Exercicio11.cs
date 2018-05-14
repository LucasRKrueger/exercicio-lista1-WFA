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
    public partial class Exercicio11 : Form
    {
        
        int dataNascimento = 0;
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void btZeigen_Click(object sender, EventArgs e)
        {


            string texto = mtbDataNascimento.Text;
            string[] numeros = texto.Split('/');
            

            int ano = Convert.ToInt32(numeros[2]);
            int quantidadeDiasVivos = (2018 - ano) * 365;
            int quantidadeAnosVivo = (2018 - ano);
            string show = "Dias vivos: " + quantidadeDiasVivos + "\r\nAnos vivos: " + (2018 - ano) + "\r\nQuantidade de meses vivo: " + (quantidadeAnosVivo * 8760) +
                "\r\nQuantidade de horas vivo: " + (quantidadeAnosVivo * 24) + "\r\nQuantidade de minutos vivo: " + (quantidadeAnosVivo * 525600) + "\r\nQuantidade de segundos vivo: " + (quantidadeAnosVivo * 31536000);
            txtResultado.Text = show;
        }
    }
}
