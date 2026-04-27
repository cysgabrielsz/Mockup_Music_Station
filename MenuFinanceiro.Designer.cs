namespace Mockup_Music_Station
{
    partial class MenuFinanceiro
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.btnTransações = new System.Windows.Forms.Button();
            this.btnFormasPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnPagamentos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnPagamentos.FlatAppearance.BorderSize = 3;
            this.btnPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamentos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnPagamentos.Location = new System.Drawing.Point(3, 19);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(129, 43);
            this.btnPagamentos.TabIndex = 22;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.UseVisualStyleBackColor = false;
            // 
            // btnTransações
            // 
            this.btnTransações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnTransações.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnTransações.FlatAppearance.BorderSize = 3;
            this.btnTransações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransações.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransações.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnTransações.Location = new System.Drawing.Point(3, 68);
            this.btnTransações.Name = "btnTransações";
            this.btnTransações.Size = new System.Drawing.Size(129, 43);
            this.btnTransações.TabIndex = 25;
            this.btnTransações.Text = "Transações";
            this.btnTransações.UseVisualStyleBackColor = false;
            // 
            // btnFormasPagamento
            // 
            this.btnFormasPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnFormasPagamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnFormasPagamento.FlatAppearance.BorderSize = 3;
            this.btnFormasPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormasPagamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormasPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnFormasPagamento.Location = new System.Drawing.Point(3, 117);
            this.btnFormasPagamento.Name = "btnFormasPagamento";
            this.btnFormasPagamento.Size = new System.Drawing.Size(129, 43);
            this.btnFormasPagamento.TabIndex = 26;
            this.btnFormasPagamento.Text = "Formas de pagamento";
            this.btnFormasPagamento.UseVisualStyleBackColor = false;
            // 
            // MenuFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFormasPagamento);
            this.Controls.Add(this.btnTransações);
            this.Controls.Add(this.btnPagamentos);
            this.Name = "MenuFinanceiro";
            this.Size = new System.Drawing.Size(135, 219);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Button btnTransações;
        private System.Windows.Forms.Button btnFormasPagamento;
    }
}
