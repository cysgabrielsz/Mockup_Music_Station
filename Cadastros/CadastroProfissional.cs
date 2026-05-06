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
        public CadastroProfissional()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
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
    }
}
