using MySql.Data.MySqlClient;
using projeto_urna_eleitoral.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEleitoral.Classes
{
    public class Candidato
    {
        #region "Propriedades"

        public int Id_candidato { get; set; }

        public int Numero { get; set; }

        public string Nome { get; set; }

        public string Cargo { get; set; }

        public string Partido { get; set; }

        public string Foto { get; set; }

        public int Ativo { get; set; }

        #endregion


        #region "Construtores"

        //Construtor padrão
        public Candidato(int v)
        {
            Id_candidato = 0;
            Numero = 0;
            Nome = string.Empty;
            Cargo = string.Empty;
            Partido = string.Empty;
            Foto = string.Empty;
            Ativo = 0;
        }

        //Construtor para inserir um candidato
        public Candidato(int numero, string nome, string cargo, string partido,
                       string foto, int ativo)
        {
            Numero = numero;
            Nome = nome;
            Cargo = cargo;
            Partido = partido;
            Foto = foto;
            Ativo = ativo;
        }

        //Construtor para alterar um candidato
        public Candidato(int id_candidato, int numero, string nome, string cargo ,string partido)
        {
            Id_candidato = id_candidato;
            Numero = numero;
            Nome = nome;
            Cargo = cargo;
            Partido = partido;
        }

        //Construtor para ativar/desativar um candidato
        public Candidato(int id_candidato, int ativo)
        {
            Id_candidato = id_candidato;
            Ativo = ativo;
        }

        //Construtor para alterar a foto de uma pessoa
        public Candidato(int id_candidato, string foto)
        {
            Id_candidato = id_candidato;
            Foto = foto;
        }

        public Candidato()
        {
        }
        #endregion


        #region "Métodos"

        //Método para inserir um candidato
        public void CadastraCandidato()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("INSERT INTO tab_candidato (nome, cargo, numero, partido, foto, ativo) VALUES ('{0}', '{1}', {2}, '{3}', '{4}', {5})", Nome, Cargo, Numero, Partido, Foto, Ativo);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();

            }
            catch (Exception)
            {


            }
            finally
            {
                cn.FechaConexao();
            }
        }

        //Método para alterar um candidato
        public void AlteraCandidato()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_candidato SET numero = {0}, nome = '{1}', cargo = '{2}', partido = '{3}' " +
                    "WHERE id_candidato = {4}", Numero, Nome, Cargo, Partido, Id_candidato);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Candidato alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //Método para alterar a foto de um candidato
        public void AlteraFoto()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_candidato SET foto = '{0}' WHERE id_candidato = {1}", Foto, Id_candidato);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Foto alterada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //Método para ativar um candidato
        public void AtivaCandidato()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_candidato SET ativo = 1 WHERE id_candidato = {0}", Id_candidato);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Candidato ativado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //Método para Desativar um candidato
        public void DesativaCandidato()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("UPDATE tab_candidato SET ativo = 0 WHERE id_candidato = {0}", Id_candidato);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Candidato excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //Método para excluir um candidato
        public void ExcluiCandidato()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("DELETE FROM tab_candidato WHERE id_candidato = {0}", Id_candidato);
                cn.comando = new MySqlCommand(cn.query, cn.conexao);
                cn.AbreConexao();
                cn.comando.ExecuteNonQuery();
                MessageBox.Show("Candidato excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        //Método para somar os votos
        public static int SomaDosVotos()
        {
            string query = string.Format("SELECT SUM(QtdVotos) FROM (SELECT C.* , COUNT(id_voto) QtdVotos FROM tab_candidato C LEFT JOIN tab_votos V ON V.id_candidato = C.id_candidato GROUP BY id_candidato) T");
            int Qtdvotos = 0;
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read())
                {
                    Qtdvotos = Convert.ToInt32(cn.dr[0]);
                }
                return Qtdvotos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Método para mostrar todos os candidatos no DataGrid
        public static dynamic BuscaTodosCandidatos()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT C.* , COUNT(id_voto) QtdVotos FROM tab_candidato C LEFT JOIN tab_votos V ON V.id_candidato = C.id_candidato GROUP BY id_candidato";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Candidato");
                return cn.ds.Tables["Candidato"];
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para buscar por cargo
        public static dynamic BuscarPorCargo(string cargo)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_candidato WHERE ativo = 1 AND cargo LIKE '%" + cargo + "%'";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Candidato");
                return cn.ds.Tables["Candidato"];

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para buscar pelo nome
        public static dynamic BuscaPorNome(string nome)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_candidato WHERE ativo = 1 AND nome LIKE '%" + nome + "%'";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Candidato");
                return cn.ds.Tables["Candidato"];
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para buscar por ID
        public static dynamic BuscaPorID(int id)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_candidato WHERE ativo = 1 AND id_candidato = ";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Candidato");
                return cn.ds.Tables["Candidato"];
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para buscar por Numero
        public static Candidato BuscaPorNumero(int numero)
        {
            string query = string.Format("SELECT * FROM tab_candidato WHERE ativo = 1 AND numero = {0}", numero);
            Conexao cn = new Conexao(query);
            Candidato candidatoBuscado = new Candidato();
            try
            {
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader(); //ExecuteReader usado para select que NÃO VAI ALIMENTAR DATAGRID
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        candidatoBuscado.Id_candidato = Convert.ToInt32(cn.dr[0]);
                        candidatoBuscado.Nome = cn.dr[1].ToString();
                        candidatoBuscado.Cargo = cn.dr[2].ToString();
                        candidatoBuscado.Numero = Convert.ToInt32(cn.dr[3]);
                        candidatoBuscado.Partido = cn.dr[4].ToString();
                        candidatoBuscado.Foto = cn.dr[5].ToString();
                        candidatoBuscado.Ativo = Convert.ToInt32(cn.dr[6]);
                    }
                    return candidatoBuscado;
                }
                else
                {
                    query = string.Format("SELECT * FROM tab_candidato WHERE numero = -1");
                    Conexao cn2 = new Conexao(query);
                    cn2.AbreConexao();
                    cn2.dr = cn2.comando.ExecuteReader();
                    try
                    {
                        while (cn2.dr.Read())
                        {
                            candidatoBuscado.Id_candidato = Convert.ToInt32(cn2.dr[0]);
                            candidatoBuscado.Nome = cn2.dr[1].ToString();
                            candidatoBuscado.Cargo = cn2.dr[2].ToString();
                            candidatoBuscado.Numero = Convert.ToInt32(cn2.dr[3]);
                            candidatoBuscado.Partido = cn2.dr[4].ToString();
                            candidatoBuscado.Foto = cn2.dr[5].ToString();
                            candidatoBuscado.Ativo = Convert.ToInt32(cn2.dr[6]);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        cn2.FechaConexao();
                    }
                    return candidatoBuscado;
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
        //Método para buscar Presidente
        public static Candidato BuscarPorPresidente(int numero)
        {
            string query = string.Format("SELECT * FROM tab_candidato WHERE ativo = 1 AND cargo = 'presidente' AND numero = {0}", numero);
            Conexao cn = new Conexao(query);
            Candidato candidatoBuscado = new Candidato();
            try
            {
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader(); //ExecuteReader usado para select que NÃO VAI ALIMENTAR DATAGRID
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        candidatoBuscado.Id_candidato = Convert.ToInt32(cn.dr[0]);
                        candidatoBuscado.Nome = cn.dr[1].ToString();
                        candidatoBuscado.Cargo = cn.dr[2].ToString();
                        candidatoBuscado.Numero = Convert.ToInt32(cn.dr[3]);
                        candidatoBuscado.Partido = cn.dr[4].ToString();
                        candidatoBuscado.Foto = cn.dr[5].ToString();
                        candidatoBuscado.Ativo = Convert.ToInt32(cn.dr[6]);
                    }
                    return candidatoBuscado;
                }
                else
                {
                    query = string.Format("SELECT * FROM tab_candidato WHERE numero = -1");
                    Conexao cn2 = new Conexao(query);
                    cn2.AbreConexao();
                    cn2.dr = cn2.comando.ExecuteReader();
                    try
                    {
                        while (cn2.dr.Read())
                        {
                            candidatoBuscado.Id_candidato = Convert.ToInt32(cn2.dr[0]);
                            candidatoBuscado.Nome = cn2.dr[1].ToString();
                            candidatoBuscado.Cargo = cn2.dr[2].ToString();
                            candidatoBuscado.Numero = Convert.ToInt32(cn2.dr[3]);
                            candidatoBuscado.Partido = cn2.dr[4].ToString();
                            candidatoBuscado.Foto = cn2.dr[5].ToString();
                            candidatoBuscado.Ativo = Convert.ToInt32(cn2.dr[6]);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        cn2.FechaConexao();
                    }
                    return candidatoBuscado;
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

        //Método para buscar Governador
        public static Candidato BuscarPorGovernador(int numero)
        {
            string query = string.Format("SELECT * FROM tab_candidato WHERE ativo = 1 AND cargo = 'governador' AND numero = {0}", numero);
            Conexao cn = new Conexao(query);
            Candidato candidatoBuscado = new Candidato();
            try
            {
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader(); //ExecuteReader usado para select que NÃO VAI ALIMENTAR DATAGRID
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        candidatoBuscado.Id_candidato = Convert.ToInt32(cn.dr[0]);
                        candidatoBuscado.Nome = cn.dr[1].ToString();
                        candidatoBuscado.Cargo = cn.dr[2].ToString();
                        candidatoBuscado.Numero = Convert.ToInt32(cn.dr[3]);
                        candidatoBuscado.Partido = cn.dr[4].ToString();
                        candidatoBuscado.Foto = cn.dr[5].ToString();
                        candidatoBuscado.Ativo = Convert.ToInt32(cn.dr[6]);
                    }
                    return candidatoBuscado;
                }
                else
                {
                    query = string.Format("SELECT * FROM tab_candidato WHERE numero = -1");
                    Conexao cn2 = new Conexao(query);
                    cn2.AbreConexao();
                    cn2.dr = cn2.comando.ExecuteReader();
                    try
                    {
                        while (cn2.dr.Read())
                        {
                            candidatoBuscado.Id_candidato = Convert.ToInt32(cn2.dr[0]);
                            candidatoBuscado.Nome = cn2.dr[1].ToString();
                            candidatoBuscado.Cargo = cn2.dr[2].ToString();
                            candidatoBuscado.Numero = Convert.ToInt32(cn2.dr[3]);
                            candidatoBuscado.Partido = cn2.dr[4].ToString();
                            candidatoBuscado.Foto = cn2.dr[5].ToString();
                            candidatoBuscado.Ativo = Convert.ToInt32(cn2.dr[6]);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        cn2.FechaConexao();
                    }
                    return candidatoBuscado;
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

        //Método para buscar por branco
        public static Candidato BuscaPorBranco()
        {
            string query = string.Format("SELECT * FROM tab_candidato WHERE ativo = 1 AND numero = 0");
            Conexao cn = new Conexao(query);
            Candidato candidatoBuscado = new Candidato();
            try
            {
                cn.AbreConexao();
                cn.dr = cn.comando.ExecuteReader(); 
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        candidatoBuscado.Id_candidato = Convert.ToInt32(cn.dr[0]);
                        candidatoBuscado.Nome = cn.dr[1].ToString();
                        candidatoBuscado.Cargo = cn.dr[2].ToString();
                        candidatoBuscado.Numero = Convert.ToInt32(cn.dr[3]);
                        candidatoBuscado.Partido = cn.dr[4].ToString();
                        candidatoBuscado.Foto = cn.dr[5].ToString();
                        candidatoBuscado.Ativo = Convert.ToInt32(cn.dr[6]);
                    }
                    return candidatoBuscado;
                }
                else
                {
                    return candidatoBuscado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para buscar pelo partido
        public static dynamic BuscaPorPartido(string partido)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_candidato WHERE ativo = 1 AND partido LIKE '%" + partido + "%'";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Candidato");
                return cn.ds.Tables["Candidato"];
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para buscar pelo desativado
        public static dynamic BuscaPorDesativado()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_candidato WHERE ativo = 0";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Candidato");
                return cn.ds.Tables["Candidato"];
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para mostrar todos os candidatos ativos no Combobox
        public static dynamic CarregaComboBox(int ativo)
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = "SELECT * FROM tab_candidato WHERE ativo = ";
                cn.da = new MySqlDataAdapter(cn.query, cn.conexao);
                cn.ds = new DataSet();
                cn.da.Fill(cn.ds, "Candidato");
                return cn.ds.Tables["Candidato"];
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
