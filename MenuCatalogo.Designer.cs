namespace Mockup_Music_Station
{
    partial class MenuCatalogo
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
            this.BtnInstrumentos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInstrumentos
            // 
            this.BtnInstrumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.BtnInstrumentos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.BtnInstrumentos.FlatAppearance.BorderSize = 3;
            this.BtnInstrumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstrumentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstrumentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.BtnInstrumentos.Location = new System.Drawing.Point(3, 12);
            this.BtnInstrumentos.Name = "BtnInstrumentos";
            this.BtnInstrumentos.Size = new System.Drawing.Size(129, 34);
            this.BtnInstrumentos.TabIndex = 18;
            this.BtnInstrumentos.Text = "Instrumentos";
            this.BtnInstrumentos.UseVisualStyleBackColor = false;
            // 
            // btnServicos
            // 
            this.btnServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnServicos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnServicos.FlatAppearance.BorderSize = 3;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnServicos.Location = new System.Drawing.Point(3, 92);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(129, 34);
            this.btnServicos.TabIndex = 19;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = false;
            // 
            // btnCargos
            // 
            this.btnCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnCargos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnCargos.FlatAppearance.BorderSize = 3;
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(180)))), ((int)(((byte)(34)))));
            this.btnCargos.Location = new System.Drawing.Point(3, 52);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(129, 34);
            this.btnCargos.TabIndex = 20;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.UseVisualStyleBackColor = false;
            // 
            // MenuCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCargos);
            this.Controls.Add(this.btnServicos);
            this.Controls.Add(this.BtnInstrumentos);
            this.Name = "MenuCatalogo";
            this.Size = new System.Drawing.Size(135, 219);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnInstrumentos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnCargos;
    }
}
