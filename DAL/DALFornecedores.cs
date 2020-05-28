using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using MODELO;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALFornecedores
    {
        
        public void Inserir( ModeloFornecedores modeloFornecedores ) 
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.CommandText = "SP_INSERIR_FORNECEDORES";

                mySqlCommand.Parameters.AddWithValue("@nome_forn",modeloFornecedores.nome_forn);
                mySqlCommand.Parameters.AddWithValue("@telefone_forn",modeloFornecedores.telefone_forn);
                mySqlCommand.Parameters.AddWithValue("@email_forn",modeloFornecedores.email_forn);
                mySqlCommand.Parameters.AddWithValue("@endereco",modeloFornecedores.endereco_forn);
              
                modeloFornecedores.cod_forn = Convert.ToInt32(mySqlCommand.ExecuteScalar());

            }

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            finally
            {
                mySqlConnection.Close();
            }

        }

        public DataTable ListaDeFornecedores()
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
                mySqlCommand.CommandText = "SP_ListarTodosFornecedores";// Nome Do Procedimento Armazenado

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                mySqlDataAdapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("AVISO", "Erro ao Tentar Listar Dados De Fornecedores.Datalhes: " + ex.Message.ToString());
            }

            finally
            {
                mySqlConnection.Close();
            }

            return dataTable;
        }

        public ModeloFornecedores CarregarModeloFornecedores (int  Codigo)
        {
           ModeloFornecedores modeloFornecedores = new ModeloFornecedores();
           MySqlDataReader mySqlDataReader = null;
           MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();
                
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.CommandText = "SP_PesquisarFornecedores_Por_Codigo";
                mySqlCommand.Parameters.AddWithValue("@Codigo_Forn",Codigo);

                mySqlDataReader  = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    mySqlDataReader.Read();
                  
                    modeloFornecedores.cod_forn = Convert.ToInt32(mySqlDataReader["cod_forn"]);
                    modeloFornecedores.nome_forn = Convert.ToString(mySqlDataReader["nome_forn"]);
                    modeloFornecedores.telefone_forn= Convert.ToString(mySqlDataReader["telefone_forn"]);
                    modeloFornecedores.email_forn = Convert.ToString((mySqlDataReader["email_forn"]));
                    modeloFornecedores.endereco_forn = Convert.ToString(mySqlDataReader["endereco"]);
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

            return modeloFornecedores;
        }

    }
}
