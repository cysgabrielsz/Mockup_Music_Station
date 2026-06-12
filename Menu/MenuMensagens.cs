using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup_Music_Station
{
    public partial class MenuMensagens : TelaBase
    {
        public MenuMensagens()
        {
            InitializeComponent();
            panelnavegacao.Visible = false;
        }
        
        
        
        
        
        private void BtnChats_Leave(object sender, EventArgs e)
        {
            BtnChats.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void btnNotificacoes_Leave(object sender, EventArgs e)
        {
            btnNotificacoes.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void btnAvaliacoes_Leave(object sender, EventArgs e)
        {
            btnAvaliacoes.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void BtnChats_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = BtnChats.Height;
            panelnavegacao.Top = BtnChats.Top;
            panelnavegacao.Left = BtnChats.Left;
            BtnChats.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnNotificacoes.Height;
            panelnavegacao.Top = btnNotificacoes.Top;
            panelnavegacao.Left = btnNotificacoes.Left;
            btnNotificacoes.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnAvaliacoes_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnAvaliacoes.Height;
            panelnavegacao.Top = btnAvaliacoes.Top;
            panelnavegacao.Left = btnAvaliacoes.Left;
            btnAvaliacoes.BackColor = Color.FromArgb(146, 117, 182);
        }
    }
}
