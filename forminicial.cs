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
using System.Runtime.InteropServices;

namespace Mockup_Music_Station
{
    public partial class forminicial : Form
    {
        
        public forminicial()
        {
            InitializeComponent();                   
            panelnavegacao.Visible = false;           
        }



        //metodo para abrir as telas dentro do panel
        private void AbrirTela(UserControl tela)
        {

            foreach (Control controle in panelMenu.Controls)
            {
                controle.Dispose();
            }
            panelMenu.Controls.Clear();
            tela.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(tela);
        }

        #region//configurando os botões do menu principal      
        private void btnpPessoas_Click(object sender, EventArgs e)
        {
            //posiciona o panel na base do botao pessoas
            panelMenuTopo.Top = btnPessoas.Bottom - panelMenuTopo.Height;
            //alinha o panela esquerda do botao
            panelMenuTopo.Left = btnPessoas.Left;
            //define a largura igual a do botao 
            panelMenuTopo.Width = btnPessoas.Width;
            //panel visivel na frente do botao
            panelMenuTopo.BringToFront();

            //esconde o panel de navegacao
            panelnavegacao.Visible = false;
            //abre a tela de pessoas
            MenuPessoas menuPessoas = new MenuPessoas();
            AbrirTela(menuPessoas);
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnCatalogo.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnCatalogo.Left;
            panelMenuTopo.Width = btnCatalogo.Width;

            panelMenuTopo.BringToFront();

            panelnavegacao.Visible = false;
            MenuCatalogo menuCatalogo = new MenuCatalogo();
            AbrirTela(menuCatalogo);
        }

        private void btnOperacional_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnOperacional.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnOperacional.Left;
            panelMenuTopo.Width = btnOperacional.Width;

            panelMenuTopo.BringToFront();

            panelnavegacao.Visible = false;
            MenuOperacional menuOperacional = new MenuOperacional();
            AbrirTela(menuOperacional);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnFinanceiro.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnFinanceiro.Left;
            panelMenuTopo.Width = btnFinanceiro.Width;

            panelMenuTopo.BringToFront();

            panelnavegacao.Visible = false;
            MenuFinanceiro menuFinanceiro = new MenuFinanceiro();
            AbrirTela(menuFinanceiro);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        { 
            panelMenuTopo.Top = BtnInicio.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = BtnInicio.Left;
            panelMenuTopo.Width = BtnInicio.Width;

            panelMenuTopo.BringToFront();

            panelnavegacao.Visible = false;
            MenuInicio menuInicio = new MenuInicio();
            AbrirTela(menuInicio);
        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnMensagens.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnMensagens.Left;
            panelMenuTopo.Width = btnMensagens.Width;

            panelMenuTopo.BringToFront();

            panelnavegacao.Visible = false;
            MenuMensagens menuMensagens = new MenuMensagens();
            AbrirTela(menuMensagens);
        }
        #endregion

        #region//configurando os botões do menu
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnDashboard.Height;
            panelnavegacao.Top = btnDashboard.Top;
            panelnavegacao.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(146, 117, 182);
        }
        
        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            // Mostra o painel de navegação
            panelnavegacao.Visible = true;
            // Define a altura igual ao botão Dashboard
            panelnavegacao.Height = btnConfiguracoes.Height;
            // Alinha o topo do painel com o topo do botão
            panelnavegacao.Top = btnConfiguracoes.Top;
            // Alinha à esquerda do botão
            panelnavegacao.Left = btnConfiguracoes.Left;
            // Muda a cor do botão
            btnConfiguracoes.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(61, 30, 98);
        }

        private void btnConfiguracoes_Leave(object sender, EventArgs e)
        {
            btnConfiguracoes.BackColor = Color.FromArgb(61, 30, 98);
        }
        #endregion

        private void menuOperacional1_Load(object sender, EventArgs e)
        {

        }
    }
}
