namespace Idade
{
    partial class frmIdade
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtDia_At = new System.Windows.Forms.TextBox();
            this.txtAno_At = new System.Windows.Forms.TextBox();
            this.txtMes_At = new System.Windows.Forms.TextBox();
            this.txtDia_Nasc = new System.Windows.Forms.TextBox();
            this.txtMes_Nasc = new System.Windows.Forms.TextBox();
            this.txtAno_Nasc = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblAtual = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(12, 42);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(26, 13);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(12, 68);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mês:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(12, 92);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(66, 164);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade:";
            // 
            // txtDia_At
            // 
            this.txtDia_At.Location = new System.Drawing.Point(53, 39);
            this.txtDia_At.Name = "txtDia_At";
            this.txtDia_At.Size = new System.Drawing.Size(48, 20);
            this.txtDia_At.TabIndex = 7;
            this.txtDia_At.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia_At.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_At_KeyPress);
            // 
            // txtAno_At
            // 
            this.txtAno_At.Location = new System.Drawing.Point(53, 92);
            this.txtAno_At.Name = "txtAno_At";
            this.txtAno_At.Size = new System.Drawing.Size(48, 20);
            this.txtAno_At.TabIndex = 8;
            this.txtAno_At.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAno_At.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_At_KeyPress);
            // 
            // txtMes_At
            // 
            this.txtMes_At.Location = new System.Drawing.Point(53, 65);
            this.txtMes_At.Name = "txtMes_At";
            this.txtMes_At.Size = new System.Drawing.Size(48, 20);
            this.txtMes_At.TabIndex = 9;
            this.txtMes_At.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes_At.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_At_KeyPress);
            // 
            // txtDia_Nasc
            // 
            this.txtDia_Nasc.Location = new System.Drawing.Point(143, 39);
            this.txtDia_Nasc.Name = "txtDia_Nasc";
            this.txtDia_Nasc.Size = new System.Drawing.Size(48, 20);
            this.txtDia_Nasc.TabIndex = 0;
            this.txtDia_Nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia_Nasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_Nasc_KeyPress);
            // 
            // txtMes_Nasc
            // 
            this.txtMes_Nasc.Location = new System.Drawing.Point(143, 65);
            this.txtMes_Nasc.Name = "txtMes_Nasc";
            this.txtMes_Nasc.Size = new System.Drawing.Size(48, 20);
            this.txtMes_Nasc.TabIndex = 1;
            this.txtMes_Nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes_Nasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_Nasc_KeyPress);
            // 
            // txtAno_Nasc
            // 
            this.txtAno_Nasc.Location = new System.Drawing.Point(143, 92);
            this.txtAno_Nasc.Name = "txtAno_Nasc";
            this.txtAno_Nasc.Size = new System.Drawing.Size(48, 20);
            this.txtAno_Nasc.TabIndex = 2;
            this.txtAno_Nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAno_Nasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_Nasc_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(53, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(138, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular Idade";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(109, 161);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(47, 20);
            this.txtIdade.TabIndex = 14;
            this.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdade_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(26, 204);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(116, 204);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Location = new System.Drawing.Point(66, 10);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(31, 13);
            this.lblAtual.TabIndex = 17;
            this.lblAtual.Text = "Atual";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(140, 10);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 18;
            this.lblNascimento.Text = "Nascimento";
            // 
            // frmIdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 254);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblAtual);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAno_Nasc);
            this.Controls.Add(this.txtMes_Nasc);
            this.Controls.Add(this.txtDia_Nasc);
            this.Controls.Add(this.txtMes_At);
            this.Controls.Add(this.txtAno_At);
            this.Controls.Add(this.txtDia_At);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(238, 293);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(238, 293);
            this.Name = "frmIdade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idade";
            this.Load += new System.EventHandler(this.frmIdade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtDia_At;
        private System.Windows.Forms.TextBox txtAno_At;
        private System.Windows.Forms.TextBox txtMes_At;
        private System.Windows.Forms.TextBox txtDia_Nasc;
        private System.Windows.Forms.TextBox txtMes_Nasc;
        private System.Windows.Forms.TextBox txtAno_Nasc;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.Label lblNascimento;
    }
}

