using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        //BOTAO CLIENTE
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            var frm_Cliente = new frm_Cliente();
            frm_Cliente.ShowDialog();
            frm_Cliente.Dispose();
        }

        //BOTAO COLABORADOR
        private void BtnColaborador_Click(object sender, EventArgs e)
        {
            var Colaborador = new frm_Colaborador();
            Colaborador.ShowDialog();
            Colaborador.Dispose();
        }

        //BOTAO fornecedor
        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            var frm_Fornecedor = new frm_Fornecedor();
            frm_Fornecedor.ShowDialog();
            frm_Fornecedor.Dispose();
        }

        //BOTAO PRODUTO
        private void BtnProduto_Click(object sender, EventArgs e)
        {
            var frm_Produto = new frm_Produto();
            frm_Produto.ShowDialog();
            frm_Produto.Dispose();
        }

        //BOTAO VENDAS
        private void BtnVendas_Click(object sender, EventArgs e)
        {
            frm_Venda venda = new frm_Venda();
            venda.ShowDialog();
            venda.Dispose();
        }

        //botao categoria
        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            var Categoria = new frm_Categoria();
            Categoria.ShowDialog();
            Categoria.Dispose();
        }

        //BOTAO ENDERECO
        private void BtnEndereco_Click(object sender, EventArgs e)
        {
            var Endereco = new frm_Endereco();
            Endereco.ShowDialog();
            Endereco.Dispose();
        }

        //BOTAO PAGAMENTO
        private void TxtTipoPagto_Click(object sender, EventArgs e)
        {
            var pagamento = new frm_TipoPagamento();
            pagamento.ShowDialog();
            pagamento.Dispose();
        }

       
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //MOSTRAR MENSAGEM SE QUER SAIR AO CLIKAR NO LOGOUT
            DialogResult msg = MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //SE O ESCOLHER SIM
            if (msg == DialogResult.Yes)
            {
                frm_Login frm_Login = new frm_Login();
                this.Hide();
                frm_Login.ShowDialog();
                this.Visible = false;
                this.Close();
                //BOTAO LOGOUt
            }
        }

        //botao compra
        private void BtnCompra_Click(object sender, EventArgs e)
        {
            var Compra = new frm_Compra();
            Compra.ShowDialog();
            Compra.Dispose();
        }

        //botao pagamento
        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            var Pagamento = new frm_PagamentoCompra();
            Pagamento.ShowDialog();
            Pagamento.Dispose();
        }

        //botao recebimento
        private void BtnRecebimentoV_Click(object sender, EventArgs e)
        {
            var recebimento = new frm_RecebimentoVenda();
            recebimento.ShowDialog();
            recebimento.Dispose();
        }
    }
}
