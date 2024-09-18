using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Tabuada
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private bool Verifica()
        {
            if (mskNumero.Text == string.Empty)
            {
                MessageBox.Show("Digite um número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskNumero.Focus();
                return false;
            }
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Verifica())
            {
                int valor;
                valor = int.Parse(mskNumero.Text);
                lstResultado.Items.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskNumero.Text = string.Empty;
            rdbUm.Checked = false;
            rdbDois.Checked = false;
            rdbTres.Checked = false;
            rdbQuatro.Checked = false;
            rdbCinco.Checked = false;
            rdbSeis.Checked = false;
            rdbSete.Checked = false;
            rdbOito.Checked = false;
            rdbNove.Checked = false;
            rdbDez.Checked = false;
            lstResultado.Items.Clear();
            mskNumero.Focus();
        }

        private void rdbUm_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbUm.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }

        private void rdbDois_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbDois.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }

        private void rdbTres_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbTres.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }

        private void rdbQuatro_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbQuatro.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }

        private void rdbCinco_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbCinco.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }

        private void rdbSeis_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbSeis.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }

        private void rdbSete_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbSete.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }

        private void rdbOito_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbOito.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }

        private void rdbNove_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbNove.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }

        private void rdbDez_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(rdbDez.Text);
            lstResultado.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstResultado.Items.Add(valor + " X " + i + " = " + (valor * i));
            }
        }
    }
}
