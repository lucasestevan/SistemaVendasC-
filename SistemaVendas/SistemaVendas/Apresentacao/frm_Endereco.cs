using BLL;
using DAL;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Endereco : Form
    {
        public int idEndereco = 0;

        public frm_Endereco()
        {
            InitializeComponent();
        }

      

        //botao pesquisar
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Endereco bll = new BLL_Endereco(con);
            dgvEndereco.DataSource = bll.Localizar(txtRua.Text);
            FormatarDGV(); //FORMATA O DATA GRID
        }

       

       

        //METODO FORMATAR DATA GRID
        private void FormatarDGV()
        {
            dgvEndereco.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvEndereco.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvEndereco.Columns[1].HeaderText = "Cep";
            dgvEndereco.Columns[1].Width = 60;
            dgvEndereco.Columns[2].HeaderText = "Rua";
            dgvEndereco.Columns[2].Width = 110;
            dgvEndereco.Columns[3].HeaderText = "Bairro";
            dgvEndereco.Columns[3].Width = 110;
            dgvEndereco.Columns[4].HeaderText = "Cidade";
            dgvEndereco.Columns[4].Width = 80;
            dgvEndereco.Columns[5].HeaderText = "UF";
            dgvEndereco.Columns[5].Width = 35;
        }

        //EVENTO AO CLIKAR NA GRID
        private void DgvEndereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //botao selecionar
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvEndereco.SelectedRows.Count > 0)
            {
                this.idEndereco = Convert.ToInt32(dgvEndereco.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
