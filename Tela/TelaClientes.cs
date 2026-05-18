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
    public partial class TelaClientes : UserControl
    {
        public TelaClientes()
        {
            InitializeComponent();
            AtualizarLista();

            ArredondarPanel(panelListBox, 20);
            ArredondarPanel(PanelConsulta, 20);
            ArredondarPanel(panelInformacoes, 20);
            ArredondarPanel(panelCliente, 20);
            ArredondarPanel(panelFundoListBox, 20);

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

        public void AtualizarLista()
        {
            lboCliente.Items.Clear();
            ClientesTableAdapter ProfissionaisDados = new ClientesTableAdapter();
            var dados = from linha in ProfissionaisDados.GetData()
                        select linha;

            foreach (ClientesRow dado in dados) lboCliente.Items.Add(dado);
        }

        private void LimparElementos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtPesquisa.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
        }

        private void lboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            btnLimpar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;

            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtNumero.Enabled = false;
            txtTelefone.Enabled = false;
            txtRua.Enabled = false;

            btnAtualizar.Text = "habilitar edição";

            if (lboCliente.SelectedItem == null) return;

            ClientesRow cliente = (ClientesRow)lboCliente.SelectedItem;
            if (cliente == null) return;
            txtNome.Text = cliente.nome;
            txtEmail.Text = cliente.email;
            txtTelefone.Text = cliente.telefone;
            txtRua.Text = cliente.rua;
            txtNumero.Text = cliente.numero.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAtualizar.Text == "habilitar edição")
            {
                btnDeletar.Enabled = true;
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtRua.Enabled = true;
                txtTelefone.Enabled = true;
                txtNumero.Enabled = true;
                btnAtualizar.Text = "salvar alterações";
            }
            else
            {
                if (lboCliente.SelectedItem == null) return;
                ClientesRow cliente = (ClientesRow)lboCliente.SelectedItem;
                if (cliente == null) return;
                try
                {
                    string telefone = txtTelefone.Text;
                    string email = txtEmail.Text;
                    string rua = txtRua.Text;
                    string numero = txtNumero.Text;
                    string nome = txtNome.Text;
                    ClientesTableAdapter clienteDados = new ClientesTableAdapter();
                    clienteDados.Update(cliente.id_usuario, nome, email, cliente.senha, rua, numero, telefone);
                    MessageBox.Show("Cliente atualizado com sucesso!");
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lboCliente.SelectedItem == null) return;

            ClientesRow cliente = lboCliente.SelectedItem as ClientesRow;
            if (cliente == null) return;

            try
            {
                ClientesTableAdapter clienteDados = new ClientesTableAdapter();
                clienteDados.Delete(cliente.id_usuario);
                MessageBox.Show("Cliente deletado com sucesso!");
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar cliente: " + ex.Message);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lboCliente.Items.Clear();
            if (txtPesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            string textoDigitado = txtPesquisa.Text;
            ClientesTableAdapter clientes = new ClientesTableAdapter();
            var dados = from linha in clientes.GetData()
                        where linha.nome.ToLower().Contains(textoDigitado.ToLower())
                        select linha;
            foreach (var cliente in dados) lboCliente.Items.Add(cliente);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastro = new CadastroCliente(AtualizarLista);
            cadastro.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboCliente.ClearSelected();
            LimparElementos();
            btnLimpar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
        }
    }
    
}
