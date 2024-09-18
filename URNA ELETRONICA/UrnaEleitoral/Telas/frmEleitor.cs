using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEleitoral.Classes;

namespace UrnaEleitoral.Telas
{
    public partial class frmEleitor : Form
    {
        public frmEleitor()
        {
            InitializeComponent();
        }

        private Boolean VerificaCampos()
        {
            if (txbNome.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNome.Focus();
                return false;
            }

            if (txbCpf.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbCpf.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                try
                {
                    if (Eleitor.VerificaCpf(txbCpf.Text))
                    {
                        Eleitor NovoEleitor = new Eleitor(txbNome.Text, txbCpf.Text, 1);
                        frmUrna abrirUrna = new frmUrna(NovoEleitor);
                        abrirUrna.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Eleitor já votou!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void frmEleitor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt || e.KeyCode == Keys.Right )
            {
                Telas.frmLogin TL = new Telas.frmLogin();
                txbNome.Clear();
                txbCpf.Clear();
                txbId.Clear();
                this.Hide();
                TL.ShowDialog();
            }
        }
    }
}
