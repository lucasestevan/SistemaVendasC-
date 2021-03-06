﻿using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_VisualizarItensVenda : Form
    {
        public frm_VisualizarItensVenda()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Frm_VisualizarItensVenda_Load(object sender, EventArgs e)
        {
            FormatarDGV();
        }

        //FORMATA O DATA GRID
        private void FormatarDGV()
        {
            dgvItensVenda.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvItensVenda.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvItensVenda.Columns[1].HeaderText = "Item";
            dgvItensVenda.Columns[1].Width = 160;
            dgvItensVenda.Columns[2].HeaderText = "Quant.";
            dgvItensVenda.Columns[2].Width = 80;
            dgvItensVenda.Columns[3].HeaderText = "Valor Unitario";
            dgvItensVenda.Columns[3].Width = 120;
            dgvItensVenda.Columns[4].Visible = false; //idCompra
            dgvItensVenda.Columns[5].Visible = false; // idproduto


            dgvParcelasVenda.Columns[0].HeaderText = "Parcela";
            dgvParcelasVenda.Columns[0].Width = 70;
            dgvParcelasVenda.Columns[1].HeaderText = "Valor";
            dgvParcelasVenda.Columns[1].Width = 70;
            dgvParcelasVenda.Columns[2].HeaderText = "Data Pagto.";
            dgvParcelasVenda.Columns[2].Width = 120;
            dgvParcelasVenda.Columns[3].HeaderText = "Data Vencimento";
            dgvParcelasVenda.Columns[3].Width = 140;
            dgvParcelasVenda.Columns[4].Visible = false; //idCompra

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
