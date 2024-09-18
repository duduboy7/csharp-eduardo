using MySql.Data.MySqlClient;
using projeto_urna_eleitoral.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEleitoral.Telas;

namespace UrnaEleitoral.Classes
{
    public class Eleitor
    {

        #region "Propriedades"

        public int Id_eleitor { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int Votou { get; set; }

        #endregion

        #region "Construtores"

        //Construtor padrão
        public Eleitor()
        {
            Id_eleitor = 0;
            Nome = string.Empty;
            Cpf = string.Empty;
            Votou = 0;
        }

        //Construtor para inserir eleitor
        public Eleitor(string nome, string cpf, int votou)
        {
            Nome = nome;
            Cpf = cpf;
            Votou = votou;
        }

        //Construtor para verificar eleitor
        public Eleitor(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        //Construtor para levar o ID
        public Eleitor(int id, string nome, string cpf, int votou)
        {
            Id_eleitor = id;
            Nome = nome;
            Cpf = cpf;
            Votou = votou;
        }

        #endregion

        #region "Métodos"

        //Método para inserir um eleitor
        public void InsereEleitor()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("INSERT INTO tab_eleitor (nome, cpf, votou) VALUES ('{0}', '{1}', {2})", Nome, Cpf, 1);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
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




        //Método para verifica se o eleitor já votou
        public static void VerificaEleitor(int votou)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_eleitor WHERE votou = 1";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Eleitor");
                if (Convert.ToInt32(cn.dr["votou"].ToString()) == 1)
                {
                    MessageBox.Show("Eleitor já votou!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        //método para verificar o cpf do eleitor
        public static bool VerificaCpf(string cpf)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_eleitor WHERE votou = 1 AND cpf LIKE '%" + cpf + "%'";
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
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
        #endregion

    }
}
