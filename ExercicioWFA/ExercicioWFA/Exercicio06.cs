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
    public partial class Exercicio06 : Form
    {
        double nota1 = 0;
        double nota2 = 0;
        double nota3 = 0;
        double nota4 = 0;
        
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void Exercicio06_Load(object sender, EventArgs e)
        {

        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            try
            {
            nota1 = Convert.ToDouble(txtNota1.Text);

            }
            catch (Exception)
            {
                
                MessageBox.Show("Leid, Nur Zahlen");
                txtNota1.Focus();
                return;
            }

            try
            {
                nota2 = Convert.ToDouble(txtNota2.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtNota2.Focus();
                return;
            }

            try
            {
                nota3 = Convert.ToDouble(txtNota3.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtNota3.Focus();
                return;
            }

            try
            {
                nota4 = Convert.ToDouble(txtNota4.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtNota4.Focus();
                return;
            }
            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            MessageBox.Show("A média do aluno é: " + media);
        }
    }
}
