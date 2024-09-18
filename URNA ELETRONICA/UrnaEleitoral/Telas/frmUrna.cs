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
    public partial class frmUrna : Form
    {
        int counter = 0;

        Candidato _candidatoBuscado;
        Eleitor _novoEleitor;

        public frmUrna(Eleitor novoEleitor)
        {
            InitializeComponent();
            _novoEleitor = novoEleitor;
            lblPresidente.Visible = false;
            lblGovernador.Visible = false;
            lblSenador.Visible = false;
            txbBranco.Visible = false;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "1";
                else if (txb2.Text == "")
                    txb2.Text = "1";
                else if (txb3.Text == "")
                    txb3.Text = "1";
                else
                    txb4.Text = "1";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "1";
                else if (txb2.Text == "")
                    txb2.Text = "1";
                else
                    txb3.Text = "1";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "1";
                else
                    txb2.Text = "1";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "1";
                else
                    txb2.Text = "1";
            }
        }
        private void btnDois_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "2";
                else if (txb2.Text == "")
                    txb2.Text = "2";
                else if (txb3.Text == "")
                    txb3.Text = "2";
                else
                    txb4.Text = "2";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "2";
                else if (txb2.Text == "")
                    txb2.Text = "2";
                else
                    txb3.Text = "2";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "2";
                else
                    txb2.Text = "2";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "2";
                else
                    txb2.Text = "2";
            }
        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "3";
                else if (txb2.Text == "")
                    txb2.Text = "3";
                else if (txb3.Text == "")
                    txb3.Text = "3";
                else
                    txb4.Text = "3";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "3";
                else if (txb2.Text == "")
                    txb2.Text = "3";
                else
                    txb3.Text = "3";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "3";
                else
                    txb2.Text = "3";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "3";
                else
                    txb2.Text = "3";
            }
        }
        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "4";
                else if (txb2.Text == "")
                    txb2.Text = "4";
                else if (txb3.Text == "")
                    txb3.Text = "4";
                else
                    txb4.Text = "4";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "4";
                else if (txb2.Text == "")
                    txb2.Text = "4";
                else
                    txb3.Text = "4";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "4";
                else
                    txb2.Text = "4";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "4";
                else
                    txb2.Text = "4";
            }
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "5";
                else if (txb2.Text == "")
                    txb2.Text = "5";
                else if (txb3.Text == "")
                    txb3.Text = "5";
                else
                    txb4.Text = "5";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "5";
                else if (txb2.Text == "")
                    txb2.Text = "5";
                else
                    txb3.Text = "5";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "5";
                else
                    txb2.Text = "5";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "5";
                else
                    txb2.Text = "5";
            }
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "6";
                else if (txb2.Text == "")
                    txb2.Text = "6";
                else if (txb3.Text == "")
                    txb3.Text = "6";
                else
                    txb4.Text = "6";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "6";
                else if (txb2.Text == "")
                    txb2.Text = "6";
                else
                    txb3.Text = "6";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "6";
                else
                    txb2.Text = "6";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "6";
                else
                    txb2.Text = "6";
            }
        }
        private void btnSete_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "7";
                else if (txb2.Text == "")
                    txb2.Text = "7";
                else if (txb3.Text == "")
                    txb3.Text = "7";
                else
                    txb4.Text = "7";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "7";
                else if (txb2.Text == "")
                    txb2.Text = "7";
                else 
                    txb3.Text = "7";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "7";
                else
                    txb2.Text = "7";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "7";
                else
                    txb2.Text = "7";
            }
        }
        private void btnOito_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "8";
                else if (txb2.Text == "")
                    txb2.Text = "8";
                else if (txb3.Text == "")
                    txb3.Text = "8";
                else
                    txb4.Text = "8";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "8";
                else if (txb2.Text == "")
                    txb2.Text = "8";
                else
                    txb3.Text = "8";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "8";
                else
                    txb2.Text = "8";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "8";
                else
                    txb2.Text = "8";
            }
        }
        private void btnNove_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "9";
                else if (txb2.Text == "")
                    txb2.Text = "9";
                else if (txb3.Text == "")
                    txb3.Text = "9";
                else
                    txb4.Text = "9";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "9";
                else if (txb2.Text == "")
                    txb2.Text = "9";
                else
                    txb3.Text = "9";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "9";
                else
                    txb2.Text = "9";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "9";
                else
                    txb2.Text = "9";
            }
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                //trabalhando com deputado
                if (txb4.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "0";
                else if (txb2.Text == "")
                    txb2.Text = "0";
                else if (txb3.Text == "")
                    txb3.Text = "0";
                else
                    txb4.Text = "0";
            }

            if (counter == 1)
            {
                //trabalhando com senador
                if (txb3.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "0";
                else if (txb2.Text == "")
                    txb2.Text = "0";
                else
                    txb3.Text = "0";

            }

            if (counter == 2)
            {
                //trabalhando com governador
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "0";
                else
                    txb2.Text = "0";
            }

            if (counter == 3)
            {
                //trabalhando com presidente
                if (txb2.Text.Length != 0)
                    return;

                if (txb1.Text == "")
                    txb1.Text = "0";
                else
                    txb2.Text = "0";
            }
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            { 
                txb1.BringToFront();
                txb2.BringToFront();
                txb3.BringToFront();
                txb4.BringToFront();
                txb1.Visible = true;
                txb2.Visible = true;
                txb3.Visible = true;
                txb4.Visible = true;
                txbNome.BringToFront();
                txbPartido.BringToFront();
                txb1.Text = String.Empty;
                txb2.Text = String.Empty;
                txb3.Text = String.Empty;
                txb4.Text = String.Empty;
                txbBranco.Clear();
                txbNome.Clear();
                txbPartido.Clear();
                picFotoCandidato.Image = null;
                txb1.Focus();

            }
            else if (counter == 1)
            {
                txb1.BringToFront();
                txb2.BringToFront();
                txb3.BringToFront();
                txb1.Visible = true;
                txb2.Visible = true;
                txb3.Visible = true;
                txbNome.BringToFront();
                txbPartido.BringToFront();
                txb1.Text = String.Empty;
                txb2.Text = String.Empty;
                txb3.Text = String.Empty;
                txbBranco.Clear();
                txbNome.Clear();
                txbPartido.Clear();
                picFotoCandidato.Image = null;
                txb1.Focus();
            }
            else if (counter == 2)
            {
                txb1.BringToFront();
                txb2.BringToFront();
                txb1.Visible = true;
                txb2.Visible = true;
                txbNome.BringToFront();
                txbPartido.BringToFront();
                txb1.Text = String.Empty;
                txb2.Text = String.Empty;
                txbBranco.Clear();
                txbNome.Clear();
                txbPartido.Clear();
                picFotoCandidato.Image = null;
                txb1.Focus();
            }
            else if (counter == 3)
            {
                txb1.BringToFront();
                txb2.BringToFront();
                txb1.Visible = true;
                txb2.Visible = true;
                txbNome.BringToFront();
                txbPartido.BringToFront();
                txb1.Text = String.Empty;
                txb2.Text = String.Empty;
                txbBranco.Clear();
                txbNome.Clear();
                txbPartido.Clear();
                picFotoCandidato.Image = null;
                txb1.Focus();
            }
            
        }
        private void btnBranco_Click(object sender, EventArgs e)
        {
            MostraBrancoUrna();
            txbBranco.Visible = true;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                try
                {
                    Votar();
                    counter++;
                    txb1.Clear();
                    txb2.Clear();
                    txb3.Clear();
                    txb4.Clear();
                    txbBranco.Visible = false;
                    txb1.BringToFront();
                    txb2.BringToFront();
                    txb3.BringToFront();
                    picLogo.Visible = true;
                    txb1.Visible = true;
                    txb2.Visible = true;
                    txb3.Visible = true;
                    txb1.Focus();
                    lblDeputado.Visible = false;
                    lblDeputado.SendToBack();
                    lblSenador.BringToFront();
                    lblSenador.Visible = true;
                    txb4.Visible = false;
                    txb4.Enabled = false;
                    txbBranco.Clear();
                    txbNome.Clear();
                    txbPartido.Clear();
                    picFotoCandidato.Image = null;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            else if (counter == 1)
            {
                try
                {
                    Votar();
                    counter++;
                    txb1.Clear();
                    txb2.Clear();
                    txb3.Clear();
                    txbBranco.Visible = false;
                    txb1.BringToFront();
                    txb2.BringToFront();
                    picLogo.Visible = true;
                    txb1.Visible = true;
                    txb2.Visible = true;
                    txb1.Focus();
                    lblSenador.Visible = false;
                    lblSenador.SendToBack();
                    lblGovernador.BringToFront();
                    lblGovernador.Visible = true;
                    txb3.Visible = false;
                    txb3.Enabled = false;
                    txb4.Visible = false;
                    txb4.Enabled = false;
                    txbBranco.Clear();
                    txbNome.Clear();
                    txbPartido.Clear();
                    picFotoCandidato.Image = null;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (counter == 2)
            {
                try
                {
                    Votar();
                    counter++;
                    txb1.Clear();
                    txb2.Clear();
                    txb3.Clear();
                    txbBranco.Visible = false;
                    txb1.BringToFront();
                    txb2.BringToFront();
                    picLogo.Visible = true;
                    txb1.Visible = true;
                    txb2.Visible = true;
                    txb1.Focus();
                    lblGovernador.Visible = false;
                    lblGovernador.SendToBack();
                    lblPresidente.BringToFront();
                    lblPresidente.Visible = true;
                    txb3.Visible = false;
                    txb3.Enabled = false;
                    txb4.Visible = false;
                    txb4.Enabled = false;
                    txbBranco.Clear();
                    txbNome.Clear();
                    txbPartido.Clear();
                    picFotoCandidato.Image = null;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (counter == 3)
            {
                try
                {
                    Votar();
                    counter++;
                    _novoEleitor.InsereEleitor();
                    txb1.Clear();
                    txb2.Clear();
                    txbBranco.Visible = false;
                    txbNome.Clear();
                    txbPartido.Clear();
                    txbBranco.Clear();
                    picLogo.Visible = false;
                    picFotoCandidato.Image = null;
                    lblPresidente.Visible = false;
                    lblPresidente.Visible = false;
                    txb1.Visible = false;
                    txb2.Visible = false;
                    txbBranco.SendToBack();
                    txbBranco.Visible = false;
                    lblFim.BringToFront();
                    lblFim.Visible = true;
                    MessageBox.Show("Voto computado com sucesso, obrigado por votar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                return;
            }
        }

        private void Votar()
        {
            try
            {
                Voto insereVoto = new Voto(_candidatoBuscado.Id_candidato);
                insereVoto.ComputaVoto();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void MostraCandidatoUrna()
        {
            if (counter == 0)
            {
                try
                {
                    _candidatoBuscado = Candidato.BuscaPorNumero(int.Parse(txb1.Text + txb2.Text + txb3.Text + txb4.Text));
                    txbNome.Text = "Nome: " + _candidatoBuscado.Nome;
                    txbPartido.Text = "Partido: " + _candidatoBuscado.Partido;
                    picFotoCandidato.Image = Image.FromFile(@"C://Users/rafael.dias/Projeto Urna/Images/" + _candidatoBuscado.Foto);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (counter == 1)
            {
                try
                {
                    _candidatoBuscado = Candidato.BuscaPorNumero(int.Parse(txb1.Text + txb2.Text + txb3.Text));
                    txbNome.Text = "Nome: " + _candidatoBuscado.Nome;
                    txbPartido.Text = "Partido: " + _candidatoBuscado.Partido;
                    picFotoCandidato.Image = Image.FromFile(@"C://Users/rafael.dias/Desktop/Projeto Urna/Images/" + _candidatoBuscado.Foto);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (counter == 2)
            {
                try
                {
                    _candidatoBuscado = Candidato.BuscarPorGovernador(int.Parse(txb1.Text + txb2.Text));
                    txbNome.Text = "Nome: " + _candidatoBuscado.Nome;
                    txbPartido.Text = "Partido: " + _candidatoBuscado.Partido;
                    picFotoCandidato.Image = Image.FromFile(@"C://Users/eduardo.sorfao/Desktop/Images/" + _candidatoBuscado.Foto);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (counter == 3)
            {
                try
                {
                    _candidatoBuscado = Candidato.BuscarPorPresidente(int.Parse(txb1.Text + txb2.Text));
                    txbNome.Text = "Nome: " + _candidatoBuscado.Nome;
                    txbPartido.Text = "Partido: " + _candidatoBuscado.Partido;
                    picFotoCandidato.Image = Image.FromFile(@"C://Users/eduardo.sorfao/Desktop/Images/" + _candidatoBuscado.Foto);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void MostraBrancoUrna()
        {
            if (counter == 0)
            {
                try
                {
                    txb1.SendToBack();
                    txb2.SendToBack();
                    txb3.SendToBack();
                    txb4.SendToBack();
                    picLogo.Visible = false;
                    txbBranco.BringToFront();
                    _candidatoBuscado = Candidato.BuscaPorBranco();
                    txbBranco.Text = _candidatoBuscado.Nome;
                    txb1.Visible = false;
                    txb2.Visible = false;
                    txb3.Visible = false;
                    txb4.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (counter == 1)
            {
                try
                {
                    txbBranco.BringToFront();
                    txb1.SendToBack();
                    txb2.SendToBack();
                    txb3.SendToBack();
                    picLogo.Visible = false;
                    _candidatoBuscado = Candidato.BuscaPorBranco();
                    txbBranco.Text = _candidatoBuscado.Nome;
                    txb1.Visible = false;
                    txb2.Visible = false;
                    txb3.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (counter == 2)
            {
                try
                {
                    txbBranco.BringToFront();
                    txb1.SendToBack();
                    txb2.SendToBack();
                    picLogo.Visible = false;
                    _candidatoBuscado = Candidato.BuscaPorBranco();
                    txbBranco.Text = _candidatoBuscado.Nome;
                    txb1.Visible = false;
                    txb2.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (counter == 3)
            {
                try
                {
                    txbBranco.BringToFront();
                    txb1.SendToBack();
                    txb2.SendToBack();
                    picLogo.Visible = false;
                    _candidatoBuscado = Candidato.BuscaPorBranco();
                    txbBranco.Text = _candidatoBuscado.Nome;
                    txb1.Visible = false;
                    txb2.Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void frmUrna_Load(object sender, EventArgs e)
        {
            dgvCandidatos.DataSource = Candidato.BuscaTodosCandidatos();
        }

        private void txb2_TextChanged(object sender, EventArgs e)
        {
            if (counter == 2)
            {
                if (txb2.Text.Length == 1)
                {
                    MostraCandidatoUrna();
                }
                else
                {
                    return;
                }
            }
            else if (counter == 3)
            {
                if (txb2.Text.Length == 1)
                {
                    MostraCandidatoUrna();
                }
                else
                {
                    return;
                }
            }
            //SE este txb2 estiver PREENCHIDO -> buscar no banco o candidato
            //SE NÃO -> Fazer nada

            if (txb1.Text + txb2.Text == "69")
            {
                Telas.frmLogin TL = new Telas.frmLogin();
                txb1.Clear();
                txb2.Clear();
                this.Hide();
                TL.ShowDialog();
                this.Show();
            }
        }

        private void txb3_TextChanged(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                if (txb3.Text.Length == 1)
                {
                    MostraCandidatoUrna();
                }
                else
                {
                    return;
                }
            }
        }

        private void txb4_TextChanged(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                if (txb4.Text.Length == 1)
                {
                    MostraCandidatoUrna();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
