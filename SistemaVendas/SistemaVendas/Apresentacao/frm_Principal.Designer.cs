namespace SistemaVendas
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPagto = new System.Windows.Forms.Button();
            this.pnAuxiliar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controle_Venda1 = new SistemaVendas.Apresentacao.ControlesUsuario.Controle_Venda();
            this.controle_Relatorio1 = new SistemaVendas.Apresentacao.ControlesUsuario.Controle_Relatorio();
            this.controle_Pagamento1 = new SistemaVendas.Apresentacao.ControlesUsuario.Controle_Pagamento();
            this.controle_Compra1 = new SistemaVendas.Apresentacao.ControlesUsuario.Controle_Compra();
            this.controle_Menu1 = new SistemaVendas.Apresentacao.ControlesUsuario.Controle_Menu1();
            this.controle_Cadastro1 = new SistemaVendas.Controle_Cadastro();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnPagto);
            this.panel1.Controls.Add(this.pnAuxiliar);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.btnCompras);
            this.panel1.Controls.Add(this.btnVendas);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 532);
            this.panel1.TabIndex = 0;
            // 
            // btnPagto
            // 
            this.btnPagto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagto.ForeColor = System.Drawing.Color.White;
            this.btnPagto.Image = ((System.Drawing.Image)(resources.GetObject("btnPagto.Image")));
            this.btnPagto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagto.Location = new System.Drawing.Point(12, 203);
            this.btnPagto.Name = "btnPagto";
            this.btnPagto.Size = new System.Drawing.Size(177, 54);
            this.btnPagto.TabIndex = 4;
            this.btnPagto.Text = "Pagamento";
            this.btnPagto.UseVisualStyleBackColor = true;
            this.btnPagto.Click += new System.EventHandler(this.btnPagto_Click);
            // 
            // pnAuxiliar
            // 
            this.pnAuxiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnAuxiliar.Location = new System.Drawing.Point(3, 23);
            this.pnAuxiliar.Name = "pnAuxiliar";
            this.pnAuxiliar.Size = new System.Drawing.Size(10, 54);
            this.pnAuxiliar.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(12, 487);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 33);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(12, 263);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(177, 54);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(12, 323);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(177, 54);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastros";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(12, 143);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(177, 54);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(12, 83);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(177, 54);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(12, 23);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(177, 54);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(189, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 26);
            this.panel2.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(579, 5);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(15, 15);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(604, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(236, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 95);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // controle_Venda1
            // 
            this.controle_Venda1.Location = new System.Drawing.Point(196, 124);
            this.controle_Venda1.Name = "controle_Venda1";
            this.controle_Venda1.Size = new System.Drawing.Size(613, 369);
            this.controle_Venda1.TabIndex = 8;
            // 
            // controle_Relatorio1
            // 
            this.controle_Relatorio1.Location = new System.Drawing.Point(196, 124);
            this.controle_Relatorio1.Name = "controle_Relatorio1";
            this.controle_Relatorio1.Size = new System.Drawing.Size(613, 369);
            this.controle_Relatorio1.TabIndex = 7;
            // 
            // controle_Pagamento1
            // 
            this.controle_Pagamento1.Location = new System.Drawing.Point(196, 124);
            this.controle_Pagamento1.Name = "controle_Pagamento1";
            this.controle_Pagamento1.Size = new System.Drawing.Size(613, 369);
            this.controle_Pagamento1.TabIndex = 6;
            // 
            // controle_Compra1
            // 
            this.controle_Compra1.Location = new System.Drawing.Point(196, 124);
            this.controle_Compra1.Name = "controle_Compra1";
            this.controle_Compra1.Size = new System.Drawing.Size(613, 369);
            this.controle_Compra1.TabIndex = 5;
            // 
            // controle_Menu1
            // 
            this.controle_Menu1.Location = new System.Drawing.Point(196, 124);
            this.controle_Menu1.Name = "controle_Menu1";
            this.controle_Menu1.Size = new System.Drawing.Size(613, 369);
            this.controle_Menu1.TabIndex = 4;
            // 
            // controle_Cadastro1
            // 
            this.controle_Cadastro1.Location = new System.Drawing.Point(195, 124);
            this.controle_Cadastro1.Name = "controle_Cadastro1";
            this.controle_Cadastro1.Size = new System.Drawing.Size(613, 369);
            this.controle_Cadastro1.TabIndex = 3;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 532);
            this.Controls.Add(this.controle_Venda1);
            this.Controls.Add(this.controle_Relatorio1);
            this.Controls.Add(this.controle_Pagamento1);
            this.Controls.Add(this.controle_Compra1);
            this.Controls.Add(this.controle_Menu1);
            this.Controls.Add(this.controle_Cadastro1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Principal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel pnAuxiliar;
        private System.Windows.Forms.Button btnPagto;
        private Controle_Cadastro controle_Cadastro1;
        private Apresentacao.ControlesUsuario.Controle_Menu1 controle_Menu1;
        private Apresentacao.ControlesUsuario.Controle_Compra controle_Compra1;
        private Apresentacao.ControlesUsuario.Controle_Pagamento controle_Pagamento1;
        private Apresentacao.ControlesUsuario.Controle_Relatorio controle_Relatorio1;
        private Apresentacao.ControlesUsuario.Controle_Venda controle_Venda1;
    }
}