namespace CalcularJurosFinanciamento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblemprestimo = new System.Windows.Forms.Label();
            this.textEmprestimo = new System.Windows.Forms.TextBox();
            this.textTaxa = new System.Windows.Forms.TextBox();
            this.textParcelas = new System.Windows.Forms.TextBox();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.btlCalcularJuros = new System.Windows.Forms.Button();
            this.lbltotaljuros = new System.Windows.Forms.Label();
            this.lbltotalpago = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblemprestimo
            // 
            this.lblemprestimo.AutoSize = true;
            this.lblemprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemprestimo.Location = new System.Drawing.Point(251, 9);
            this.lblemprestimo.Name = "lblemprestimo";
            this.lblemprestimo.Size = new System.Drawing.Size(204, 24);
            this.lblemprestimo.TabIndex = 0;
            this.lblemprestimo.Text = "Valor do empréstimo";
            this.lblemprestimo.Click += new System.EventHandler(this.lblemprestimo_Click);
            // 
            // textEmprestimo
            // 
            this.textEmprestimo.Location = new System.Drawing.Point(255, 55);
            this.textEmprestimo.Name = "textEmprestimo";
            this.textEmprestimo.Size = new System.Drawing.Size(200, 20);
            this.textEmprestimo.TabIndex = 1;
            this.textEmprestimo.TextChanged += new System.EventHandler(this.textEmprestimo_TextChanged);
            // 
            // textTaxa
            // 
            this.textTaxa.Location = new System.Drawing.Point(245, 163);
            this.textTaxa.Name = "textTaxa";
            this.textTaxa.Size = new System.Drawing.Size(209, 20);
            this.textTaxa.TabIndex = 2;
            this.textTaxa.TextChanged += new System.EventHandler(this.textTaxa_TextChanged);
            // 
            // textParcelas
            // 
            this.textParcelas.Location = new System.Drawing.Point(246, 272);
            this.textParcelas.Name = "textParcelas";
            this.textParcelas.Size = new System.Drawing.Size(209, 20);
            this.textParcelas.TabIndex = 3;
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(251, 114);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(203, 24);
            this.lblTaxa.TabIndex = 4;
            this.lblTaxa.Text = "Taxa de Juros Anual";
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.Location = new System.Drawing.Point(254, 227);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(201, 24);
            this.lblParcelas.TabIndex = 5;
            this.lblParcelas.Text = "Número de Parcelas";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbltotal.Location = new System.Drawing.Point(255, 418);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(143, 18);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "Valor da Parcela R$:";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(314, 480);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(0, 13);
            this.lblJuros.TabIndex = 8;
            // 
            // btlCalcularJuros
            // 
            this.btlCalcularJuros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btlCalcularJuros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlCalcularJuros.BackgroundImage")));
            this.btlCalcularJuros.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlCalcularJuros.Location = new System.Drawing.Point(228, 318);
            this.btlCalcularJuros.Name = "btlCalcularJuros";
            this.btlCalcularJuros.Size = new System.Drawing.Size(237, 59);
            this.btlCalcularJuros.TabIndex = 6;
            this.btlCalcularJuros.Text = "Calcular Juros";
            this.btlCalcularJuros.UseVisualStyleBackColor = false;
            this.btlCalcularJuros.Click += new System.EventHandler(this.btlCalcularJuros_Click);
            // 
            // lbltotaljuros
            // 
            this.lbltotaljuros.AutoSize = true;
            this.lbltotaljuros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltotaljuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaljuros.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbltotaljuros.Location = new System.Drawing.Point(255, 450);
            this.lbltotaljuros.Name = "lbltotaljuros";
            this.lbltotaljuros.Size = new System.Drawing.Size(139, 18);
            this.lbltotaljuros.TabIndex = 9;
            this.lbltotaljuros.Text = "Total dos Juros R$:";
            // 
            // lbltotalpago
            // 
            this.lbltotalpago.AutoSize = true;
            this.lbltotalpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpago.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbltotalpago.Location = new System.Drawing.Point(255, 480);
            this.lbltotalpago.Name = "lbltotalpago";
            this.lbltotalpago.Size = new System.Drawing.Size(107, 18);
            this.lbltotalpago.TabIndex = 10;
            this.lbltotalpago.Text = "Total Pago R$:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 519);
            this.Controls.Add(this.lbltotalpago);
            this.Controls.Add(this.lbltotaljuros);
            this.Controls.Add(this.btlCalcularJuros);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.textParcelas);
            this.Controls.Add(this.textTaxa);
            this.Controls.Add(this.textEmprestimo);
            this.Controls.Add(this.lblemprestimo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemprestimo;
        private System.Windows.Forms.TextBox textEmprestimo;
        private System.Windows.Forms.TextBox textTaxa;
        private System.Windows.Forms.TextBox textParcelas;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Button btlCalcularJuros;
        private System.Windows.Forms.Label lbltotaljuros;
        private System.Windows.Forms.Label lbltotalpago;
    }
}

