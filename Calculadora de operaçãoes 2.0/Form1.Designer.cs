namespace Calculadora_de_operaçãoes_2._0
{
    partial class frmOperaCalc
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
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(21, 53);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(318, 20);
            this.txtCampo.TabIndex = 0;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(21, 79);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 1;
            this.btnSomar.Text = "button1";
            this.btnSomar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(164, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "label2";
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(264, 79);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "button2";
            this.btnDividir.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(183, 79);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 5;
            this.btnMultiplicar.Text = "button3";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(102, 79);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "button4";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(21, 108);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(318, 23);
            this.btnResultado.TabIndex = 7;
            this.btnResultado.Text = "button5";
            this.btnResultado.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 137);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(318, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "button5";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmOperaCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 418);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtCampo);
            this.Name = "frmOperaCalc";
            this.Text = "Calculadora de Operações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnLimpar;
    }
}

