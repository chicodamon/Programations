namespace Forms1___PSI
{
    partial class janela
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblDatadeNascimento = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbDesporto = new System.Windows.Forms.CheckBox();
            this.cbMusica = new System.Windows.Forms.CheckBox();
            this.cbPintura = new System.Windows.Forms.CheckBox();
            this.cbFotografia = new System.Windows.Forms.CheckBox();
            this.cbJardinagem = new System.Windows.Forms.CheckBox();
            this.cbCulinaria = new System.Windows.Forms.CheckBox();
            this.cbLeitura = new System.Windows.Forms.CheckBox();
            this.pbimagem = new System.Windows.Forms.PictureBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(23, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrito.Location = new System.Drawing.Point(23, 70);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(63, 20);
            this.lblDistrito.TabIndex = 1;
            this.lblDistrito.Text = "Distrito:";
            // 
            // lblDatadeNascimento
            // 
            this.lblDatadeNascimento.AutoSize = true;
            this.lblDatadeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatadeNascimento.Location = new System.Drawing.Point(24, 113);
            this.lblDatadeNascimento.Name = "lblDatadeNascimento";
            this.lblDatadeNascimento.Size = new System.Drawing.Size(127, 18);
            this.lblDatadeNascimento.TabIndex = 2;
            this.lblDatadeNascimento.Text = "Data Nascimento:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(84, 29);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(229, 20);
            this.txtbNome.TabIndex = 3;
            // 
            // cbDistrito
            // 
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDistrito.Items.AddRange(new object[] {
            "Aveiro",
            "",
            "Beja",
            "",
            "Braga",
            "",
            "Bragança",
            "",
            "Castelo Branco",
            "",
            "Coimbra",
            "",
            "Évora",
            "",
            "Faro",
            "",
            "Guarda",
            "",
            "Leiria",
            "",
            "Lisboa",
            "",
            "Portalegre",
            "",
            "Porto",
            "",
            "Santarém",
            "",
            "Setúbal",
            "",
            "Viana do Castelo",
            "",
            "Vila Real",
            "",
            "Viseu"});
            this.cbDistrito.Location = new System.Drawing.Point(92, 72);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(221, 21);
            this.cbDistrito.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(27, 149);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 6;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(112, 149);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 7;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dados:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 426);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.lblDistrito);
            this.tabPage1.Controls.Add(this.rbMasculino);
            this.tabPage1.Controls.Add(this.lblDatadeNascimento);
            this.tabPage1.Controls.Add(this.rbFeminino);
            this.tabPage1.Controls.Add(this.txtbNome);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.cbDistrito);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbDesporto);
            this.tabPage2.Controls.Add(this.cbMusica);
            this.tabPage2.Controls.Add(this.cbPintura);
            this.tabPage2.Controls.Add(this.cbFotografia);
            this.tabPage2.Controls.Add(this.cbJardinagem);
            this.tabPage2.Controls.Add(this.cbCulinaria);
            this.tabPage2.Controls.Add(this.cbLeitura);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hobbies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbDesporto
            // 
            this.cbDesporto.AutoSize = true;
            this.cbDesporto.Location = new System.Drawing.Point(19, 157);
            this.cbDesporto.Name = "cbDesporto";
            this.cbDesporto.Size = new System.Drawing.Size(69, 17);
            this.cbDesporto.TabIndex = 6;
            this.cbDesporto.Text = "Desporto";
            this.cbDesporto.UseVisualStyleBackColor = true;
            // 
            // cbMusica
            // 
            this.cbMusica.AutoSize = true;
            this.cbMusica.Location = new System.Drawing.Point(19, 134);
            this.cbMusica.Name = "cbMusica";
            this.cbMusica.Size = new System.Drawing.Size(60, 17);
            this.cbMusica.TabIndex = 5;
            this.cbMusica.Text = "Musica";
            this.cbMusica.UseVisualStyleBackColor = true;
            // 
            // cbPintura
            // 
            this.cbPintura.AutoSize = true;
            this.cbPintura.Location = new System.Drawing.Point(19, 111);
            this.cbPintura.Name = "cbPintura";
            this.cbPintura.Size = new System.Drawing.Size(59, 17);
            this.cbPintura.TabIndex = 4;
            this.cbPintura.Text = "Pintura";
            this.cbPintura.UseVisualStyleBackColor = true;
            // 
            // cbFotografia
            // 
            this.cbFotografia.AutoSize = true;
            this.cbFotografia.Location = new System.Drawing.Point(19, 88);
            this.cbFotografia.Name = "cbFotografia";
            this.cbFotografia.Size = new System.Drawing.Size(73, 17);
            this.cbFotografia.TabIndex = 3;
            this.cbFotografia.Text = "Fotografia";
            this.cbFotografia.UseVisualStyleBackColor = true;
            // 
            // cbJardinagem
            // 
            this.cbJardinagem.AutoSize = true;
            this.cbJardinagem.Location = new System.Drawing.Point(19, 65);
            this.cbJardinagem.Name = "cbJardinagem";
            this.cbJardinagem.Size = new System.Drawing.Size(80, 17);
            this.cbJardinagem.TabIndex = 2;
            this.cbJardinagem.Text = "Jardinagem";
            this.cbJardinagem.UseVisualStyleBackColor = true;
            // 
            // cbCulinaria
            // 
            this.cbCulinaria.AutoSize = true;
            this.cbCulinaria.Location = new System.Drawing.Point(19, 42);
            this.cbCulinaria.Name = "cbCulinaria";
            this.cbCulinaria.Size = new System.Drawing.Size(66, 17);
            this.cbCulinaria.TabIndex = 1;
            this.cbCulinaria.Text = "Culinaria";
            this.cbCulinaria.UseVisualStyleBackColor = true;
            // 
            // cbLeitura
            // 
            this.cbLeitura.AutoSize = true;
            this.cbLeitura.Location = new System.Drawing.Point(19, 19);
            this.cbLeitura.Name = "cbLeitura";
            this.cbLeitura.Size = new System.Drawing.Size(58, 17);
            this.cbLeitura.TabIndex = 0;
            this.cbLeitura.Text = "Leitura";
            this.cbLeitura.UseVisualStyleBackColor = true;
            // 
            // pbimagem
            // 
            this.pbimagem.Image = global::Forms1___PSI.Properties.Resources.Imagem_WhatsApp_2024_12_23_às_14_41_33_43e8de6c;
            this.pbimagem.Location = new System.Drawing.Point(504, 34);
            this.pbimagem.Name = "pbimagem";
            this.pbimagem.Size = new System.Drawing.Size(251, 208);
            this.pbimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagem.TabIndex = 10;
            this.pbimagem.TabStop = false;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(680, 248);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 31);
            this.btnValidar.TabIndex = 11;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.pbimagem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "janela";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblDatadeNascimento;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbimagem;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.CheckBox cbDesporto;
        private System.Windows.Forms.CheckBox cbMusica;
        private System.Windows.Forms.CheckBox cbPintura;
        private System.Windows.Forms.CheckBox cbFotografia;
        private System.Windows.Forms.CheckBox cbJardinagem;
        private System.Windows.Forms.CheckBox cbCulinaria;
        private System.Windows.Forms.CheckBox cbLeitura;
    }
}

