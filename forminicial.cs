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
using System.Runtime.InteropServices;

namespace Mockup_Music_Station
{
    public partial class forminicial : Form
    {
        public int NivelAcesso { get; set; }
        public forminicial()
        {
            InitializeComponent();
            panelnavegacao.Visible = false;
            panelDesign.Visible = false;
        }

        private void AbrirTela(TelaBase tela)
        {
            foreach (Control controle in panelMenu.Controls)
            {
                controle.Dispose();
            }
            panelMenu.Controls.Clear();
            tela.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(tela);
        }

        public void ExibirUserControl(TelaBase novoControle, Panel painelDestino)
        {
            if (painelDestino.Controls.Count > 0)
            {
                for (int i = painelDestino.Controls.Count - 1; i >= 0; i--)
                {
                    Control controleAntigo = painelDestino.Controls[i];
                    painelDestino.Controls.Remove(controleAntigo);
                    controleAntigo.Dispose();
                }
            }
            novoControle.Dock = DockStyle.Fill;
            painelDestino.Controls.Add(novoControle);
        }

        #region //configurando os botões do menu principal
        private void btnpPessoas_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnPessoas.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnPessoas.Left;
            panelMenuTopo.Width = btnPessoas.Width;
            panelMenuTopo.BringToFront();
            panelDesign.Visible = false;

            MenuPessoas menuPessoas = new MenuPessoas();
            menuPessoas.NivelAcesso = this.NivelAcesso;
            menuPessoas.SolicitarAbertura = (proximaTela) =>
            {
                proximaTela.NivelAcesso = this.NivelAcesso;
                ExibirUserControl(proximaTela, panelConteudo);
            };
            AbrirTela(menuPessoas);
            ExibirUserControl(menuPessoas, panelMenu);
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnCatalogo.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnCatalogo.Left;
            panelMenuTopo.Width = btnCatalogo.Width;
            panelMenuTopo.BringToFront();
            panelDesign.Visible = false;

            MenuCatalogo menuCatalogo = new MenuCatalogo();
            menuCatalogo.NivelAcesso = this.NivelAcesso;
            menuCatalogo.SolicitarAbertura = (proximaTela) =>
            {
                proximaTela.NivelAcesso = this.NivelAcesso;
                ExibirUserControl(proximaTela, panelConteudo);
            };
            AbrirTela(menuCatalogo);
            ExibirUserControl(menuCatalogo, panelMenu);
        }

        private void btnOperacional_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnOperacional.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnOperacional.Left;
            panelMenuTopo.Width = btnOperacional.Width;
            panelMenuTopo.BringToFront();
            panelDesign.Visible = false;

            MenuOperacional menuOperacional = new MenuOperacional();
            menuOperacional.NivelAcesso = this.NivelAcesso;
            menuOperacional.SolicitarAbertura = (proximaTela) =>
            {
                proximaTela.NivelAcesso = this.NivelAcesso;
                ExibirUserControl(proximaTela, panelConteudo);
            };
            AbrirTela(menuOperacional);
            ExibirUserControl(menuOperacional, panelMenu);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnFinanceiro.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnFinanceiro.Left;
            panelMenuTopo.Width = btnFinanceiro.Width;
            panelMenuTopo.BringToFront();
            panelDesign.Visible = false;

            MenuFinanceiro menuFinanceiro = new MenuFinanceiro();
            menuFinanceiro.NivelAcesso = this.NivelAcesso;
            menuFinanceiro.SolicitarAbertura = (proximaTela) =>
            {
                proximaTela.NivelAcesso = this.NivelAcesso;
                ExibirUserControl(proximaTela, panelConteudo);
            };
            AbrirTela(menuFinanceiro);
            ExibirUserControl(menuFinanceiro, panelMenu);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = BtnInicio.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = BtnInicio.Left;
            panelMenuTopo.Width = BtnInicio.Width;
            panelMenuTopo.BringToFront();
            panelDesign.Visible = false;

            MenuInicio menuInicio = new MenuInicio();
            AbrirTela(menuInicio);
        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnMensagens.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnMensagens.Left;
            panelMenuTopo.Width = btnMensagens.Width;
            panelMenuTopo.BringToFront();
            panelDesign.Visible = false;

            MenuMensagens menuMensagens = new MenuMensagens();
            menuMensagens.NivelAcesso = this.NivelAcesso;
            menuMensagens.SolicitarAbertura = (proximaTela) =>
            {
                proximaTela.NivelAcesso = this.NivelAcesso;
                ExibirUserControl(proximaTela, panelConteudo);
            };
            AbrirTela(menuMensagens);
            ExibirUserControl(menuMensagens, panelMenu);
        }
        #endregion

        #region //configurando os botões do menu
        private void btnconfig_Click(object sender, EventArgs e)
        {
            panelDesign.Visible = true;
            panelDesign.Height = btnconfig.Height;
            panelDesign.Top = btnconfig.Top;
            panelDesign.Left = btnconfig.Left;
            btnconfig.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            panelDesign.Visible = true;
            panelDesign.Height = btnDashboard.Height;
            panelDesign.Top = btnDashboard.Top;
            panelDesign.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnconfig_Leave(object sender, EventArgs e)
        {
            btnconfig.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(49, 30, 65);
        }
        #endregion

        private void forminicial_Load(object sender, EventArgs e)
        {
            if (NivelAcesso == 1)
            {
                btnDashboard.Visible = false;
            }
            MessageBox.Show("Form Inicial: " + NivelAcesso);
        }
    }
}