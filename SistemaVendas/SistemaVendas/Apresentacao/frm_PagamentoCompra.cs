using BLL;
using DAL;
using Modelo;
using SistemaVendas.Apresentacao;
using System;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class frm_PagamentoCompra : Form
    {
        public string status = "";

        public frm_PagamentoCompra()
        {
            InitializeComponent();
        }

        //BOTAO LOCALIZAR
        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            frm_Compra Compra = new frm_Compra();
            Compra.ShowDialog();
            if (Compra.idCompra != 0)
            {

                //chamr modelo bll e dal compra
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Compra bllCompra = new BLL_Compra(con);
                Model_Compra modeloCom = bllCompra.CarregaModeloCompra(Compra.idCompra);
                txtId.Text = modeloCom.IdCompra.ToString();
                dtCompra.Value = modeloCom.DataCompra;
                txtValor.Text = modeloCom.Total.ToString();
                this.status = modeloCom.CompraStatus;

                //pegar nome do fonecedor
                BLL_Fornecedor bllf = new BLL_Fornecedor(con);
                Model_Fornecedor modeloFor = bllf.CarregaModeloFornecedor(modeloCom.IdFornecedor);
                txtFornecedor.Text = modeloFor.Nome;
            }
           
        }

        //BOTAO PAGAR
        private void BtnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                //SE O STATUS ESTIVER COMO PAGA NAO DEIXAR pagar novamnte
                if (this.status == "PAGO")
                {
                    MessageBox.Show("O pagamento para está compra já foi realizado,\nNão é possível pagar novamente!");
                }
                else
                {
                    //LEITURA DOS DADOS
                    Model_Compra modelo = new Model_Compra();
                    modelo.IdCompra = Convert.ToInt32(txtId.Text);
                    modelo.CompraStatus = "PAGO";
                    //OBJ PARA GRAVAR NO BANCO
                    DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                    BLL_Compra bll = new BLL_Compra(con);

                    
                    bll.PagarConta(modelo);
                    MessageBox.Show("Pagamento efetuado com sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efeturar pagamemo da Compra\n" + ex.Message);
            }
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
    }
}
