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

namespace Mockup_Music_Station
{
    public partial class MenuOperacional : UserControl
    {
        public MenuOperacional()
        {
            InitializeComponent();
            panelnavegacao.Visible = false;
        }



        private void btnPedidos_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnPedidos.Height;
            panelnavegacao.Top = btnPedidos.Top;
            panelnavegacao.Left = btnPedidos.Left;
            btnPedidos.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnLocacoes_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnLocacoes.Height;
            panelnavegacao.Top = btnLocacoes.Top;
            panelnavegacao.Left = btnLocacoes.Left;
            btnLocacoes.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnPedidos_Leave(object sender, EventArgs e)
        {
            btnPedidos.BackColor = Color.FromArgb(61, 30, 98);
        }

        private void btnLocacoes_Leave(object sender, EventArgs e)
        {
            btnLocacoes.BackColor = Color.FromArgb(61, 30, 98);
        }
    }
}
