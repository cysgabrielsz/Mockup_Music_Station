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

    public partial class CadastroServicos : Form
    {
        Action funcaoAtualizarLista;
        public CadastroServicos(Action funcao)
        {
            InitializeComponent();
            this.funcaoAtualizarLista = funcao;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
              string.IsNullOrWhiteSpace(txtDescricao.Text) ||
              string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            decimal preco = Convert.ToDecimal(txtPreco.Text);

            try
            {
                ServicosTableAdapter servicos = new ServicosTableAdapter();
                servicos.Insert(nome, descricao, preco);

                MessageBox.Show("Serviço cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar serviço: " + ex.Message);
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
                btnCadastrar.Focus();
            }
        }
        #endregion
    }
}
