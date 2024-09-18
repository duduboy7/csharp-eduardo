using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEleitoral.Telas;

namespace projeto_urna_eleitoral.classes
{
    public class Login
    {
        #region "Variáveis"

        private int _id_admin;
        private string _nome;
        private string _email;
        private string _login;
        private string _senha;
        private string _frase_seguranca;
        private int _nivel;
        private int _ativo;

        #endregion


        #region "Propriedades"

        public int Id_admin
        {
            get { return _id_admin; }
            set { _id_admin = value; }
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
            Id_admin = 0;
            Nome = string.Empty;
            Email = string.Empty;
            Logins = string.Empty;
            Senha = string.Empty;
            Frase_seguranca = string.Empty;
            Nivel = 0;
            Ativo = 0;
        }

        //Construtor para Efetuar o Login
        public Login(int id_admin, string nome, string email, string login, string senha, string frase_seguranca, int nivel, int ativo)
        {
            Id_admin = id_admin;
            Nome = nome;
            Email = email;
            Logins = login;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
            Nivel = nivel;
            Ativo = ativo;
        }

        //Construtor para inserir um adm
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

        //Construtor para alterar um adm
        public Login(int id_admin, string nome, string email, string login, int nivel)
        {
            Id_admin = id_admin;
            Nome = nome;
            Email = email;
            Logins = login;
            Nivel = nivel;
        }

        //Construtor para ativar/desativar um adm
        public Login(int id_admin, int ativo)
        {
            Id_admin = id_admin;
            Ativo = ativo;
        }

        //Construtor para alterar a senha do adm
        public Login(int id_admin, string senha, string frase_seguranca)
        {
            Id_admin = id_admin;
            Senha = senha;
            Frase_seguranca = frase_seguranca;
        }




        #endregion

        #region "Métodos"

        //Método para efetuar o login
        public static void LoginAdm(string nome, string email)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_admin WHERE nome = '" + nome + "'";
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    Login usuarioLogado = new Login();
                    while (cn.dr.Read())
                    {
                        usuarioLogado = new Login(Convert.ToInt32(cn.dr["id_admin"]),
                                                  cn.dr["nome"].ToString(),
                                                  cn.dr["email"].ToString(),
                                                  cn.dr["login"].ToString(),
                                                  cn.dr["senha"].ToString(),
                                                  cn.dr["frase_seguranca"].ToString(),
                                                  Convert.ToInt32(cn.dr["nivel"]),
                                                  Convert.ToInt32(cn.dr["ativo"]));
                    }
                    if (usuarioLogado.Nivel == 1)
                    {
                        if (usuarioLogado.Email == email)
                        {
                            frmAdm TA = new frmAdm(usuarioLogado);
                            TA.ShowDialog();
                        }
                        else
                        {
                            throw new Exception("Senha inválida");
                        }
                    }
                    else
                    {
                        throw new Exception("Usuário bloqueado!");
                    }
                }
                else
                {
                    throw new Exception("Usuário não encontrado!");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FechaConexao();
            }
        }

        //Método para efetuar o login
        public static void RealizarLogin(string login, string senha)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_admin WHERE login = '" + login + "'";
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    Login usuarioLogado = new Login();
                    while (cn.dr.Read())
                    {
                        usuarioLogado = new Login(Convert.ToInt32(cn.dr["id_admin"]),
                                                  cn.dr["nome"].ToString(),
                                                  cn.dr["email"].ToString(),
                                                  cn.dr["login"].ToString(),
                                                  cn.dr["senha"].ToString(),
                                                  cn.dr["frase_seguranca"].ToString(),
                                                  Convert.ToInt32(cn.dr["nivel"]),
                                                  Convert.ToInt32(cn.dr["ativo"]));
                    }
                    if (usuarioLogado.Ativo == 1)
                    {
                        if (usuarioLogado.Senha == senha)
                        {
                            frmAdm TA = new frmAdm(usuarioLogado);
                            TA.ShowDialog();
                        }
                        else
                        {
                            throw new Exception("Senha inválida");
                        }
                    }
                    else
                    {
                        throw new Exception("Usuário bloqueado!");
                    }
                }
                else
                {
                    throw new Exception("Usuário não encontrado!");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FechaConexao();
            }
        }

        // Método para alterar a senha do usuário/admin
        public void AlterarSenha()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_admin SET senha = '{0}', frase_seguranca = '{1}' WHERE id_admin = {2}", Senha, Frase_seguranca, Id_admin);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Senha alterada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FechaConexao();
            }
        }

        //Método para mostrar todos os usuários/admins ativados
        public static dynamic BuscarTodosUsuariosAtivados()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_admin WHERE ativo = 1";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Usuarios");
                return cn.ds.Tables["Usuarios"];
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para mostrar todos os usuários/admins desativados
        public static dynamic BuscarTodosUsuariosDesativados()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_admin WHERE ativo = 0";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Usuarios");
                return cn.ds.Tables["Usuarios"];
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para inserir um usuário/admin
        public void InsereUsuario()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("INSERT INTO tab_admin (nome, email, login, senha, frase_seguranca, nivel, ativo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6})", Nome, Email, Logins, Senha, Frase_seguranca, Nivel, Ativo);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Usuário inserido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FechaConexao();
            }
        }

        //Método para alterar um usuário/admin
        public void AlteraUsuario()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_admin SET nome = '{0}', email = '{1}', login = '{2}', nivel = {3} WHERE id_admin = {4}", Nome, Email, Logins, Nivel, Id_admin);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Usuário alterado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FechaConexao();
            }
        }

        //Método para Ativar um usuário/admin
        public void AtivaUsuario()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_admin SET ativo = 1 WHERE  id_admin = {0}", Id_admin);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Usuário ativado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para Desativar um usuário/admin
        public void DesativaUsuario()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_admin SET ativo = 0 WHERE  id_admin = {0}", Id_admin);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Usuário ativado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para excluir um usuário
        public void ExcluiUsuário()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("DELETE FROM tab_admin WHERE id_admin = {0}", Id_admin);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Usuário excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FechaConexao();
            }
        }

        #endregion
    }
}
