namespace ExercicioWFA
{
    partial class Exercicio06
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
            this.labelNota1 = new System.Windows.Forms.Label();
            this.labelNota2 = new System.Windows.Forms.Label();
            this.labelNota3 = new System.Windows.Forms.Label();
            this.labelNota4 = new System.Windows.Forms.Label();
            this.labelBoletim = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.btMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota1.Location = new System.Drawing.Point(12, 65);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(56, 20);
            this.labelNota1.TabIndex = 0;
            this.labelNota1.Text = "Nota 1";
            // 
            // labelNota2
            // 
            this.labelNota2.AutoSize = true;
            this.labelNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota2.Location = new System.Drawing.Point(12, 98);
            this.labelNota2.Name = "labelNota2";
            this.labelNota2.Size = new System.Drawing.Size(56, 20);
            this.labelNota2.TabIndex = 1;
            this.labelNota2.Text = "Nota 2";
            // 
            // labelNota3
            // 
            this.labelNota3.AutoSize = true;
            this.labelNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota3.Location = new System.Drawing.Point(12, 135);
            this.labelNota3.Name = "labelNota3";
            this.labelNota3.Size = new System.Drawing.Size(56, 20);
            this.labelNota3.TabIndex = 2;
            this.labelNota3.Text = "Nota 3";
            // 
            // labelNota4
            // 
            this.labelNota4.AutoSize = true;
            this.labelNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota4.Location = new System.Drawing.Point(12, 170);
            this.labelNota4.Name = "labelNota4";
            this.labelNota4.Size = new System.Drawing.Size(56, 20);
            this.labelNota4.TabIndex = 3;
            this.labelNota4.Text = "Nota 4";
            // 
            // labelBoletim
            // 
            this.labelBoletim.AutoSize = true;
            this.labelBoletim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoletim.Location = new System.Drawing.Point(122, 9);
            this.labelBoletim.Name = "labelBoletim";
            this.labelBoletim.Size = new System.Drawing.Size(104, 31);
            this.labelBoletim.TabIndex = 4;
            this.labelBoletim.Text = "Boletim";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(74, 65);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(73, 20);
            this.txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(74, 100);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(73, 20);
            this.txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(74, 137);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(73, 20);
            this.txtNota3.TabIndex = 7;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(74, 170);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(73, 20);
            this.txtNota4.TabIndex = 8;
            // 
            // btMedia
            // 
            this.btMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMedia.Location = new System.Drawing.Point(247, 226);
            this.btMedia.Name = "btMedia";
            this.btMedia.Size = new System.Drawing.Size(92, 35);
            this.btMedia.TabIndex = 9;
            this.btMedia.Text = "Média";
            this.btMedia.UseVisualStyleBackColor = true;
            this.btMedia.Click += new System.EventHandler(this.btMedia_Click);
            // 
            // Exercicio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 273);
            this.Controls.Add(this.btMedia);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.labelBoletim);
            this.Controls.Add(this.labelNota4);
            this.Controls.Add(this.labelNota3);
            this.Controls.Add(this.labelNota2);
            this.Controls.Add(this.labelNota1);
            this.Name = "Exercicio06";
            this.Text = "Exercicio06";
            this.Load += new System.EventHandler(this.Exercicio06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.Label labelNota2;
        private System.Windows.Forms.Label labelNota3;
        private System.Windows.Forms.Label labelNota4;
        private System.Windows.Forms.Label labelBoletim;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Button btMedia;
    }
}