using BLL;
using DAL;
using Modelo;
using System;
using System.Data;
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
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);

                //LEITURA DOS DADOS endereco
                Model_Endereco modeloE = new Model_Endereco();
                modeloE.Cep = txtCep.Text;
                modeloE.Rua = txtRua.Text;
                modeloE.Bairro = txtBairro.Text;
                modeloE.Cidade = txtCidade.Text;
                modeloE.Uf = txtUf.Text;
                //OBJ PARA GRAVAR NO BANCO
                BLL_Endereco bllE = new BLL_Endereco(con);
                //CADASTRAR UM endereco
                bllE.Incluir(modeloE);

                //LEITURA DOS DADOS cliente
                Model_Cliente modeloC = new Model_Cliente();
                modeloC.Nome = txtNome.Text;
                modeloC.Cpf = txtCPF.Text;
                modeloC.Telefone = txtTelefone.Text;
                modeloC.Celular = txtCel.Text;
                modeloC.Email = txtEmail.Text;
                modeloC.Observacao = txtObs.Text;
                modeloC.Cep = txtCep.Text;
                modeloC.NumeroEnde = txtNumero.Text;
                //OBJ PARA GRAVAR NO BANCO
                BLL_Cliente bllC = new BLL_Cliente(con);

                //CADASTRAR UMA CATEGORIA
                bllC.Incluir(modeloC);
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
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);

                //LEITURA DOS DADOS endereco
                Model_Endereco modeloE = new Model_Endereco();
                modeloE.Cep = txtCep.Text;
                modeloE.Rua = txtRua.Text;
                modeloE.Bairro = txtBairro.Text;
                modeloE.Cidade = txtCidade.Text;
                modeloE.Uf = txtUf.Text;
                //OBJ PARA GRAVAR NO BANCO
                BLL_Endereco bllE = new BLL_Endereco(con);
                //CADASTRAR UM endereco
                bllE.Incluir(modeloE);

                //LEITURA DOS DADOS cliente
                Model_Cliente modeloC = new Model_Cliente();
                modeloC.IdCliente = Convert.ToInt32(txtId.Text);
                modeloC.Nome = txtNome.Text;
                modeloC.Cpf = txtCPF.Text;
                modeloC.Telefone = txtTelefone.Text;
                modeloC.Celular = txtCel.Text;
                modeloC.Email = txtEmail.Text;
                modeloC.Observacao = txtObs.Text;
                modeloC.Cep = txtCep.Text;
                modeloC.NumeroEnde = txtNumero.Text;
                //OBJ PARA GRAVAR NO BANCO
                BLL_Cliente bllC = new BLL_Cliente(con);

                //alterr
                bllC.Alterar(modeloC);
                MessageBox.Show("Cliente alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Cliente \n" + ex.Message);
            }
        }

        private void txtCep_Leave_1(object sender, EventArgs e)
        {
            BuscarCEP();
        }

        private void btnEndereco_Click_1(object sender, EventArgs e)
        {
            BuscarCEP();
        }

        //METODO BUSCAR CEP
        public void BuscarCEP()
        {
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
                .Replace("@cep", txtCep.Text);

            DataSet ds = new DataSet();
            ds.ReadXml(xml);

            txtRua.Text = ds.Tables[0].Rows[0][6].ToString();
            txtBairro.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCidade.Text = ds.Tables[0].Rows[0][3].ToString();
            //txtUf.Text = ds.Tables[0].Rows[0][2].ToString();

        }

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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
