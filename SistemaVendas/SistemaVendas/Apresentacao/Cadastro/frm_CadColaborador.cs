using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadColaborador : Form
    {
        public frm_CadColaborador()
        {
            InitializeComponent();
        }

        //BOTAO SALVAR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Colaborador modelo = new Model_Colaborador();
                modelo.Nome = txtNome.Text;
                modelo.Cpf = txtCPF.Text;
                modelo.Senha = txtSenha.Text;
                modelo.Telefone = txtTelefone.Text;
                modelo.Celular = txtCel.Text;
                modelo.Descricao = txtDesc.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Colaborador bll = new BLL_Colaborador(con);

                //CADASTRAR UMA CATEGORIA
                bll.Incluir(modelo);
                MessageBox.Show("Colaborador cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Colaborador \n" + ex.Message);
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Colaborador modelo = new Model_Colaborador();
                modelo.IdColaborador = Convert.ToInt32(txtId.Text);
                modelo.Nome = txtNome.Text;
                modelo.Cpf = txtCPF.Text;
                modelo.Telefone = txtTelefone.Text;
                modelo.Celular = txtCel.Text;
                modelo.Descricao = txtDesc.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Colaborador bll = new BLL_Colaborador(con);

                //CADASTRAR UMA CATEGORIA
                bll.Alterar(modelo);
                MessageBox.Show("Colaborador alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Colaborador \n" + ex.Message);
            }
        }

        //ALTERAR A SENHAA
        private void BtnSenha_Click(object sender, EventArgs e)
        {
            frm_AlterarSenha alterarSenha = new frm_AlterarSenha();
            alterarSenha.Show();
        }
    }
}
