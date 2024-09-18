
namespace _04_Tabuada
{
    partial class frmTabuada
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbUm = new System.Windows.Forms.RadioButton();
            this.rdbDois = new System.Windows.Forms.RadioButton();
            this.rdbTres = new System.Windows.Forms.RadioButton();
            this.rdbQuatro = new System.Windows.Forms.RadioButton();
            this.rdbCinco = new System.Windows.Forms.RadioButton();
            this.rdbDez = new System.Windows.Forms.RadioButton();
            this.rdbNove = new System.Windows.Forms.RadioButton();
            this.rdbOito = new System.Windows.Forms.RadioButton();
            this.rdbSete = new System.Windows.Forms.RadioButton();
            this.rdbSeis = new System.Windows.Forms.RadioButton();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskNumero
            // 
            this.mskNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNumero.Location = new System.Drawing.Point(48, 12);
            this.mskNumero.Mask = "00";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(53, 38);
            this.mskNumero.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(183, 12);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(70, 38);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(269, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 38);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDez);
            this.groupBox1.Controls.Add(this.rdbNove);
            this.groupBox1.Controls.Add(this.rdbOito);
            this.groupBox1.Controls.Add(this.rdbSete);
            this.groupBox1.Controls.Add(this.rdbSeis);
            this.groupBox1.Controls.Add(this.rdbCinco);
            this.groupBox1.Controls.Add(this.rdbQuatro);
            this.groupBox1.Controls.Add(this.rdbTres);
            this.groupBox1.Controls.Add(this.rdbDois);
            this.groupBox1.Controls.Add(this.rdbUm);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // rdbUm
            // 
            this.rdbUm.AutoSize = true;
            this.rdbUm.Location = new System.Drawing.Point(18, 32);
            this.rdbUm.Name = "rdbUm";
            this.rdbUm.Size = new System.Drawing.Size(31, 17);
            this.rdbUm.TabIndex = 0;
            this.rdbUm.TabStop = true;
            this.rdbUm.Text = "1";
            this.rdbUm.UseVisualStyleBackColor = true;
            this.rdbUm.CheckedChanged += new System.EventHandler(this.rdbUm_CheckedChanged);
            // 
            // rdbDois
            // 
            this.rdbDois.AutoSize = true;
            this.rdbDois.Location = new System.Drawing.Point(18, 57);
            this.rdbDois.Name = "rdbDois";
            this.rdbDois.Size = new System.Drawing.Size(31, 17);
            this.rdbDois.TabIndex = 1;
            this.rdbDois.TabStop = true;
            this.rdbDois.Text = "2";
            this.rdbDois.UseVisualStyleBackColor = true;
            this.rdbDois.CheckedChanged += new System.EventHandler(this.rdbDois_CheckedChanged);
            // 
            // rdbTres
            // 
            this.rdbTres.AutoSize = true;
            this.rdbTres.Location = new System.Drawing.Point(18, 82);
            this.rdbTres.Name = "rdbTres";
            this.rdbTres.Size = new System.Drawing.Size(31, 17);
            this.rdbTres.TabIndex = 3;
            this.rdbTres.TabStop = true;
            this.rdbTres.Text = "3";
            this.rdbTres.UseVisualStyleBackColor = true;
            this.rdbTres.CheckedChanged += new System.EventHandler(this.rdbTres_CheckedChanged);
            // 
            // rdbQuatro
            // 
            this.rdbQuatro.AutoSize = true;
            this.rdbQuatro.Location = new System.Drawing.Point(18, 107);
            this.rdbQuatro.Name = "rdbQuatro";
            this.rdbQuatro.Size = new System.Drawing.Size(31, 17);
            this.rdbQuatro.TabIndex = 4;
            this.rdbQuatro.TabStop = true;
            this.rdbQuatro.Text = "4";
            this.rdbQuatro.UseVisualStyleBackColor = true;
            this.rdbQuatro.CheckedChanged += new System.EventHandler(this.rdbQuatro_CheckedChanged);
            // 
            // rdbCinco
            // 
            this.rdbCinco.AutoSize = true;
            this.rdbCinco.Location = new System.Drawing.Point(18, 132);
            this.rdbCinco.Name = "rdbCinco";
            this.rdbCinco.Size = new System.Drawing.Size(31, 17);
            this.rdbCinco.TabIndex = 5;
            this.rdbCinco.TabStop = true;
            this.rdbCinco.Text = "5";
            this.rdbCinco.UseVisualStyleBackColor = true;
            this.rdbCinco.CheckedChanged += new System.EventHandler(this.rdbCinco_CheckedChanged);
            // 
            // rdbDez
            // 
            this.rdbDez.AutoSize = true;
            this.rdbDez.Location = new System.Drawing.Point(68, 132);
            this.rdbDez.Name = "rdbDez";
            this.rdbDez.Size = new System.Drawing.Size(37, 17);
            this.rdbDez.TabIndex = 10;
            this.rdbDez.TabStop = true;
            this.rdbDez.Text = "10";
            this.rdbDez.UseVisualStyleBackColor = true;
            this.rdbDez.CheckedChanged += new System.EventHandler(this.rdbDez_CheckedChanged);
            // 
            // rdbNove
            // 
            this.rdbNove.AutoSize = true;
            this.rdbNove.Location = new System.Drawing.Point(68, 107);
            this.rdbNove.Name = "rdbNove";
            this.rdbNove.Size = new System.Drawing.Size(31, 17);
            this.rdbNove.TabIndex = 9;
            this.rdbNove.TabStop = true;
            this.rdbNove.Text = "9";
            this.rdbNove.UseVisualStyleBackColor = true;
            this.rdbNove.CheckedChanged += new System.EventHandler(this.rdbNove_CheckedChanged);
            // 
            // rdbOito
            // 
            this.rdbOito.AutoSize = true;
            this.rdbOito.Location = new System.Drawing.Point(68, 82);
            this.rdbOito.Name = "rdbOito";
            this.rdbOito.Size = new System.Drawing.Size(31, 17);
            this.rdbOito.TabIndex = 8;
            this.rdbOito.TabStop = true;
            this.rdbOito.Text = "8";
            this.rdbOito.UseVisualStyleBackColor = true;
            this.rdbOito.CheckedChanged += new System.EventHandler(this.rdbOito_CheckedChanged);
            // 
            // rdbSete
            // 
            this.rdbSete.AutoSize = true;
            this.rdbSete.Location = new System.Drawing.Point(68, 57);
            this.rdbSete.Name = "rdbSete";
            this.rdbSete.Size = new System.Drawing.Size(31, 17);
            this.rdbSete.TabIndex = 7;
            this.rdbSete.TabStop = true;
            this.rdbSete.Text = "7";
            this.rdbSete.UseVisualStyleBackColor = true;
            this.rdbSete.CheckedChanged += new System.EventHandler(this.rdbSete_CheckedChanged);
            // 
            // rdbSeis
            // 
            this.rdbSeis.AutoSize = true;
            this.rdbSeis.Location = new System.Drawing.Point(68, 32);
            this.rdbSeis.Name = "rdbSeis";
            this.rdbSeis.Size = new System.Drawing.Size(31, 17);
            this.rdbSeis.TabIndex = 6;
            this.rdbSeis.TabStop = true;
            this.rdbSeis.Text = "6";
            this.rdbSeis.UseVisualStyleBackColor = true;
            this.rdbSeis.CheckedChanged += new System.EventHandler(this.rdbSeis_CheckedChanged);
            // 
            // lstResultado
            // 
            this.lstResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.ItemHeight = 35;
            this.lstResultado.Location = new System.Drawing.Point(150, 65);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(222, 354);
            this.lstResultado.TabIndex = 4;
            // 
            // frmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 458);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mskNumero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTabuada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de tabuadas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDez;
        private System.Windows.Forms.RadioButton rdbNove;
        private System.Windows.Forms.RadioButton rdbOito;
        private System.Windows.Forms.RadioButton rdbSete;
        private System.Windows.Forms.RadioButton rdbSeis;
        private System.Windows.Forms.RadioButton rdbCinco;
        private System.Windows.Forms.RadioButton rdbQuatro;
        private System.Windows.Forms.RadioButton rdbTres;
        private System.Windows.Forms.RadioButton rdbDois;
        private System.Windows.Forms.RadioButton rdbUm;
        private System.Windows.Forms.ListBox lstResultado;
    }
}

