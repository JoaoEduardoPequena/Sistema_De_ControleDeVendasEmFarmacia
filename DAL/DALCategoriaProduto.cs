using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALCategoriaProduto
    {

        public DataTable ListaCategoriaProdutos()
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
                mySqlCommand.CommandText = "SP_ListarTodasCategoriaProdutos";// Nome Do Procedimento Armazenado

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                mySqlDataAdapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("AVISO","Erro ao Tentar Listar Categorias de Produtos.Datalhes: " + ex.Message.ToString());
            }

            finally
            {
                mySqlConnection.Close();
            }

          return dataTable;
        }
    }
}
