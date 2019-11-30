using BLL;
using DAL;
using System;
using System.Drawing;
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
            try
            {
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Produto bll = new BLL_Produto(con);
                dgvEstoqueBaixo.DataSource = bll.LocalizarEstoqueBaixo();
                FormatarDGV1(); //FORMATA O DATA GRID
                ContarLinhas1();
            }
            catch (Exception)
            {

            }
        }

        public void CarregarGrid2()
        {
            try
            {
                DateTime data1 = new DateTime();
                DateTime data2 = new DateTime();
                data1 = DateTime.Now;
                data2 = DateTime.Now;
                data2 = new DateTime(data2.Year, data2.Month, data2.Day);

                if (data2.Day == 26)
                {
                    data2 = new DateTime(data2.Year, data2.Month + 1, 1);
                }
                if (data2.Day == 27)
                {
                    data2 = new DateTime(data2.Year, data2.Month + 1, 2);
                }
                if (data2.Day == 28)
                {
                    data2 = new DateTime(data2.Year, data2.Month + 1, 3);
                }
                if (data2.Day == 29)
                {
                    data2 = new DateTime(data2.Year, data2.Month + 1, 4);
                }
                if (data2.Day == 30)
                {
                    data2 = new DateTime(data2.Year, data2.Month + 1, 5);
                }
                if (data2.Day == 31)
                {
                    data2 = new DateTime(data2.Year, data2.Month + 1, 6);
                }
                if (data2.Month == 13)
                {
                    data2 = new DateTime(data2.Year + 1,  1, data2.Day);
                }

                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_ParcelasVenda bll = new BLL_ParcelasVenda(con);
                dgvVencimento.DataSource = bll.LocalizarPertoVencimento(data1, data2);
                FormatarDGV2(); //FORMATA O DATA GRID
                ContarLinhas2();
            }
            catch (Exception)
            {

            }
        }

        private void FormatarDGV1()
        {
            dgvEstoqueBaixo.Columns[0].HeaderText = "Produto";
            dgvEstoqueBaixo.Columns[0].Width = 140;
            dgvEstoqueBaixo.Columns[1].HeaderText = "Quant.";
            dgvEstoqueBaixo.Columns[1].Width = 60;
            dgvEstoqueBaixo.CurrentRow.Selected = false;
        }

        //METODO CONTAR LINHAS
        private void ContarLinhas1()
        {
            int total = dgvEstoqueBaixo.Rows.Count;
            lblQtdTotal.Text = total.ToString();
        }
        
        private void FormatarDGV2()
        {
            dgvVencimento.Columns[0].HeaderText = "Pedido";
            dgvVencimento.Columns[0].Width = 55;
            dgvVencimento.Columns[1].HeaderText = "Vencimento";
            dgvVencimento.Columns[1].Width = 90;
            dgvVencimento.Columns[2].HeaderText = "Valor";
            dgvVencimento.Columns[2].Width = 55;
            dgvVencimento.Columns[3].Visible = false;
            dgvVencimento.CurrentRow.Selected = false;

            //inserir cor no fundo
            for (int i = 0; i < dgvVencimento.Rows.Count; i++)
            {
                string CampoPago = Convert.ToString(dgvVencimento.Rows[i].Cells[3].Value.ToString());

                if (CampoPago == "01/01/0001 00:00:00" && CampoPago != "")//a data que ele tras, nao deixa vazio
                {

                }
                else
                {
                    dgvVencimento.Rows[i].Cells[0].Style.BackColor = Color.Green;
                }
            }
        }

        //METODO CONTAR LINHAS
        private void ContarLinhas2()
        {
            int total = dgvVencimento.Rows.Count;
            lblQtdTotal2.Text = total.ToString();
        }
    }
}
