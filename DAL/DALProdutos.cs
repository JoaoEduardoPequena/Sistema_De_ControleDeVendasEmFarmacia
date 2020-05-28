using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Collections;


using MySql.Data.MySqlClient;

using MODELO;


namespace DAL
{
    public class DALProdutos
    {
        public void Inserir( ModeloProdutos modeloProdutos ) 
        {
            MySqlConnection mySqlConnection = new MySqlConnection();  
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.CommandText = "SP_INSERIR_TBPRODUTOS";
               
                mySqlCommand.Parameters.AddWithValue("@cod_forn", modeloProdutos.cod_forn);
                mySqlCommand.Parameters.AddWithValue("@cod_cat", modeloProdutos.cod_cat);
                mySqlCommand.Parameters.AddWithValue("@cod_barra", modeloProdutos.cod_barra);
                mySqlCommand.Parameters.AddWithValue("@nome_prod", modeloProdutos.nome_prod);
                mySqlCommand.Parameters.AddWithValue("@data_fabricao", modeloProdutos.data_fabricao);
                mySqlCommand.Parameters.AddWithValue("@data_expiracao", modeloProdutos.data_expiracao);
                mySqlCommand.Parameters.AddWithValue("@peso",modeloProdutos.peso);
                mySqlCommand.Parameters.AddWithValue("@preco",modeloProdutos.preco);
                mySqlCommand.Parameters.AddWithValue("@quant_estoque", modeloProdutos.quant_estoque);
                mySqlCommand.Parameters.AddWithValue("@descricao",modeloProdutos.descricao);

                modeloProdutos.cod_prod = Convert.ToInt32(mySqlCommand.ExecuteScalar());
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                mySqlConnection.Close();
            }
        }

        public ModeloProdutos CarregaModeloProdutos(int Codigo)
        {
            ModeloProdutos modeloProdutos = new ModeloProdutos();

            MySqlDataReader mySqlDataReader=null;

            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.CommandText = "SP_PesquisarProdutos_Por_Codigo";

                mySqlCommand.Parameters.AddWithValue("@Codigo_Prod",Codigo);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    mySqlDataReader.Read();
                   
                    modeloProdutos.cod_prod = Convert.ToInt32(mySqlDataReader["cod_prod"]);
                    modeloProdutos.cod_forn = Convert.ToInt32(mySqlDataReader["cod_forn"]);
                    modeloProdutos.cod_cat = Convert.ToInt32(mySqlDataReader["cod_cat"]);
                    modeloProdutos.cod_barra = Convert.ToString(mySqlDataReader["cod_barra"]);
                    modeloProdutos.nome_prod = Convert.ToString(mySqlDataReader["nome_prod"]);
                    modeloProdutos.data_fabricao = Convert.ToDateTime(mySqlDataReader["data_fabricao"]);
                    modeloProdutos.data_expiracao = Convert.ToDateTime(mySqlDataReader["data_expiracao"]);
                    modeloProdutos.peso = Convert.ToString(mySqlDataReader["peso"]);
                    modeloProdutos.preco = Convert.ToDecimal(mySqlDataReader["preco"]);
                    modeloProdutos.quant_estoque = Convert.ToInt32(mySqlDataReader["quant_estoque"]);
                    modeloProdutos.descricao = Convert.ToString(mySqlDataReader["descricao"]);
                }

                else
                {
                  MessageBox.Show("O Código Do Produto Informado Não Existe");
                }
  
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                mySqlConnection.Close();
                mySqlDataReader.Close();
            }

            return modeloProdutos;
        }

        public DataTable ListarTodosProdutos()
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            DataTable dataTable = new DataTable();

            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.CommandText = "SP_ListarTodosProdutos";// Nome Do Procedimento Armazenado

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                mySqlDataAdapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("AVISO", "Erro ao Tentar Listar Dados De Produtos.Datalhes:" + ex.Message.ToString());
            }

            finally
            {
                mySqlConnection.Close();
            }

            return dataTable;
        }
    }
}
