namespace ExercicioWFA
{
    partial class Exercicio09
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
            this.labelInfomeUmNumero = new System.Windows.Forms.Label();
            this.txtInformeUmNumero1 = new System.Windows.Forms.TextBox();
            this.labelInformeUmNumero2 = new System.Windows.Forms.Label();
            this.txtInformeUmNumero2 = new System.Windows.Forms.TextBox();
            this.brZeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfomeUmNumero
            // 
            this.labelInfomeUmNumero.AutoSize = true;
            this.labelInfomeUmNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfomeUmNumero.Location = new System.Drawing.Point(12, 9);
            this.labelInfomeUmNumero.Name = "labelInfomeUmNumero";
            this.labelInfomeUmNumero.Size = new System.Drawing.Size(124, 20);
            this.labelInfomeUmNumero.TabIndex = 0;
            this.labelInfomeUmNumero.Text = "Primeiro número";
            // 
            // txtInformeUmNumero1
            // 
            this.txtInformeUmNumero1.Location = new System.Drawing.Point(150, 12);
            this.txtInformeUmNumero1.Name = "txtInformeUmNumero1";
            this.txtInformeUmNumero1.Size = new System.Drawing.Size(79, 20);
            this.txtInformeUmNumero1.TabIndex = 1;
            // 
            // labelInformeUmNumero2
            // 
            this.labelInformeUmNumero2.AutoSize = true;
            this.labelInformeUmNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeUmNumero2.Location = new System.Drawing.Point(12, 45);
            this.labelInformeUmNumero2.Name = "labelInformeUmNumero2";
            this.labelInformeUmNumero2.Size = new System.Drawing.Size(132, 20);
            this.labelInformeUmNumero2.TabIndex = 2;
            this.labelInformeUmNumero2.Text = "Segundo número";
            // 
            // txtInformeUmNumero2
            // 
            this.txtInformeUmNumero2.Location = new System.Drawing.Point(150, 47);
            this.txtInformeUmNumero2.Name = "txtInformeUmNumero2";
            this.txtInformeUmNumero2.Size = new System.Drawing.Size(79, 20);
            this.txtInformeUmNumero2.TabIndex = 3;
            // 
            // brZeigen
            // 
            this.brZeigen.Location = new System.Drawing.Point(150, 73);
            this.brZeigen.Name = "brZeigen";
            this.brZeigen.Size = new System.Drawing.Size(79, 27);
            this.brZeigen.TabIndex = 4;
            this.brZeigen.Text = "Zeigen";
            this.brZeigen.UseVisualStyleBackColor = true;
            this.brZeigen.Click += new System.EventHandler(this.brZeigen_Click);
            // 
            // Exercicio09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.brZeigen);
            this.Controls.Add(this.txtInformeUmNumero2);
            this.Controls.Add(this.labelInformeUmNumero2);
            this.Controls.Add(this.txtInformeUmNumero1);
            this.Controls.Add(this.labelInfomeUmNumero);
            this.Name = "Exercicio09";
            this.Text = "Exercicio09";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfomeUmNumero;
        private System.Windows.Forms.TextBox txtInformeUmNumero1;
        private System.Windows.Forms.Label labelInformeUmNumero2;
        private System.Windows.Forms.TextBox txtInformeUmNumero2;
        private System.Windows.Forms.Button brZeigen;
    }
}