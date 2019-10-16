using BLL;
using DAL;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Compra : Form
    {
        public int idCompra = 0;
        public string Status = "";

        public frm_Compra()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadCompra cadMovimentacaoCompra = new frm_CadCompra();
            cadMovimentacaoCompra.ShowDialog();
        }

        //BOTAO EXCLUIR
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Model_Compra modeloCompra = new Model_Compra();
                        this.idCompra = Convert.ToInt32(dgvCompra.CurrentRow.Cells[0].Value);
                        //EXCLUIR ITENS DA COMPRA 
                        DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                        BLL_ItensCompra bllItens = new BLL_ItensCompra(con);
                        //excluir Compra
                        BLL_Compra bllCompra = new BLL_Compra(con);
                        this.Status = Convert.ToString(dgvCompra.CurrentRow.Cells[5].Value);

                        //SE O STATUS ESTIVER COMO PAGA NAO DEIXAR EXCLUIR
                        if (Status == "PAGO")
                        {
                            MessageBox.Show("A Compra está com status de PAGA, não é possível excluir!");
                        }
                        else
                        {
                            bllItens.ExcluirTodosItens(Convert.ToInt32(txtId.Text));

                            bllCompra.Excluir(Convert.ToInt32(txtId.Text));

                            MessageBox.Show("Compra excluida com sucesso!");
                            BtnPesquisar_Click(sender, e); //RECARREGA A TELA COM O ITEM EXCLUIDO
                            txtId.Text = "";

                            //EXECUTAR A TRIGGER DO BD PARA ARRUMAR ESTOQUE
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Compra, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA DATAGRID
        private void DgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvCompra.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //EVENTO LOAD
        private void Frm_MovimentacaoCompra_Load(object sender, EventArgs e)
        {
            RbGeral_CheckedChanged(sender, e);
        }

        private void RbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //OCUTAR PAINEIS
            gbData.Visible = false;
            gbFornecedor.Visible = false;
            gbCodigo.Visible = false;
            btnPesquisarGeral.Visible = false;

            //LIMPAR O GRID
            dgvCompra.DataSource = null;

            if (rbGeral.Checked == true)
            {
                btnPesquisarGeral.Visible = true;
            }
            if ((rbData.Checked == true))
            {
                gbData.Visible = true;
            }

            if ((RbFornecedor.Checked == true))
            {
                gbFornecedor.Visible = true;
            }

            if ((rbCodigo.Checked == true))
            {
                gbCodigo.Visible = true;
            }
        }

        //BOTAO PESQUISAR geral
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Compra bll = new BLL_Compra(con);
            dgvCompra.DataSource = bll.LocalizarGeral();
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //BOTAO PESQUISAR IDCOMPRA
        private void BtnPesquisarCod_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Compra bll = new BLL_Compra(con);
            dgvCompra.DataSource = bll.localizarIdCompra(Convert.ToInt32(txtIdCompraPes.Text.Length));
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //BOTAO PESQUISAR FORNECEDOR
        private void BtnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Compra bll = new BLL_Compra(con);
            dgvCompra.DataSource = bll.LocalizarNome(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //BOTAO PESQUISAR Data
        private void BtnPesquisaData_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Compra bll = new BLL_Compra(con);
            dgvCompra.DataSource = bll.LocalizarData(dtInicial.Value, dtFinal.Value);
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //FORMATA O DATA GRID
        private void FormatarDGV()
        {
            dgvCompra.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvCompra.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvCompra.Columns[1].HeaderText = "Data da Compra";
            dgvCompra.Columns[1].Width = 120;
            dgvCompra.Columns[2].HeaderText = "Nota Fiscal";
            dgvCompra.Columns[2].Width = 85;
            dgvCompra.Columns[3].HeaderText = "N° Parcelas";
            dgvCompra.Columns[3].Width = 90;
            dgvCompra.Columns[4].HeaderText = "Total";
            dgvCompra.Columns[4].Width = 80;
            dgvCompra.Columns[5].HeaderText = "Status";
            dgvCompra.Columns[5].Width = 60;
            dgvCompra.Columns[6].Visible = false;
            dgvCompra.Columns[7].Visible = false;
            dgvCompra.Columns[8].HeaderText = "Fornecedor";
            dgvCompra.Columns[8].Width = 140;
        }

        //BOTAO VIZUALIZAR
        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                //CRIAR O FORM VIZUALIZAR ITEM
                frm_VisualizarItensCompra visualizarItensCompra = new frm_VisualizarItensCompra();

                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_ItensCompra bllItens = new BLL_ItensCompra(con);

                visualizarItensCompra.dgvItensCompra.DataSource = bllItens.Localizar(Convert.ToInt32(dgvCompra.CurrentRow.Cells[0].Value));
                visualizarItensCompra.ShowDialog();
            }
        }

        //BOTAO ALTERA
        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            this.Status = Convert.ToString(dgvCompra.CurrentRow.Cells[5].Value);

            //SE O STATUS ESTIVER COMO PAGA NAO DEIXAR alterar
            if (Status == "PAGO")
            {
                MessageBox.Show("A Compra está com status de PAGO, não é possível Alterar!");
            }
            else
            {
                if (dgvCompra.SelectedRows.Count > 0)
                {
                    //pega o id da data grid
                    this.idCompra = (Convert.ToInt32(dgvCompra.CurrentRow.Cells[0].Value));

                    //chamr modelo bll e dal compra
                    DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                    BLL_Compra bll = new BLL_Compra(con);
                    Model_Compra modelo = bll.CarregaModeloCompra(idCompra);

                    //CHAMAR O FORM CAD COMPRA
                    frm_CadCompra cadMovimentacaoCompra = new frm_CadCompra();
                    cadMovimentacaoCompra.btnSalvar.Enabled = false;
                    cadMovimentacaoCompra.alterabotao = "1";

                    cadMovimentacaoCompra.txtId.Text = modelo.IdCompra.ToString();
                    cadMovimentacaoCompra.txtNfiscal.Text = modelo.NFiscal.ToString();
                    cadMovimentacaoCompra.dtCompra.Value = modelo.DataCompra;
                    cadMovimentacaoCompra.cbFornecedor.SelectedValue = modelo.IdFornecedor;
                    cadMovimentacaoCompra.txtNParcelas.Value = modelo.NParcelas;
                    cadMovimentacaoCompra.cbFormaPagto.SelectedValue = modelo.IdTipoPagamento;
                    cadMovimentacaoCompra.txtTotalCompra.Text = modelo.Total.ToString();
                    cadMovimentacaoCompra.totalCompra = modelo.Total;

                    //itens da compra
                    BLL_ItensCompra bll_Itens = new BLL_ItensCompra(con);
                    DataTable tabela = bll_Itens.Localizar(modelo.IdCompra);

                    //jogar todos os itens na tela
                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        string icod = tabela.Rows[i]["id_produto"].ToString();
                        string inome = tabela.Rows[i]["nome"].ToString();
                        string iqtd = tabela.Rows[i]["quantidade"].ToString();
                        string ivaloruni = tabela.Rows[i]["valor"].ToString();
                        Double totalLocal = Convert.ToDouble(tabela.Rows[i]["quantidade"]) * Convert.ToDouble(tabela.Rows[i]["valor"]);

                        String[] it = new String[] { icod, inome, iqtd, ivaloruni, totalLocal.ToString() };
                        cadMovimentacaoCompra.dgvCompra.Rows.Add(it);
                    }
                    cadMovimentacaoCompra.ShowDialog();
                }
            }
        }

        //BOTAO SELECIONAR
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                this.idCompra = Convert.ToInt32(dgvCompra.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }

        //botao estornar compra
        private void BtnEstornar_Click(object sender, EventArgs e)
        {
            this.Status = Convert.ToString(dgvCompra.CurrentRow.Cells[5].Value);
            try
            {
                //SE O STATUS ESTIVER COMO PAGA NAO DEIXAR estornar
                if (this.Status == "ABERTO")
                {
                    MessageBox.Show("A Compra está com status em 'ABERTO',\nNão é possível Estorna-la!");
                }
                else
                {
                    //LEITURA DOS DADOS
                    Model_Compra modelo = new Model_Compra();
                    modelo.IdCompra = Convert.ToInt32(txtId.Text);
                    modelo.CompraStatus = "ABERTO";
                    //OBJ PARA GRAVAR NO BANCO
                    DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                    BLL_Compra bll = new BLL_Compra(con);

                    //CADASTRAR UMA CATEGORIA
                    bll.EstornarConta(modelo);
                    MessageBox.Show("Estorno efetuado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efeturar estorno da Compra\n" + ex.Message);
            }
        }
    }
}
