using BLL;
using DAL;
using Modelo;
using System;
using System.Data;
using System.Windows.Forms;


namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadFornecedor : Form
    {
        public frm_CadFornecedor()
        {
            InitializeComponent();
        }

        //BOTAO SALVAR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);

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
                Model_Fornecedor modeloF = new Model_Fornecedor();
                modeloF.Nome = txtNome.Text;
                modeloF.CpfCNPJ = txtCPF.Text;
                modeloF.Telefone = txtTelefone.Text;
                modeloF.Celular = txtCel.Text;
                modeloF.Email = txtEmail.Text;
                modeloF.Observacao = txtObs.Text;
                modeloF.Cep = txtCep.Text;
                modeloF.NumeroEnde = txtNumero.Text;

                //OBJ PARA GRAVAR NO BANCO
                BLL_Fornecedor bllF = new BLL_Fornecedor(con);

                //CADASTRAR 
                bllF.Incluir(modeloF);
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Fornecedor \n" + ex.Message);
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);

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
                Model_Fornecedor modeloF = new Model_Fornecedor();
                modeloF.IdFornecedor = Convert.ToInt32(txtId.Text);
                modeloF.Nome = txtNome.Text;
                modeloF.CpfCNPJ = txtCPF.Text;
                modeloF.Telefone = txtTelefone.Text;
                modeloF.Celular = txtCel.Text;
                modeloF.Email = txtEmail.Text;
                modeloF.Observacao = txtObs.Text;
                modeloF.Cep = txtCep.Text;
                modeloF.NumeroEnde = txtNumero.Text;

                //OBJ PARA GRAVAR NO BANCO
                BLL_Fornecedor bllF = new BLL_Fornecedor(con);

                bllF.Alterar(modeloF);
                MessageBox.Show("Fornecedor alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Fornecedor \n" + ex.Message);
            }
        }

        private void RbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
            {
                lblNome.Text = "Nome";
                lblCPF.Text = "CPF";
                txtCPF.Mask = "000.000.000-00";
            }
            else
            {
                lblNome.Text = "Razão Social";
                lblCPF.Text = "CNPJ";
                txtCPF.Mask = "00.000.000/0000-00";
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            BuscarCEP();
        }

        private void btnEndereco_Click(object sender, EventArgs e)
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
