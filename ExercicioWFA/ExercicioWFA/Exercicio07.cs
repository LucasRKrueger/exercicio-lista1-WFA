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
    public partial class Exercicio07 : Form
    {
        public Exercicio07()
        {
            InitializeComponent();
        }

        private void btZeigen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"       
                *             
               ***            
              *****             
             *******
            *********
          ************");
        }
    }
}
