namespace ExerciciosWFA
{
    partial class Exercicio03
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
            this.labelInformeUmNumero1 = new System.Windows.Forms.Label();
            this.txtInformeUmNumero = new System.Windows.Forms.TextBox();
            this.labelInformeUmNumero2 = new System.Windows.Forms.Label();
            this.txtInformeUmNumero2 = new System.Windows.Forms.TextBox();
            this.btSomar = new System.Windows.Forms.Button();
            this.btSubtracao = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.btProdutoDosValores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInformeUmNumero1
            // 
            this.labelInformeUmNumero1.AutoSize = true;
            this.labelInformeUmNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeUmNumero1.Location = new System.Drawing.Point(12, 32);
            this.labelInformeUmNumero1.Name = "labelInformeUmNumero1";
            this.labelInformeUmNumero1.Size = new System.Drawing.Size(195, 20);
            this.labelInformeUmNumero1.TabIndex = 0;
            this.labelInformeUmNumero1.Text = "Informe um número inteiro";
            // 
            // txtInformeUmNumero
            // 
            this.txtInformeUmNumero.Location = new System.Drawing.Point(213, 32);
            this.txtInformeUmNumero.Name = "txtInformeUmNumero";
            this.txtInformeUmNumero.Size = new System.Drawing.Size(57, 20);
            this.txtInformeUmNumero.TabIndex = 1;
            // 
            // labelInformeUmNumero2
            // 
            this.labelInformeUmNumero2.AutoSize = true;
            this.labelInformeUmNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeUmNumero2.Location = new System.Drawing.Point(12, 81);
            this.labelInformeUmNumero2.Name = "labelInformeUmNumero2";
            this.labelInformeUmNumero2.Size = new System.Drawing.Size(195, 20);
            this.labelInformeUmNumero2.TabIndex = 2;
            this.labelInformeUmNumero2.Text = "Informe um número inteiro";
            // 
            // txtInformeUmNumero2
            // 
            this.txtInformeUmNumero2.Location = new System.Drawing.Point(213, 81);
            this.txtInformeUmNumero2.Name = "txtInformeUmNumero2";
            this.txtInformeUmNumero2.Size = new System.Drawing.Size(57, 20);
            this.txtInformeUmNumero2.TabIndex = 3;
            this.txtInformeUmNumero2.TextChanged += new System.EventHandler(this.txtInformeUmNumero2_TextChanged);
            // 
            // btSomar
            // 
            this.btSomar.Location = new System.Drawing.Point(12, 135);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(86, 36);
            this.btSomar.TabIndex = 4;
            this.btSomar.Text = "Somar";
            this.btSomar.UseVisualStyleBackColor = true;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // btSubtracao
            // 
            this.btSubtracao.Location = new System.Drawing.Point(104, 135);
            this.btSubtracao.Name = "btSubtracao";
            this.btSubtracao.Size = new System.Drawing.Size(86, 36);
            this.btSubtracao.TabIndex = 5;
            this.btSubtracao.Text = "Subtração";
            this.btSubtracao.UseVisualStyleBackColor = true;
            this.btSubtracao.Click += new System.EventHandler(this.btSubtracao_Click);
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.Location = new System.Drawing.Point(12, 177);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(86, 36);
            this.btMultiplicacao.TabIndex = 6;
            this.btMultiplicacao.Text = "Multiplicação";
            this.btMultiplicacao.UseVisualStyleBackColor = true;
            this.btMultiplicacao.Click += new System.EventHandler(this.btMultiplicacao_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.Location = new System.Drawing.Point(104, 177);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(86, 36);
            this.btDivisao.TabIndex = 7;
            this.btDivisao.Text = "Divisão";
            this.btDivisao.UseVisualStyleBackColor = true;
            this.btDivisao.Click += new System.EventHandler(this.btDivisao_Click);
            // 
            // btProdutoDosValores
            // 
            this.btProdutoDosValores.Location = new System.Drawing.Point(12, 219);
            this.btProdutoDosValores.Name = "btProdutoDosValores";
            this.btProdutoDosValores.Size = new System.Drawing.Size(178, 36);
            this.btProdutoDosValores.TabIndex = 8;
            this.btProdutoDosValores.Text = "Produto dos valores";
            this.btProdutoDosValores.UseVisualStyleBackColor = true;
            this.btProdutoDosValores.Click += new System.EventHandler(this.btProdutoDosValores_Click);
            // 
            // Exercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(303, 383);
            this.Controls.Add(this.btProdutoDosValores);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.btMultiplicacao);
            this.Controls.Add(this.btSubtracao);
            this.Controls.Add(this.btSomar);
            this.Controls.Add(this.txtInformeUmNumero2);
            this.Controls.Add(this.labelInformeUmNumero2);
            this.Controls.Add(this.txtInformeUmNumero);
            this.Controls.Add(this.labelInformeUmNumero1);
            this.Name = "Exercicio03";
            this.Text = "Exercicio03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformeUmNumero1;
        private System.Windows.Forms.TextBox txtInformeUmNumero;
        private System.Windows.Forms.Label labelInformeUmNumero2;
        private System.Windows.Forms.TextBox txtInformeUmNumero2;
        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.Button btSubtracao;
        private System.Windows.Forms.Button btMultiplicacao;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button btProdutoDosValores;
    }
}