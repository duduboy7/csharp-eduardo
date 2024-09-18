using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CRUD.Classes
{
    class Conexao
    {
        #region "Variáveis"

        private static string _servidor = @"VPR0576602W10-1";
        private static string _baseDeDados = "pessoas";
        private static string _usuario = "sa";
        private static string _senha = "123456";

        //Linha de conexão para o SQL Server com usuário e senha
        //private static string _strConexao = "Data Source=" + _servidor + ";Initial Catalog=" + _baseDeDados + ";User ID=" + _usuario + ";Password=" + _senha;

        //Linha de conexão para o SQL Server com autenticação do Windows
        private static string _strConexao = "Data Souce=" + _servidor + ";Initial Catalog=" + _baseDeDados + ";Integrated Security=True";

        public string query;
        public SqlConnection conexao = new SqlConnection(_strConexao);
        public SqlCommand comando;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataSet ds;

        #endregion


        #region "Métodos"

        public void AbreConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            conexao.Open();
        }

        public void FechaConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        #endregion
    }
}
