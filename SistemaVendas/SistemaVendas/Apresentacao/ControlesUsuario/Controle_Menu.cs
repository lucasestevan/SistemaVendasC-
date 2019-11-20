using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    public partial class Controle_Menu1 : UserControl
    {
        public Controle_Menu1()
        {
            InitializeComponent();
        }

        private void Controle_Menu1_Load(object sender, EventArgs e)
        {
            CarregarGrid1();
            CarregarGrid2();
        }

        public void CarregarGrid1()
        {
            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
            BLL_Produto bll = new BLL_Produto(con);
            dgvEstoqueBaixo.DataSource = bll.LocalizarEstoqueBaixo();
            FormatarDGV(); //FORMATA O DATA GRID
            ContarLinhas();
        }

        public void CarregarGrid2()
        {
            DateTime data1 = new DateTime();
            DateTime data2 = new DateTime();
            data1 = DateTime.Now;
            data2 = DateTime.Now;

            data2 = new DateTime(data2.Year, data2.Month, data2.Day + 5);

            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
            BLL_ParcelasVenda bll = new BLL_ParcelasVenda(con);
            dgvVencimento.DataSource = bll.LocalizarPertoVencimento(data1,data2);
            //FormatarDGV(); //FORMATA O DATA GRID
            //ContarLinhas();
        }


        private void FormatarDGV()
        {
            dgvEstoqueBaixo.Columns[0].HeaderText = "Produto";
            dgvEstoqueBaixo.Columns[0].Width = 140;
            dgvEstoqueBaixo.Columns[1].HeaderText = "Quant.";
            dgvEstoqueBaixo.Columns[1].Width = 60;
        }

        //METODO CONTAR LINHAS
        private void ContarLinhas()
        {
            int total = dgvEstoqueBaixo.Rows.Count;
            lblQtdTotal.Text = total.ToString();
        }

      
    }
}
