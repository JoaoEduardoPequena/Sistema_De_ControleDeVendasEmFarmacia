using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODELO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class DALFuncionarios
    {
        public void DALInserirFuncionarios( ModeloFuncionarios modeloFuncionarios)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;

                //mySqlCommand.CommandText = "SP_INSERIR_FUNCIONARIOS";
                //mySqlCommand.CommandType = CommandType.StoredProcedure;
                
                mySqlCommand.CommandType = CommandType.Text;
                
                mySqlCommand.CommandText = " INSERT INTO tb_funcionarios(nome_func,usuario,senha_func,funcao,telefone_func,email) VALUES(@nome_func,@usuario,@senha_func,@funcao,@telefone_func,@email)";
                mySqlCommand.Parameters.AddWithValue("@nome_func",modeloFuncionarios.nome_func);
                mySqlCommand.Parameters.AddWithValue("@usuario",modeloFuncionarios.usuario);
                mySqlCommand.Parameters.AddWithValue("@senha_func",modeloFuncionarios.senha_func);
                mySqlCommand.Parameters.AddWithValue("@funcao",modeloFuncionarios.funcao);
                mySqlCommand.Parameters.AddWithValue("@telefone_func",modeloFuncionarios.telefone_func);
                mySqlCommand.Parameters.AddWithValue("@email",modeloFuncionarios.email_func);

                modeloFuncionarios.cod_func = Convert.ToInt32(mySqlCommand.ExecuteScalar());

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


        public DataTable DALLListarTodosFuncionarios( )
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

                mySqlCommand.CommandText = "SP_ListarTodosFuncionarios";// Nome Do Procedimento Armazenado
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                mySqlDataAdapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
               MessageBox.Show("AVISO", "Erro ao Tentar Listar Dados do Funcionario.Datalhes: " + ex.Message.ToString());
            }

            finally
            {
                mySqlConnection.Close();
            }

            return dataTable;
        }


        public ModeloFuncionarios DALLoginFuncionarios(string nome_usuario, string senha_usuario)
        {
            ModeloFuncionarios modeloFuncionarios = new ModeloFuncionarios();
            MySqlDataReader mySqlDataReader = null;

            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection.ConnectionString = DadosDaConexao.StringDeConexao;
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.CommandText = "SELECT * FROM tb_funcionarios WHERE(usuario=@usuario AND senha_func=@senha_func)";
                mySqlCommand.CommandType = CommandType.Text;

                mySqlCommand.Parameters.AddWithValue("@usuario",nome_usuario);
                mySqlCommand.Parameters.AddWithValue("@senha_func",senha_usuario);

                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    mySqlDataReader.Read();

                    modeloFuncionarios.cod_func = Convert.ToInt32(mySqlDataReader["cod_func"]);
                    modeloFuncionarios.nome_func = Convert.ToString(mySqlDataReader["nome_func"]);
                    modeloFuncionarios.usuario = Convert.ToString(mySqlDataReader["usuario"]);
                    modeloFuncionarios.senha_func = Convert.ToString(mySqlDataReader["senha_func"]);
                    modeloFuncionarios.funcao = Convert.ToString(mySqlDataReader["funcao"]);
                    modeloFuncionarios.telefone_func = Convert.ToInt32(mySqlDataReader["telefone_func"]);
                    modeloFuncionarios.email_func = Convert.ToString(mySqlDataReader["email"]); 
                }
                

            }
            //catch (Exception)
            //{

            //}

            finally 
            {
               mySqlConnection.Close();
               //mySqlDataReader.Close();
            }

            return modeloFuncionarios;
        }
    }
}
