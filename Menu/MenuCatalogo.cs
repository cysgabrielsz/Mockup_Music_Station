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
    public partial class MenuCatalogo : UserControl
    {
        public MenuCatalogo()
        {
            InitializeComponent();   
            panelnavegacao.Visible = false;
        }

        private void BtnInstrumentos_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = BtnInstrumentos.Height;
            panelnavegacao.Top = BtnInstrumentos.Top;
            panelnavegacao.Left = BtnInstrumentos.Left;
            BtnInstrumentos.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnServicos.Height;
            panelnavegacao.Top = btnServicos.Top;
            panelnavegacao.Left = btnServicos.Left;
            btnServicos.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            panelnavegacao.Visible = true;
            panelnavegacao.Height = btnCargos.Height;
            panelnavegacao.Top = btnCargos.Top;
            panelnavegacao.Left = btnCargos.Left;
            btnCargos.BackColor = Color.FromArgb(146, 117, 182);
        }

        private void BtnInstrumentos_Leave(object sender, EventArgs e)
        {
            BtnInstrumentos.BackColor = Color.FromArgb(61,30, 98);
        }

        private void btnServicos_Leave(object sender, EventArgs e)
        {
            btnServicos.BackColor = Color.FromArgb(61, 30, 98);
        }

        private void btnCargos_Leave(object sender, EventArgs e)
        {
            btnCargos.BackColor = Color.FromArgb(61, 30, 98);
        }
    }
}
