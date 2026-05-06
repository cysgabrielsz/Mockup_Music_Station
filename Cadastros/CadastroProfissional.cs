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
    public partial class CadastroProfissional : UserControl
    {
        private TelaProfissionais telaPrincipal;
        public CadastroProfissional(TelaProfissionais telaPrincipal)
        {
            InitializeComponent();
            this.telaPrincipal = telaPrincipal;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
        

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string telefone = txtTelefone.Text;

            try
            {
                ProfissionaisTableAdapter profissional = new ProfissionaisTableAdapter();
                profissional.Insert(nome, email, senha, telefone);

                MessageBox.Show("Profissional cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar profissional: " + ex.Message);
            }
        
        }


        private void FecharTela()
        {
            telaPrincipal.AtualizarLista();

            Panel painel = this.Parent as Panel;

            if (painel != null)
            {
                painel.Controls.Remove(this);

                painel.Visible = false;

                painel.SendToBack();
            }

            this.Dispose();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }
    }
}
