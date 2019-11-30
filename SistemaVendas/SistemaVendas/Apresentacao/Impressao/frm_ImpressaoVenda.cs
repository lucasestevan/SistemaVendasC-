using BLL;
using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Impressao
{
    public partial class frm_ImpressaoVenda : Form
    {
        public frm_ImpressaoVenda()
        {
            InitializeComponent();
        }
        public class ItensVenda
        {
            public string Cod { get; set; }
            public string Nome { get; set; }
            public string Qtd { get; set; }
            public string Valoruni { get; set; }
        }

        public string pedido;
        public int idvenda;
        public string data;
        public string cliente;
        public string cpf;
        public string endereco;
        public string status;
        public string total;
        public string parcelas;
        public string telefone;
        public string celular;
        public string bairro;
        public string Nendereco;
        public string cidade;

        ReportDataSource rs = new ReportDataSource();

        private void frm_ImpressaoVenda_Load(object sender, EventArgs e)
        {
            List<ItensVenda> lista = new List<ItensVenda>();
            lista.Clear();

            //chamr modelo bll e dal venda
            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);

            ////itens da venda
            BLL_ItensVendas bllItens = new BLL_ItensVendas(con);
            DataTable tabela = bllItens.Localizar(idvenda);

            //jogar todos os itens na tela
            for (int i = 0; i < tabela.Rows.Count; i++)
            {

                lista.Add(new ItensVenda
                {
                    Cod = tabela.Rows[i]["id_produto"].ToString(),
                    Nome = tabela.Rows[i]["nome"].ToString(),
                    Qtd = tabela.Rows[i]["quantidade"].ToString(),
                    Valoruni = tabela.Rows[i]["valor"].ToString(),
                });

                rs.Name = "DataSet1";
                rs.Value = lista;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rs);
            }

            //CRIAR PARAMETROS E PEGAR OQUE ESTA NO ESTATICO PARA JOGAR NA TELA DE IMPRESSAO
            ReportParameterCollection reportVenda = new ReportParameterCollection();
            reportVenda.Add(new ReportParameter("Pedido", this.pedido));
            reportVenda.Add(new ReportParameter("DataVenda", this.data));
            reportVenda.Add(new ReportParameter("Cliente", this.cliente));
            reportVenda.Add(new ReportParameter("CPF", this.cpf));
            reportVenda.Add(new ReportParameter("Endereco", this.endereco));
            reportVenda.Add(new ReportParameter("Status", this.status));
            reportVenda.Add(new ReportParameter("Total", this.total));
            reportVenda.Add(new ReportParameter("Parcelas", this.parcelas));
            reportVenda.Add(new ReportParameter("Telefone", this.telefone));
            reportVenda.Add(new ReportParameter("Celular", this.celular));
            reportVenda.Add(new ReportParameter("Bairro", this.bairro));
            reportVenda.Add(new ReportParameter("Cidade", this.cidade));
            reportVenda.Add(new ReportParameter("Nendereco", this.Nendereco));

            this.reportViewer1.LocalReport.SetParameters(reportVenda);

            this.reportViewer1.RefreshReport();
        }

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
