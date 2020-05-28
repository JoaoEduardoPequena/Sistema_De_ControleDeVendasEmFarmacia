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
    public partial class FrmTelaCadastroFornecedores : Form
    {
        public int codigo;

        ModeloFornecedores modeloFornecedores = new ModeloFornecedores();

        BLLFornecedores bllFornecedores = new BLLFornecedores(); 

        public FrmTelaCadastroFornecedores()
        {
            InitializeComponent();
        }


        private void ActualizarDataGrid() 
        {
            dataGridView1.DataSource = bllFornecedores.ListarTodosFornecedores();
        }

        private void btSALAVAR_Click(object sender, EventArgs e)
        {
            modeloFornecedores.nome_forn = txtNomeFornecedores.Text;
            modeloFornecedores.telefone_forn = mskTelefFornecedores.Text;
            modeloFornecedores.email_forn = txtEmail.Text;
            modeloFornecedores.endereco_forn = txtEnderecoFornecedores.Text;

            bllFornecedores.InserirFornecedores(modeloFornecedores);

            txtCodFornecedores.Text = modeloFornecedores.cod_forn.ToString();
            ActualizarDataGrid();
            MessageBox.Show("Dados Inseridos Com Sucesso");
        }

        private void FrmTelaCadastroFornecedores_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>0)
            {
                codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Close();
            }
        }
    }
}
