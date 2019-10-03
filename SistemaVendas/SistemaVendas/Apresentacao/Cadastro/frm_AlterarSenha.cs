using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_AlterarSenha : Form
    {
        public frm_AlterarSenha()
        {
            InitializeComponent();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Colaborador modelo = new Model_Colaborador();
                modelo.idColaborador = Convert.ToInt32(txtId.Text);
                modelo.senha = txtSenhanova.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Colaborador bll = new BLL_Colaborador(con);

                //CADASTRAR UMA CATEGORIA
                bll.ApagarSenha(modelo);
                MessageBox.Show("Senha Alterada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Senha \n" + ex.Message);
            }
        }
    }
}
