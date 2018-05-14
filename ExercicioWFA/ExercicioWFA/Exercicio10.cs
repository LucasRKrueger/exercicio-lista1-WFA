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
    public partial class Exercicio10 : Form
    {
        int anoNascimento = 0;
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void btZeigen_Click(object sender, EventArgs e)
        {
            try
            {
                anoNascimento = Convert.ToInt32(txtAnoDeNascimento.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtAnoDeNascimento.Focus();
                return;
            }
            int idadeAtual = (2018 - anoNascimento);

            MessageBox.Show("Sua idade atual é: " + idadeAtual);
        }
    }
}
