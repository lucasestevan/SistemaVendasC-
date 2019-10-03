using System;
using BLL;
using DAL;
using Modelo;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadMovimentacaoCompra : Form
    {
        public double totalCompra = 0;


        public frm_CadMovimentacaoCompra()
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
                modeloCompra.dataCompra = dtCompra.Value;
                modeloCompra.nFiscal = Convert.ToInt32(txtNfiscal.Text.Length);
                modeloCompra.nParcelas = Convert.ToInt32(txtNParcelas.Text);
                modeloCompra.CompraStatus = "Ativo";
                modeloCompra.total = Convert.ToInt32(txtTotalCompra.Text);
                modeloCompra.idFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                modeloCompra.idTipoPagamento = Convert.ToInt32(cbFormaPagto.SelectedValue);
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
                    modeloItensCompra.idItensCompra = i + 1;
                    modeloItensCompra.idCompraItensCompra = modeloCompra.idCompra;
                    modeloItensCompra.idProdutoItensCompra = Convert.ToInt32(dgvCompra.Rows[i].Cells[0].Value); //PEGA O IDE DO DATA GRID
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
                MessageBox.Show("Erro ao Cadastrar Produto \n" + ex.Message);
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            /*try
            {
                //LEITURA DOS DADOS
                Model_Produto modelo = new Model_Produto();
                modelo.idProduto = Convert.ToInt32(txtId.Text);
                modelo.nome = txtNome.Text;
                modelo.preco = Convert.ToDouble(txtPreco.Text);
                modelo.quantidade = Convert.ToDouble(txtQtd.Text);
                modelo.descricao = txtDesc.Text;
                modelo.idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                modelo.idFornecedor = Convert.ToInt32(cmbFornecedor.SelectedValue);
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Produto bll = new BLL_Produto(con);

                //CADASTRAR UMA CATEGORIA
                bll.Alterar(modelo);
                MessageBox.Show("Produto alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Produto \n" + ex.Message);
            }*/
        }

        //LOAD DO FORM
        private void Frm_CadMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            listarComboboxBox();
        }

        //METODO LISTAR COMBOBOX
        private void listarComboboxBox()
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

            //CARREGAR FORNECEDOR
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
            //VERIFICAR SE OS CAMPOS NAO SAO VAZIOS
            if ((cbProtudo.ValueMember != "") && (txtQtd.Text != "") && (txtValorUni.Text != ""))
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
    }
}
