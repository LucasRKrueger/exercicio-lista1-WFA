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
    public partial class Exercicio09 : Form
    {
        int numero1 = 0;
        int numero2 = 0;
        

        public Exercicio09()
        {
            InitializeComponent();
        }

        private void brZeigen_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToInt32(txtInformeUmNumero1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Leid, Nur Zahlen");
                txtInformeUmNumero1.Focus();
                return;
            }

            try
            {
                numero2 = Convert.ToInt32(txtInformeUmNumero2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Leid, Nur Zahlen");
                txtInformeUmNumero2.Focus();
                return;
            }
            int wtf = numero1;
            numero1 = numero2;
            numero2 = wtf;

            MessageBox.Show("Primeiro número: " + numero1 + "\nSegundo número: " + numero2);

        }
    }
}
