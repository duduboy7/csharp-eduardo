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
    public partial class frmSenha : Form
    {
        Login usuarioLogado = new Login();
        public frmSenha(Login usu)
        {
            InitializeComponent();
            usuarioLogado = usu;
        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                string senhaAtualCrypto = Crypto.sha256encrypt(txbSenhaAtual.Text);
                senhaAtualCrypto = senhaAtualCrypto.ToLower();

                if (senhaAtualCrypto == usuarioLogado.Senha)
                {
                    string senhaNova = Crypto.sha256encrypt(txbSenha.Text);
                    senhaNova = senhaNova.ToLower();

                    int id = usuarioLogado.Id_admin;

                    Login TrocaSenha = new Login(id, senhaNova, txbFrase.Text);
                    TrocaSenha.AlterarSenha();
                    txbSenhaAtual.Clear();
                    txbSenha.Clear();
                    txbSenha2.Clear();
                    txbFrase.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha atual não confere", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private Boolean ValidaDados()
        {
            if (txbSenhaAtual.Text == string.Empty)
            {
                MessageBox.Show("Campo Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbSenhaAtual.Focus();
                return false;
            }

            if (txbSenha.Text == string.Empty)
            {
                MessageBox.Show("Campo Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbSenha.Focus();
                return false;
            }

            if (txbSenha2.Text == string.Empty)
            {
                MessageBox.Show("Campo Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbSenha2.Focus();
                return false;
            }

            if (txbSenha.Text != txbSenha2.Text)
            {
                MessageBox.Show("As senhas não conferem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbSenha.Clear();
                txbSenha2.Clear();
                txbSenha.Focus();
                return false;
            }

            if (txbFrase.Text == string.Empty)
            {
                MessageBox.Show("Campo Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbSenhaAtual.Focus();
                return false;
            }

            return true;
        }
    }
}
