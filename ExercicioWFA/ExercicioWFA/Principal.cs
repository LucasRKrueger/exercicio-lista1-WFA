﻿using ExercicioWFA;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercicio01 exercicio01 = new Exercicio01();
            exercicio01.Show();
        }

        private void btExercicio02_Click(object sender, EventArgs e)
        {
            Exercicio02 exercicio02 = new Exercicio02();
            exercicio02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exercicio03 exercicio03 = new Exercicio03();
            exercicio03.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exercicio04 exercicio04 = new Exercicio04();
            exercicio04.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exercicio05 exercicio05 = new Exercicio05();
            exercicio05.Show();
        }

        private void btExercicio06_Click(object sender, EventArgs e)
        {
            Exercicio06 exercicio06 = new Exercicio06();
            exercicio06.Show();
        }

        private void btExercicio07_Click(object sender, EventArgs e)
        {
            Exercicio07 exercicio07 = new Exercicio07();
            exercicio07.Show();
        }

        private void btExercicio08_Click(object sender, EventArgs e)
        {
            Exercicio08 exercicio08 = new Exercicio08();
            exercicio08.Show();
        }

        private void btExercicio09_Click(object sender, EventArgs e)
        {
            Exercicio09 exercicio09 = new Exercicio09();
            exercicio09.Show();
        }

        private void btExercicio10_Click(object sender, EventArgs e)
        {
            Exercicio10 exercicio10 = new Exercicio10();
            exercicio10.Show();
        }

        private void btExercicio11_Click(object sender, EventArgs e)
        {
            Exercicio11 exercicio11 = new Exercicio11();
            exercicio11.Show();
        }
    }
}