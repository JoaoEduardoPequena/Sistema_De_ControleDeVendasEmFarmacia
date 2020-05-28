namespace GUI
{
    partial class TelaMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenuPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus_UsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMENTAÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURAMENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATÓRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOSMAISVENDIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOSMENOSVENDIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINANÇASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDASAPAGADASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_UsuarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus_UsuarioLogado
            // 
            this.toolStripStatus_UsuarioLogado.Name = "toolStripStatus_UsuarioLogado";
            this.toolStripStatus_UsuarioLogado.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatus_UsuarioLogado.Text = "Usuário Logado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.mOVIMENTAÇÃOToolStripMenuItem,
            this.fACTURAMENTOToolStripMenuItem,
            this.rELATÓRIOToolStripMenuItem,
            this.fINANÇASToolStripMenuItem,
            this.vENDASAPAGADASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // mOVIMENTAÇÃOToolStripMenuItem
            // 
            this.mOVIMENTAÇÃOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.comprasToolStripMenuItem1});
            this.mOVIMENTAÇÃOToolStripMenuItem.Name = "mOVIMENTAÇÃOToolStripMenuItem";
            this.mOVIMENTAÇÃOToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.mOVIMENTAÇÃOToolStripMenuItem.Text = "MOVIMENTAÇÃO";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.comprasToolStripMenuItem1.Text = "Compras";
            // 
            // fACTURAMENTOToolStripMenuItem
            // 
            this.fACTURAMENTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem1});
            this.fACTURAMENTOToolStripMenuItem.Name = "fACTURAMENTOToolStripMenuItem";
            this.fACTURAMENTOToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.fACTURAMENTOToolStripMenuItem.Text = "FACTURAMENTO";
            // 
            // rELATÓRIOToolStripMenuItem
            // 
            this.rELATÓRIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRODUTOSMAISVENDIDOSToolStripMenuItem,
            this.pRODUTOSMENOSVENDIDOSToolStripMenuItem});
            this.rELATÓRIOToolStripMenuItem.Name = "rELATÓRIOToolStripMenuItem";
            this.rELATÓRIOToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.rELATÓRIOToolStripMenuItem.Text = "RELATÓRIO";
            // 
            // pRODUTOSMAISVENDIDOSToolStripMenuItem
            // 
            this.pRODUTOSMAISVENDIDOSToolStripMenuItem.Name = "pRODUTOSMAISVENDIDOSToolStripMenuItem";
            this.pRODUTOSMAISVENDIDOSToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.pRODUTOSMAISVENDIDOSToolStripMenuItem.Text = "Procurar Produtos Mais Vendidos";
            // 
            // pRODUTOSMENOSVENDIDOSToolStripMenuItem
            // 
            this.pRODUTOSMENOSVENDIDOSToolStripMenuItem.Name = "pRODUTOSMENOSVENDIDOSToolStripMenuItem";
            this.pRODUTOSMENOSVENDIDOSToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.pRODUTOSMENOSVENDIDOSToolStripMenuItem.Text = "Procurar Produtos Menos Vendidos";
            // 
            // fINANÇASToolStripMenuItem
            // 
            this.fINANÇASToolStripMenuItem.Name = "fINANÇASToolStripMenuItem";
            this.fINANÇASToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.fINANÇASToolStripMenuItem.Text = "FINANÇAS";
            // 
            // vENDASAPAGADASToolStripMenuItem
            // 
            this.vENDASAPAGADASToolStripMenuItem.Name = "vENDASAPAGADASToolStripMenuItem";
            this.vENDASAPAGADASToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.vENDASAPAGADASToolStripMenuItem.Text = "PROCURAR VENDAS APAGADAS";
            // 
            // lblDataHora
            // 
            this.lblDataHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.Blue;
            this.lblDataHora.Location = new System.Drawing.Point(501, 32);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(303, 85);
            this.lblDataHora.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // TelaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 369);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA DE MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaMenuPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIMENTAÇÃOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fACTURAMENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATÓRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINANÇASToolStripMenuItem;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_UsuarioLogado;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOSMAISVENDIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOSMENOSVENDIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDASAPAGADASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
    }
}