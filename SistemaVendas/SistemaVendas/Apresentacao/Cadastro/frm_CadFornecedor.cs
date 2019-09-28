using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;


namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadFornecedor : Form
    {
        public frm_CadFornecedor()
        {
            InitializeComponent();
        }

        //BOTAO SALVAR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Fornecedor modelo = new Model_Fornecedor();
                modelo.nome = txtNome.Text;
                modelo.cpfCNPJ = txtCPF.Text;
                modelo.telefone = txtTel.Text;
                modelo.email = txtEmail.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Fornecedor bll = new BLL_Fornecedor(con);

                //CADASTRAR UMA CATEGORIA
                bll.Incluir(modelo);
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Fornecedor \n" + ex.Message);
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Fornecedor modelo = new Model_Fornecedor();
                modelo.idFornecedor = Convert.ToInt32(txtId.Text);
                modelo.nome = txtNome.Text;
                modelo.cpfCNPJ = txtCPF.Text;
                modelo.telefone = txtTel.Text;
                modelo.email = txtEmail.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Fornecedor bll = new BLL_Fornecedor(con);

                //CADASTRAR UMA CATEGORIA
                bll.Alterar(modelo);
                MessageBox.Show("Fornecedor alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Fornecedor \n" + ex.Message);
            }
        }

        private void RbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true )
            {
                lblNome.Text = "Nome";
                lblCPF.Text = "CPF";
                txtCPF.Mask = "000.000.000-00";
            }
            else
            {
                lblNome.Text = "Razão Social";
                lblCPF.Text = "CNPJ";
                txtCPF.Mask = "00.000.000/0000-00";
            }
        }
    }
}
