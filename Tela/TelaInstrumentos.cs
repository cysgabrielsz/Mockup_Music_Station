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
    public partial class TelaInstrumentos : TelaBase
    {
        public TelaInstrumentos()
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
            lboInstrumentos.Items.Clear();
            InstrumentosTableAdapter instrumentosDados = new InstrumentosTableAdapter();
            var dados = from linha in instrumentosDados.GetData()
                        select linha;

            foreach (InstrumentosRow dado in dados) lboInstrumentos.Items.Add(dado);
        }

        private void LimparElementos()
        {
            txtNomeFantasia.Text = "";
            txtInstrumento.Text = "";
            txtDescricao.Text = "";
            txtPesquisa.Text = "";
            txtPreco.Text = "";
            cbDisponivel.Checked = false;
        }

        private void lboInstrumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLimpar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;

            txtNomeFantasia.Enabled = false;
            txtInstrumento.Enabled = false;
            txtDescricao.Enabled = false;
            txtPreco.Enabled = false;
            cbDisponivel.Enabled = false;
            btnAtualizar.Text = "habilitar edição";

            if (lboInstrumentos.SelectedItem == null) return;

            InstrumentosRow instrumento = (InstrumentosRow)lboInstrumentos.SelectedItem;
            if (instrumento == null) return;
            txtNomeFantasia.Text = instrumento.nome_fantasia;
            txtInstrumento.Text = instrumento.nome;
            txtDescricao.Text = instrumento.descricao;
            txtPreco.Text = instrumento.preco_locacao.ToString();
            cbDisponivel.Checked = instrumento.disponivel;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAtualizar.Text == "habilitar edição")
            {
                btnDeletar.Enabled = true;                
                txtInstrumento.Enabled = true;
                txtDescricao.Enabled = true;
                txtPreco.Enabled = true;
                cbDisponivel.Enabled = true;
                btnAtualizar.Text = "salvar alterações";
            }
            else
            {
                if (lboInstrumentos.SelectedItem == null) return;
                InstrumentosRow instrumento = (InstrumentosRow)lboInstrumentos.SelectedItem;
                if (instrumento == null) return;
                try
                {                   
                    string instrumentoNome = txtInstrumento.Text;
                    string descricao = txtDescricao.Text;
                    decimal preco = decimal.Parse(txtPreco.Text);
                    bool disponivel = cbDisponivel.Checked;
                    InstrumentosTableAdapter instrumentosDados = new InstrumentosTableAdapter();
                    instrumentosDados.Update(instrumento.id_instrumento, instrumento.id_empresa, instrumentoNome, descricao, preco, disponivel);
                    MessageBox.Show("Instrumento atualizado com sucesso!");
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar instrumento: " + ex.Message);
                }
            }



        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lboInstrumentos.SelectedItem == null) return;

            InstrumentosRow instrumento = lboInstrumentos.SelectedItem as InstrumentosRow;
            if (instrumento == null) return;

            try
            {
                InstrumentosTableAdapter instrumentosDados = new InstrumentosTableAdapter();
                instrumentosDados.Delete(instrumento.id_instrumento);
                MessageBox.Show("Instrumento deletado com sucesso!");
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar instrumento: " + ex.Message);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            lboInstrumentos.Items.Clear();
            if (txtPesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            string textoDigitado = txtPesquisa.Text;
            InstrumentosTableAdapter instrumentos = new InstrumentosTableAdapter();
            var dados = from linha in instrumentos.GetData()
                        where linha.nome.ToLower().Contains(textoDigitado.ToLower())
                        select linha;
            foreach (var instrumento in dados) lboInstrumentos.Items.Add(instrumento);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroInstrumento cadastroInstrumento = new CadastroInstrumento(AtualizarLista);
            cadastroInstrumento.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboInstrumentos.ClearSelected();
            LimparElementos();
            btnLimpar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
        }
    }
}
