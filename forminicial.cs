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
    public partial class forminicial : Form
    {
        public forminicial()
        {
            InitializeComponent(); 
                ArredondarBotao(btnPessoas, 8);
                ArredondarBotao(btnCatalogo, 8);
                ArredondarBotao(btnFinanceiro, 8);
                ArredondarBotao(btnMensagens, 8);
                ArredondarBotao(btnOperacional, 8);
                ArredondarBotao(BtnInicio, 8);

        }

        private void ArredondarBotao(Button btn, int raio)
        {
            GraphicsPath path = new GraphicsPath();            
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(btn.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(btn.Width - raio, btn.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, btn.Height - raio, raio, raio, 90, 90);

            path.CloseFigure();

            btn.Region = new Region(path);
        }


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

        private void btnpPessoas_Click(object sender, EventArgs e)
        {
            MenuPessoas menuPessoas = new MenuPessoas();
            AbrirTela(menuPessoas);
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            MenuCatalogo menuCatalogo = new MenuCatalogo();
            AbrirTela(menuCatalogo);
        }

        private void btnOperacional_Click(object sender, EventArgs e)
        {
            MenuOperacional menuOperacional = new MenuOperacional();
            AbrirTela(menuOperacional);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            MenuFinanceiro menuFinanceiro = new MenuFinanceiro();
            AbrirTela(menuFinanceiro);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            AbrirTela(menuInicio);
        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            MenuMensagens menuMensagens = new MenuMensagens();
            AbrirTela(menuMensagens);
        }
    }
}
