namespace ExercicioWFA
{
    partial class Exercicio05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomeDoCarro = new System.Windows.Forms.Label();
            this.txtNomeDoCarro = new System.Windows.Forms.TextBox();
            this.labelValorDoCarro = new System.Windows.Forms.Label();
            this.txtValorDoCarro = new System.Windows.Forms.TextBox();
            this.labelValorDeCadaParcela = new System.Windows.Forms.Label();
            this.txtValorDeCadaParcela = new System.Windows.Forms.TextBox();
            this.labelQuantidadeDeParcelas = new System.Windows.Forms.Label();
            this.txtQuantidadeDeParcelas = new System.Windows.Forms.TextBox();
            this.labelQuantidadeMesesFinanciado = new System.Windows.Forms.Label();
            this.txtQuantidadeDeMesesFinanciado = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.btExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeDoCarro
            // 
            this.labelNomeDoCarro.AutoSize = true;
            this.labelNomeDoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeDoCarro.Location = new System.Drawing.Point(12, 9);
            this.labelNomeDoCarro.Name = "labelNomeDoCarro";
            this.labelNomeDoCarro.Size = new System.Drawing.Size(113, 20);
            this.labelNomeDoCarro.TabIndex = 0;
            this.labelNomeDoCarro.Text = "Nome do carro";
            this.labelNomeDoCarro.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeDoCarro
            // 
            this.txtNomeDoCarro.Location = new System.Drawing.Point(131, 11);
            this.txtNomeDoCarro.Name = "txtNomeDoCarro";
            this.txtNomeDoCarro.Size = new System.Drawing.Size(128, 20);
            this.txtNomeDoCarro.TabIndex = 1;
            // 
            // labelValorDoCarro
            // 
            this.labelValorDoCarro.AutoSize = true;
            this.labelValorDoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorDoCarro.Location = new System.Drawing.Point(12, 58);
            this.labelValorDoCarro.Name = "labelValorDoCarro";
            this.labelValorDoCarro.Size = new System.Drawing.Size(108, 20);
            this.labelValorDoCarro.TabIndex = 2;
            this.labelValorDoCarro.Text = "Valor do carro";
            this.labelValorDoCarro.Click += new System.EventHandler(this.labelInformeOvalorDoCarro_Click);
            // 
            // txtValorDoCarro
            // 
            this.txtValorDoCarro.Location = new System.Drawing.Point(126, 58);
            this.txtValorDoCarro.Name = "txtValorDoCarro";
            this.txtValorDoCarro.Size = new System.Drawing.Size(128, 20);
            this.txtValorDoCarro.TabIndex = 3;
            // 
            // labelValorDeCadaParcela
            // 
            this.labelValorDeCadaParcela.AutoSize = true;
            this.labelValorDeCadaParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorDeCadaParcela.Location = new System.Drawing.Point(12, 116);
            this.labelValorDeCadaParcela.Name = "labelValorDeCadaParcela";
            this.labelValorDeCadaParcela.Size = new System.Drawing.Size(163, 20);
            this.labelValorDeCadaParcela.TabIndex = 4;
            this.labelValorDeCadaParcela.Text = "Valor de cada parcela";
            // 
            // txtValorDeCadaParcela
            // 
            this.txtValorDeCadaParcela.Location = new System.Drawing.Point(181, 116);
            this.txtValorDeCadaParcela.Name = "txtValorDeCadaParcela";
            this.txtValorDeCadaParcela.Size = new System.Drawing.Size(128, 20);
            this.txtValorDeCadaParcela.TabIndex = 5;
            // 
            // labelQuantidadeDeParcelas
            // 
            this.labelQuantidadeDeParcelas.AutoSize = true;
            this.labelQuantidadeDeParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeDeParcelas.Location = new System.Drawing.Point(12, 160);
            this.labelQuantidadeDeParcelas.Name = "labelQuantidadeDeParcelas";
            this.labelQuantidadeDeParcelas.Size = new System.Drawing.Size(178, 20);
            this.labelQuantidadeDeParcelas.TabIndex = 6;
            this.labelQuantidadeDeParcelas.Text = "Quantidade de parcelas";
            // 
            // txtQuantidadeDeParcelas
            // 
            this.txtQuantidadeDeParcelas.Location = new System.Drawing.Point(196, 160);
            this.txtQuantidadeDeParcelas.Name = "txtQuantidadeDeParcelas";
            this.txtQuantidadeDeParcelas.Size = new System.Drawing.Size(128, 20);
            this.txtQuantidadeDeParcelas.TabIndex = 7;
            // 
            // labelQuantidadeMesesFinanciado
            // 
            this.labelQuantidadeMesesFinanciado.AutoSize = true;
            this.labelQuantidadeMesesFinanciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeMesesFinanciado.Location = new System.Drawing.Point(12, 214);
            this.labelQuantidadeMesesFinanciado.Name = "labelQuantidadeMesesFinanciado";
            this.labelQuantidadeMesesFinanciado.Size = new System.Drawing.Size(242, 20);
            this.labelQuantidadeMesesFinanciado.TabIndex = 8;
            this.labelQuantidadeMesesFinanciado.Text = "Quantidade de meses financiado";
            // 
            // txtQuantidadeDeMesesFinanciado
            // 
            this.txtQuantidadeDeMesesFinanciado.Location = new System.Drawing.Point(260, 214);
            this.txtQuantidadeDeMesesFinanciado.Name = "txtQuantidadeDeMesesFinanciado";
            this.txtQuantidadeDeMesesFinanciado.Size = new System.Drawing.Size(128, 20);
            this.txtQuantidadeDeMesesFinanciado.TabIndex = 9;
            this.txtQuantidadeDeMesesFinanciado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(16, 301);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(353, 131);
            this.txtResultado.TabIndex = 10;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(12, 278);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(82, 20);
            this.labelResultado.TabIndex = 11;
            this.labelResultado.Text = "Resultado";
            // 
            // btExecutar
            // 
            this.btExecutar.Location = new System.Drawing.Point(348, 9);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(92, 36);
            this.btExecutar.TabIndex = 12;
            this.btExecutar.Text = "Executar";
            this.btExecutar.UseVisualStyleBackColor = true;
            this.btExecutar.Click += new System.EventHandler(this.btExecutar_Click);
            // 
            // Exercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 444);
            this.Controls.Add(this.btExecutar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtQuantidadeDeMesesFinanciado);
            this.Controls.Add(this.labelQuantidadeMesesFinanciado);
            this.Controls.Add(this.txtQuantidadeDeParcelas);
            this.Controls.Add(this.labelQuantidadeDeParcelas);
            this.Controls.Add(this.txtValorDeCadaParcela);
            this.Controls.Add(this.labelValorDeCadaParcela);
            this.Controls.Add(this.txtValorDoCarro);
            this.Controls.Add(this.labelValorDoCarro);
            this.Controls.Add(this.txtNomeDoCarro);
            this.Controls.Add(this.labelNomeDoCarro);
            this.Name = "Exercicio05";
            this.Text = "Exercicio05";
            this.Load += new System.EventHandler(this.Exercicio05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeDoCarro;
        private System.Windows.Forms.TextBox txtNomeDoCarro;
        private System.Windows.Forms.Label labelValorDoCarro;
        private System.Windows.Forms.TextBox txtValorDoCarro;
        private System.Windows.Forms.Label labelValorDeCadaParcela;
        private System.Windows.Forms.TextBox txtValorDeCadaParcela;
        private System.Windows.Forms.Label labelQuantidadeDeParcelas;
        private System.Windows.Forms.TextBox txtQuantidadeDeParcelas;
        private System.Windows.Forms.Label labelQuantidadeMesesFinanciado;
        private System.Windows.Forms.TextBox txtQuantidadeDeMesesFinanciado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button btExecutar;
    }
}