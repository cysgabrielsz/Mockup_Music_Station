using Mockup_Music_Station.MusicStationDataSetTableAdapters;
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
using static Mockup_Music_Station.MusicStationDataSet;

namespace Mockup_Music_Station
{
    public partial class TelaAdminstradores : TelaBase  // <-- trocado
    {
        public TelaAdminstradores()
        {
            InitializeComponent();
            ArredondarPanel(panelListBox, 20);
            ArredondarPanel(PanelConsulta, 20);
            ArredondarPanel(panelInformacoes, 20);
            ArredondarPanel(panelCliente, 20);
            ArredondarPanel(panelFundoListBox, 20);

            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btnLimpar.Enabled = false;
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

        public void AtualizarLista()
        {
            lboAdministradores.Items.Clear();
            AdministradoresTableAdapter AdminDados = new AdministradoresTableAdapter();
            var dados = from linha in AdminDados.GetData()
                        select linha;
            foreach (AdministradoresRow dado in dados) lboAdministradores.Items.Add(dado);
        }

        private void LimparElementos()
        {
            cbAcesso.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtObservacoes.Text = "";
            txtPesquisa.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboAdministradores.ClearSelected();
            LimparElementos();
            btnLimpar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lboAdministradores.SelectedItems == null) return;
            AdministradoresRow administradores = lboAdministradores.SelectedItem as AdministradoresRow;
            if (administradores == null) return;
            try
            {
                AdministradoresTableAdapter admin = new AdministradoresTableAdapter();
                admin.Delete(administradores.id_usuario);
                MessageBox.Show("Administrador excluído com sucesso");
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao excluir o admin" + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAtualizar.Text == "habilitar edição")
            {
                btnDeletar.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                cbAcesso.Enabled = true;
                txtObservacoes.Enabled = true;
                btnAtualizar.Text = "salvar alterações";
            }
            else
            {
                if (lboAdministradores.SelectedItem == null) return;
                AdministradoresRow admin = (AdministradoresRow)lboAdministradores.SelectedItem;
                if (admin == null) return;
                try
                {
                    string email = txtEmail.Text;
                    string nome = txtNome.Text;
                    string acesso = cbAcesso.Text;
                    string obeservacoes = txtObservacoes.Text;
                    AdministradoresTableAdapter adminDados = new AdministradoresTableAdapter();
                    adminDados.Update(admin.id_usuario, nome, email, admin.senha, acesso, obeservacoes);
                    MessageBox.Show("Administrador atualizado com sucesso!");
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar Administrador: " + ex.Message);
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lboAdministradores.Items.Clear();
            if (txtPesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }
            string textoDigitado = txtPesquisa.Text;
            AdministradoresTableAdapter admin = new AdministradoresTableAdapter();
            var dados = from linha in admin.GetData()
                        where linha.nome.ToLower().Contains(textoDigitado.ToLower())
                        select linha;
            foreach (AdministradoresRow administrador in dados) lboAdministradores.Items.Add(administrador);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroAdmin admin = new CadastroAdmin(AtualizarLista);
            admin.ShowDialog();
        }

        private void lboAdministradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLimpar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            cbAcesso.Enabled = false;
            txtObservacoes.Enabled = false;
            btnAtualizar.Text = "habilitar edição";
            if (lboAdministradores.SelectedItem == null) return;
            AdministradoresRow admin = (AdministradoresRow)lboAdministradores.SelectedItem;
            if (admin == null) return;
            txtNome.Text = admin.nome;
            txtEmail.Text = admin.email;
            txtObservacoes.Text = admin.observacoes;
        }

        private void TelaAdminstradores_Load(object sender, EventArgs e)
        {
            MessageBox.Show(NivelAcesso.ToString());
            if (NivelAcesso == 1)
            {
                btnCadastrar.Visible = false;
                btnAtualizar.Visible = false;
                btnDeletar.Visible = false;
            }
        }
    }
}