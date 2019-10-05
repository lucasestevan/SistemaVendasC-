using BLL;
using DAL;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Fornecedor : Form
    {
        public int idFornecedor = 0;
        public frm_Fornecedor()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadFornecedor cadFornecedor = new frm_CadFornecedor();
            cadFornecedor.ShowDialog();
        }

        //botao pesquisar
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Fornecedor bll = new BLL_Fornecedor(con);
            dgvFornecedor.DataSource = bll.Localizar(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
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
                        //CRIAR CONEXAO
                        DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                        BLL_Fornecedor bll = new BLL_Fornecedor(con);

                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Fornecedor excluido com sucesso!");
                        BtnPesquisar_Click(sender, e); //RECARREGA A TELA COM O ITEM EXCLUIDO
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Fornededor, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA GRID
        private void DgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvFornecedor.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //pega o id da data grid
            this.idFornecedor = (Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value));

            //chamr modelo bll e dal 
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Fornecedor bll = new BLL_Fornecedor(con);
            Model_Fornecedor modelo = bll.CarregaModeloFornecedor(idFornecedor);

            //CHAMAR O FORM Card e passar as informacoes
            frm_CadFornecedor cadFornecedor = new frm_CadFornecedor();
            cadFornecedor.btnAlterar.Enabled = true;
            cadFornecedor.btnSalvar.Enabled = false;

            cadFornecedor.txtId.Text = modelo.idFornecedor.ToString();
            cadFornecedor.txtNome.Text = modelo.nome.ToString();
            cadFornecedor.txtCPF.Text = modelo.cpfCNPJ.ToString();
            cadFornecedor.txtTel.Text = modelo.telefone.ToString();
            cadFornecedor.txtEmail.Text = modelo.email.ToString();
            cadFornecedor.ShowDialog();
            BtnPesquisar_Click(sender, e); // CHAMR O BOTAO PESQUISAR PARA ATUALIZAR A GRID
        }

        //METODO  DATA GRID
        private void FormatarDGV()
        {
            dgvFornecedor.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvFornecedor.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvFornecedor.Columns[1].HeaderText = "Nome";
            dgvFornecedor.Columns[1].Width = 130;
            dgvFornecedor.Columns[2].HeaderText = "CPF / CNPJ";
            dgvFornecedor.Columns[2].Width = 110;
            dgvFornecedor.Columns[3].HeaderText = "Telefone";
            dgvFornecedor.Columns[3].Width = 85;
            dgvFornecedor.Columns[4].HeaderText = "E-mail";
            dgvFornecedor.Columns[4].Width = 110;
        }
    }
}
