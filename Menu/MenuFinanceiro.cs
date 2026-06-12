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
    public partial class MenuFinanceiro : TelaBase
    {
        public MenuFinanceiro()
        {
            InitializeComponent();
            panelnavegacao.Visible = false;

        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnPagamentos.Height;
            panelnavegacao.Top = btnPagamentos.Top;
            panelnavegacao.Left = btnPagamentos.Left;
            btnPagamentos.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnTransações_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnTransações.Height;
            panelnavegacao.Top = btnTransações.Top;
            panelnavegacao.Left = btnTransações.Left;
            btnTransações.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnFormasPagamento_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnFormasPagamento.Height;
            panelnavegacao.Top = btnFormasPagamento.Top;
            panelnavegacao.Left = btnFormasPagamento.Left;
            btnFormasPagamento.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnPagamentos_Leave(object sender, EventArgs e)
        {
            btnPagamentos.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void btnTransações_Leave(object sender, EventArgs e)
        {
            btnTransações.BackColor = Color.FromArgb(49, 30, 65);
        }

        private void btnFormasPagamento_Leave(object sender, EventArgs e)
        {
            btnFormasPagamento.BackColor = Color.FromArgb(49, 30, 65);
        }
    }
}
