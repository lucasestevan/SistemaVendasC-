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
            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
            BLL_Fornecedor bll = new BLL_Fornecedor(con);
            dgvFornecedor.DataSource = bll.Localizar(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
            ContarLinhas();
            
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
                        DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
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
            if (txtId.Text != "")
            {
                //pega o id da data grid
                this.idFornecedor = (Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value));

                //chamr modelo bll e dal 
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Fornecedor bllF = new BLL_Fornecedor(con);
                Model_Fornecedor modeloF = bllF.CarregaModeloFornecedor(idFornecedor);

                BLL_Endereco bllEnde = new BLL_Endereco(con);
                Model_Endereco modeloEnde = bllEnde.CarregaModeloEndereco(modeloF.Cep);

                //CHAMAR O FORM Card e passar as informacoes
                frm_CadFornecedor cadFornecedor = new frm_CadFornecedor();

                cadFornecedor.txtId.Text = modeloF.IdFornecedor.ToString();
                cadFornecedor.txtNome.Text = modeloF.Nome.ToString();
                cadFornecedor.txtCPF.Text = modeloF.CpfCNPJ.ToString();
                cadFornecedor.txtTelefone.Text = modeloF.Telefone.ToString();
                cadFornecedor.txtCel.Text = modeloF.Celular.ToString();
                cadFornecedor.txtEmail.Text = modeloF.Email.ToString();
                cadFornecedor.txtObs.Text = modeloF.Observacao.ToString();
                cadFornecedor.txtCep.Text = modeloEnde.Cep.ToString();
                cadFornecedor.txtRua.Text = modeloEnde.Rua.ToString(); //RUA
                cadFornecedor.txtNumero.Text = modeloF.NumeroEnde.ToString();// NUMERO
                cadFornecedor.txtBairro.Text = modeloEnde.Bairro.ToString(); // BAIRRO
                cadFornecedor.txtCidade.Text = modeloEnde.Cidade.ToString();// CIDADE//
                cadFornecedor.txtUf.Text = modeloEnde.Uf.ToString(); //UF
                cadFornecedor.btnAlterar.Visible = true;
                cadFornecedor.btnSalvar.Visible = false;
                cadFornecedor.ShowDialog();
                BtnPesquisar_Click(sender, e); // CHAMR O BOTAO PESQUISAR PARA ATUALIZAR A GRID
            }
            else
            {
                MessageBox.Show("Selecione algum campo para alterar!");
            }
        }

        //METODO  DATA GRID
        private void FormatarDGV()
        {
            dgvFornecedor.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvFornecedor.Columns[0].Width = 50; //TAMANHO DA LARGURA
            dgvFornecedor.Columns[1].HeaderText = "Nome";
            dgvFornecedor.Columns[1].Width = 130;
            dgvFornecedor.Columns[2].HeaderText = "CPF / CNPJ";
            dgvFornecedor.Columns[2].Width = 110;
            dgvFornecedor.Columns[3].HeaderText = "Telefone";
            dgvFornecedor.Columns[3].Width = 90;
            dgvFornecedor.Columns[4].HeaderText = "Celular";
            dgvFornecedor.Columns[4].Width = 90;
            dgvFornecedor.Columns[5].HeaderText = "E-mail";
            dgvFornecedor.Columns[5].Width = 120;
            dgvFornecedor.Columns[6].HeaderText = "Observação";
            dgvFornecedor.Columns[6].Width = 120;
            dgvFornecedor.Columns[7].Visible = false; //cep
            dgvFornecedor.Columns[8].HeaderText = "Rua";
            dgvFornecedor.Columns[8].Width = 120;
            dgvFornecedor.Columns[9].Visible = false; //numero 
            dgvFornecedor.Columns[10].HeaderText = "Bairro";
            dgvFornecedor.Columns[10].Width = 120;
            dgvFornecedor.Columns[11].Visible = false;
            dgvFornecedor.Columns[12].Visible = false;
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

        //METODO CONTAR LINHAS
        private void ContarLinhas()
        {
            int total = dgvFornecedor.Rows.Count;
            lblQtdTotal.Text = total.ToString();
        }
    }
}
