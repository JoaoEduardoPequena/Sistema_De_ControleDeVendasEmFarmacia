using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using MODELO;
using System.Windows.Forms;
using System.Data;

namespace DAL
{
    public class DALItensVendas
    {
        public void Inserir(ModeloItemVendas modeloItemVendas)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.CommandText = "SP_INSERIR_ITENSVENDAS";

                mySqlCommand.Parameters.AddWithValue("@cod_prod",modeloItemVendas.cod_prod);
                mySqlCommand.Parameters.AddWithValue("@cod_venda",modeloItemVendas.cod_venda);
                mySqlCommand.Parameters.AddWithValue("@quantidade",modeloItemVendas.quantidade);
                mySqlCommand.Parameters.AddWithValue("@preco_unitario",modeloItemVendas.preco_unitario);
                mySqlCommand.Parameters.AddWithValue("@valor_total",modeloItemVendas.valor_total);

                modeloItemVendas.cod_venda = Convert.ToInt32(mySqlCommand.ExecuteScalar());

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

        public ModeloItemVendas CarregaModeloItemVendas( )
        {
            ModeloItemVendas modeloItemVendas = new ModeloItemVendas();
            
            MySqlDataReader mySqlDataReader = null;

            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.CommandText = "SP_ListarTodos_ItensVendas";

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    mySqlDataReader.Read();

                    modeloItemVendas.cod_prod = Convert.ToInt32(mySqlDataReader["cod_prod"]);
                    modeloItemVendas.cod_venda= Convert.ToInt32(mySqlDataReader["cod_venda"]);
                    modeloItemVendas.quantidade = Convert.ToInt32(mySqlDataReader["quantidade"]);
                    modeloItemVendas.preco_unitario = Convert.ToDecimal(mySqlDataReader["preco_unitario"]);
                    modeloItemVendas.valor_total = Convert.ToDecimal(mySqlDataReader["valor_total"]);
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

            return modeloItemVendas;
        }

    }
}
