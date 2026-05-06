using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Mockup_Music_Station
{
    public partial class MenuPessoas : UserControl
    {
        public Action<UserControl> SolicitarAbertura;
        public MenuPessoas()
        {
            InitializeComponent();
            panelnavegacao.Visible = false;
        }

       

        
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = BtnUsuarios.Height;
            panelnavegacao.Top = BtnUsuarios.Top;
            panelnavegacao.Left = BtnUsuarios.Left;
            BtnUsuarios.BackColor = Color.FromArgb(146, 117, 182);            

        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnProfissionais.Height;
            panelnavegacao.Top = btnProfissionais.Top;
            panelnavegacao.Left = btnProfissionais.Left;
            btnProfissionais.BackColor = Color.FromArgb(146, 117, 182);

            SolicitarAbertura?.Invoke(new TelaProfissionais());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnClientes.Height;
            panelnavegacao.Top = btnClientes.Top;
            panelnavegacao.Left = btnClientes.Left;
            btnClientes.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnAdministradores.Height;
            panelnavegacao.Top = btnAdministradores.Top;
            panelnavegacao.Left = btnAdministradores.Left;
            btnAdministradores.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnEmpresa.Height;
            panelnavegacao.Top = btnEmpresa.Top;
            panelnavegacao.Left = btnEmpresa.Left;
            btnEmpresa.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void BtnUsuarios_Leave(object sender, EventArgs e)
        {
            BtnUsuarios.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void btnProfissionais_Leave(object sender, EventArgs e)
        {
            btnProfissionais.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void btnClientes_Leave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void btnAdministradores_Leave(object sender, EventArgs e)
        {
            btnAdministradores.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void btnEmpresa_Leave(object sender, EventArgs e)
        {
            btnEmpresa.BackColor = Color.FromArgb(49, 30, 65);
        }
    }
}
