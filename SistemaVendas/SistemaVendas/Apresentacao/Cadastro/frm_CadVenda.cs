﻿using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadVenda : Form
    {
        public double totalVenda = 0;
        public string alterabotao = "0";


        public frm_CadVenda()
        {
            InitializeComponent();
        }

        //botao Ok
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (totalVenda <= 0)
            {
                MessageBox.Show("Insira pelo menos 1 item para continuar");
            }
            else
            {
                dgvParcelas.Rows.Clear();
                int parcelas = Convert.ToInt32(txtNParcelas.Value);
                Double totalLocal = this.totalVenda;
                double valor = totalLocal / parcelas;
                DateTime dt = new DateTime();
                dt = dtPgtoInicial.Value;
                lblTotalVenda.Text = this.totalVenda.ToString();
                for (int i = 1; i <= parcelas; i++)
                {
                    string[] k = new String[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                    this.dgvParcelas.Rows.Add(k);

                    if (dt.Month != 12)
                    {
                        dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dt.Day);
                    }
                }
                pnVenda.Visible = false;
                pnFinalizaCompra.Visible = true;
                btnOk.Visible = false;
                if (this.alterabotao == "0")
                {
                    btnSalvar.Enabled = true;
                }
                if (this.alterabotao == "1")
                {
                    btnAlterar.Enabled = true;
                }

                btnCancelar.Enabled = true;
            }
        }

        //metodo load do form
        private void Frm_CadVenda_Load(object sender, EventArgs e)
        {
            txtNParcelas.Value = 1;
            txtNfiscal.Text = "0";
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
        }

        //BOTAO ADICONAR PRODUTO
        private void BtnAddProdu_Click(object sender, EventArgs e)
        {
            Double QTD = 0;

            try
            {
                //VERIFICAR SE OS CAMPOS NAO SAO VAZIOS
                if ((cbProtudo.ValueMember != "") && (txtQtd.Text != "0,00") && (txtQtd.Text != "") && (txtQtd.Text != "0,") && (txtQtd.Text != "0") && (txtQtd.Text != ",00") &&
                    (txtValorUni.Text != "") && (txtValorUni.Text != "0,00") && (txtValorUni.Text != "0,") && (txtValorUni.Text != "0"))
                {
                    if (cbVerificaEstoque.Checked == true)
                    {
                        QTD = verificaProdutoEstoque(Convert.ToInt32(cbProtudo.SelectedValue));
                        if (Convert.ToDouble(txtQtd.Text) > QTD)
                        {
                            MessageBox.Show("Quantidade vendida maior que a disponivel no estoque");
                            return;
                        }
                    }
                    Double TotalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtValorUni.Text);

                    //FAZER QUE MINHA VARIAVEL TOTAL COMPRA RECEBA O VALOR DO TOTAL LOCAL
                    this.totalVenda = this.totalVenda + TotalLocal;

                    //inserir produto na grid com vetor
                    String[] i = new String[] { cbProtudo.SelectedValue.ToString(), cbProtudo.Text.ToString(), txtQtd.Text, txtValorUni.Text, TotalLocal.ToString() };
                    this.dgvVenda.Rows.Add(i);

                    //LIMPAR OS CAMPOS DEPOS DE INSERIR
                    txtQtd.Clear();

                    //ATUALIZAR O TOTAL DA COMPRA
                    txtTotalVenda.Text = this.totalVenda.ToString();
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
        private void DgvVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MOSTRAR MENSAGEM desejo remover item
                DialogResult msg = MessageBox.Show("Deseja realmente remover o Item da Venda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                //SE O ESCOLHER SIM

                if (msg == DialogResult.Yes)
                {
                    cbProtudo.Text = dgvVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtQtd.Text = dgvVenda.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtValorUni.Text = dgvVenda.Rows[e.RowIndex].Cells[3].Value.ToString();
                    Double valor = Convert.ToDouble(dgvVenda.Rows[e.RowIndex].Cells[4].Value);
                    this.totalVenda = this.totalVenda - valor;

                    //REMOVER LINHA DGV
                    dgvVenda.Rows.RemoveAt(e.RowIndex);
                    txtTotalVenda.Text = this.totalVenda.ToString();
                }
            }
        }

        //EVENTO CHEcAR a vista
        private void CbAvista_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAvista.Checked == true)
            {
                txtNParcelas.Value = 1;
                txtNParcelas.Enabled = false;
            }
            else
            {
                txtNParcelas.Enabled = true;
            }
        }

        //Botao cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            pnFinalizaCompra.Visible = false;
            pnVenda.Visible = true;
            btnOk.Visible = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        //Botao SALVAR VENDA
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Venda modeloVenda = new Model_Venda();
                modeloVenda.DataVenda = dtVenda.Value;
                modeloVenda.NFiscal = Convert.ToInt32(txtNfiscal.Text);
                modeloVenda.NParcelas = Convert.ToInt32(txtNParcelas.Text);
                modeloVenda.Total = Convert.ToDouble(txtTotalVenda.Text);
                modeloVenda.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);
                modeloVenda.IdTipoPagamento = Convert.ToInt32(cbFormaPagto.SelectedValue);
                if (cbxAvista.Checked == true)
                {
                    modeloVenda.Avista = 1;
                    modeloVenda.VendaStatus = "PAGO";
                }
                else
                {
                    modeloVenda.Avista = 0;
                    modeloVenda.VendaStatus = "ABERTO";
                }

                //OBJ PARA GRAVAR NO BANCO
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Venda bllVenda = new BLL_Venda(con);

                //ITENS VENDA
                Model_ItensVenda modeloItensVendas = new Model_ItensVenda();
                BLL_ItensVendas bllItenVenda = new BLL_ItensVendas(con);

                //PARCELAS VENDA
                Model_ParcelasVenda modeloParcelas = new Model_ParcelasVenda();
                BLL_ParcelasVenda bllParcelas = new BLL_ParcelasVenda(con);


                //CADASTRAR Venda
                bllVenda.Incluir(modeloVenda);

                //CADASTRAR ITENS Venda
                for (int i = 0; i < dgvVenda.RowCount; i++)
                {
                    modeloItensVendas.IdItensVenda = i + 1;
                    modeloItensVendas.IdVendaItensVendas = modeloVenda.IdVenda;
                    modeloItensVendas.IdProdutoItensVenda = Convert.ToInt32(dgvVenda.Rows[i].Cells[0].Value); //PEGA O IDE DO DATA GRID
                    modeloItensVendas.Quantidade = Convert.ToDouble(dgvVenda.Rows[i].Cells[2].Value); //PEGA A qtd  DO DATA GRID
                    modeloItensVendas.Valor = Convert.ToDouble(dgvVenda.Rows[i].Cells[3].Value); //PEGA O valor DO DATA GRID

                    bllItenVenda.Incluir(modeloItensVendas);

                    //ALTERAR A QUANTIDADE DE PRODUTOS vendidos NA TABLE DA PRODUTOS
                    //TRIGGER CRIADA NO BD
                }

                //CADASTRAR PARCELAS VENDA
                for (int i = 0; i < dgvParcelas.RowCount; i++)
                {
                    modeloParcelas.IdVenda = modeloVenda.IdVenda;
                    modeloParcelas.IdParcelasVenda = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value); //PEGA O IDE DO DATA GRID
                    modeloParcelas.Valor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value); //PEGA a valor
                    modeloParcelas.DataVencimento = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value); //PEGA a data DO DATA GRID
                    if (modeloVenda.Avista == 1)
                    {
                        modeloParcelas.DataPagto = Convert.ToDateTime(dtPgtoInicial.Text);
                    }

                    bllParcelas.Incluir(modeloParcelas);
                }

                MessageBox.Show("Venda cadastrada com sucesso!");

                ImprimirPedido(modeloVenda.IdVenda);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Venda \n" + ex.Message);
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Model_Venda modeloVenda = new Model_Venda();
                modeloVenda.IdVenda = Convert.ToInt32(txtId.Text);
                modeloVenda.DataVenda = dtVenda.Value;
                modeloVenda.NFiscal = Convert.ToInt32(txtNfiscal.Text);
                modeloVenda.NParcelas = Convert.ToInt32(txtNParcelas.Text);
                modeloVenda.Total = Convert.ToInt32(txtTotalVenda.Text);
                modeloVenda.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);
                modeloVenda.IdTipoPagamento = Convert.ToInt32(cbFormaPagto.SelectedValue);
                if (cbxAvista.Checked == true)
                {
                    modeloVenda.Avista = 1;
                    modeloVenda.VendaStatus = "PAGO";
                }
                else
                {
                    modeloVenda.Avista = 0;
                    modeloVenda.VendaStatus = "ABERTO";
                }

                //OBJ PARA GRAVAR NO BANCO
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Venda bllVenda = new BLL_Venda(con);

                //ITENS VENDA
                Model_ItensVenda modeloItensVendas = new Model_ItensVenda();
                BLL_ItensVendas bllItenVenda = new BLL_ItensVendas(con);

                //EXCLUIR TODOS OS ITENS DA COMPRA
                bllItenVenda.ExcluirTodosItens(modeloVenda.IdVenda);


                //PARCELAS VENDA
                Model_ParcelasVenda modeloParcelas = new Model_ParcelasVenda();
                BLL_ParcelasVenda bllParcelas = new BLL_ParcelasVenda(con);

                //EXCLUIR TODOS OS ITENS DA COMPRA
                bllParcelas.ExcluirTodasParcelas(modeloVenda.IdVenda);

                //CADASTRAR Venda
                bllVenda.Alterar(modeloVenda);

                //CADASTRAR ITENS Venda
                for (int i = 0; i < dgvVenda.RowCount; i++)
                {
                    modeloItensVendas.IdItensVenda = i + 1;
                    modeloItensVendas.IdVendaItensVendas = modeloVenda.IdVenda;
                    modeloItensVendas.IdProdutoItensVenda = Convert.ToInt32(dgvVenda.Rows[i].Cells[0].Value); //PEGA O IDE DO DATA GRID
                    modeloItensVendas.Quantidade = Convert.ToDouble(dgvVenda.Rows[i].Cells[2].Value); //PEGA A qtd  DO DATA GRID
                    modeloItensVendas.Valor = Convert.ToDouble(dgvVenda.Rows[i].Cells[3].Value); //PEGA O valor DO DATA GRID

                    bllItenVenda.Incluir(modeloItensVendas);

                    //ALTERAR A QUANTIDADE DE PRODUTOS vendidos NA TABLE DA PRODUTOS
                    //TRIGGER CRIADA NO BD
                }

                //CADASTRAR PARCELAS VENDA
                for (int i = 0; i < dgvParcelas.RowCount; i++)
                {
                    modeloParcelas.IdVenda = modeloVenda.IdVenda;
                    modeloParcelas.IdParcelasVenda = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value); //PEGA O IDE DO DATA GRID
                    modeloParcelas.Valor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value); //PEGA a valor
                    modeloParcelas.DataVencimento = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value); //PEGA a data DO DATA GRID
                    if (modeloVenda.Avista == 1)
                    {
                        modeloParcelas.DataPagto = Convert.ToDateTime(dtPgtoInicial.Text);
                    }
                    bllParcelas.Incluir(modeloParcelas);
                }

                MessageBox.Show("Venda alterada com sucesso!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Venda \n" + ex.Message);
            }
        }

        //AJUSTAR O CAMPO qtd
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

        //quando sair do cmapo qtd
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

        private void txtTotalVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (!txtTotalVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtTotalVenda_Leave(object sender, EventArgs e)
        {
            if (txtTotalVenda.Text.Contains(",") == false)
            {
                txtTotalVenda.Text += ",00";
            }
            else
            {
                if (txtTotalVenda.Text.IndexOf(",") == txtTotalVenda.Text.Length - 1)
                {
                    txtTotalVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtTotalVenda.Text);
            }
            catch
            {
                txtTotalVenda.Text = "0,00";
            }
        }

        //evento seleicona o produto
        private void CbProtudo_Enter(object sender, EventArgs e)
        {
            //CARREGAR produto
            try
            {
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Produto bll = new BLL_Produto(con);
                cbProtudo.DataSource = bll.Localizar("");   //CARREGA OS DADOS DA TABELA QUE CRIEI
                cbProtudo.DisplayMember = "nome";   //PEGA O NOME
                cbProtudo.ValueMember = "id_produto"; //PEGA O ID
                cbProtudo.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar tabela Produto \n");
            }
        }

        //VERIFICA QTD PRODUTO
        private Double verificaProdutoEstoque(int idProduto)
        {
            Double QtdEstoque = 0;
            try
            {
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Produto bll = new BLL_Produto(con);
                Model_Produto modelo = bll.CarregaModeloProduto(Convert.ToInt32(cbProtudo.SelectedValue.ToString()));
                QtdEstoque = modelo.Quantidade;

                //verifica produtos na grid
                //CADASTRAR ITENS Venda
                for (int i = 0; i < dgvVenda.RowCount; i++)
                {
                    if (Convert.ToInt32(dgvVenda.Rows[i].Cells[0].Value) == idProduto)
                    {
                        QtdEstoque = QtdEstoque - Convert.ToDouble(dgvVenda.Rows[i].Cells[2].Value); //PEGA A qtd  DO DATA GRID
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Não foi possivel verificar o estoque");
            }
            return QtdEstoque;
        }

        //EVENTO BUSCA O PRECO DO PRODUTO
        private void CbProtudo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BuscaPrecoProduto();
        }

        //event ao aapertar enter
        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQtd.ContainsFocus == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BtnAddProdu_Click(sender, e);
                }
            }
        }

        private void cbProtudo_Leave(object sender, EventArgs e)
        {
            BuscaPrecoProduto();
        }

        //EVENTO BUSCA O PRECO DO PRODUTO
        public void BuscaPrecoProduto()
        {
            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
            BLL_Produto bll = new BLL_Produto(con);
            Model_Produto modelo = bll.CarregaModeloProduto(Convert.ToInt32(cbProtudo.SelectedValue.ToString()));

            txtValorUni.Text = modelo.Preco.ToString();
            lblEstoque.Text = modelo.Quantidade.ToString();


            //AJUSTAR O CAMPO VALOR AO ADICIONAR O PRODUTO
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

        //CARREGAR CLIENTE
        private void cbCliente_Enter(object sender, EventArgs e)
        {
            //CARREGAR CLIENTE
            try
            {
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Cliente bll = new BLL_Cliente(con);
                cbCliente.DataSource = bll.Localizar("");   //CARREGA OS DADOS DA TABELA QUE CRIEI
                cbCliente.DisplayMember = "nome";   //PEGA O NOME
                cbCliente.ValueMember = "id_cliente"; //PEGA O ID
                cbCliente.AutoCompleteMode = AutoCompleteMode.Suggest; //AUTO COMPLETAR
                cbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar tabela Cliente \n");
            }
        }

        //CARREGAR TIPO DE PAGAMENTO
        private void cbFormaPagto_Enter(object sender, EventArgs e)
        {
            //CARREGAR TIPO DE PAGAMENTO
            try
            {
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_TipoPagamento bll = new BLL_TipoPagamento(con);
                cbFormaPagto.DataSource = bll.Localizar("");   //CARREGA OS DADOS DA TABELA QUE CRIEI
                cbFormaPagto.DisplayMember = "nome";   //PEGA O NOME
                cbFormaPagto.ValueMember = "id_tipoPagamento"; //PEGA O ID
                cbFormaPagto.AutoCompleteMode = AutoCompleteMode.Suggest; //AUTO COMPLETAR
                cbFormaPagto.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar tabela Tipo de Pagamento: \n");
            }
        }

        //botao minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //botao fechar
        private void btnClose_Click(object sender, EventArgs e)
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
                impressao.status = modeloVenda.VendaStatus.ToString();
                impressao.total = modeloVenda.Total.ToString();
                impressao.parcelas = modeloVenda.NParcelas.ToString();

                //DADOS DO CLIENTE
                BLL_Cliente bllCliente = new BLL_Cliente(con);
                Model_Cliente modeloCliente = bllCliente.CarregaModeloCliente(modeloVenda.IdCliente);

                impressao.cliente = modeloCliente.Nome.ToString();
                impressao.cpf = modeloCliente.Cpf.ToString();
                impressao.telefone = modeloCliente.Telefone.ToString();
                impressao.celular = modeloCliente.Celular.ToString();
                impressao.Nendereco = modeloCliente.NumeroEnde.ToString();

                //DADOS DO ENDERECO
                BLL_Endereco bllEndereco = new BLL_Endereco(con);
                Model_Endereco modeloEndereco = bllEndereco.CarregaModeloEndereco(modeloCliente.Cep);

                impressao.endereco = modeloEndereco.Rua.ToString();
                impressao.bairro = modeloEndereco.Bairro.ToString();
                impressao.cidade = modeloEndereco.Cidade.ToString();

                impressao.ShowDialog();
            }
        }
    }
}
