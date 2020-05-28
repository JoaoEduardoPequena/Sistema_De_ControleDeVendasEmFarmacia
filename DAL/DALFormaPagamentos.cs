using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODELO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace DAL
{
    public class DALFormaPagamentos
    {
        public DataTable ListarFormaPagamentos()
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
                mySqlCommand.CommandText = "SP_ListarTodasFormaPagamento";// Nome Do Procedimento Armazenado

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                mySqlDataAdapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("AVISO", "Erro ao Tentar Listar Dados de tipo de Pagamento.Datalhes: " + ex.Message.ToString());
            }

            finally
            {
                mySqlConnection.Close();
            }

            return dataTable;
        }
    }
}
