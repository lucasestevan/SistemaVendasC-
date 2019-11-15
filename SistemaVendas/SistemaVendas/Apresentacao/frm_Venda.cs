using BLL;
using DAL;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Venda : Form
    {
        public int idVenda = 0;
        public string Status = "";

        public frm_Venda()
        {
            InitializeComponent();
        }

        //botao novo
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadVenda venda = new frm_CadVenda();
            venda.ShowDialog();
        }

        //load
        private void Frm_Venda_Load(object sender, EventArgs e)
        {
            RbGeral_CheckedChanged(sender, e);
        }

        private void RbGeral_CheckedChanged(object sender, EventArgs e)
        {

            //OCUTAR PAINEIS
            gbData.Visible = false;
            gbCliente.Visible = false;
            gbCodigo.Visible = false;
            btnPesquisarGeral.Visible = false;

            //LIMPAR O GRID
            dgvVenda.DataSource = null;
            txtId.Text = "";

            if (rbGeral.Checked == true)
            {
                btnPesquisarGeral.Visible = true;

            }
            if ((rbData.Checked == true))
            {
                gbData.Visible = true;
            }

            if ((rbCliente.Checked == true))
            {
                gbCliente.Visible = true;
            }

            if ((rbCodigo.Checked == true))
            {
                gbCodigo.Visible = true;
            }
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
                        Model_Venda modeloVenda = new Model_Venda();
                        this.idVenda = Convert.ToInt32(dgvVenda.CurrentRow.Cells[0].Value);
                        //EXCLUIR ITENS DA COMPRA 
                        DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                        BLL_ItensVendas bllItens = new BLL_ItensVendas(con);
                        //excluir Compra
                        BLL_Venda bllVenda = new BLL_Venda(con);
                        this.Status = Convert.ToString(dgvVenda.CurrentRow.Cells[5].Value);

                        //SE O STATUS ESTIVER COMO PAGA NAO DEIXAR EXCLUIR
                        if (Status == "PAGO" || Status == "CANCELADO")
                        {
                            MessageBox.Show("A Venda está com status de PAGA/CANCELADO, não é possível excluir!");
                        }
                        else
                        {
                            bllItens.ExcluirTodosItens(Convert.ToInt32(txtId.Text));

                            bllVenda.Excluir(Convert.ToInt32(txtId.Text));

                            MessageBox.Show("Venda excluida com sucesso!");
                            txtId.Text = "";

                            //EXECUTAR A TRIGGER DO BD PARA ARRUMAR ESTOQUE
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Venda, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA DATAGRID
        private void DgvVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvVenda.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnVisualizar.Enabled = true;
            btnSelecionar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }

        //BOTAO PESQUISAR geral
        private void BtnPesquisarGeral_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Venda bll = new BLL_Venda(con);
            dgvVenda.DataSource = bll.LocalizarGeral();
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //BOTAO PESQUISAR IDCOMPRA
        private void BtnPesquisarCod_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Venda bll = new BLL_Venda(con);
            dgvVenda.DataSource = bll.LocalizaridVenda(Convert.ToInt32(txtIdVenda.Text.Length));
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //BOTAO PESQUISAR Data
        private void BtnPesquisaData_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Venda bll = new BLL_Venda(con);
            dgvVenda.DataSource = bll.LocalizarData(dtInicial.Value, dtFinal.Value);
            FormatarDGV(); //FORMATA O DATA GRID
        }

        private void BtnPesquisaCliente_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Venda bll = new BLL_Venda(con);
            dgvVenda.DataSource = bll.LocalizarNome(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //BOTAO VIZUALIZAR
        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            //if (dgvVenda.SelectedRows.Count > 0)
            if (txtId.Text != "")
            {
                //CRIAR O FORM VIZUALIZAR ITEM
                frm_VisualizarItensVenda visualizar = new frm_VisualizarItensVenda();

                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_ItensVendas bllItens = new BLL_ItensVendas(con);
                BLL_ParcelasVenda bllParcelas = new BLL_ParcelasVenda(con);

                visualizar.dgvItensVenda.DataSource = bllItens.Localizar(Convert.ToInt32(dgvVenda.CurrentRow.Cells[0].Value));
                visualizar.dgvParcelasVenda.DataSource = bllParcelas.Localizar(Convert.ToInt32(dgvVenda.CurrentRow.Cells[0].Value));
                visualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder visualizar");
            }
        }

        //botao alterar
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                this.Status = Convert.ToString(dgvVenda.CurrentRow.Cells[5].Value);

                //SE O STATUS ESTIVER COMO PAGA NAO DEIXAR alterar
                if (Status == "PAGO" || Status == "CANCELADO")
                {
                    MessageBox.Show("A venda está com status de PAGO/CANCELADO, não é possível Alterar!");
                }
                else
                {
                    if (dgvVenda.SelectedRows.Count > 0)
                    {
                        //pega o id da data grid
                        this.idVenda = (Convert.ToInt32(dgvVenda.CurrentRow.Cells[0].Value));

                        //chamr modelo bll e dal venda
                        DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                        BLL_Venda bll = new BLL_Venda(con);
                        Model_Venda modelo = bll.CarregaModeloVenda(idVenda);

                        //CHAMAR O FORM CAD COMPRA
                        frm_CadVenda cadVenda = new frm_CadVenda();
                        cadVenda.alterabotao = "1";
                        cadVenda.btnSalvar.Enabled = false;

                        cadVenda.txtId.Text = modelo.IdVenda.ToString();
                        cadVenda.txtNfiscal.Text = modelo.NFiscal.ToString();
                        cadVenda.dtVenda.Value = modelo.DataVenda;
                        cadVenda.cbCliente.SelectedValue = modelo.IdVenda;
                        cadVenda.txtNParcelas.Value = Convert.ToInt32(modelo.NParcelas.ToString());
                        cadVenda.cbFormaPagto.SelectedValue = modelo.IdTipoPagamento;
                        cadVenda.txtTotalVenda.Text = modelo.Total.ToString();
                        if (modelo.Avista == 1) cadVenda.cbxAvista.Checked = true;
                        else cadVenda.cbxAvista.Checked = false;
                        cadVenda.totalVenda = modelo.Total;

                        //itens da venda
                        BLL_ItensVendas bll_Itens = new BLL_ItensVendas(con);
                        DataTable tabela = bll_Itens.Localizar(modelo.IdVenda);

                        //jogar todos os itens na tela
                        for (int i = 0; i < tabela.Rows.Count; i++)
                        {
                            string icod = tabela.Rows[i]["id_produto"].ToString();
                            string inome = tabela.Rows[i]["nome"].ToString();
                            string iqtd = tabela.Rows[i]["quantidade"].ToString();
                            string ivaloruni = tabela.Rows[i]["valor"].ToString();
                            Double totalLocal = Convert.ToDouble(tabela.Rows[i]["quantidade"]) * Convert.ToDouble(tabela.Rows[i]["valor"]);

                            String[] it = new String[] { icod, inome, iqtd, ivaloruni, totalLocal.ToString() };
                            cadVenda.dgvVenda.Rows.Add(it);
                        }
                        cadVenda.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder Alterar");
            }
        }

        //FORMATA O DATA GRID
        private void FormatarDGV()
        {
            dgvVenda.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvVenda.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvVenda.Columns[1].HeaderText = "Data da Venda";
            dgvVenda.Columns[1].Width = 110;
            dgvVenda.Columns[2].HeaderText = "Cliente";
            dgvVenda.Columns[2].Width = 140;
            dgvVenda.Columns[3].HeaderText = "N° Parcelas";
            dgvVenda.Columns[3].Width = 90;
            dgvVenda.Columns[4].HeaderText = "Total";
            dgvVenda.Columns[4].Width = 80;
            dgvVenda.Columns[5].HeaderText = "Status";
            dgvVenda.Columns[5].Width = 80;
            dgvVenda.Columns[6].Visible = false;
            dgvVenda.Columns[7].Visible = false;
            dgvVenda.Columns[8].Visible = false; ;
            dgvVenda.Columns[9].HeaderText = "Nota Fiscal";
            dgvVenda.Columns[9].Width = 90;

            for (int i = 0; i < dgvVenda.Rows.Count; i++)
            {
                string Campostatus = Convert.ToString(dgvVenda.Rows[i].Cells[5].Value.ToString());
                if (Campostatus == "CANCELADO")
                {
                    dgvVenda.Rows[i].Cells[5].Style.BackColor = Color.Red;
                }
                if (Campostatus == "PAGO")
                {
                    dgvVenda.Rows[i].Cells[5].Style.BackColor = Color.Green;
                }
            }
        }

        //botao cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente Cancelar a venda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        this.idVenda = Convert.ToInt32(dgvVenda.CurrentRow.Cells[0].Value);
                        //EXCLUIR ITENS DA COMPRA 
                        DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                        //excluir Compra
                        BLL_Venda bllVenda = new BLL_Venda(con);
                        this.Status = Convert.ToString(dgvVenda.CurrentRow.Cells[5].Value);

                        //SE O STATUS ESTIVER COMO PAGA NAO DEIXAR cancelar
                        if (Status == "PAGO" || Status == "CANCELADO")
                        {
                            MessageBox.Show("A Venda está com status de PAGA/CANCELADO \n Não é possível Cancelar!");
                        }
                        else
                        {
                            bllVenda.CancelarVenda(Convert.ToInt32(txtId.Text));

                            MessageBox.Show("Venda Cancelada com sucesso!");
                            txtId.Text = "";

                            //EXECUTAR A TRIGGER DO BD PARA ARRUMAR ESTOQUE
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Cancelar a Venda" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder Cancelar");
            }
        }

        //BOTAO SELECIONAR
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvVenda.SelectedRows.Count > 0)
            {
                this.idVenda = Convert.ToInt32(dgvVenda.CurrentRow.Cells[0].Value);
                this.Close();
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
    }
}
