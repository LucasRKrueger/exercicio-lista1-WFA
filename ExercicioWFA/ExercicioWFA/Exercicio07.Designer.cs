namespace ExercicioWFA
{
    partial class Exercicio07
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
            this.btZeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btZeigen
            // 
            this.btZeigen.Location = new System.Drawing.Point(97, 103);
            this.btZeigen.Name = "btZeigen";
            this.btZeigen.Size = new System.Drawing.Size(86, 34);
            this.btZeigen.TabIndex = 0;
            this.btZeigen.Text = "Zeigen";
            this.btZeigen.UseVisualStyleBackColor = true;
            this.btZeigen.Click += new System.EventHandler(this.btZeigen_Click);
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btZeigen);
            this.Name = "Exercicio07";
            this.Text = "Exercicio07";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btZeigen;
    }
}