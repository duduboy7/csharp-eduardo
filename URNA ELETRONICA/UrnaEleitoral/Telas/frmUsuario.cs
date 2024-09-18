using projeto_urna_eleitoral.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEleitoral.Telas
{
    public partial class frmUsuario : Form
    {
        Login usuarioLogado = new Login();
        public frmUsuario(Login usu)
        {
            InitializeComponent();
            usuarioLogado = usu;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuariosAtivados.DataSource = Login.BuscarTodosUsuariosAtivados();
            dgvUsuariosAtivados.Columns[0].Visible = false;
            dgvUsuariosAtivados.Columns[1].HeaderText = "Nome";
            dgvUsuariosAtivados.Columns[2].HeaderText = "E-mail";
            dgvUsuariosAtivados.Columns[3].Visible = false;
            dgvUsuariosAtivados.Columns[4].Visible = false;
            dgvUsuariosAtivados.Columns[5].Visible = false;
            dgvUsuariosAtivados.Columns[6].HeaderText = "Nível";
            dgvUsuariosAtivados.Columns[7].Visible = false;

            dgvUsuariosDesativados.DataSource = Login.BuscarTodosUsuariosDesativados();
            dgvUsuariosDesativados.Columns[0].Visible = false;
            dgvUsuariosDesativados.Columns[1].HeaderText = "Nome";
            dgvUsuariosDesativados.Columns[2].HeaderText = "E-mail";
            dgvUsuariosDesativados.Columns[3].Visible = false;
            dgvUsuariosDesativados.Columns[4].Visible = false;
            dgvUsuariosDesativados.Columns[5].Visible = false;
            dgvUsuariosDesativados.Columns[6].HeaderText = "Nível";
            dgvUsuariosDesativados.Columns[7].Visible = false;
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                string senhaCrypto = Crypto.sha256encrypt("123");
                senhaCrypto = senhaCrypto.ToLower();
                string frase = "padrão";

                Login NovoUsuario = new Login(txbNome.Text, txbEmail.Text, txbLogin.Text, senhaCrypto, frase, cbbNivel.SelectedIndex, 1);
                NovoUsuario.InsereUsuario();
                dgvUsuariosAtivados.DataSource = Login.BuscarTodosUsuariosAtivados();
                LimpaDados();
                txbNome.Focus();
            }
        }

        private void LimpaDados()
        {
            txbID.Clear();
            txbNome.Clear();
            txbEmail.Clear();
            txbLogin.Clear();
            cbbNivel.SelectedIndex = -1;
            dgvUsuariosAtivados.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
        }

        private Boolean ValidaDados()
        {
            if (txbNome.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNome.Focus();
                return false;
            }

            if (txbEmail.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbEmail.Focus();
                return false;
            }

            if (txbLogin.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbLogin.Focus();
                return false;
            }

            if (cbbNivel.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o nível do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbNivel.Focus();
                return false;
            }
            return true;
        }

        private void dgvUsuariosAtivados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostraUsuarios();
        }

        private void MostraUsuarios()
        {
            try
            {
                if (dgvUsuariosAtivados.SelectedRows.Count > 0)
                {
                    txbID.Text = dgvUsuariosAtivados.SelectedRows[0].Cells[0].Value.ToString();
                    txbNome.Text = dgvUsuariosAtivados.SelectedRows[0].Cells[1].Value.ToString();
                    txbEmail.Text = dgvUsuariosAtivados.SelectedRows[0].Cells[2].Value.ToString();
                    txbLogin.Text = dgvUsuariosAtivados.SelectedRows[0].Cells[3].Value.ToString();
                    cbbNivel.SelectedIndex = Convert.ToInt32(dgvUsuariosAtivados.SelectedRows[0].Cells[6].Value.ToString());
                    toolStripSalvar.Enabled = false;
                    toolStripAlterar.Enabled = true;
                    toolStripExcluir.Enabled = true;
                    toolStripCancelar.Visible = true;
                    dgvUsuariosAtivados.DefaultCellStyle.SelectionBackColor = Color.Tomato;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            LimpaDados();
            toolStripSalvar.Enabled = true;
            toolStripAlterar.Enabled = false;
            toolStripExcluir.Enabled = false;
            toolStripCancelar.Visible = false;
            txbNome.Focus();
        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                Login AtualizaUsuario = new Login(int.Parse(txbID.Text), txbNome.Text, txbEmail.Text, txbLogin.Text, cbbNivel.SelectedIndex);
                AtualizaUsuario.AlteraUsuario();
                LimpaDados();
                toolStripSalvar.Enabled = true;
                toolStripAlterar.Enabled = false;
                toolStripExcluir.Enabled = false;
                toolStripCancelar.Visible = false;
                dgvUsuariosAtivados.DataSource = Login.BuscarTodosUsuariosAtivados();
                txbNome.Focus();
            }
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Pergunta = MessageBox.Show("Deseja excluir este usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Pergunta == DialogResult.Yes)
            {
                Login Exclui = new Login(int.Parse(txbID.Text), 0);
                Exclui.ExcluiUsuário();
                LimpaDados();
                toolStripCancelar.PerformClick();
                dgvUsuariosAtivados.DataSource = Login.BuscarTodosUsuariosAtivados();
                dgvUsuariosDesativados.DataSource = Login.BuscarTodosUsuariosDesativados();
                txbNome.Focus();
            }
        }

        private void dgvUsuariosDesativados_DoubleClick(object sender, EventArgs e)
        {
            int meuid = Convert.ToInt32(dgvUsuariosDesativados.SelectedRows[0].Cells[0].Value.ToString());
            if (usuarioLogado.Nivel == 0)
            {
                DialogResult Pergunta = MessageBox.Show("Deseja ativar este usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Pergunta == DialogResult.Yes)
                {
                    try
                    {
                        Login Ativar = new Login(meuid, 1);
                        Ativar.AtivaUsuario();
                        toolStripSalvar.Enabled = true;
                        toolStripAlterar.Enabled = false;
                        toolStripExcluir.Enabled = false;
                        toolStripCancelar.Visible = false;
                        LimpaDados();
                        dgvUsuariosAtivados.DataSource = Login.BuscarTodosUsuariosAtivados();
                        dgvUsuariosDesativados.DataSource = Login.BuscarTodosUsuariosDesativados();
                        txbNome.Focus();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para ativar usuários", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvUsuariosAtivados_DoubleClick(object sender, EventArgs e)
        {
            int meuid = Convert.ToInt32(dgvUsuariosAtivados.SelectedRows[0].Cells[0].Value.ToString());
            if (usuarioLogado.Nivel == 0)
            {
                DialogResult Pergunta = MessageBox.Show("Deseja desativar este usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Pergunta == DialogResult.Yes)
                {
                    try
                    {
                        Login Desativar = new Login(meuid, 1);
                        Desativar.DesativaUsuario();
                        toolStripSalvar.Enabled = true;
                        toolStripAlterar.Enabled = false;
                        toolStripExcluir.Enabled = false;
                        toolStripCancelar.Visible = false;
                        LimpaDados();
                        dgvUsuariosAtivados.DataSource = Login.BuscarTodosUsuariosAtivados();
                        dgvUsuariosDesativados.DataSource = Login.BuscarTodosUsuariosDesativados();
                        txbNome.Focus();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para desativar usuários", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
