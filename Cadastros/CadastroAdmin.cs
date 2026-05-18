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
    public partial class CadastroAdmin : Form
    {
        Action funcaoAtualizarLista;
        public CadastroAdmin(Action funcao)
        {
            InitializeComponent();
            this.funcaoAtualizarLista = funcao;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtSenha.Text) ||
               string.IsNullOrWhiteSpace(txtAcesso.Text) ||
                string.IsNullOrWhiteSpace(txtObservacoes.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string acesso = txtAcesso.Text;
            string observacoes = txtObservacoes.Text; 

            try
            {
                AdministradoresTableAdapter admin = new AdministradoresTableAdapter();
                admin.Insert(nome, email, senha, acesso, observacoes);

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
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
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAcesso.Focus();
            }
        }

        private void txtAcesso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtObservacoes.Focus();
            }
        }

        private void txtObservacoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.Focus();
            }
        }

        #endregion
    }
}
