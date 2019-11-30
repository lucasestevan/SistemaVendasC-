using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_VendasFC : Form
    {
        public double totalVenda = 0;
        public string Codigo = "";

        public frm_VendasFC()
        {
            InitializeComponent();
        }

        //meotodoLOCALIZAR ITEM
        public void localizarProduto()
        {
            try
            {
                //VERIFICAR SE OS CAMPOS NAO SAO VAZIOS
                if ((lblProduto.Text != null))
                {
                    //pega o id da data grid
                    this.Codigo = txtCod.Text;

                    //chamr modelo bll e dal 
                    DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                    BLL_Produto bll = new BLL_Produto(con);
                    Model_Produto modelo = bll.CarregaModeloProdutoCodigo(this.Codigo);

                    Model_Produto modelo2 = bll.CarregaModeloProduto(modelo.IdProduto); //carregar estoque

                    lblIdPro.Text = modelo.IdProduto.ToString();//id
                    lblProduto.Text = modelo.Nome.ToString(); //nome
                    lblValor.Text = modelo.Preco.ToString();//preco
                    lblEstoque.Text = modelo2.Quantidade.ToString();

                    txtQtd.Enabled = true;
                    txtQtd.Focus();
                }
                else
                {
                    MessageBox.Show("Código não localizado");
                }
            }
            catch
            {
                MessageBox.Show("Código não localizado");
            }
        }

        //meotodo inseri quantidade e itens na grid
        public void inserirItem()
        {
            try
            {
                //VERIFICAR SE OS CAMPOS NAO SAO VAZIOS
                if ((lblProduto.Text != "") && (txtQtd.Text != "0,00") && (txtQtd.Text != "") && (txtQtd.Text != "0,") && (txtQtd.Text != "0") && (txtQtd.Text != ",00"))
                {
                    Double TotalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(lblValor.Text);
                    //FAZER QUE MINHA VARIAVEL TOTAL RECEBA O VALOR DO TOTAL LOCAL
                    this.totalVenda = this.totalVenda + TotalLocal;

                    //inserir produto na grid com vetor
                    String[] i = new String[] { lblIdPro.Text.ToString(), txtCod.Text.ToString(), lblProduto.Text.ToString(), txtQtd.Text, lblValor.Text, TotalLocal.ToString() };
                    this.dgvVenda.Rows.Add(i);

                    //LIMPAR OS CAMPOS DEPOS DE INSERIR
                    txtCod.Text = "";
                    txtQtd.Text = "";
                    lblProduto.Text = "";
                    lblIdPro.Text = "";
                    lblValor.Text = "";
                    lblEstoque.Text = "";

                    //ATUALIZAR O TOTAL DA COMPRA
                    lblTotal.Text = this.totalVenda.ToString();
                    txtCod.Focus();
                    txtQtd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Quantidade deve ser maior que zero!");
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números no campo Quantidade");
            }
        }

        //EVENTO AO CLIKAR DUAS VEZES NA GRID
        private void dgvVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MOSTRAR MENSAGEM desejo remover item
            DialogResult msg = MessageBox.Show("Deseja realmente remover o Item da Venda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //SE O ESCOLHER SIM

            if (msg == DialogResult.Yes)
            {
                Double valor = Convert.ToDouble(dgvVenda.Rows[e.RowIndex].Cells[5].Value);
                this.totalVenda = this.totalVenda - valor;

                //REMOVER LINHA DGV
                dgvVenda.Rows.RemoveAt(e.RowIndex);
                lblTotal.Text = this.totalVenda.ToString();
                txtCod.Focus();
            }
        }

        public void FinalizarVenda()
        {
            if (this.totalVenda <= 0)
            {
                MessageBox.Show("Valor da venda deve ser maior que zero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            else
            {
                //MOSTRAR MENSAGEM desejo remover item
                DialogResult msg = MessageBox.Show("Deseja finalizar a Venda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                //SE O ESCOLHER SIM
                if (msg == DialogResult.Yes)
                {
                    frm_Pagamento pagamento = new frm_Pagamento();
                    pagamento.lblTotal.Text = this.lblTotal.Text.ToString();
                    pagamento.ShowDialog();

                    //LEITURA DOS DADOS
                    Model_Venda modeloVenda = new Model_Venda();

                    //OBJ PARA GRAVAR NO BANCO
                    DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                    //ITENS VENDA
                    Model_ItensVenda modeloItensVendas = new Model_ItensVenda();
                    BLL_ItensVendas bllItenVenda = new BLL_ItensVendas(con);

                    //CADASTRAR ITENS Venda
                    for (int i = 0; i < dgvVenda.RowCount; i++)
                    {
                        modeloItensVendas.IdItensVenda = i + 1;
                        modeloItensVendas.IdVendaItensVendas = pagamento.idVenda;
                        modeloItensVendas.IdProdutoItensVenda = Convert.ToInt32(dgvVenda.Rows[i].Cells[0].Value); //PEGA O IDE DO DATA GRID
                        modeloItensVendas.Quantidade = Convert.ToDouble(dgvVenda.Rows[i].Cells[3].Value); //PEGA A qtd  DO DATA GRID
                        modeloItensVendas.Valor = Convert.ToDouble(dgvVenda.Rows[i].Cells[4].Value); //PEGA O valor DO DATA GRID

                        bllItenVenda.Incluir(modeloItensVendas);

                        //ALTERAR A QUANTIDADE DE PRODUTOS vendidos NA TABLE DA PRODUTOS
                        //TRIGGER CRIADA NO BD
                    }

                    //PARCELAS VENDA
                    Model_ParcelasVenda modeloParcelas = new Model_ParcelasVenda();
                    BLL_ParcelasVenda bllParcelas = new BLL_ParcelasVenda(con);

                    //CADASTRAR PARCELAS VENDA
                    modeloParcelas.IdVenda = pagamento.idVenda;
                    modeloParcelas.IdParcelasVenda = 1;//PEGA O IDE DO DATA GRID
                    modeloParcelas.Valor = Convert.ToDouble(pagamento.lblTotal.Text);
                    modeloParcelas.DataVencimento = Convert.ToDateTime(DateTime.Now); //PEGA a data DO DATA GRID

                    bllParcelas.Incluir(modeloParcelas);

                    ImprimirPedido(pagamento.idVenda);

                    this.Close();
                }
            }
        }

        public void fecharForm()
        {
            //MOSTRAR MENSAGEM SE QUER SAIR AO CLIKAR NO sair
            DialogResult msg = MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //SE O ESCOLHER SIM
            if (msg == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
            }
        }

        //EVENTO AO SELECIONAR UMA TECLA
        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCod.ContainsFocus == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    localizarProduto();
                }

                if (e.KeyCode == Keys.F10)
                {
                    FinalizarVenda();
                }


                if (e.KeyCode == Keys.Escape)
                {
                    fecharForm();
                }
            }

        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQtd.ContainsFocus == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    inserirItem();
                }

                if (e.KeyCode == Keys.F10)
                {
                    FinalizarVenda();
                }

                if (e.KeyCode == Keys.Escape)
                {
                    fecharForm();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            fecharForm();
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQtd_Leave_1(object sender, EventArgs e)
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

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ENTER - LOCALIZAR O PRODUTO.\n\n" +
                "F10 - FINALIZAR A VENDA.\n\n" +
                "ESC - SAIR DA VENDA.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        private void frm_VendasFC_Load(object sender, EventArgs e)
        {
            txtCod.Focus();
        }

        public void ImprimirPedido(int idVenda)
        {
            DialogResult msg = MessageBox.Show("Deseja imprimir o Pedido?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            //SE O ESCOLHER SIM FAÇA
            if (msg == DialogResult.Yes)
            {
                //CHAMAR O FORM impressao
                Impressao.frm_ImpressaoVenda impressao = new Impressao.frm_ImpressaoVenda();

                //chamr modelo bll e dal venda
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);

                //DADOS DA VENDA
                BLL_Venda bllVenda = new BLL_Venda(con);
                Model_Venda modeloVenda = bllVenda.CarregaModeloVenda(idVenda);
                impressao.idvenda = idVenda;
                impressao.pedido = modeloVenda.IdVenda.ToString();
                impressao.data = modeloVenda.DataVenda.ToString();
                impressao.status = "PAGO VR";
                impressao.total = modeloVenda.Total.ToString();
                impressao.parcelas = modeloVenda.NParcelas.ToString();
                impressao.cliente = "CONSUMIDOR";
                impressao.cpf = "";
                impressao.telefone = "";
                impressao.celular = "";
                impressao.Nendereco = "";
                impressao.endereco = "";
                impressao.bairro = "";
                impressao.cidade = "";

                impressao.ShowDialog();
            }
        }
    }
}
