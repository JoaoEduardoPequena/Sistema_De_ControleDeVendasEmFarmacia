using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MODELO;

using BLL;

namespace GUI
{
    public partial class FrmTelaCadastroProdutos : Form
    {
        BLLCategoriaProduto bllCategoriaProduto = new BLLCategoriaProduto();

        BLLProdutos bllProdutos = new BLLProdutos();

        BLLFornecedores bllFornecedores = new BLLFornecedores();

        ModeloFornecedores modeloFornecedor = new ModeloFornecedores();

        ModeloProdutos modeloProdutos = new ModeloProdutos();

        public FrmTelaCadastroProdutos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();

            comboBox1.DataSource = bllCategoriaProduto.ListaTodasCategoriasProdutos();
            comboBox1.ValueMember = "cod_cat";
            comboBox1.DisplayMember = "nome_cat";
        }


        private void ActualizarDataGrid() 
        {
           dgvAlunos.DataSource = bllProdutos.ListaTodosProdutos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            modeloProdutos.cod_forn = int.Parse(txtCodFornecedor.Text);
            modeloProdutos.cod_cat = int.Parse(comboBox1.SelectedValue.ToString());
            modeloProdutos.cod_barra = Convert.ToString(txtCodBarras.Text);
            modeloProdutos.nome_prod = txtNomeProduto.Text;
            modeloProdutos.data_fabricao = Convert.ToDateTime(dtDataFabricaoa.Value.ToString("dd/MM/yyyy"));
            modeloProdutos.data_expiracao = Convert.ToDateTime(dtDataExpiracao.Value.ToString("dd/MM/yyyy"));
            modeloProdutos.peso = txtPesoProduto.Text;
            modeloProdutos.preco = decimal.Parse(txtPreco.Text);
            modeloProdutos.quant_estoque = int.Parse(txtQtdeEstoque.Text);
            modeloProdutos.descricao= txtDescricao.Text;

            bllProdutos.InserirProdutos(modeloProdutos);

            txtCodProduto.Text = Convert.ToString(modeloProdutos.cod_prod);
            ActualizarDataGrid();
            MessageBox.Show("Dados Inseridos Com Sucesso");
         
        }

        private void btLocalizarFornecedores_Click_1(object sender, EventArgs e)
        {
            FrmTelaCadastroFornecedores f = new FrmTelaCadastroFornecedores();

            f.ShowDialog();

            if( f.codigo !=0)
            {
                txtCodFornecedor.Text = f.codigo.ToString();
                txtCodFornecedor_Leave(sender, e);
            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (txtCodFornecedor.Text != "")
            {
                modeloFornecedor = bllFornecedores.LocalizarFornecdoresPorCodigoBLL(int.Parse(txtCodFornecedor.Text));
                txtCodFornecedor.Text = modeloFornecedor.cod_forn.ToString();
                lblNomeFornecedor.Text = modeloFornecedor.nome_forn.ToString();
            }

            else if( txtCodFornecedor.Text == "")
            {
                lblNomeFornecedor.Text = "Informe o Código do Fornecedor ou Clica em Localizar";
            }
        }
            
    }
}
