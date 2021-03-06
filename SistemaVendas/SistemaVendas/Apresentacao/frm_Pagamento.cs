﻿using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Pagamento : Form
    {
        public int idVenda = 0;
        public double troco = 0;


        public frm_Pagamento()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (this.TotalTroco < 0)
            {

            }
            else
            {
                Finalizar();
            }
        }

        public void Finalizar()
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Venda modeloVenda = new Model_Venda();
                modeloVenda.DataVenda = DateTime.Now;
                modeloVenda.NFiscal = 0;
                modeloVenda.NParcelas = 0;
                modeloVenda.Total = Convert.ToDouble(lblTotal.Text);
                modeloVenda.IdCliente = 1;
                modeloVenda.IdTipoPagamento = 1;
                modeloVenda.Avista = 1;
                modeloVenda.VendaStatus = "PAGO VR";

                //OBJ PARA GRAVAR NO BANCO
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Venda bllVenda = new BLL_Venda(con);

                //CADASTRAR Venda
                bllVenda.Incluir(modeloVenda);
                this.idVenda = modeloVenda.IdVenda;

                MessageBox.Show("Venda realizada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Venda \n" + ex.Message);
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorPago.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0,00";
            }
        }

        public Decimal TotalTroco;
        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            if (txtValorPago.Text == "")
            {
                lblTroco.Text = this.troco.ToString();
            }

            try
            {
                if (txtValorPago.Text != "")
                {
                    this.TotalTroco = Convert.ToDecimal(txtValorPago.Text.Trim()) - Convert.ToDecimal(lblTotal.Text.Trim());
                    //FAZER QUE MINHA VARIAV EL TOTAL RECEBA O VALOR DO TOTAL LOCAL

                    lblTroco.Text = this.TotalTroco.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Informe apenas números!");
            }

            if (this.TotalTroco < 0)
            {
                btnFinalizar.Enabled = false;
            }
            else
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void txtValorPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtValorPago.ContainsFocus == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.TotalTroco < 0)
                    {

                    }
                    else
                    {
                        Finalizar();
                    }
                }
            }
        }

        private void frm_Pagamento_Load(object sender, EventArgs e)
        {
            if (txtValorPago.Text == "")
            {
                txtValorPago.Text = "0";
            }
        }
    }
}
