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
        public int NivelAcesso { get; set; }
        public forminicial()
        {
            InitializeComponent();                   
            panelnavegacao.Visible = false;   
            panelDesign.Visible = false;

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


        public void ExibirUserControl(UserControl novoControle, Panel painelDestino)
        {
            // 1. Limpa o painel e libera a memória dos controles antigos
            if (painelDestino.Controls.Count > 0)
            {
                for (int i = painelDestino.Controls.Count - 1; i >= 0; i--)
                {
                    Control controleAntigo = painelDestino.Controls[i];

                    // Remove do painel
                    painelDestino.Controls.Remove(controleAntigo);

                    // Libera recursos e handles do Windows
                    controleAntigo.Dispose();
                }
            }

            // 2. Configura o novo controle para ocupar todo o espaço do painel
            novoControle.Dock = DockStyle.Fill;

            // 3. Adiciona o novo controle ao painel
            painelDestino.Controls.Add(novoControle);
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
            panelDesign.Visible = false;
            //abre a tela de pessoas
            MenuPessoas menuPessoas = new MenuPessoas();
            AbrirTela(menuPessoas);

            //abrindo a tela no painel principal
            MenuPessoas menuPessoas1 = new MenuPessoas();
                menuPessoas1.SolicitarAbertura = (proximatela) =>
                { 
                    ExibirUserControl(proximatela, panelConteudo);
                };
            ExibirUserControl(menuPessoas1, panelMenu);
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnCatalogo.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnCatalogo.Left;
            panelMenuTopo.Width = btnCatalogo.Width;

            panelMenuTopo.BringToFront();

            panelDesign.Visible = false;
            MenuCatalogo menuCatalogo = new MenuCatalogo();
            AbrirTela(menuCatalogo);

            //abrindo a tela no painel principal
            MenuCatalogo menuCatalogo1 = new MenuCatalogo();
            menuCatalogo1.SolicitarAbertura = (proximatela) =>
            {
                ExibirUserControl(proximatela, panelConteudo);
            };
            ExibirUserControl(menuCatalogo1, panelMenu);
        }

        private void btnOperacional_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnOperacional.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnOperacional.Left;
            panelMenuTopo.Width = btnOperacional.Width;

            panelMenuTopo.BringToFront();

            panelDesign.Visible = false;
            MenuOperacional menuOperacional = new MenuOperacional();
            AbrirTela(menuOperacional);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            panelMenuTopo.Top = btnFinanceiro.Bottom - panelMenuTopo.Height;
            panelMenuTopo.Left = btnFinanceiro.Left;
            panelMenuTopo.Width = btnFinanceiro.Width;

            panelMenuTopo.BringToFront();

            panelDesign.Visible = false;
            MenuFinanceiro menuFinanceiro = new MenuFinanceiro();
            AbrirTela(menuFinanceiro);
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
            AbrirTela(menuMensagens);
        }
        #endregion

        #region//configurando os botões do menu


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
            // Mostra o painel de navegação
            panelDesign.Visible = true;
            // Define a altura igual ao botão Dashboard
            panelDesign.Height = btnDashboard.Height;
            // Alinha o topo do painel com o topo do botão
            panelDesign.Top = btnDashboard.Top;
            // Alinha à esquerda do botão
            panelDesign.Left = btnDashboard.Left;
            // Muda a cor do botão
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
