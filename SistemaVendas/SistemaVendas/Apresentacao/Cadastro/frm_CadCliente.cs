using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadCliente : Form
    {
        public frm_CadCliente()
        {
            InitializeComponent();
        }

        //botao salvar
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Cliente modelo = new Model_Cliente();
                modelo.nome = txtNome.Text;
                modelo.cpf = txtCPF.Text;
                modelo.telefone = txtTelefone.Text;
                modelo.celular = txtCel.Text;
                modelo.email = txtEmail.Text;
                modelo.observacao = txtObs.Text;
                modelo.idEndereco = Convert.ToInt32(txtIdEnde.Text);
                modelo.numeroEnde = txtNumero.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Cliente bll = new BLL_Cliente(con);

                //CADASTRAR UMA CATEGORIA
                bll.Incluir(modelo);
                MessageBox.Show("Cliente cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Cliente \n" + ex.Message);
            }
        }

        //botao alterar
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Cliente modelo = new Model_Cliente();
                modelo.idCliente = Convert.ToInt32(txtId.Text);
                modelo.nome = txtNome.Text;
                modelo.cpf = txtCPF.Text;
                modelo.telefone = txtTelefone.Text;
                modelo.celular = txtCel.Text;
                modelo.email = txtEmail.Text;
                modelo.observacao = txtObs.Text;
                modelo.idEndereco = Convert.ToInt32(txtIdEnde.Text);
                modelo.numeroEnde =txtNumero.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Cliente bll = new BLL_Cliente(con);

                //CADASTRAR UMA CATEGORIA
                bll.Alterar(modelo);
                MessageBox.Show("Cliente alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Cliente \n" + ex.Message);
            }
        }

        //botao localizar endereco
        private void BtnEndereco_Click(object sender, EventArgs e)
        {
            txtCep.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";


            frm_Endereco endereco = new frm_Endereco();
            //DESABILITAR OS BOTOES PRIMEIRO E DPS CHAMAR O FORM enderecoO
            endereco.btnAlterar.Visible = false;
            endereco.btnExcluir.Visible = false;
            endereco.btnSelecionar.Visible = true;
            endereco.ShowDialog();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
