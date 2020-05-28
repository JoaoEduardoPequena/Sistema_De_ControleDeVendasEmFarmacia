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
    public class DALVendas
    {
        ModeloVendas modeloVendas = new ModeloVendas();

        ModeloProdutos modeloProduros = new ModeloProdutos();

        public void Inserir(ModeloVendas modeloVendas)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                
                // Código Para Inserir Na tabela de Vendas
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandType = CommandType.Text;
                mySqlCommand.CommandText = "INSERT INTO tb_Vendas(cod_func,cod_formaPgto,data_venda,total_venda,estado) VALUES(@cod_func,@cod_formaPgto,@data_venda,@total_venda,@estado); Select @@Identity;";

                mySqlConnection.Open(); // Abre a Conexão

                mySqlCommand.Parameters.AddWithValue("@cod_func",modeloVendas.cod_func);
                mySqlCommand.Parameters.AddWithValue("@cod_formaPgto",modeloVendas.cod_formaPgto);
                mySqlCommand.Parameters.AddWithValue("@cod_prod", modeloProduros.cod_prod);
                mySqlCommand.Parameters.AddWithValue("@quant_estoque", modeloProduros.quant_estoque);
                
                mySqlCommand.Parameters.Add("@data_venda", MySqlDbType.DateTime);
                mySqlCommand.Parameters["@data_venda"].Value = modeloVendas.data_venda;

                mySqlCommand.Parameters.AddWithValue("@total_venda", modeloVendas.total_venda);
                mySqlCommand.Parameters.AddWithValue("@estado",modeloVendas.estado_venda);

                modeloVendas.cod_venda = Convert.ToInt32(mySqlCommand.ExecuteScalar()); //Comando Para Inserir Na tabela de Vendas
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

        public ModeloVendas CarregaModeloVendas()
        {
            MySqlDataReader mySqlDataReader = null;

            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.CommandText = "   ";

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    mySqlDataReader.Read();

                    modeloVendas.cod_venda = Convert.ToInt32(mySqlDataReader["cod_venda"]);
                    modeloVendas.cod_func = Convert.ToInt32(mySqlDataReader["cod_func"]);
                    modeloVendas.cod_formaPgto = Convert.ToInt32(mySqlDataReader["cod_formaPgto"]);
                    modeloVendas.data_venda = Convert.ToDateTime(mySqlDataReader["data_venda"]);
                    modeloVendas.estado_venda = Convert.ToString(mySqlDataReader["estado_venda"]);
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

            return modeloVendas;
        }

        public DataTable GerarCodigoVendas()
        { 
          DataTable dataTable = new DataTable();
          MySqlConnection mySqlConnection = new MySqlConnection();
          try
          {
              mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
              mySqlConnection.Open();

              MySqlCommand mySqlCommand = new MySqlCommand();
              mySqlCommand.Connection = mySqlConnection;
              mySqlCommand.CommandType = CommandType.Text;
              //mySqlCommand.CommandText = "SP_GERAR_CODIGO_VENDAS"; // Nome Do Procedimento Armazenado
   
              mySqlCommand.CommandText = "SELECT MAX(cod_venda) FROM tb_vendas";
              MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
              mySqlDataAdapter.SelectCommand = mySqlCommand;
              mySqlDataAdapter.Fill(dataTable);
          }
          catch (Exception)
          {

              throw;
          }

          finally 
          {
              mySqlConnection.Close();
          }
          
          return dataTable;
        }

    }
}
