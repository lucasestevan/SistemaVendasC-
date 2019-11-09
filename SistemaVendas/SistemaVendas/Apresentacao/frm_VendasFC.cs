using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_VendasFC : Form
    {
        public double totalVenda = 0;
        public string Codigo = "";

        public frm_VendasFC()
        {
            InitializeComponent();
        }

        //evento leave
        private void txtCod_Leave(object sender, EventArgs e)
        {
            //pega o id da data grid
            this.Codigo = txtCod.Text;

            //chamr modelo bll e dal 
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Produto bll = new BLL_Produto(con);
            Model_Produto modelo = bll.CarregaModeloProdutoCodigo(this.Codigo);

            lblIdPro.Text = modelo.IdProduto.ToString();//id
            lblProduto.Text = modelo.Nome.ToString(); //nome
            lblValor.Text = modelo.Preco.ToString();//preco
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            try
            {
                //VERIFICAR SE OS CAMPOS NAO SAO VAZIOS
                if ((lblProduto.Text != "") && (txtQtd.Text != "0,00") && (txtQtd.Text != "") && (txtQtd.Text != "0,") && (txtQtd.Text != "0"))
                {
                    Double TotalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(lblValor.Text);
                    //FAZER QUE MINHA VARIAVEL TOTAL RECEBA O VALOR DO TOTAL LOCAL
                    this.totalVenda = this.totalVenda + TotalLocal;

                    //inserir produto na grid com vetor
                    String[] i = new String[] { lblIdPro.Text.ToString(), txtCod.Text.ToString(), lblProduto.Text.ToString(), txtQtd.Text, lblValor.Text, TotalLocal.ToString() };
                    this.dgvVenda.Rows.Add(i);

                    //LIMPAR OS CAMPOS DEPOS DE INSERIR
                    txtCod.Clear();
                    txtQtd.Clear();
                    lblProduto.Text = "";
                    lblIdPro.Text = "";
                    lblValor.Text = "";

                    //ATUALIZAR O TOTAL DA COMPRA
                    lblTotal.Text = this.totalVenda.ToString();
                }
                else
                {
                    MessageBox.Show("Quantidade e Valor devem ser maiores que zero!");
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos Valor e Quantidade");
            }
        }

        private void frm_VendasFC_Load(object sender, EventArgs e)
        {

        }
    }
}
