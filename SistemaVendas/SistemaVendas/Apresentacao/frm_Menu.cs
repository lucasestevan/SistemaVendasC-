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
        }

        //BOTAO COLABORADOR
        private void BtnColaborador_Click(object sender, EventArgs e)
        {
            var Colaborador = new frm_Colaborador();
            Colaborador.ShowDialog();
        }

        //BOTAO fornecedor
        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            var frm_Fornecedor = new frm_Fornecedor();
            frm_Fornecedor.ShowDialog();
        }

        //BOTAO PRODUTO
        private void BtnProduto_Click(object sender, EventArgs e)
        {
            var frm_Produto = new frm_Produto();
            frm_Produto.ShowDialog();
        }

        //BOTAO VENDAS
        private void BtnVendas_Click(object sender, EventArgs e)
        {
            frm_Venda venda = new frm_Venda();
            venda.ShowDialog();
        }

        //botao categoria
        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            var Categoria = new frm_Categoria();
            Categoria.ShowDialog();
        }

        //BOTAO LOGOUt
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
            }
        }
    }
}
