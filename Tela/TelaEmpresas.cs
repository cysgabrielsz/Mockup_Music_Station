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
    public partial class TelaEmpresas : UserControl
    {
        public TelaEmpresas()
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
            lboEmpresas.Items.Clear();
            EmpresasTableAdapter empresasDados = new EmpresasTableAdapter();
            var dados = from linha in empresasDados.GetData()
                        select linha;

            foreach (EmpresasRow dado in dados) lboEmpresas.Items.Add(dado);
        }

        private void LimparElementos()
        {
            txtCNPJ.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtNomeFantasia.Text = "";
            txtDescricao.Text = "";
            txtRazaoSocial.Text = "";
            txtPesquisa.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboEmpresas.ClearSelected();
            LimparElementos();
            btnLimpar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lboEmpresas.SelectedItems == null) return;

            EmpresasRow empresa = lboEmpresas.SelectedItem as EmpresasRow;
            if (empresa == null) return;

            try
            {
                EmpresasTableAdapter empresas = new EmpresasTableAdapter();
                empresas.Delete(empresa.id_usuario);
                MessageBox.Show("Empresa excluída com sucesso");
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao excluir a empresa" + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAtualizar.Text == "habilitar edição")
            {
                btnDeletar.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtNomeFantasia.Enabled = true;
                txtTelefone.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtCNPJ.Enabled = true;
                txtDescricao.Enabled = true;
                btnAtualizar.Text = "salvar alterações";
            }
            else
            {
                if (lboEmpresas.SelectedItem == null) return;
                EmpresasRow empresa = (EmpresasRow)lboEmpresas.SelectedItem;
                if (empresa == null) return;
                try
                {
                    string email = txtEmail.Text;
                    string nome = txtNome.Text;
                    string nomeFantasia = txtNomeFantasia.Text;
                    string telefone = txtTelefone.Text;
                    string razaoSocial = txtRazaoSocial.Text;
                    string cnpj = txtCNPJ.Text;
                    string descricao = txtDescricao.Text;
                    EmpresasTableAdapter empresasDados = new EmpresasTableAdapter();
                    empresasDados.Update(empresa.id_usuario, nome,email, empresa.senha , nomeFantasia, razaoSocial, cnpj, telefone, descricao);
                    MessageBox.Show("Empresa atualizada com sucesso!");
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar Empresa: " + ex.Message);
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lboEmpresas.Items.Clear();
            if (txtPesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            string textoDigitado = txtPesquisa.Text;
            EmpresasTableAdapter empresas = new EmpresasTableAdapter();
            var dados = from linha in empresas.GetData()
                        where linha.nome.ToLower().Contains(textoDigitado.ToLower())
                        select linha;
            foreach (EmpresasRow empresa in dados) lboEmpresas.Items.Add(empresa);
        }

        private void lboEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLimpar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;

            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtCNPJ.Enabled = false;
            txtTelefone.Enabled = false;
            txtDescricao.Enabled = false;

            btnAtualizar.Text = "habilitar edição";

            if (lboEmpresas.SelectedItem == null) return;

            EmpresasRow empresa = (EmpresasRow)lboEmpresas.SelectedItem;
            if (empresa == null) return;
            txtNome.Text = empresa.nome;
            txtEmail.Text = empresa.email;
            txtNomeFantasia.Text = empresa.nome_fantasia;
            txtRazaoSocial.Text = empresa.razao_social;
            txtCNPJ.Text = empresa.cnpj;
            txtTelefone.Text = empresa.telefone;
            txtDescricao.Text = empresa.descricao;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroEmpresas empresas = new CadastroEmpresas(AtualizarLista);
            empresas.ShowDialog();
        }
    }
}
