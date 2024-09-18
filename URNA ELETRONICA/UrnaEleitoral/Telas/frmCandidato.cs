using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEleitoral
{
    public partial class frmCandidato : Form
    {
        public frmCandidato()
        {
            Login usuarioLogado = new Login();
            string nivelUsu = "";
            public frmCandidato(Login usu)
            {
                InitializeComponent();
                usuarioLogado = usu;
            }

            private void frmPrincipal_Load(object sender, EventArgs e)
            {
                if (usuarioLogado.Nivel == 0)
                {
                    nivelUsu = "Administrador";
                }
                else
                {
                    nivelUsu = "Usuário comum";
                }
                statusStrip1.Text = "Olá " + usuarioLogado.Nome + ", seu nível de acesso é " + nivelUsu;
                dgvCandidatos.DataSource = Candidato.BuscaTodosCandidatos();
                dgvCandidatos.Columns[0].HeaderText = "ID";
                dgvCandidatos.Columns[1].HeaderText = "Nome";
                dgvCandidatos.Columns[2].HeaderText = "Partido";
                dgvCandidatos.Columns[3].HeaderText = "Dt nascimento";
                dgvCandidatos.Columns[4].HeaderText = "Sexo";
                dgvCandidatos.Columns[5].Visible = false;
                dgvCandidatos.Columns[6].Visible = false;
            }
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                try
                {
                    //Copia a foto
                    string Destino = Directory.GetCurrentDirectory();
                    CopiarArquivo(txbFoto.Text, @Destino + "\\" + Path.GetFileName(txbFoto.Text));

                    //Grava os dados no banco de dados
                    string DataBanco = dtpNascimento.Value.ToString("yyyy-MM-dd");
                    Candidato NovoCandidato = new Candidato(txbNome.Text, txbPartido.Text, DataBanco, cbbSexo.SelectedItem.ToString(), Path.GetFileName(txbFoto.Text), 1);
                    int id = NovoCandidato.CadastraCandidato();
                    MessageBox.Show("Candidato inserido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Criando o log
                    string arquivoLog = @Destino + @"\log.txt";
                    if (!File.Exists(arquivoLog))
                        File.Create(arquivoLog).Close();
                    File.AppendAllText(arquivoLog, "Usuário " + usuarioLogado.Nome + " - inseriu o registro " + id + " em (" + DateTime.Now.ToString() + ")\r\n");

                    //Atualiza o datagrid
                    dgvCandidatos.DataSource = Candidato.BuscaTodosCandidatos();

                    //Limpar o textbox
                    LimpaDados();
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro: " + erro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
