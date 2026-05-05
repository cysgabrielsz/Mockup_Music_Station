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
using Mockup_Music_Station.MusicStationDataSetTableAdapters;
using static Mockup_Music_Station.MusicStationDataSet;

namespace Mockup_Music_Station
{
    public partial class TelaUsuario : UserControl
    {
        public TelaUsuario()
        {
            InitializeComponent();
            ArredondarPanel(panelConteudo, 20);
            ArredondarPanel(panelUsuarios, 20);
            ArredondarPanel(panelDados, 20);
            AtualizarLista();
        }

        public void ArredondarPanel(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void AtualizarLista()
        {
            lboUsuarios.Items.Clear();
            UsuariosTableAdapter UsuariosDados = new UsuariosTableAdapter();
            var dados = from linha in UsuariosDados.GetData()
                        select linha;

            foreach (UsuariosRow dado in dados) lboUsuarios.Items.Add(dado);
        }

        private void LimparElementos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
        }

        private void lboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboUsuarios.SelectedItem == null) return;

            UsuariosRow usuario = (UsuariosRow)lboUsuarios.SelectedItem;
            if (usuario == null) return;
            txtNome.Text = usuario.nome;
            txtEmail.Text = usuario.email;
            txtSenha.Text = usuario.senha;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            try
            {               
                UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
                usuarios.Insert(nome, email, senha, DateTime.Now);
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de digitação", "Erro");

            }
        }
    }
}
