using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mockup_Music_Station.MusicStationDataSetTableAdapters;
using static Mockup_Music_Station.MusicStationDataSet;

namespace Mockup_Music_Station
{
    public partial class FormLogin : Form
    {        
        public bool saida { get; set; }
        public int NivelAcesso { get; set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
        
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            VerificarUsuarioTableAdapter login = new VerificarUsuarioTableAdapter();

            var dados =
                login.GetData(usuario, senha);

            if (dados.Rows.Count > 0)
            {
                NivelAcesso =
                    Convert.ToInt32(dados[0].nivel_acesso);

                MessageBox.Show("Login realizado!");

                saida = true;
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha inválidos!");
            }
        }
    }

    
    
}
