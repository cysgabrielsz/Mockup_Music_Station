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
    public partial class TelaServicos : TelaBase
    {
        public TelaServicos()
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
            lboServicos.Items.Clear();
            ServicosTableAdapter servicosDados = new ServicosTableAdapter();
            var dados = from linha in servicosDados.GetData()
                        select linha;

            foreach (ServicosRow dado in dados) lboServicos.Items.Add(dado);
        }

        private void LimparElementos()
        {
            txtPreco.Text = "";
            txtDescricao.Text = "";
            txtNome.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboServicos.ClearSelected();
            LimparElementos();
            btnLimpar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lboServicos.SelectedItems == null) return;

            ServicosRow servicos = lboServicos.SelectedItem as ServicosRow;
            if (servicos == null) return;

            try
            {
                ServicosTableAdapter servicosDados = new ServicosTableAdapter();
                //servicosDados.Delete(servicos.id_servico);
                MessageBox.Show("Serviço excluído com sucesso");
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
                txtDescricao.Enabled = true;
                txtPreco.Enabled = true;
                btnAtualizar.Text = "salvar alterações";
            }
            else
            {
                if (lboServicos.SelectedItem == null) return;
                ServicosRow servicos = (ServicosRow)lboServicos.SelectedItem;
                if (servicos == null) return;
                try
                {
                    string nome = txtNome.Text;
                    string descricao = txtDescricao.Text;
                    Decimal preco = Convert.ToDecimal(txtPreco.Text);
                    ServicosTableAdapter servicosDados = new ServicosTableAdapter();
                    //servicosDados.Update(servicos.id_servico, nome, descricao, preco);
                    MessageBox.Show("Serviço atualizado com sucesso!");
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar Serviço: " + ex.Message);
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lboServicos.Items.Clear();
            if (txtPesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            string textoDigitado = txtPesquisa.Text;
            ServicosTableAdapter servicosDados = new ServicosTableAdapter();
            var dados = from linha in servicosDados.GetData()
                        where linha.nome.ToLower().Contains(textoDigitado.ToLower())
                        select linha;
            foreach (ServicosRow servico in dados) lboServicos.Items.Add(servico);
        }

        private void lboServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLimpar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;

            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtPreco.Enabled = false;

            btnAtualizar.Text = "habilitar edição";

            if (lboServicos.SelectedItem == null) return;
            ServicosRow servico = (ServicosRow)lboServicos.SelectedItem;
            if (servico == null) return;
            txtNome.Text = servico.nome;
            txtDescricao.Text = servico.descricao;
            txtPreco.Text = servico.preco.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroServicos cadastroServicos = new CadastroServicos(AtualizarLista);
            cadastroServicos.ShowDialog();
        }
    }
}
