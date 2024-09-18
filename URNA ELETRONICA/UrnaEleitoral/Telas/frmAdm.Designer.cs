
namespace UrnaEleitoral.Telas
{
    partial class frmAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripDesativa = new System.Windows.Forms.ToolStripButton();
            this.toolStripMudaFoto = new System.Windows.Forms.ToolStripButton();
            this.toolStripUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripZerar = new System.Windows.Forms.ToolStripButton();
            this.toolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlterarSenha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCargo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txbFoto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPartido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvCandidato = new System.Windows.Forms.DataGridView();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSalvar,
            this.toolStripAlterar,
            this.toolStripExcluir,
            this.toolStripDesativa,
            this.toolStripMudaFoto,
            this.toolStripUsuario,
            this.toolStripZerar,
            this.toolStripImprimir,
            this.toolStripCancelar,
            this.toolStripAlterarSenha,
            this.toolStripSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(779, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSalvar
            // 
            this.toolStripSalvar.Image = global::UrnaEleitoral.Properties.Resources.save_32;
            this.toolStripSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalvar.Name = "toolStripSalvar";
            this.toolStripSalvar.Size = new System.Drawing.Size(42, 51);
            this.toolStripSalvar.Text = "Salvar";
            this.toolStripSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSalvar.Click += new System.EventHandler(this.toolStripSalvar_Click);
            // 
            // toolStripAlterar
            // 
            this.toolStripAlterar.Enabled = false;
            this.toolStripAlterar.Image = global::UrnaEleitoral.Properties.Resources.update_32;
            this.toolStripAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAlterar.Name = "toolStripAlterar";
            this.toolStripAlterar.Size = new System.Drawing.Size(46, 51);
            this.toolStripAlterar.Text = "Alterar";
            this.toolStripAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAlterar.Click += new System.EventHandler(this.toolStripAlterar_Click);
            // 
            // toolStripExcluir
            // 
            this.toolStripExcluir.Image = global::UrnaEleitoral.Properties.Resources.delete_32;
            this.toolStripExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExcluir.Name = "toolStripExcluir";
            this.toolStripExcluir.Size = new System.Drawing.Size(46, 51);
            this.toolStripExcluir.Text = "Excluir";
            this.toolStripExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripExcluir.Visible = false;
            this.toolStripExcluir.Click += new System.EventHandler(this.toolStripExcluir_Click);
            // 
            // toolStripDesativa
            // 
            this.toolStripDesativa.Image = global::UrnaEleitoral.Properties.Resources.disable_icon_176417;
            this.toolStripDesativa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDesativa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDesativa.Name = "toolStripDesativa";
            this.toolStripDesativa.Size = new System.Drawing.Size(55, 51);
            this.toolStripDesativa.Text = "Desativa";
            this.toolStripDesativa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDesativa.Visible = false;
            this.toolStripDesativa.Click += new System.EventHandler(this.toolStripDesativa_Click);
            // 
            // toolStripMudaFoto
            // 
            this.toolStripMudaFoto.Image = global::UrnaEleitoral.Properties.Resources.image;
            this.toolStripMudaFoto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMudaFoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMudaFoto.Name = "toolStripMudaFoto";
            this.toolStripMudaFoto.Size = new System.Drawing.Size(69, 51);
            this.toolStripMudaFoto.Text = "Muda Foto";
            this.toolStripMudaFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMudaFoto.Visible = false;
            this.toolStripMudaFoto.Click += new System.EventHandler(this.toolStripMudaFoto_Click);
            // 
            // toolStripUsuario
            // 
            this.toolStripUsuario.Image = global::UrnaEleitoral.Properties.Resources.user;
            this.toolStripUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUsuario.Name = "toolStripUsuario";
            this.toolStripUsuario.Size = new System.Drawing.Size(56, 51);
            this.toolStripUsuario.Text = "Usuários";
            this.toolStripUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripUsuario.Click += new System.EventHandler(this.toolStripAdmin_Click);
            // 
            // toolStripZerar
            // 
            this.toolStripZerar.Image = global::UrnaEleitoral.Properties.Resources.print_32;
            this.toolStripZerar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripZerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZerar.Name = "toolStripZerar";
            this.toolStripZerar.Size = new System.Drawing.Size(59, 51);
            this.toolStripZerar.Text = "Zerésima";
            this.toolStripZerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripZerar.Click += new System.EventHandler(this.toolStripZerar_Click);
            // 
            // toolStripImprimir
            // 
            this.toolStripImprimir.Image = global::UrnaEleitoral.Properties.Resources.print_32;
            this.toolStripImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripImprimir.Name = "toolStripImprimir";
            this.toolStripImprimir.Size = new System.Drawing.Size(57, 51);
            this.toolStripImprimir.Text = "Imprimir";
            this.toolStripImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripImprimir.Click += new System.EventHandler(this.toolStripImprimir_Click_1);
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = global::UrnaEleitoral.Properties.Resources.cancel_32;
            this.toolStripCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(57, 51);
            this.toolStripCancelar.Text = "Cancelar";
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Visible = false;
            this.toolStripCancelar.Click += new System.EventHandler(this.toolStripCancelar_Click);
            // 
            // toolStripAlterarSenha
            // 
            this.toolStripAlterarSenha.Image = global::UrnaEleitoral.Properties.Resources.key;
            this.toolStripAlterarSenha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAlterarSenha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAlterarSenha.Name = "toolStripAlterarSenha";
            this.toolStripAlterarSenha.Size = new System.Drawing.Size(81, 51);
            this.toolStripAlterarSenha.Text = "Alterar Senha";
            this.toolStripAlterarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAlterarSenha.Click += new System.EventHandler(this.toolStripAlterarSenha_Click);
            // 
            // toolStripSair
            // 
            this.toolStripSair.Image = global::UrnaEleitoral.Properties.Resources.exit_32;
            this.toolStripSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(36, 51);
            this.toolStripSair.Text = "Sair";
            this.toolStripSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCargo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbNumero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(this.txbFoto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbPartido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 297);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // cbbCargo
            // 
            this.cbbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbbCargo.FormattingEnabled = true;
            this.cbbCargo.Items.AddRange(new object[] {
            "Deputado",
            "Senador",
            "Governador",
            "Presidente"});
            this.cbbCargo.Location = new System.Drawing.Point(18, 43);
            this.cbbCargo.Name = "cbbCargo";
            this.cbbCargo.Size = new System.Drawing.Size(121, 28);
            this.cbbCargo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cargo:";
            // 
            // txbNumero
            // 
            this.txbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumero.Location = new System.Drawing.Point(404, 46);
            this.txbNumero.MaxLength = 4;
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(121, 30);
            this.txbNumero.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Número:";
            // 
            // btnFoto
            // 
            this.btnFoto.Image = global::UrnaEleitoral.Properties.Resources.finder_24;
            this.btnFoto.Location = new System.Drawing.Point(492, 223);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(33, 30);
            this.btnFoto.TabIndex = 14;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txbFoto
            // 
            this.txbFoto.Enabled = false;
            this.txbFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFoto.Location = new System.Drawing.Point(17, 223);
            this.txbFoto.Name = "txbFoto";
            this.txbFoto.Size = new System.Drawing.Size(465, 30);
            this.txbFoto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Foto:";
            // 
            // txbPartido
            // 
            this.txbPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPartido.Location = new System.Drawing.Point(17, 154);
            this.txbPartido.Name = "txbPartido";
            this.txbPartido.Size = new System.Drawing.Size(508, 30);
            this.txbPartido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Partido:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(17, 99);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(508, 30);
            this.txbNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(210, 43);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(76, 30);
            this.txbId.TabIndex = 1;
            this.txbId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Candidatos:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(779, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvCandidato
            // 
            this.dgvCandidato.AllowUserToAddRows = false;
            this.dgvCandidato.AllowUserToDeleteRows = false;
            this.dgvCandidato.AllowUserToOrderColumns = true;
            this.dgvCandidato.AllowUserToResizeColumns = false;
            this.dgvCandidato.AllowUserToResizeRows = false;
            this.dgvCandidato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidato.Location = new System.Drawing.Point(12, 406);
            this.dgvCandidato.Name = "dgvCandidato";
            this.dgvCandidato.ReadOnly = true;
            this.dgvCandidato.RowHeadersVisible = false;
            this.dgvCandidato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCandidato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidato.Size = new System.Drawing.Size(754, 150);
            this.dgvCandidato.TabIndex = 9;
            this.dgvCandidato.Click += new System.EventHandler(this.dgvCandidato_Click);
            this.dgvCandidato.DoubleClick += new System.EventHandler(this.dgvCandidato_DoubleClick);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(617, 150);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(100, 133);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 4;
            this.picFoto.TabStop = false;
            this.picFoto.DoubleClick += new System.EventHandler(this.picFoto_DoubleClick);
            // 
            // frmAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 604);
            this.Controls.Add(this.dgvCandidato);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAdm";
            this.Text = "Cadastro de candidatos";
            this.Load += new System.EventHandler(this.frmAdm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSalvar;
        private System.Windows.Forms.ToolStripButton toolStripAlterar;
        private System.Windows.Forms.ToolStripButton toolStripMudaFoto;
        private System.Windows.Forms.ToolStripButton toolStripUsuario;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripAlterarSenha;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.TextBox txbFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPartido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvCandidato;
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStripButton toolStripDesativa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbCargo;
        private System.Windows.Forms.ToolStripButton toolStripZerar;
        private System.Windows.Forms.ToolStripButton toolStripImprimir;
    }
}