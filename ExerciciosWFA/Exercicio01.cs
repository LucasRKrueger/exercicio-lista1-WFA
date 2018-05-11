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
    public partial class Exercicio01 : Form
    {
        int numero = 0;
        
        
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void Exercicio01_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInformeUmNumero_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void btGerar_Click(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(txtInformeUmNumero.Text);
            string aplicacao = "Numero: " + numero + " \nAntecessor: " + (numero -1) + "\nSucessor: " + (numero + 1);
            txtResultado.Text = aplicacao;
                        
        }
        

        private void txtInformeUmNumero_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
