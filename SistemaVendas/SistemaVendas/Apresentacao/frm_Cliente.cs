using BLL;
using DAL;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Cliente : Form
    {
        public int idCliente = 0;

        public frm_Cliente()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadCliente cadCliente = new frm_CadCliente();
            cadCliente.ShowDialog();
        }

        //BOTAO PESQUISAR
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Cliente bll = new BLL_Cliente(con);
            dgvCliente.DataSource = bll.Localizar(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //botao excluir
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
                        BLL_Cliente bll = new BLL_Cliente(con);

                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Cliente excluido com sucesso!");
                        BtnPesquisar_Click(sender, e); //RECARREGA A TELA COM O ITEM EXCLUIDO
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Cliente, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA GRID
        private void DgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //pega o id da data grid
            this.idCliente = (Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value));

            //chamr modelo bll e dal 
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Cliente bllCliente = new BLL_Cliente(con);
            Model_Cliente modelo = bllCliente.CarregaModeloCliente(idCliente);

            BLL_Endereco bllEnde = new BLL_Endereco(con);
            Model_Endereco modeloEnde = bllEnde.CarregaModeloEndereco(modelo.Cep);

            //CHAMAR O FORM Card e passar as informacoes
            frm_CadCliente cadCliente = new frm_CadCliente();
            cadCliente.btnAlterar.Enabled = true;
            cadCliente.btnSalvar.Enabled = false;

            cadCliente.txtId.Text = modelo.IdCliente.ToString();
            cadCliente.txtNome.Text = modelo.Nome.ToString();
            cadCliente.txtCPF.Text = modelo.Cpf.ToString();
            cadCliente.txtTelefone.Text = modelo.Telefone.ToString();
            cadCliente.txtCel.Text = modelo.Celular.ToString();
            cadCliente.txtEmail.Text = modelo.Email.ToString();
            cadCliente.txtObs.Text = modelo.Observacao.ToString();
            cadCliente.txtCep.Text = modeloEnde.Cep.ToString();
            cadCliente.txtRua.Text = modeloEnde.Rua.ToString(); //RUA
            cadCliente.txtNumero.Text = modelo.NumeroEnde.ToString();// NUMERO
            cadCliente.txtBairro.Text = modeloEnde.Bairro.ToString(); // BAIRRO
            cadCliente.txtCidade.Text = modeloEnde.Cidade.ToString();// CIDADE//
            cadCliente.txtUf.Text = modeloEnde.Uf.ToString(); //UF
            cadCliente.btnAlterar.Visible = true;
            cadCliente.btnSalvar.Visible = false;
            cadCliente.ShowDialog();
            BtnPesquisar_Click(sender, e); // CHAMR O BOTAO PESQUISAR PARA ATUALIZAR A GRID
        }

        //METODO formatar  DATA GRIDu
        private void FormatarDGV()
        {
            dgvCliente.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvCliente.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvCliente.Columns[1].HeaderText = "Nome";
            dgvCliente.Columns[1].Width = 130;
            dgvCliente.Columns[2].HeaderText = "CPF";
            dgvCliente.Columns[2].Width = 90;
            dgvCliente.Columns[3].HeaderText = "Telefone";
            dgvCliente.Columns[3].Width = 90;
            dgvCliente.Columns[4].HeaderText = "Celular";
            dgvCliente.Columns[4].Width = 90;
            dgvCliente.Columns[5].HeaderText = "E-mail";
            dgvCliente.Columns[5].Width = 120;
            dgvCliente.Columns[6].HeaderText = "Observação";
            dgvCliente.Columns[6].Width = 120;
            dgvCliente.Columns[7].Visible = false; //cep
            dgvCliente.Columns[8].HeaderText = "Rua";
            dgvCliente.Columns[8].Width = 120;
            dgvCliente.Columns[9].Visible = false; //numero 
            dgvCliente.Columns[10].HeaderText = "Bairro"; 
            dgvCliente.Columns[10].Width = 120;
            dgvCliente.Columns[11].Visible = false;
            dgvCliente.Columns[12].Visible = false;
        }
    }
}

