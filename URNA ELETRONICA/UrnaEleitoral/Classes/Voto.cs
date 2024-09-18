using MySql.Data.MySqlClient;
using projeto_urna_eleitoral.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEleitoral.Classes
{
    public class Voto
    {
        #region "Propriedades"

        public int Id_voto { get; set; }

        public int Id_candidato { get; set; }

        #endregion

        #region "Construtores"

        //Construtor padrão
        public Voto()
        {
            Id_voto = 0;
            Id_candidato = 0;
        }


        //Construtor para Inserir o Voto
        public Voto(int id_candidato)
        {
            Id_candidato = id_candidato;
        }

        #endregion

        #region "Métodos"
        //Método para zerar a tabela de votos
        public void ZerarVotos()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("TRUNCATE TABLE tab_votos");
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

        //Método para computar o voto
        public void ComputaVoto()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("INSERT INTO tab_votos (id_candidato) VALUES ({0})", Id_candidato);
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

        //Método para voto nulo
        public void ComputaNulo()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("INSERT INTO tab_votos (id_candidato) VALUES ('0')", Id_candidato);
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

        //Método para voto em branco
        public void ComputaBranco()
        {
            Conexao cn = new Conexao();
            try
            {
                cn.query = String.Format("INSERT INTO tab_votos (id_candidato) VALUES ('1')", Id_candidato);
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

        #endregion
    }
}
