using System;
using BLL;
using DAL;
using Modelo;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadCompra : Form
    {
        public double totalCompra = 0;
        public string alterabotao = "0";

        public frm_CadCompra()
        {
            InitializeComponent();
        }

        // BOTAO SALVAR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //cOMPRA
                //LEITURA DOS DADOS
                Model_Compra modeloCompra = new Model_Compra();
                modeloCompra.DataCompra = dtCompra.Value;
                modeloCompra.NFiscal = Convert.ToInt32(txtNfiscal.Text);
                modeloCompra.NParcelas = Convert.ToInt32(txtNParcelas.Text);
                modeloCompra.CompraStatus = "ABERTO";
                modeloCompra.Total = Convert.ToInt32(txtTotalCompra.Text);
                modeloCompra.IdFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                modeloCompra.IdTipoPagamento = Convert.ToInt32(cbFormaPagto.SelectedValue);
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Compra bllCompra = new BLL_Compra(con);

                //ITENS COMPRA
                Model_ItensCompra modeloItensCompra = new Model_ItensCompra();
                BLL_ItensCompra bllItensCompra = new BLL_ItensCompra(con);


                //CADASTRAR compra
                bllCompra.Incluir(modeloCompra);

                //CADASTRAR ITENS COMPRA
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    modeloItensCompra.IdItensCompra = i + 1;
                    modeloItensCompra.IdCompraItensCompra = modeloCompra.IdCompra;
                    modeloItensCompra.IdProdutoItensCompra = Convert.ToInt32(dgvCompra.Rows[i].Cells[0].Value); //PEGA O IDE DO DATA GRID
                    modeloItensCompra.Quantidade = Convert.ToDouble(dgvCompra.Rows[i].Cells[2].Value); //PEGA A qtd  DO DATA GRID
                    modeloItensCompra.Valor = Convert.ToDouble(dgvCompra.Rows[i].Cells[3].Value); //PEGA O valor DO DATA GRID
                    bllItensCompra.Incluir(modeloItensCompra);

                    //ALTERAR A QUANTIDADE DE PRODUTOS COMPRADOS NA TABLE DA PRODUTOS
                    //TRIGGER CRIADA NO BD
                }
                MessageBox.Show("Compra cadastrada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Compra \n" + ex.Message);
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //cOMPRA
                //LEITURA DOS DADOS
                Model_Compra modeloCompra = new Model_Compra();
                modeloCompra.IdCompra = Convert.ToInt32(txtId.Text);
                modeloCompra.DataCompra = dtCompra.Value;
                modeloCompra.NFiscal = Convert.ToInt32(txtNfiscal.Text);
                modeloCompra.NParcelas = Convert.ToInt32(txtNParcelas.Text);
                modeloCompra.CompraStatus = "ABERTO";
                modeloCompra.Total = Convert.ToInt32(txtTotalCompra.Text);
                modeloCompra.IdFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                modeloCompra.IdTipoPagamento = Convert.ToInt32(cbFormaPagto.SelectedValue);

                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Compra bllCompra = new BLL_Compra(con);
                //CADASTRAR compra
                bllCompra.Alterar(modeloCompra);

                //ITENS COMPRA
                Model_ItensCompra modeloItensCompra = new Model_ItensCompra();
                BLL_ItensCompra bllItensCompra = new BLL_ItensCompra(con);

                //EXCLUIR TODOS OS ITENS DA COMPRA
               bllItensCompra.ExcluirTodosItens(modeloCompra.IdCompra);

                //CADASTRAR ITENS COMPRA
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    modeloItensCompra.IdItensCompra = i + 1;
                    modeloItensCompra.IdCompraItensCompra = modeloCompra.IdCompra;
                    modeloItensCompra.IdProdutoItensCompra = Convert.ToInt32(dgvCompra.Rows[i].Cells[0].Value); //PEGA O IDE DO DATA GRID
                    modeloItensCompra.Quantidade = Convert.ToDouble(dgvCompra.Rows[i].Cells[2].Value); //PEGA A qtd  DO DATA GRID
                    modeloItensCompra.Valor = Convert.ToDouble(dgvCompra.Rows[i].Cells[3].Value); //PEGA O valor DO DATA GRID
                    bllItensCompra.Incluir(modeloItensCompra);

                    //ALTERAR A QUANTIDADE DE PRODUTOS COMPRADOS NA TABLE DA PRODUTOS
                    //executar a TRIGGER CRIADA NO BD
                }

                MessageBox.Show("Compra alterada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterada Produto \n" + ex.Message);
            }
        }

        //LOAD DO FORM
        private void Frm_CadMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            listarComboBox();
            txtNfiscal.Text = "0";

            if (this.alterabotao == "0")
            {
                btnSalvar.Enabled = true;
                btnAlterar.Enabled = false;
            }

            if (this.alterabotao == "1")
            {
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
            }
        }

        //METODO LISTAR COMBOBOX
        private void listarComboBox()
        {
            //CARREGAR TIPO DE PAGAMENTO
            try
            {
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_TipoPagamento bll = new BLL_TipoPagamento(con);
                cbFormaPagto.DataSource = bll.Localizar("");   //CARREGA OS DADOS DA TABELA QUE CRIEI
                cbFormaPagto.DisplayMember = "nome";   //PEGA O NOME
                cbFormaPagto.ValueMember = "id_tipoPagamento"; //PEGA O ID
                cbFormaPagto.AutoCompleteMode = AutoCompleteMode.Suggest; //AUTO COMPLETAR
                cbFormaPagto.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela Tipo de Pagamento: \n" + ex);
            }

            //CARREGAR FORNECEDOR
            try
            {
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Fornecedor bll = new BLL_Fornecedor(con);
                cbFornecedor.DataSource = bll.Localizar("");   //CARREGA OS DADOS DA TABELA QUE CRIEI
                cbFornecedor.DisplayMember = "nome";   //PEGA O NOME
                cbFornecedor.ValueMember = "id_fornecedor"; //PEGA O ID
                cbFornecedor.AutoCompleteMode = AutoCompleteMode.Suggest; //AUTO COMPLETAR
                cbFornecedor.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela Fornecedor \n" + ex);
            }

            //CARREGAR produto
            try
            {
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Produto bll = new BLL_Produto(con);
                cbProtudo.DataSource = bll.Localizar("");   //CARREGA OS DADOS DA TABELA QUE CRIEI
                cbProtudo.DisplayMember = "nome";   //PEGA O NOME
                cbProtudo.ValueMember = "id_produto"; //PEGA O ID
                cbProtudo.AutoCompleteMode = AutoCompleteMode.Suggest; //AUTO COMPLETAR
                cbProtudo.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela Fornecedor \n" + ex);
            }

        }

        //BOTAO ADICONAR PRODUTO
        private void BtnAddProdu_Click(object sender, EventArgs e)
        {
            try
            {
                //VERIFICAR SE OS CAMPOS NAO SAO VAZIOS
                if ((cbProtudo.ValueMember != "") && (txtQtd.Text != "0,00") && (txtQtd.Text != "") && (txtQtd.Text != "0,") && (txtQtd.Text != "0") &&
                  (txtValorUni.Text != "") && (txtValorUni.Text != "0,00") && (txtValorUni.Text != "0,") && (txtValorUni.Text != "0"))
                {
                    Double TotalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtValorUni.Text);

                    //FAZER QUE MINHA VARIAVEL TOTAL COMPRA RECEBA O VALOR DO TOTAL LOCAL
                    this.totalCompra = this.totalCompra + TotalLocal;

                    //inserir produto na grid com vetor
                    String[] i = new String[] { cbProtudo.SelectedValue.ToString(), cbProtudo.Text.ToString(), txtQtd.Text, txtValorUni.Text, TotalLocal.ToString() };
                    this.dgvCompra.Rows.Add(i);

                    //LIMPAR OS CAMPOS DEPOS DE INSERIR
                    txtQtd.Clear();
                    txtValorUni.Clear();

                    //ATUALIZAR O TOTAL DA COMPRA
                    txtTotalCompra.Text = this.totalCompra.ToString();
                }
                else
                {
                    MessageBox.Show("Quantidade e Valor devem ser maiores que zero!");
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos Valor e Quantidade");
            }
        }

        //EVENTO AO CLIKAR DUAS VEZES NA GRID
        private void DgvCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MOSTRAR MENSAGEM desejo remover item
                DialogResult msg = MessageBox.Show("Deseja realmente remover o Item da compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                //SE O ESCOLHER SIM

                if (msg == DialogResult.Yes)
                {
                    cbProtudo.Text = dgvCompra.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtQtd.Text = dgvCompra.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtValorUni.Text = dgvCompra.Rows[e.RowIndex].Cells[3].Value.ToString();
                    Double valor = Convert.ToDouble(dgvCompra.Rows[e.RowIndex].Cells[4].Value);
                    this.totalCompra = this.totalCompra - valor;

                    //REMOVER LINHA DGV
                    dgvCompra.Rows.RemoveAt(e.RowIndex);
                    txtTotalCompra.Text = this.totalCompra.ToString();
                }
            }
        }

        private void TxtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (!txtQtd.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void TxtQtd_Leave(object sender, EventArgs e)
        {
            if (txtQtd.Text.Contains(",") == false)
            {
                txtQtd.Text += ",00";
            }
            else
            {
                if (txtQtd.Text.IndexOf(",") == txtQtd.Text.Length - 1)
                {
                    txtQtd.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtQtd.Text);
            }
            catch
            {
                txtQtd.Text = "0,00";
            }
        }

        private void TxtValorUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (!txtValorUni.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void TxtValorUni_Leave(object sender, EventArgs e)
        {
            if (txtValorUni.Text.Contains(",") == false)
            {
                txtValorUni.Text += ",00";
            }
            else
            {
                if (txtValorUni.Text.IndexOf(",") == txtValorUni.Text.Length - 1)
                {
                    txtValorUni.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorUni.Text);
            }
            catch
            {
                txtValorUni.Text = "0,00";
            }
        }
    }
}
