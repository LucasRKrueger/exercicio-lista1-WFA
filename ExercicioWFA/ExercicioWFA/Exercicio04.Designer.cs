namespace ExerciciosWFA
{
    partial class Exercicio04
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
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.labelInformeUmNumero = new System.Windows.Forms.Label();
            this.txtInformeUmNumero = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicar.Location = new System.Drawing.Point(16, 42);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(114, 34);
            this.btMultiplicar.TabIndex = 0;
            this.btMultiplicar.Text = "Multiplicar";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // labelInformeUmNumero
            // 
            this.labelInformeUmNumero.AutoSize = true;
            this.labelInformeUmNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeUmNumero.Location = new System.Drawing.Point(12, 9);
            this.labelInformeUmNumero.Name = "labelInformeUmNumero";
            this.labelInformeUmNumero.Size = new System.Drawing.Size(148, 20);
            this.labelInformeUmNumero.TabIndex = 1;
            this.labelInformeUmNumero.Text = "Informe um número";
            // 
            // txtInformeUmNumero
            // 
            this.txtInformeUmNumero.Location = new System.Drawing.Point(166, 11);
            this.txtInformeUmNumero.Name = "txtInformeUmNumero";
            this.txtInformeUmNumero.Size = new System.Drawing.Size(100, 20);
            this.txtInformeUmNumero.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(16, 119);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(222, 304);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(12, 96);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(82, 20);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtInformeUmNumero);
            this.Controls.Add(this.labelInformeUmNumero);
            this.Controls.Add(this.btMultiplicar);
            this.Name = "Exercicio04";
            this.Text = "Exercicio04";
            this.Load += new System.EventHandler(this.Exercicio04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Label labelInformeUmNumero;
        private System.Windows.Forms.TextBox txtInformeUmNumero;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label labelResultado;
    }
}