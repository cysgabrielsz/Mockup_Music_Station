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
    public partial class TelaProfissionais : UserControl
    {
        public TelaProfissionais()
        {
            InitializeComponent();
            ArredondarPanel(panelConteudo, 20);
            ArredondarPanel(panelUsuarios, 20);
            ArredondarPanel(panelDados, 20);
            AtualizarLista();
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btnLimpar.Enabled = false;
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
            lboProfissionais.Items.Clear();
            ProfissionaisTableAdapter ProfissionaisDados = new ProfissionaisTableAdapter();
            var dados = from linha in ProfissionaisDados.GetData()
                        select linha;

            foreach (ProfissionaisRow dado in dados) lboProfissionais.Items.Add(dado);
        }

        private void LimparElementos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
        }

        private void lboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLimpar.Enabled = true;  
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;

            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            txtTelefone.Enabled = false;

            btnAtualizar.Text = "habilitar edição";

            if (lboProfissionais.SelectedItem == null) return;

            ProfissionaisRow profissional = (ProfissionaisRow)lboProfissionais.SelectedItem;
            if (profissional == null) return;
            txtNome.Text = profissional.nome;
            txtEmail.Text = profissional.email;
            txtSenha.Text = profissional.senha;
            txtTelefone.Text = profissional.telefone;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAtualizar.Text == "habilitar edição")
            {
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                txtTelefone.Enabled = true;
                btnAtualizar.Text = "salvar alterações";
            }
            else
            {
                if (lboProfissionais.SelectedItem == null) return;
                ProfissionaisRow profissional = (ProfissionaisRow)lboProfissionais.SelectedItem;
                if (profissional == null) return;
                try
                {
                    string telefone = txtTelefone.Text;
                    string email = txtEmail.Text;
                    string senha = txtSenha.Text;
                    string nome = txtNome.Text;
                    ProfissionaisTableAdapter profissionalDados = new ProfissionaisTableAdapter();
                    profissionalDados.Update(profissional.usuario_id, nome, email, senha, telefone);
                    MessageBox.Show("Profissional atualizado com sucesso!");
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar profissional: " + ex.Message);
                }
            }
        }
    }
}
