using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadCategoria : Form
    {
        public frm_CadCategoria()
        {
            InitializeComponent();
        }

        //BOTAO SALVAR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Categoria modelo = new Model_Categoria();
                modelo.Nome = txtNome.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con1 = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Categoria bll1 = new BLL_Categoria(con1);

                //CADASTRAR UMA CATEGORIA
                bll1.Incluir(modelo);
                MessageBox.Show("Categoria cadastrada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Categoria \n" + ex.Message);
            }

        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Categoria modelo = new Model_Categoria();
                modelo.Id_categoria = Convert.ToInt32(txtId.Text);
                modelo.Nome = txtNome.Text;

                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Categoria bll = new BLL_Categoria(con);

                //CADASTRAR UMA CATEGORIA
                bll.Alterar(modelo);
                MessageBox.Show("Categoria Alterada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar Categoria \n" + ex.Message);
            }
        }
    }
}
