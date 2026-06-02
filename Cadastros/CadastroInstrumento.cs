using Mockup_Music_Station.MusicStationDataSetTableAdapters;
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
    public partial class CadastroInstrumento : Form
    {
        Action funcaoAtualizarLista;
        public CadastroInstrumento(Action funcao)
        {
            InitializeComponent();
            ObterEmpresasComboTableAdapter empresas = new ObterEmpresasComboTableAdapter();

            cbEmpresas.DataSource =
                empresas.GetData();

            cbEmpresas.DisplayMember =
                "nome_fantasia";

            cbEmpresas.ValueMember =
                "id_empresa";


            this.funcaoAtualizarLista = funcao;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
               string.IsNullOrWhiteSpace(txtDescricao.Text) ||
               string.IsNullOrWhiteSpace(txtPreco.Text) ||
               string.IsNullOrWhiteSpace(cbDisponivel.Text) ||
                string.IsNullOrWhiteSpace(cbEmpresas.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            decimal preco;
            if (!decimal.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Por favor, insira um preço válido.");
                return;
            }
            bool disponivel = cbDisponivel.Checked;
            int empresaID =
                Convert.ToInt32(cbEmpresas.SelectedValue);

            try
            {
                InstrumentosTableAdapter admin = new InstrumentosTableAdapter();
                admin.Insert(empresaID, nome, descricao, preco, disponivel);

                MessageBox.Show("Instrumento cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar instrumento: " + ex.Message);
            }
            funcaoAtualizarLista?.Invoke();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();            
        }

        #region
        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescricao.Focus();
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPreco.Focus();
            }
        }

        private void txtPreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbDisponivel.Focus();
            }
        }

        private void cbDisponivel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.Focus();
            }
        }

        #endregion
    }
}
