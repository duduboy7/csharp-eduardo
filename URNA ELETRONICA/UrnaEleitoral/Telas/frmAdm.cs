using projeto_urna_eleitoral.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEleitoral.Classes;

namespace UrnaEleitoral.Telas
{
    public partial class frmAdm : Form
    {
        Login usuarioLogado = new Login();
        string nivelUsu = "";
        int QtdVotos = 0;
        public frmAdm(Login usu)
        {
            InitializeComponent();
            usuarioLogado = usu;
        }

        private void frmAdm_Load(object sender, EventArgs e)
        {
            if (usuarioLogado.Nivel == 0)
            {
                nivelUsu = "Administrador";
            }
            else
            {
                nivelUsu = "Usuário comum";
                toolStripUsuario.Visible = true;
            }
                toolStrip1.Text = "Olá " + usuarioLogado.Nome + ", seu nível de acesso é " + nivelUsu;
                dgvCandidato.DataSource = Candidato.BuscaTodosCandidatos();
                dgvCandidato.Columns[0].HeaderText = "ID";
                dgvCandidato.Columns[1].HeaderText = "Nome";
                dgvCandidato.Columns[2].HeaderText = "Cargo";
                dgvCandidato.Columns[3].HeaderText = "Número";
                dgvCandidato.Columns[4].HeaderText = "Partido";
        }
        private void toolStripImprimir_Click(object sender, EventArgs e)
        {
            using (PrintDocument print = new PrintDocument())
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                print.PrintPage += Print_PrintPage;
                dialog.Document = print;
                dialog.ShowDialog();

            }
        }
        private void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            MostraCandidato();
            //Instanciando o objeto gráfico
            Graphics g = e.Graphics;


            using (Font fontDestaque = new Font("Arial Black", 14),
                        fontPadrao = new Font("Arial", 12),
                        fontData = new Font("Arial", 10))
            {

                //Posicionando o titulo
                g.DrawString("SISTEMA DE VOTOS", fontDestaque, Brushes.DarkRed, 100, 30);

                //Posicionando o nome do candidato
                //g.DrawString("CANDIDATO: " + dgvCandidato, fontData, Brushes.Black, 40, 90);

                //Posicionando a data
                string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
                g.DrawString("Data: " + dataAtual, fontData, Brushes.Black, 40, 110);

                //Criar uma linha divisória
                Pen divisoria = new Pen(Color.Black);
                g.DrawLine(divisoria, 40, 140, 800, 140);

                //Posicionar as legendas
                g.DrawString("Número", fontDestaque, Brushes.Black, 30, 160);
                g.DrawString("Candidato", fontDestaque, Brushes.Black, 150, 160);
                g.DrawString("Partido", fontDestaque, Brushes.Black, 350, 160);
                g.DrawString("Cargo", fontDestaque, Brushes.Black, 525, 160);
                g.DrawString("Votos", fontDestaque, Brushes.Black, 680, 160);

                //Variável para os conteúdos das próximas linhas
                int linha = 190; //

                //Laço para carregar os conteúdos do datagridgfghfhghfhgh
                for (int i = 0; i < dgvCandidato.RowCount; i++)
                {
                    string Candidato = dgvCandidato.Rows[i].Cells[1].Value.ToString();
                    if (Candidato.Length > 35)
                    {
                        Candidato = Candidato.Substring(0, 35) + "...";
                    }    // MMSDJGKK 
                    //Definindo alinhamento
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Far;

                    //Impressão do conteúdo do datagrid
                    g.DrawString(Convert.ToString(dgvCandidato.Rows[i].Cells[3].Value), fontPadrao, Brushes.Black, 30, linha);
                    g.DrawString(Candidato, fontPadrao, Brushes.Black, 150, linha);
                    g.DrawString(Convert.ToString(dgvCandidato.Rows[i].Cells[4].Value), fontPadrao, Brushes.Black, 350, linha);
                    g.DrawString(Convert.ToString(dgvCandidato.Rows[i].Cells[2].Value), fontPadrao, Brushes.Black, 525, linha);
                    g.DrawString(Convert.ToString(dgvCandidato.Rows[i].Cells[7].Value), fontPadrao, Brushes.Black, 680, linha);

                    //Incrementando a linha
                    linha = linha + 25;
                }

                //Linha divisória antes do total
                g.DrawLine(divisoria, 40, (linha + 10), 800, (linha + 10));

                //Impressão do total
                g.DrawString("Total de votos:", fontDestaque, Brushes.DarkRed, 470, linha + 20);
                g.DrawString(Convert.ToString(Candidato.SomaDosVotos()), fontDestaque, Brushes.DarkRed, 680, linha + 20);

                Pen divisoria2 = new Pen(Color.Black);
                g.DrawLine(divisoria, 40, 140, 800, 140);
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
                    Candidato NovoCandidato = new Candidato(int.Parse(txbNumero.Text), txbNome.Text, cbbCargo.Text, txbPartido.Text, Path.GetFileName(txbFoto.Text), 1);
                    NovoCandidato.CadastraCandidato();
                    MessageBox.Show("Candidato inserido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Atualiza o datagrid
                    dgvCandidato.DataSource = Candidato.BuscaTodosCandidatos();

                    //Limpar o textbox
                    LimpaDadosCandidatos();
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro: " + erro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private Boolean ValidaDados()
        {
            if (txbNumero.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNumero.Focus();
                return false;
            }

            if (txbNome.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNome.Focus();
                return false;
            }

            if (cbbCargo.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbCargo.Focus();
                return false;
            }

            if (txbPartido.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPartido.Focus();
                return false;
            }

            return true;
        }

        private void LimpaDadosCandidatos()
        {
            txbId.Clear();
            txbNumero.Clear();
            txbNome.Clear();
            cbbCargo.SelectedIndex = -1;
            txbPartido.Clear();
            txbFoto.Clear();
            picFoto.Image = null;
            txbNumero.Focus();
        }

        static bool CopiarArquivo(string nomeArquivoOrigem, string nomeArquivoDestino)
        {
            if (File.Exists(nomeArquivoOrigem) == false)
            {
                MessageBox.Show("Atenção! \nNão foi possível encontrar a foto", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (File.Exists(nomeArquivoDestino) == true)
            {
                if (MessageBox.Show("Atenção! \nJá existe foto com esse nome, deseja substituir a foto?", "Cadastro de Pessoas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return false;
            }
            try
            {
                Stream s1 = File.Open(@nomeArquivoOrigem, FileMode.Open, FileAccess.ReadWrite);
                Stream s2 = File.Open(@nomeArquivoDestino, FileMode.Create);

                BinaryReader f1 = new BinaryReader(s1);
                BinaryWriter f2 = new BinaryWriter(s2);

                while (true)
                {
                    byte[] buf = new byte[10240];
                    int sz = f1.Read(buf, 0, 10240);
                    if (sz <= 0)
                        break;
                    f2.Write(buf, 0, sz);
                    if (sz < 10240)
                        break;
                }
                f1.Close();
                f2.Close();
                MessageBox.Show("Foto salva!", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar a foto", "Cadastro de Pessoas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbreFoto = new OpenFileDialog();
            AbreFoto.Title = "Selecione uma foto";
            AbreFoto.Filter = "All files (*.*)|*.*";
            DialogResult dr = AbreFoto.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    txbFoto.Text = AbreFoto.FileName;
                    picFoto.ImageLocation = txbFoto.Text;
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao carregar a foto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgvCandidato_Click(object sender, EventArgs e)
        {
            toolStripSalvar.Enabled = false;
            toolStripAlterar.Enabled = true;
            toolStripExcluir.Visible = true;
            toolStripDesativa.Visible = true;
            toolStripCancelar.Visible = true;
            btnFoto.Enabled = true;
            picFoto.Enabled = true;
            dgvCandidato.DefaultCellStyle.SelectionBackColor = Color.Tomato;
            try
            {
                MostraCandidato();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar a foto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MostraCandidato()
        {
            try
            {
                if (dgvCandidato.SelectedRows.Count > 0)
                {
                    txbId.Text = dgvCandidato.SelectedRows[0].Cells[0].Value.ToString();
                    txbNumero.Text = dgvCandidato.SelectedRows[0].Cells[2].Value.ToString();
                    txbNome.Text = dgvCandidato.SelectedRows[0].Cells[1].Value.ToString();
                    cbbCargo.Text = dgvCandidato.SelectedRows[0].Cells[3].Value.ToString();
                    txbPartido.Text = dgvCandidato.SelectedRows[0].Cells[4].Value.ToString();
                    txbFoto.Text = dgvCandidato.SelectedRows[0].Cells[5].Value.ToString();
                    picFoto.Image = null;
                    picFoto.Load(dgvCandidato.SelectedRows[0].Cells[5].Value.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            {
                LimpaDadosCandidatos();
                toolStripSalvar.Enabled = true;
                toolStripAlterar.Enabled = false;
                toolStripExcluir.Visible = false;
                toolStripDesativa.Visible = false;
                toolStripCancelar.Visible = false;
                picFoto.Enabled = false;
                txbNumero.Focus();
                dgvCandidato.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            }
        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                Candidato Atualiza = new Candidato(int.Parse(txbId.Text), int.Parse(txbNumero.Text), txbNome.Text, cbbCargo.Text, txbPartido.Text);
                Atualiza.AlteraCandidato();
                toolStripCancelar.PerformClick();
                dgvCandidato.DataSource = Candidato.BuscaTodosCandidatos();
                txbNumero.Focus();
            }
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            {
                DialogResult Pergunta = MessageBox.Show("Deseja excluir este candidato?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Pergunta == DialogResult.Yes)
                {
                    Candidato Exclui = new Candidato(int.Parse(txbId.Text));
                    Exclui.ExcluiCandidato();
                    toolStripCancelar.PerformClick();
                    dgvCandidato.DataSource = Candidato.BuscaTodosCandidatos();
                    txbNumero.Focus();
                }
            }
        }

        private void picFoto_DoubleClick(object sender, EventArgs e)
        {
            if (usuarioLogado.Nivel == 0)
            {
                btnFoto.Enabled = true;
                btnFoto.PerformClick();
                txbNumero.Enabled = false;
                txbNome.Enabled = false;
                cbbCargo.Enabled = false;
                txbPartido.Enabled = false;
                toolStripAlterar.Enabled = false;
                toolStripMudaFoto.Visible = true;
                toolStripSalvar.Enabled = false;
                toolStripCancelar.Visible = true;
                toolStripExcluir.Enabled = false;
            }
            else
            {
                MessageBox.Show("Você não tem permissão para alterar a foto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMudaFoto_Click(object sender, EventArgs e)
        {
            //Copia a foto
            string Destino = Directory.GetCurrentDirectory();
            CopiarArquivo(txbFoto.Text, @Destino + "\\" + Path.GetFileName(txbFoto.Text));

            //Atualiza o banco de dados
            Candidato MudaFoto = new Candidato(int.Parse(txbId.Text), Path.GetFileName(txbFoto.Text));
            MudaFoto.AlteraFoto();
            toolStripCancelar.PerformClick();
            dgvCandidato.DataSource = Candidato.BuscaTodosCandidatos();
            txbNome.Enabled = true;
            cbbCargo.Enabled = true;
            txbPartido.Enabled = true;
            txbNumero.Focus();
            toolStripMudaFoto.Visible = false;
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripAlterarSenha_Click(object sender, EventArgs e)
        {
            frmSenha TS = new frmSenha(usuarioLogado);
            TS.ShowDialog();
        }

        private void toolStripAdmin_Click(object sender, EventArgs e)
        {
            frmUsuario TU = new frmUsuario(usuarioLogado);
            TU.ShowDialog();
        }

        private void toolStripDesativa_Click(object sender, EventArgs e)
        {
            DialogResult Pergunta = MessageBox.Show("Deseja desativar este candidato?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Pergunta == DialogResult.Yes)
            {
                Candidato Desativa = new Candidato(int.Parse(txbId.Text, 0));
                Desativa.DesativaCandidato();
                toolStripCancelar.PerformClick();
                dgvCandidato.DataSource = Candidato.BuscaTodosCandidatos();
                txbNumero.Focus();
            }
        }

        private void dgvCandidato_DoubleClick(object sender, EventArgs e)
        {
            DialogResult Pergunta = MessageBox.Show("Deseja ativar este candidato?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Pergunta == DialogResult.Yes)
            {
                Candidato Ativa = new Candidato(int.Parse(txbId.Text));
                Ativa.AtivaCandidato();
                toolStripCancelar.PerformClick();
                dgvCandidato.DataSource = Candidato.BuscaTodosCandidatos();
                txbNumero.Focus();
            }
        }

        private void toolStripImprimir_Click_1(object sender, EventArgs e)
        {
            using (PrintDocument print = new PrintDocument())
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                print.PrintPage += Print_PrintPage;
                dialog.Document = print;
                dialog.ShowDialog();
            }
        }
        public void Zeresima()
        {
            try
            {
                Voto ZeraVoto = new Voto();
                ZeraVoto.ZerarVotos();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void toolStripZerar_Click(object sender, EventArgs e)
        {
            Zeresima();
            dgvCandidato.DataSource = Candidato.BuscaTodosCandidatos();
            using (PrintDocument print = new PrintDocument())
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                print.PrintPage += Print_PrintPage;
                dialog.Document = print;
                dialog.ShowDialog();
            }
        }
    }
}
