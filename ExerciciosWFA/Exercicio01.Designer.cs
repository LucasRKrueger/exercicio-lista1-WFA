namespace ExerciciosWFA
{
    partial class Exercicio01
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
            this.labelInformeUmNumero = new System.Windows.Forms.Label();
            this.btGerar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtInformeUmNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInformeUmNumero
            // 
            this.labelInformeUmNumero.AutoSize = true;
            this.labelInformeUmNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeUmNumero.Location = new System.Drawing.Point(12, 37);
            this.labelInformeUmNumero.Name = "labelInformeUmNumero";
            this.labelInformeUmNumero.Size = new System.Drawing.Size(121, 16);
            this.labelInformeUmNumero.TabIndex = 0;
            this.labelInformeUmNumero.Text = "Informe um número";
            this.labelInformeUmNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(160, 65);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(79, 23);
            this.btGerar.TabIndex = 2;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(15, 105);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 67);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtInformeUmNumero_TextChanged_1);
            // 
            // txtInformeUmNumero
            // 
            this.txtInformeUmNumero.Location = new System.Drawing.Point(139, 39);
            this.txtInformeUmNumero.Name = "txtInformeUmNumero";
            this.txtInformeUmNumero.Size = new System.Drawing.Size(100, 20);
            this.txtInformeUmNumero.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado";
            // 
            // Exercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInformeUmNumero);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.labelInformeUmNumero);
            this.Name = "Exercicio01";
            this.Text = "Exercicio01";
            this.Load += new System.EventHandler(this.Exercicio01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformeUmNumero;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtInformeUmNumero;
        private System.Windows.Forms.Label label2;
    }
}