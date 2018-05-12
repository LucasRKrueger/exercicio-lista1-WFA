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
    public partial class Exercicio03 : Form
    {
        int numero1 = 0, numero2 = 0;
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void txtInformeUmNumero2_TextChanged(object sender, EventArgs e)
        {

        }
        public void Armazenamento()
        {
            numero1 = Convert.ToInt32(txtInformeUmNumero.Text);
            numero2 = Convert.ToInt32(txtInformeUmNumero2.Text);
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            Armazenamento();
            MessageBox.Show("A subtração dos valores é: " + (numero1 - numero2));
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            Armazenamento();
            MessageBox.Show("A multiplicação dos valores é: " + (numero1 * numero2));
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            Armazenamento();
            MessageBox.Show("A divisão dos valores é: " + (numero1 / numero2));
        }

        private void btProdutoDosValores_Click(object sender, EventArgs e)
        {
            Armazenamento();
            int produto1 = numero1 * numero1;
            int produto2 = numero2 * numero2;
            MessageBox.Show("O produto dos valores do primeiro número é: " + produto1 + "\nO produto dos valores do segundo número é: " + produto2);
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            Armazenamento();
            MessageBox.Show("A soma dos valores é: " + (numero1 + numero2));
        }
    }
}
