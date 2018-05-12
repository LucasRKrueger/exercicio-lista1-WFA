namespace ExerciciosWFA
{
    partial class Exercicio02
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
            this.labelQuantidadeLitros = new System.Windows.Forms.Label();
            this.txtQuantidadeLitros = new System.Windows.Forms.TextBox();
            this.labelQuantidadeAnosConsumidos = new System.Windows.Forms.Label();
            this.txtQuantidadeAnosConsumidos = new System.Windows.Forms.TextBox();
            this.labelValorPagoPorLitro = new System.Windows.Forms.Label();
            this.btGerarResultado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbValorPagoLitro = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelQuantidadeLitros
            // 
            this.labelQuantidadeLitros.AutoSize = true;
            this.labelQuantidadeLitros.Location = new System.Drawing.Point(12, 35);
            this.labelQuantidadeLitros.Name = "labelQuantidadeLitros";
            this.labelQuantidadeLitros.Size = new System.Drawing.Size(223, 13);
            this.labelQuantidadeLitros.TabIndex = 0;
            this.labelQuantidadeLitros.Text = "Quantidade de litros de água ingeridos por dia";
            this.labelQuantidadeLitros.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQuantidadeLitros
            // 
            this.txtQuantidadeLitros.Location = new System.Drawing.Point(15, 51);
            this.txtQuantidadeLitros.Name = "txtQuantidadeLitros";
            this.txtQuantidadeLitros.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeLitros.TabIndex = 1;
            this.txtQuantidadeLitros.TextChanged += new System.EventHandler(this.txtQuantidadeLitros_TextChanged);
            // 
            // labelQuantidadeAnosConsumidos
            // 
            this.labelQuantidadeAnosConsumidos.AutoSize = true;
            this.labelQuantidadeAnosConsumidos.Location = new System.Drawing.Point(12, 83);
            this.labelQuantidadeAnosConsumidos.Name = "labelQuantidadeAnosConsumidos";
            this.labelQuantidadeAnosConsumidos.Size = new System.Drawing.Size(163, 13);
            this.labelQuantidadeAnosConsumidos.TabIndex = 2;
            this.labelQuantidadeAnosConsumidos.Text = "Quantidade de anos Consumidos";
            // 
            // txtQuantidadeAnosConsumidos
            // 
            this.txtQuantidadeAnosConsumidos.Location = new System.Drawing.Point(15, 99);
            this.txtQuantidadeAnosConsumidos.Name = "txtQuantidadeAnosConsumidos";
            this.txtQuantidadeAnosConsumidos.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeAnosConsumidos.TabIndex = 3;
            // 
            // labelValorPagoPorLitro
            // 
            this.labelValorPagoPorLitro.AutoSize = true;
            this.labelValorPagoPorLitro.Location = new System.Drawing.Point(12, 132);
            this.labelValorPagoPorLitro.Name = "labelValorPagoPorLitro";
            this.labelValorPagoPorLitro.Size = new System.Drawing.Size(100, 13);
            this.labelValorPagoPorLitro.TabIndex = 4;
            this.labelValorPagoPorLitro.Text = "Valor Pago por Litro";
            // 
            // btGerarResultado
            // 
            this.btGerarResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGerarResultado.Location = new System.Drawing.Point(293, 33);
            this.btGerarResultado.Name = "btGerarResultado";
            this.btGerarResultado.Size = new System.Drawing.Size(102, 38);
            this.btGerarResultado.TabIndex = 8;
            this.btGerarResultado.Text = "Quantidade Litros Consumidos";
            this.btGerarResultado.UseVisualStyleBackColor = false;
            this.btGerarResultado.Click += new System.EventHandler(this.btGerarResultado_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(420, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Valor Total Pago";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtbValorPagoLitro
            // 
            this.mtbValorPagoLitro.Location = new System.Drawing.Point(15, 148);
            this.mtbValorPagoLitro.Mask = "000,00";
            this.mtbValorPagoLitro.Name = "mtbValorPagoLitro";
            this.mtbValorPagoLitro.Size = new System.Drawing.Size(100, 20);
            this.mtbValorPagoLitro.TabIndex = 10;
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 350);
            this.Controls.Add(this.mtbValorPagoLitro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btGerarResultado);
            this.Controls.Add(this.labelValorPagoPorLitro);
            this.Controls.Add(this.txtQuantidadeAnosConsumidos);
            this.Controls.Add(this.labelQuantidadeAnosConsumidos);
            this.Controls.Add(this.txtQuantidadeLitros);
            this.Controls.Add(this.labelQuantidadeLitros);
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            this.Load += new System.EventHandler(this.Exercicio02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuantidadeLitros;
        private System.Windows.Forms.TextBox txtQuantidadeLitros;
        private System.Windows.Forms.Label labelQuantidadeAnosConsumidos;
        private System.Windows.Forms.TextBox txtQuantidadeAnosConsumidos;
        private System.Windows.Forms.Label labelValorPagoPorLitro;
        private System.Windows.Forms.Button btGerarResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbValorPagoLitro;
    }
}