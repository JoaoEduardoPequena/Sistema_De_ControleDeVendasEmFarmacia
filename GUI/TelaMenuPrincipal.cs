using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TelaMenuPrincipal : Form
    {
        public string nome_usuario;
        int codigo_funcionario;
        
        public TelaMenuPrincipal( String usuarioLogado, int cod_func)
        {
            InitializeComponent();

            nome_usuario = usuarioLogado.ToUpper();
            toolStripStatus_UsuarioLogado.Text = nome_usuario;
            codigo_funcionario = cod_func;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;

            lblDataHora.Text = "DATA:"    +dataHora.ToLongDateString().ToUpper() + "\nHORA:"    +dataHora.ToLongTimeString().ToUpper();
        }

        private void TelaMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaCadastroProdutos frmTelaCadastroProdutos = new FrmTelaCadastroProdutos();
            frmTelaCadastroProdutos.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaCadastroFornecedores frmTelaCadastroFornecedores = new FrmTelaCadastroFornecedores();
            frmTelaCadastroFornecedores.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaDeVendas frmTelaDeVendas = new FrmTelaDeVendas(toolStripStatus_UsuarioLogado.Text,codigo_funcionario);
            frmTelaDeVendas.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionarios frmCadastroFuncionarios = new FrmCadastroFuncionarios();
            frmCadastroFuncionarios.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
