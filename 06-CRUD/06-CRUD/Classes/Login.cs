using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CRUD.Classes
{
    public class Login
    {
        #region "Variáveis"

        private int _id_usuario;
        private string _nome;
        private string _email;
        private string _login;
        private string _senha;
        private string _frase_seguranca;
        private int _nivel;
        private int _ativo;

        #endregion


        #region "Propriedades"

        public int Id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Logins
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public string Frase_seguranca
        {
            get { return _frase_seguranca; }
            set { _frase_seguranca = value; }
        }

        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        public int Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

        #endregion


        #region "Construtores"

        //Construtor padrão
        public Login()
        {
            Id_usuario = 0;
            Nome = string.Empty;
            Email = string.Empty;
            Logins = string.Empty;
            Senha = string.Empty;
            Frase_seguranca = string.Empty;
            Nivel = 0;
            Ativo = 0;
        }

        //Construtor para Efetuar o Login
        public Login(int id_usuario, string nome, string email, string login, string senha, string frase_seguranca, int nivel, int ativo)
        {
            Id_usuario = id_usuario;
            Nome = nome;
            Email = email;
            Logins = login;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
            Nivel = nivel;
            Ativo = ativo;
        }

        //Construtor para inserir usuário
        public Login(string nome, string email, string login, string senha, string frase_seguranca, int nivel, int ativo)
        {
            Nome = nome;
            Email = email;
            Logins = login;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
            Nivel = nivel;
            Ativo = ativo;
        }

        //Construtor para alterar usuário
        public Login(int id_usuario, string nome, string email, string login, int nivel)
        {
            Id_usuario = id_usuario;
            Nome = nome;
            Email = email;
            Logins = login;
            Nivel = nivel;
        }

        //Construtor para ativar/desativar usuário
        public Login(int id_usuario, int ativo)
        {
            Id_usuario = id_usuario;
            Ativo = ativo;
        }

        //Construtor para alterar a senha do usuário
        public Login(int id_usuario, string senha, string frase_seguranca)
        {
            Id_usuario = id_usuario;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
        }

        #endregion


        #region "Métodos"

        //Método para efetuar o login
        public static void RealizarLogin(string login, string senha)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_usuarios WHERE login = '" + login + "'";
                cn.comando = new SqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
