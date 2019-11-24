using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Impressao
{
    public partial class frm_ImpressaoVenda : Form
    {
        public frm_ImpressaoVenda()
        {
            InitializeComponent();
        }

        public string pedido = "";
        public string data = "";
        public string cliente = "";
        public string cpf = "";
        public string endereco = "";
        public string itens = "";
        public string status = "";
        public string total = "";
        public string parcelas = "";
        public string telefone = "";
        public string celular = "";
        public string bairro = "";
        public string cidade = "";
        public string Nendereco = "";

        private void frm_ImpressaoVenda_Load(object sender, EventArgs e)
        {
            //CRIAR PARAMETROS E PEGAR OQUE ESTA NO ESTATICO PARA JOGAR NA TELA DE IMPRESSAO
            ReportParameterCollection reportVenda = new ReportParameterCollection();
            reportVenda.Add(new ReportParameter("Pedido", this.pedido));
            reportVenda.Add(new ReportParameter("DataVenda", this.data));
            reportVenda.Add(new ReportParameter("Cliente", this.cliente));
            reportVenda.Add(new ReportParameter("CPF", this.cpf));
            reportVenda.Add(new ReportParameter("Endereco", this.endereco));
            reportVenda.Add(new ReportParameter("Itens", this.itens));
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
