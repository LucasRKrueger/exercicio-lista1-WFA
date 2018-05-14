namespace ExercicioWFA
{
    partial class Exercicio08
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
            this.labelContaLuz = new System.Windows.Forms.Label();
            this.labelContaAgua = new System.Windows.Forms.Label();
            this.labelValorNet = new System.Windows.Forms.Label();
            this.labelValorVivo = new System.Windows.Forms.Label();
            this.labelValorOi = new System.Windows.Forms.Label();
            this.labelValorIptu = new System.Windows.Forms.Label();
            this.labelValorIpva = new System.Windows.Forms.Label();
            this.labelValorSeguroCarro = new System.Windows.Forms.Label();
            this.txtContaDeLuz = new System.Windows.Forms.TextBox();
            this.txtContaDeAgua = new System.Windows.Forms.TextBox();
            this.txtValorDaNet = new System.Windows.Forms.TextBox();
            this.txtValorDaVivo = new System.Windows.Forms.TextBox();
            this.txtValorDaOi = new System.Windows.Forms.TextBox();
            this.txtValorIptu = new System.Windows.Forms.TextBox();
            this.txtValorIpva = new System.Windows.Forms.TextBox();
            this.txtValorSeguroDoCarro = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.btZeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelContaLuz
            // 
            this.labelContaLuz.AutoSize = true;
            this.labelContaLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContaLuz.Location = new System.Drawing.Point(12, 9);
            this.labelContaLuz.Name = "labelContaLuz";
            this.labelContaLuz.Size = new System.Drawing.Size(115, 24);
            this.labelContaLuz.TabIndex = 0;
            this.labelContaLuz.Text = "Conta de luz";
            // 
            // labelContaAgua
            // 
            this.labelContaAgua.AutoSize = true;
            this.labelContaAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContaAgua.Location = new System.Drawing.Point(12, 60);
            this.labelContaAgua.Name = "labelContaAgua";
            this.labelContaAgua.Size = new System.Drawing.Size(133, 24);
            this.labelContaAgua.TabIndex = 1;
            this.labelContaAgua.Text = "Conta de água";
            this.labelContaAgua.Click += new System.EventHandler(this.labelContaAgua_Click);
            // 
            // labelValorNet
            // 
            this.labelValorNet.AutoSize = true;
            this.labelValorNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorNet.Location = new System.Drawing.Point(12, 109);
            this.labelValorNet.Name = "labelValorNet";
            this.labelValorNet.Size = new System.Drawing.Size(114, 24);
            this.labelValorNet.TabIndex = 2;
            this.labelValorNet.Text = "Valor da Net";
            // 
            // labelValorVivo
            // 
            this.labelValorVivo.AutoSize = true;
            this.labelValorVivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorVivo.Location = new System.Drawing.Point(12, 160);
            this.labelValorVivo.Name = "labelValorVivo";
            this.labelValorVivo.Size = new System.Drawing.Size(118, 24);
            this.labelValorVivo.TabIndex = 3;
            this.labelValorVivo.Text = "Valor da vivo";
            this.labelValorVivo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelValorOi
            // 
            this.labelValorOi.AutoSize = true;
            this.labelValorOi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorOi.Location = new System.Drawing.Point(502, 9);
            this.labelValorOi.Name = "labelValorOi";
            this.labelValorOi.Size = new System.Drawing.Size(104, 24);
            this.labelValorOi.TabIndex = 4;
            this.labelValorOi.Text = "Valor da Oi";
            // 
            // labelValorIptu
            // 
            this.labelValorIptu.AutoSize = true;
            this.labelValorIptu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorIptu.Location = new System.Drawing.Point(502, 59);
            this.labelValorIptu.Name = "labelValorIptu";
            this.labelValorIptu.Size = new System.Drawing.Size(100, 24);
            this.labelValorIptu.TabIndex = 5;
            this.labelValorIptu.Text = "Valor IPTU";
            // 
            // labelValorIpva
            // 
            this.labelValorIpva.AutoSize = true;
            this.labelValorIpva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorIpva.Location = new System.Drawing.Point(502, 108);
            this.labelValorIpva.Name = "labelValorIpva";
            this.labelValorIpva.Size = new System.Drawing.Size(101, 24);
            this.labelValorIpva.TabIndex = 6;
            this.labelValorIpva.Text = "Valor IPVA";
            // 
            // labelValorSeguroCarro
            // 
            this.labelValorSeguroCarro.AutoSize = true;
            this.labelValorSeguroCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorSeguroCarro.Location = new System.Drawing.Point(502, 161);
            this.labelValorSeguroCarro.Name = "labelValorSeguroCarro";
            this.labelValorSeguroCarro.Size = new System.Drawing.Size(193, 24);
            this.labelValorSeguroCarro.TabIndex = 7;
            this.labelValorSeguroCarro.Text = "Valor seguro do carro";
            this.labelValorSeguroCarro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtContaDeLuz
            // 
            this.txtContaDeLuz.Location = new System.Drawing.Point(133, 14);
            this.txtContaDeLuz.Name = "txtContaDeLuz";
            this.txtContaDeLuz.Size = new System.Drawing.Size(133, 20);
            this.txtContaDeLuz.TabIndex = 8;
            // 
            // txtContaDeAgua
            // 
            this.txtContaDeAgua.Location = new System.Drawing.Point(151, 64);
            this.txtContaDeAgua.Name = "txtContaDeAgua";
            this.txtContaDeAgua.Size = new System.Drawing.Size(133, 20);
            this.txtContaDeAgua.TabIndex = 9;
            // 
            // txtValorDaNet
            // 
            this.txtValorDaNet.Location = new System.Drawing.Point(132, 113);
            this.txtValorDaNet.Name = "txtValorDaNet";
            this.txtValorDaNet.Size = new System.Drawing.Size(133, 20);
            this.txtValorDaNet.TabIndex = 10;
            // 
            // txtValorDaVivo
            // 
            this.txtValorDaVivo.Location = new System.Drawing.Point(136, 165);
            this.txtValorDaVivo.Name = "txtValorDaVivo";
            this.txtValorDaVivo.Size = new System.Drawing.Size(133, 20);
            this.txtValorDaVivo.TabIndex = 11;
            // 
            // txtValorDaOi
            // 
            this.txtValorDaOi.Location = new System.Drawing.Point(612, 9);
            this.txtValorDaOi.Name = "txtValorDaOi";
            this.txtValorDaOi.Size = new System.Drawing.Size(133, 20);
            this.txtValorDaOi.TabIndex = 12;
            // 
            // txtValorIptu
            // 
            this.txtValorIptu.Location = new System.Drawing.Point(608, 59);
            this.txtValorIptu.Name = "txtValorIptu";
            this.txtValorIptu.Size = new System.Drawing.Size(133, 20);
            this.txtValorIptu.TabIndex = 13;
            // 
            // txtValorIpva
            // 
            this.txtValorIpva.Location = new System.Drawing.Point(608, 109);
            this.txtValorIpva.Name = "txtValorIpva";
            this.txtValorIpva.Size = new System.Drawing.Size(133, 20);
            this.txtValorIpva.TabIndex = 14;
            // 
            // txtValorSeguroDoCarro
            // 
            this.txtValorSeguroDoCarro.Location = new System.Drawing.Point(701, 166);
            this.txtValorSeguroDoCarro.Name = "txtValorSeguroDoCarro";
            this.txtValorSeguroDoCarro.Size = new System.Drawing.Size(133, 20);
            this.txtValorSeguroDoCarro.TabIndex = 15;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(16, 229);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(405, 178);
            this.txtResultado.TabIndex = 16;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(12, 206);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(82, 20);
            this.labelResultado.TabIndex = 17;
            this.labelResultado.Text = "Resultado";
            // 
            // btZeigen
            // 
            this.btZeigen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btZeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btZeigen.Location = new System.Drawing.Point(790, 363);
            this.btZeigen.Name = "btZeigen";
            this.btZeigen.Size = new System.Drawing.Size(126, 44);
            this.btZeigen.TabIndex = 18;
            this.btZeigen.Text = "Zeigen";
            this.btZeigen.UseVisualStyleBackColor = false;
            this.btZeigen.Click += new System.EventHandler(this.btZeigen_Click);
            // 
            // Exercicio08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 419);
            this.Controls.Add(this.btZeigen);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValorSeguroDoCarro);
            this.Controls.Add(this.txtValorIpva);
            this.Controls.Add(this.txtValorIptu);
            this.Controls.Add(this.txtValorDaOi);
            this.Controls.Add(this.txtValorDaVivo);
            this.Controls.Add(this.txtValorDaNet);
            this.Controls.Add(this.txtContaDeAgua);
            this.Controls.Add(this.txtContaDeLuz);
            this.Controls.Add(this.labelValorSeguroCarro);
            this.Controls.Add(this.labelValorIpva);
            this.Controls.Add(this.labelValorIptu);
            this.Controls.Add(this.labelValorOi);
            this.Controls.Add(this.labelValorVivo);
            this.Controls.Add(this.labelValorNet);
            this.Controls.Add(this.labelContaAgua);
            this.Controls.Add(this.labelContaLuz);
            this.Name = "Exercicio08";
            this.Text = "Exercicio08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContaLuz;
        private System.Windows.Forms.Label labelContaAgua;
        private System.Windows.Forms.Label labelValorNet;
        private System.Windows.Forms.Label labelValorVivo;
        private System.Windows.Forms.Label labelValorOi;
        private System.Windows.Forms.Label labelValorIptu;
        private System.Windows.Forms.Label labelValorIpva;
        private System.Windows.Forms.Label labelValorSeguroCarro;
        private System.Windows.Forms.TextBox txtContaDeLuz;
        private System.Windows.Forms.TextBox txtContaDeAgua;
        private System.Windows.Forms.TextBox txtValorDaNet;
        private System.Windows.Forms.TextBox txtValorDaVivo;
        private System.Windows.Forms.TextBox txtValorDaOi;
        private System.Windows.Forms.TextBox txtValorIptu;
        private System.Windows.Forms.TextBox txtValorIpva;
        private System.Windows.Forms.TextBox txtValorSeguroDoCarro;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button btZeigen;
    }
}