using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using MySql.Data.MySqlClient;

using MODELO;

using BLL;

namespace GUI
{
    public partial class FrmTelaDeVendas : Form
    {
        String vendedorLogado;

        int codigoFuncionarioVendedor;

        DialogResult resposta;

        decimal total_Venda = 0;

        int totalItens = 0;

        BLLFormaPagamentos bllFormaPagamentos = new BLLFormaPagamentos();

        BLLFuncionarios bllFuncionarios = new BLLFuncionarios();

        BLLProdutos bllProdutos = new BLLProdutos();

        BLL_ItensVendas bllItensVendas = new BLL_ItensVendas();

        ModeloItemVendas modeloItensVendas = new ModeloItemVendas();

        ModeloVendas modeloVendas = new ModeloVendas();
        BLLVendas bllVendas = new BLLVendas();

        
        public FrmTelaDeVendas( String logado, int cod_funcVendedor)
        {
            InitializeComponent();

            txtNomeUsuario.Text = logado;

            vendedorLogado = logado;
            codigoFuncionarioVendedor = cod_funcVendedor;
            lblCodFuncionario.Text = codigoFuncionarioVendedor.ToString();
        }

        private void LimparTela()
        {
            txtCodProduto.Clear();
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtPrecoUnitario.Clear();
        }

        private void ActualizarGrid()
        {
            
            
        }

        private void FrmTelaDeVendas_Load(object sender, EventArgs e)
        {
            
            //lblNumVendas.Text = Convert.ToString(GerarNumVendas());

            //comboBox1.DataSource = bllFuncionarios.PesquisarFuncionarioPorNomeUsuario(vlogado);
            //comboBox1.ValueMember = "cod_func";
            //comboBox1.DisplayMember = "usuario";

            //txtNomeUsuario.Text = bllFuncionarios.PesquisarFuncionarioPorNomeUsuario(vlogado).ToString();
            
            // Combox da forma de Pagamento
            cboFormaDePagamento.DataSource = bllFormaPagamentos.ListaTodasFormaPagamentos();
            cboFormaDePagamento.ValueMember = "cod_formaPgto";
            cboFormaDePagamento.DisplayMember = "formaPgto";
        }

        public DataTable GerarNumVendas()
        {
           DataTable dataTable = new DataTable();
           BLLVendas bllVendas = new BLLVendas();
           dataTable = bllVendas.BLLGerarCodigoVendas();
           return dataTable;
        }

        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            if ( txtCodProduto.Text!="" && txtNomeProduto.Text !="" && txtQuantidade.Text !="" && txtPrecoUnitario.Text!="" )
            {
                decimal total_Local = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtPrecoUnitario.Text);

                total_Venda = total_Venda + total_Local;

                String[] contador = new String[] { txtCodProduto.Text, txtNomeProduto.Text, txtQuantidade.Text, txtPrecoUnitario.Text, total_Local.ToString() };
                this.totalItens = this.totalItens + 1;

              // Adicionar linhas no data grid view ou seja, adicionar item do produto no data grid view
                this.dgvItensVendas.Rows.Add(contador); 

                LimparTela();
                label10.Text = totalItens.ToString();
                txtCodProduto.Focus();
                txtTotalVendas.Text = total_Venda.ToString();
            }

        }

        private void txtCodProduto_MouseLeave(object sender, EventArgs e)
        {
            ModeloProdutos modeloProdutos = new ModeloProdutos();

            if (txtCodProduto.Text != "")
            {
                modeloProdutos = bllProdutos.LocalizarProdutosPorCodigoBLL(int.Parse(txtCodProduto.Text));
                txtNomeProduto.Text = Convert.ToString(modeloProdutos.nome_prod);
                txtPrecoUnitario.Text = Convert.ToString(modeloProdutos.preco);
            }

            else if (txtCodProduto.Text == "")
            {
                LimparTela();
                txtCodProduto.Focus();
            }

        }

       // Botão Finalizar Venda
        private void btFinalizarVendas_Click(object sender, EventArgs e)
        {
            if (dgvItensVendas.Rows.Count != 0)// Antes de Finalizar Vendas Verifica Se no DataGridView Tem Linhas
            {
                resposta = MessageBox.Show("Tens Certeza Que Pretendes Finalizar Esta Venda?", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resposta == DialogResult.Yes)
                {
                    // Cadastrar as Vendas na tabela vendas
                    modeloVendas.cod_func = codigoFuncionarioVendedor;
                    modeloVendas.cod_formaPgto = Convert.ToInt32(cboFormaDePagamento.SelectedValue);
                    modeloVendas.data_venda = Convert.ToDateTime(dt_DataVenda.Value);
                    modeloVendas.total_venda = Convert.ToDecimal(txtTotalVendas.Text);
                    modeloVendas.estado_venda = "Válida";
                    bllVendas.InserirVendas(modeloVendas);

                    txtNumeroVendas.Text = Convert.ToString(modeloVendas.cod_venda);

                    // Cadastrar Itens de Vendas na tabela itens de vendas
                    for (int i = 0; i < dgvItensVendas.RowCount; i++)
                    {
                        modeloItensVendas.cod_prod = Convert.ToInt32(dgvItensVendas.Rows[i].Cells[0].Value);

                        modeloItensVendas.cod_venda = Convert.ToInt32(txtNumeroVendas.Text);

                        modeloItensVendas.quantidade = Convert.ToInt32(dgvItensVendas.Rows[i].Cells[2].Value);

                        modeloItensVendas.preco_unitario = Convert.ToDecimal(dgvItensVendas.Rows[i].Cells[3].Value);

                        modeloItensVendas.valor_total = Convert.ToDecimal(dgvItensVendas.Rows[i].Cells[4].Value);

                        bllItensVendas.BLLInserirItensVendas(modeloItensVendas);
                    }

                    txtTotalVendas.Text = "00,0";
                    dgvItensVendas.Rows.Clear();// Ao Finalizar A venda Apaga Todas Linhas do DataGridView (dgvItensVendas)

                    MessageBox.Show("VENDA EFECTUADA COM SUCESSO","INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }

            else if(resposta==DialogResult.No)
            {
                MessageBox.Show("OPERAÇÃO CANCELADA PELO UTILIZADOR","INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtCodProduto.Focus(); // Se a resposta do utilizador for não Coloca o foco no textbox txtCodProd
                return;
            }

            else
	        {
                MessageBox.Show("Não Existem Produtos Incluidos No DataGridView", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
	        }
            
        }

        // Codigo do evento Double Cell Click, quando clicado 2 vezes na célula remove o item do produto no data grid view
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tens Certeza Que Pretendes Remover Este Item da Venda?","PERGUNTA",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (resposta == DialogResult.Yes)
            {
                if (dgvItensVendas.SelectedRows.Count > 0)
                {
                    txtCodProduto.Text = dgvItensVendas.CurrentRow.Cells[0].Value.ToString();
                    txtNomeProduto.Text = dgvItensVendas.CurrentRow.Cells[1].Value.ToString();
                    txtQuantidade.Text = dgvItensVendas.CurrentRow.Cells[2].Value.ToString();
                    txtPrecoUnitario.Text = dgvItensVendas.CurrentRow.Cells[3].Value.ToString();

                    decimal valorTotal = Convert.ToDecimal(dgvItensVendas.CurrentRow.Cells[4].Value.ToString());

                    this.total_Venda = this.total_Venda - valorTotal;

                    dgvItensVendas.Rows.RemoveAt(e.RowIndex); // Código que vai remover a linha no datagrid quando usaurio dar um duplo clique na linha seleccionada
                    txtTotalVendas.Text = this.total_Venda.ToString();
                }

                else
                {
                    MessageBox.Show("Nenhuma Linha Seleccionada.Detalhe :Seleccionar Uma Linha Para Remover da Lista de Venda");
                }
            }

            else if ( resposta == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada Pelo Usuário", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

    }
}
