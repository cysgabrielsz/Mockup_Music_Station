namespace Mockup_Music_Station
{
    partial class MenuOperacional
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
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnLocacoes = new System.Windows.Forms.Button();
            this.panelnavegacao = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnPedidos.Location = new System.Drawing.Point(0, 0);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(164, 46);
            this.btnPedidos.TabIndex = 21;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            this.btnPedidos.Leave += new System.EventHandler(this.btnPedidos_Leave);
            // 
            // btnLocacoes
            // 
            this.btnLocacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnLocacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocacoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnLocacoes.FlatAppearance.BorderSize = 0;
            this.btnLocacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnLocacoes.Location = new System.Drawing.Point(0, 46);
            this.btnLocacoes.Name = "btnLocacoes";
            this.btnLocacoes.Size = new System.Drawing.Size(164, 46);
            this.btnLocacoes.TabIndex = 22;
            this.btnLocacoes.Text = "Locações";
            this.btnLocacoes.UseVisualStyleBackColor = false;
            this.btnLocacoes.Click += new System.EventHandler(this.btnLocacoes_Click);
            this.btnLocacoes.Leave += new System.EventHandler(this.btnLocacoes_Leave);
            // 
            // panelnavegacao
            // 
            this.panelnavegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.panelnavegacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.panelnavegacao.Location = new System.Drawing.Point(0, 0);
            this.panelnavegacao.Name = "panelnavegacao";
            this.panelnavegacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelnavegacao.Size = new System.Drawing.Size(3, 229);
            this.panelnavegacao.TabIndex = 30;
            // 
            // MenuOperacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelnavegacao);
            this.Controls.Add(this.btnLocacoes);
            this.Controls.Add(this.btnPedidos);
            this.Name = "MenuOperacional";
            this.Size = new System.Drawing.Size(164, 229);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnLocacoes;
        private System.Windows.Forms.Panel panelnavegacao;
    }
}
