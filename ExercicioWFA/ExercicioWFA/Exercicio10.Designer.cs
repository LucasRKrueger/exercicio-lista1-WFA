namespace ExercicioWFA
{
    partial class Exercicio10
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
            this.labelInformeOanoDeNascimento = new System.Windows.Forms.Label();
            this.txtAnoDeNascimento = new System.Windows.Forms.TextBox();
            this.btZeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInformeOanoDeNascimento
            // 
            this.labelInformeOanoDeNascimento.AutoSize = true;
            this.labelInformeOanoDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeOanoDeNascimento.Location = new System.Drawing.Point(12, 9);
            this.labelInformeOanoDeNascimento.Name = "labelInformeOanoDeNascimento";
            this.labelInformeOanoDeNascimento.Size = new System.Drawing.Size(216, 20);
            this.labelInformeOanoDeNascimento.TabIndex = 0;
            this.labelInformeOanoDeNascimento.Text = "Informe o ano de nascimento";
            // 
            // txtAnoDeNascimento
            // 
            this.txtAnoDeNascimento.Location = new System.Drawing.Point(234, 12);
            this.txtAnoDeNascimento.Name = "txtAnoDeNascimento";
            this.txtAnoDeNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtAnoDeNascimento.TabIndex = 1;
            // 
            // btZeigen
            // 
            this.btZeigen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btZeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZeigen.Location = new System.Drawing.Point(253, 38);
            this.btZeigen.Name = "btZeigen";
            this.btZeigen.Size = new System.Drawing.Size(81, 31);
            this.btZeigen.TabIndex = 2;
            this.btZeigen.Text = "Zeigen";
            this.btZeigen.UseVisualStyleBackColor = false;
            this.btZeigen.Click += new System.EventHandler(this.btZeigen_Click);
            // 
            // Exercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 136);
            this.Controls.Add(this.btZeigen);
            this.Controls.Add(this.txtAnoDeNascimento);
            this.Controls.Add(this.labelInformeOanoDeNascimento);
            this.Name = "Exercicio10";
            this.Text = "Exercicio10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformeOanoDeNascimento;
        private System.Windows.Forms.TextBox txtAnoDeNascimento;
        private System.Windows.Forms.Button btZeigen;
    }
}