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
using System.Runtime.CompilerServices;
using Mockup_Music_Station.Cadastros;


namespace Mockup_Music_Station
{
    public partial class TelaProfissionais : UserControl
    {

        
        public TelaProfissionais()
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
            txtTelefone.Text = "";
        }

        private void lboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLimpar.Enabled = true;  
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;

            txtNome.Enabled = false;
            txtEmail.Enabled = false;            
            txtTelefone.Enabled = false;

            btnAtualizar.Text = "habilitar edição";

            if (lboProfissionais.SelectedItem == null) return;

            ProfissionaisRow profissional = (ProfissionaisRow)lboProfissionais.SelectedItem;
            if (profissional == null) return;
            txtNome.Text = profissional.nome;
            txtEmail.Text = profissional.email;            
            txtTelefone.Text = profissional.telefone;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAtualizar.Text == "habilitar edição")
            {
                btnDeletar.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;    
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
                    string nome = txtNome.Text;
                    ProfissionaisTableAdapter profissionalDados = new ProfissionaisTableAdapter();
                    profissionalDados.Update(profissional.id_usuario, nome, profissional.senha , email,telefone);
                    MessageBox.Show("Profissional atualizado com sucesso!");
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar profissional: " + ex.Message);
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lboProfissionais.SelectedItem == null) return;

            ProfissionaisRow profissional = lboProfissionais.SelectedItem as ProfissionaisRow;
            if (profissional == null) return;

            try
            {
                ProfissionaisTableAdapter profissionalDados = new ProfissionaisTableAdapter();
                profissionalDados.Delete(profissional.id_usuario);
                MessageBox.Show("Profissional deletado com sucesso!");
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar profissional: " + ex.Message);
            }
        }

        

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lboProfissionais.Items.Clear();
            if (txtPesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            string textoDigitado = txtPesquisa.Text;
            ProfissionaisTableAdapter profissionais = new ProfissionaisTableAdapter();
            var dados = from linha in profissionais.GetData()
                        where linha.nome.ToLower().Contains(textoDigitado.ToLower())
                        select linha;
            foreach (var profissional in dados) lboProfissionais.Items.Add(profissional);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboProfissionais.ClearSelected();
            LimparElementos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Teste tela = new Teste(AtualizarLista);       
            tela.ShowDialog();

        }
    }
}
