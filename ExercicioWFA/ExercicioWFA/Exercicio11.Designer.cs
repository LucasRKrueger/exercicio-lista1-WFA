namespace ExercicioWFA
{
    partial class Exercicio11
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
            this.labelDataDeNascimento = new System.Windows.Forms.Label();
            this.mtbDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.btZeigen = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDataDeNascimento
            // 
            this.labelDataDeNascimento.AutoSize = true;
            this.labelDataDeNascimento.Location = new System.Drawing.Point(12, 20);
            this.labelDataDeNascimento.Name = "labelDataDeNascimento";
            this.labelDataDeNascimento.Size = new System.Drawing.Size(104, 13);
            this.labelDataDeNascimento.TabIndex = 0;
            this.labelDataDeNascimento.Text = "Data de Nascimento";
            // 
            // mtbDataNascimento
            // 
            this.mtbDataNascimento.Location = new System.Drawing.Point(122, 17);
            this.mtbDataNascimento.Mask = "00/00/0000";
            this.mtbDataNascimento.Name = "mtbDataNascimento";
            this.mtbDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mtbDataNascimento.TabIndex = 1;
            // 
            // btZeigen
            // 
            this.btZeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZeigen.Location = new System.Drawing.Point(142, 43);
            this.btZeigen.Name = "btZeigen";
            this.btZeigen.Size = new System.Drawing.Size(80, 25);
            this.btZeigen.TabIndex = 2;
            this.btZeigen.Text = "Zeigen";
            this.btZeigen.UseVisualStyleBackColor = true;
            this.btZeigen.Click += new System.EventHandler(this.btZeigen_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(15, 144);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(257, 105);
            this.txtResultado.TabIndex = 3;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(12, 128);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "Resultado";
            // 
            // Exercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btZeigen);
            this.Controls.Add(this.mtbDataNascimento);
            this.Controls.Add(this.labelDataDeNascimento);
            this.Name = "Exercicio11";
            this.Text = "Exercicio11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDataDeNascimento;
        private System.Windows.Forms.MaskedTextBox mtbDataNascimento;
        private System.Windows.Forms.Button btZeigen;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label labelResultado;
    }
}