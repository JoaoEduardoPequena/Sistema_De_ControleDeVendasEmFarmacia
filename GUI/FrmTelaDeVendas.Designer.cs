namespace GUI
{
    partial class FrmTelaDeVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.dgvItensVendas = new System.Windows.Forms.DataGridView();
            this.cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_DataVenda = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboFormaDePagamento = new System.Windows.Forms.ComboBox();
            this.txtTotalVendas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btFinalizarVendas = new System.Windows.Forms.Button();
            this.btImprimirFactura = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroVendas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtCodProduto.Location = new System.Drawing.Point(412, 43);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(94, 20);
            this.txtCodProduto.TabIndex = 1;
            this.txtCodProduto.MouseLeave += new System.EventHandler(this.txtCodProduto_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(528, 43);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(317, 20);
            this.txtNomeProduto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(600, 100);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(68, 20);
            this.txtQuantidade.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço Unitário";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(681, 101);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.ReadOnly = true;
            this.txtPrecoUnitario.Size = new System.Drawing.Size(71, 20);
            this.txtPrecoUnitario.TabIndex = 8;
            // 
            // dgvItensVendas
            // 
            this.dgvItensVendas.AllowUserToAddRows = false;
            this.dgvItensVendas.AllowUserToDeleteRows = false;
            this.dgvItensVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prod,
            this.nome_prod,
            this.Quantidade,
            this.preco_unitario,
            this.valor_total});
            this.dgvItensVendas.Location = new System.Drawing.Point(33, 138);
            this.dgvItensVendas.Name = "dgvItensVendas";
            this.dgvItensVendas.ReadOnly = true;
            this.dgvItensVendas.RowHeadersVisible = false;
            this.dgvItensVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensVendas.Size = new System.Drawing.Size(559, 249);
            this.dgvItensVendas.TabIndex = 10;
            this.dgvItensVendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cod_prod
            // 
            this.cod_prod.DataPropertyName = "cod_prod";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.cod_prod.DefaultCellStyle = dataGridViewCellStyle1;
            this.cod_prod.HeaderText = "CÓDIGO";
            this.cod_prod.Name = "cod_prod";
            this.cod_prod.ReadOnly = true;
            this.cod_prod.Width = 55;
            // 
            // nome_prod
            // 
            this.nome_prod.DataPropertyName = "nome_prod";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nome_prod.DefaultCellStyle = dataGridViewCellStyle2;
            this.nome_prod.HeaderText = "PRODUTO";
            this.nome_prod.Name = "nome_prod";
            this.nome_prod.ReadOnly = true;
            this.nome_prod.Width = 250;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantidade.HeaderText = "QUANTIDADE";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 83;
            // 
            // preco_unitario
            // 
            this.preco_unitario.DataPropertyName = "preco_unitario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.preco_unitario.DefaultCellStyle = dataGridViewCellStyle4;
            this.preco_unitario.HeaderText = "PREÇO";
            this.preco_unitario.Name = "preco_unitario";
            this.preco_unitario.ReadOnly = true;
            this.preco_unitario.Width = 50;
            // 
            // valor_total
            // 
            this.valor_total.DataPropertyName = "valor_total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.valor_total.DefaultCellStyle = dataGridViewCellStyle5;
            this.valor_total.HeaderText = "VALOR TOTAL";
            this.valor_total.Name = "valor_total";
            this.valor_total.ReadOnly = true;
            this.valor_total.Width = 120;
            // 
            // dt_DataVenda
            // 
            this.dt_DataVenda.CustomFormat = "dd/MM/yyyy";
            this.dt_DataVenda.Enabled = false;
            this.dt_DataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DataVenda.Location = new System.Drawing.Point(760, 100);
            this.dt_DataVenda.Name = "dt_DataVenda";
            this.dt_DataVenda.Size = new System.Drawing.Size(82, 20);
            this.dt_DataVenda.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(761, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data da Venda";
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdicionarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdicionarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarProduto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btAdicionarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdicionarProduto.Location = new System.Drawing.Point(667, 133);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(95, 55);
            this.btAdicionarProduto.TabIndex = 13;
            this.btAdicionarProduto.Text = "Adicionar Produto";
            this.btAdicionarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome do Usuário";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(411, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Seleccionar a Forma de Pagamento";
            // 
            // cboFormaDePagamento
            // 
            this.cboFormaDePagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboFormaDePagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFormaDePagamento.FormattingEnabled = true;
            this.cboFormaDePagamento.Location = new System.Drawing.Point(414, 101);
            this.cboFormaDePagamento.Name = "cboFormaDePagamento";
            this.cboFormaDePagamento.Size = new System.Drawing.Size(168, 21);
            this.cboFormaDePagamento.Sorted = true;
            this.cboFormaDePagamento.TabIndex = 16;
            // 
            // txtTotalVendas
            // 
            this.txtTotalVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVendas.ForeColor = System.Drawing.Color.White;
            this.txtTotalVendas.Location = new System.Drawing.Point(441, 393);
            this.txtTotalVendas.Name = "txtTotalVendas";
            this.txtTotalVendas.ReadOnly = true;
            this.txtTotalVendas.Size = new System.Drawing.Size(100, 26);
            this.txtTotalVendas.TabIndex = 18;
            this.txtTotalVendas.Text = "00,0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(301, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total  da Venda";
            // 
            // btFinalizarVendas
            // 
            this.btFinalizarVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFinalizarVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFinalizarVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btFinalizarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizarVendas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btFinalizarVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btFinalizarVendas.Location = new System.Drawing.Point(667, 192);
            this.btFinalizarVendas.Name = "btFinalizarVendas";
            this.btFinalizarVendas.Size = new System.Drawing.Size(95, 55);
            this.btFinalizarVendas.TabIndex = 21;
            this.btFinalizarVendas.Text = "Finalizar Vendas";
            this.btFinalizarVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btFinalizarVendas.UseVisualStyleBackColor = true;
            this.btFinalizarVendas.Click += new System.EventHandler(this.btFinalizarVendas_Click);
            // 
            // btImprimirFactura
            // 
            this.btImprimirFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimirFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimirFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimirFactura.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btImprimirFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btImprimirFactura.Location = new System.Drawing.Point(667, 252);
            this.btImprimirFactura.Name = "btImprimirFactura";
            this.btImprimirFactura.Size = new System.Drawing.Size(95, 55);
            this.btImprimirFactura.TabIndex = 22;
            this.btImprimirFactura.Text = "Imprimir Factura";
            this.btImprimirFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btImprimirFactura.UseVisualStyleBackColor = true;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(14, 43);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.ReadOnly = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(168, 20);
            this.txtNomeUsuario.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodFuncionario);
            this.groupBox1.Controls.Add(this.txtNomeUsuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 76);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FUNCIONÁRIO";
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Location = new System.Drawing.Point(106, 23);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(110, 13);
            this.lblCodFuncionario.TabIndex = 27;
            this.lblCodFuncionario.Text = "CÓD. FUNCIONARIO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(67, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(544, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "A KZ";
            // 
            // txtNumeroVendas
            // 
            this.txtNumeroVendas.Location = new System.Drawing.Point(332, 38);
            this.txtNumeroVendas.Name = "txtNumeroVendas";
            this.txtNumeroVendas.ReadOnly = true;
            this.txtNumeroVendas.Size = new System.Drawing.Size(50, 20);
            this.txtNumeroVendas.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(258, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Venda Nº";
            // 
            // FrmTelaDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(804, 428);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNumeroVendas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btImprimirFactura);
            this.Controls.Add(this.btFinalizarVendas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalVendas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboFormaDePagamento);
            this.Controls.Add(this.btAdicionarProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_DataVenda);
            this.Controls.Add(this.dgvItensVendas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodProduto);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmTelaDeVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela De Vendas";
            this.Load += new System.EventHandler(this.FrmTelaDeVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.DataGridView dgvItensVendas;
        private System.Windows.Forms.DateTimePicker dt_DataVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAdicionarProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFormaDePagamento;
        private System.Windows.Forms.TextBox txtTotalVendas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btFinalizarVendas;
        private System.Windows.Forms.Button btImprimirFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCodFuncionario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroVendas;
        private System.Windows.Forms.Label label12;
    }
}