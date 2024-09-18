using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_CalcularFrete
{
    public partial class frmCalcularFrete : Form
    {
        public frmCalcularFrete()
        {
            InitializeComponent();
        }

        private void frmCalcularFrete_Load(object sender, EventArgs e)
        {
            cbbEstado.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void LimpaCampos()
        {
            // Resetando os campos
            txbNome.Clear();
            txbValor.Clear();
            cbbEstado.SelectedIndex = 0;
            lblValor.Text = string.Empty;
            lblFrete.Text = string.Empty;
            lblTotal.Text = string.Empty;
            txbNome.Focus();
        }

        public Boolean VerificaCampos()
        {
            if (txbNome.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Focus();
                return false;
            }
            if (txbValor.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbValor.Focus();
                return false;
            }
            if (cbbEstado.Text == "Selecione")
            {
                MessageBox.Show("Selecione o estado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbEstado.Focus();
                return false;
            }
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                Calcular();
            }
        }

        private void txbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && 
                !char.IsDigit(e.KeyChar) && 
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        public void Calcular()
        {
            // Declarando as variáveis
            string nome = txbNome.Text;
            decimal valor = decimal.Parse(txbValor.Text);
            string estado = cbbEstado.SelectedItem.ToString();
            decimal frete = 0, total = 0;

            // Cálculo do frete
            if (valor > 1000)
            {
                frete = 0;
            }
            else
            {
                switch (estado)
                {
                    case "SP":
                        frete = 5;
                        break;
                    case "RJ":
                        frete = 10;
                        break;
                    case "AM":
                        frete = 20;
                        break;
                    default:
                        frete = 15;
                        break;
                }
            }

            // A variável total recebe o valor digitado mais o frete
            total = valor + frete;

            // Mostrar os valores nos labels
            lblValor.Text = valor.ToString("c");
            lblFrete.Text = frete.ToString("c");
            lblTotal.Text = total.ToString("c");
        }
    }
}
