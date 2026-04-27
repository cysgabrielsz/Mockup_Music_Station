namespace Mockup_Music_Station
{
    partial class MenuMensagens
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
            this.BtnChats = new System.Windows.Forms.Button();
            this.btnNotificacoes = new System.Windows.Forms.Button();
            this.btnAvaliacoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnChats
            // 
            this.BtnChats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.BtnChats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.BtnChats.FlatAppearance.BorderSize = 3;
            this.BtnChats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.BtnChats.Location = new System.Drawing.Point(3, 17);
            this.BtnChats.Name = "BtnChats";
            this.BtnChats.Size = new System.Drawing.Size(129, 34);
            this.BtnChats.TabIndex = 10;
            this.BtnChats.Text = "Chats";
            this.BtnChats.UseVisualStyleBackColor = false;
            // 
            // btnNotificacoes
            // 
            this.btnNotificacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnNotificacoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnNotificacoes.FlatAppearance.BorderSize = 3;
            this.btnNotificacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnNotificacoes.Location = new System.Drawing.Point(3, 57);
            this.btnNotificacoes.Name = "btnNotificacoes";
            this.btnNotificacoes.Size = new System.Drawing.Size(129, 34);
            this.btnNotificacoes.TabIndex = 11;
            this.btnNotificacoes.Text = "Notificações";
            this.btnNotificacoes.UseVisualStyleBackColor = false;
            // 
            // btnAvaliacoes
            // 
            this.btnAvaliacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnAvaliacoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnAvaliacoes.FlatAppearance.BorderSize = 3;
            this.btnAvaliacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvaliacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnAvaliacoes.Location = new System.Drawing.Point(3, 97);
            this.btnAvaliacoes.Name = "btnAvaliacoes";
            this.btnAvaliacoes.Size = new System.Drawing.Size(129, 34);
            this.btnAvaliacoes.TabIndex = 12;
            this.btnAvaliacoes.Text = "Avaliação";
            this.btnAvaliacoes.UseVisualStyleBackColor = false;
            // 
            // MenuMensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAvaliacoes);
            this.Controls.Add(this.btnNotificacoes);
            this.Controls.Add(this.BtnChats);
            this.Name = "MenuMensagens";
            this.Size = new System.Drawing.Size(135, 219);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnChats;
        private System.Windows.Forms.Button btnNotificacoes;
        private System.Windows.Forms.Button btnAvaliacoes;
    }
}
