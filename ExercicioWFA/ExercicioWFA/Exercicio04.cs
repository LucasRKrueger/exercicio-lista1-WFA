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
    public partial class Exercicio04 : Form
    {
        int numero = 0;
        int resultado = 0;
        int resultado1 = 0;
        int resultado2 = 0;
        int resultado3 = 0;
        int resultado4 = 0;
        int resultado5 = 0;
        int resultado6 = 0;
        int resultado7 = 0;
        int resultado8 = 0;
        int resultado9 = 0;
        int resultado10 = 0;
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public void Armazenamento()
        {
             resultado = numero * 0;
             resultado1 = numero * 1;
             resultado2 = numero * 2;
             resultado3 = numero * 3;
             resultado4 = numero * 4;
             resultado5 = numero * 5;
             resultado6 = numero * 6;
             resultado7 = numero * 7;
             resultado8 = numero * 8;
             resultado9 = numero * 9;
             resultado10 = numero * 10;

        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
             numero = Convert.ToInt32(txtInformeUmNumero.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Leid, Nur Zahlen");
                txtInformeUmNumero.Focus();
                return;
            }
            Armazenamento();
            string textu = numero + " X " + (0) + " = " + resultado + "\r\n" + "\r\n" + numero + " X " + (1) + " = " + resultado1 + "\r\n" + "\r\n" + numero + " X " + (2) + " = " + resultado2 + "\r\n" + "\r\n" + numero + " X " + (3) + " = " + resultado3 + "\r\n" + "\r\n" + numero + " X " + (4) + " = " + resultado4 + "\r\n" +
                "\r\n" + numero + " X " + (5) + " = " + resultado5 + "\r\n" + "\r\n" + numero + " X " + (6) + " = " + resultado6 + "\r\n" + "\r\n" + numero + " X " + (7) + " = " + resultado7 + "\r\n" + "\r\n" + numero + " X " + (8) + " = " + resultado8 + "\r\n" +
                "\r\n" + numero + " X " + (9) + " = " + resultado9 + "\r\n" + "\r\n" + numero + " X " + (10) + " = " + resultado10 + "\r\n" + "\r\n";
            txtResultado.Text = textu;

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void Exercicio04_Load(object sender, EventArgs e)
        {

        }
    }
}
