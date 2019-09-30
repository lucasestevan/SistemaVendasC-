using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadTipoPagamento : Form
    {
        public frm_CadTipoPagamento()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_TipoPagamento modelo = new Model_TipoPagamento();
                modelo.nome = txtNome.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_TipoPagamento bll = new BLL_TipoPagamento(con);

                //CADASTRAR UMA CATEGORIA
                bll.Incluir(modelo);
                MessageBox.Show("Tipo de Pagamento cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Tipo de Pagamento \n" + ex.Message);
            }
        }

        //botao alterar
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_TipoPagamento modelo = new Model_TipoPagamento();
                modelo.idTipoPagamento = Convert.ToInt32(txtId.Text);
                modelo.nome = txtNome.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_TipoPagamento bll = new BLL_TipoPagamento(con);

                //CADASTRAR UMA CATEGORIA
                bll.Alterar(modelo);
                MessageBox.Show("Tipo de Pagamento alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Tipo de Pagamento \n" + ex.Message);
            }
        }
    }
}
