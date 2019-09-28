namespace SistemaVendas.Apresentacao.Cadastro
{
    partial class frm_CadEndereco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblrua = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCep = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(226, 126);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(37, 20);
            this.txtUf.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(33, 126);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(113, 20);
            this.txtCidade.TabIndex = 61;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(30, 110);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 60;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(33, 165);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(230, 20);
            this.txtBairro.TabIndex = 59;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(38, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 20);
            this.txtId.TabIndex = 58;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(33, 207);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(230, 20);
            this.txtRua.TabIndex = 57;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(30, 149);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 53;
            this.lblBairro.Text = "Bairro";
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.Location = new System.Drawing.Point(31, 191);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(27, 13);
            this.lblrua.TabIndex = 52;
            this.lblrua.Text = "Rua";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(30, 65);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(26, 13);
            this.lblCep.TabIndex = 51;
            this.lblCep.Text = "Cep";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(187, 260);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 65;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(33, 260);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 64;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnCep
            // 
            this.btnCep.Location = new System.Drawing.Point(118, 78);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(28, 23);
            this.btnCep.TabIndex = 71;
            this.btnCep.UseVisualStyleBackColor = true;
            this.btnCep.Click += new System.EventHandler(this.BtnCep_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(33, 80);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(75, 20);
            this.txtCep.TabIndex = 72;
            // 
            // frm_CadEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 307);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnCep);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblrua);
            this.Controls.Add(this.lblCep);
            this.Name = "frm_CadEndereco";
            this.Text = "frm_CadEndereco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        internal System.Windows.Forms.TextBox txtBairro;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblrua;
        private System.Windows.Forms.Label lblCep;
        internal System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.Button btnSalvar;
        internal System.Windows.Forms.Button btnCep;
        internal System.Windows.Forms.MaskedTextBox txtCep;
    }
}