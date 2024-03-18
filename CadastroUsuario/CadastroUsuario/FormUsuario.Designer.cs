namespace CadastroUsuario
{
    partial class FormUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonUltimo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonProximo = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonPrimeiro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.listBoxNomes = new System.Windows.Forms.ListBox();
            this.buttonListaNomesUsuario = new System.Windows.Forms.Button();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNovo);
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonUltimo);
            this.groupBox1.Controls.Add(this.buttonProximo);
            this.groupBox1.Controls.Add(this.buttonAnterior);
            this.groupBox1.Controls.Add(this.buttonPrimeiro);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(6, 11);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(62, 22);
            this.buttonNovo.TabIndex = 10;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.ImageKey = "(none)";
            this.buttonExcluir.Location = new System.Drawing.Point(414, 11);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(73, 22);
            this.buttonExcluir.TabIndex = 16;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.ImageKey = "(none)";
            this.buttonSalvar.Location = new System.Drawing.Point(346, 11);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(62, 22);
            this.buttonSalvar.TabIndex = 15;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.ImageKey = "proximo.png";
            this.buttonUltimo.ImageList = this.imageList1;
            this.buttonUltimo.Location = new System.Drawing.Point(278, 11);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(62, 22);
            this.buttonUltimo.TabIndex = 14;
            this.buttonUltimo.UseVisualStyleBackColor = true;
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "anterior.png");
            this.imageList1.Images.SetKeyName(1, "seta.png");
            this.imageList1.Images.SetKeyName(2, "mover.png");
            this.imageList1.Images.SetKeyName(3, "proximo.png");
            // 
            // buttonProximo
            // 
            this.buttonProximo.ImageKey = "mover.png";
            this.buttonProximo.ImageList = this.imageList1;
            this.buttonProximo.Location = new System.Drawing.Point(210, 11);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(62, 22);
            this.buttonProximo.TabIndex = 13;
            this.buttonProximo.UseVisualStyleBackColor = true;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.ImageKey = "seta.png";
            this.buttonAnterior.ImageList = this.imageList1;
            this.buttonAnterior.Location = new System.Drawing.Point(142, 11);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(62, 22);
            this.buttonAnterior.TabIndex = 12;
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonPrimeiro
            // 
            this.buttonPrimeiro.ImageKey = "anterior.png";
            this.buttonPrimeiro.ImageList = this.imageList1;
            this.buttonPrimeiro.Location = new System.Drawing.Point(74, 11);
            this.buttonPrimeiro.Name = "buttonPrimeiro";
            this.buttonPrimeiro.Size = new System.Drawing.Size(62, 22);
            this.buttonPrimeiro.TabIndex = 11;
            this.buttonPrimeiro.UseVisualStyleBackColor = true;
            this.buttonPrimeiro.Click += new System.EventHandler(this.buttonPrimeiro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxId);
            this.groupBox2.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBox2.Controls.Add(this.maskedTextBoxCPF);
            this.groupBox2.Controls.Add(this.listBoxNomes);
            this.groupBox2.Controls.Add(this.buttonListaNomesUsuario);
            this.groupBox2.Controls.Add(this.textBoxEndereco);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.labelDataNascimento);
            this.groupBox2.Controls.Add(this.labelNumero);
            this.groupBox2.Controls.Add(this.labelNome);
            this.groupBox2.Controls.Add(this.labelTelefone);
            this.groupBox2.Controls.Add(this.labelEndereco);
            this.groupBox2.Controls.Add(this.labelSexo);
            this.groupBox2.Controls.Add(this.labelComplemento);
            this.groupBox2.Controls.Add(this.labelCPF);
            this.groupBox2.Controls.Add(this.comboBoxSexo);
            this.groupBox2.Controls.Add(this.dateTimePickerDataNascimento);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.textBoxNome);
            this.groupBox2.Controls.Add(this.textBoxComplemento);
            this.groupBox2.Controls.Add(this.textBoxNumero);
            this.groupBox2.Location = new System.Drawing.Point(13, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(346, 29);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(29, 22);
            this.textBoxId.TabIndex = 17;
            this.textBoxId.Visible = false;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(87, 136);
            this.maskedTextBoxTelefone.Mask = "(00)00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(129, 22);
            this.maskedTextBoxTelefone.TabIndex = 5;
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(87, 18);
            this.maskedTextBoxCPF.Mask = "000,000,000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(129, 22);
            this.maskedTextBoxCPF.TabIndex = 1;
            this.maskedTextBoxCPF.Leave += new System.EventHandler(this.maskedTextBoxCPF_Leave);
            // 
            // listBoxNomes
            // 
            this.listBoxNomes.FormattingEnabled = true;
            this.listBoxNomes.ItemHeight = 16;
            this.listBoxNomes.Location = new System.Drawing.Point(381, 29);
            this.listBoxNomes.Name = "listBoxNomes";
            this.listBoxNomes.Size = new System.Drawing.Size(106, 20);
            this.listBoxNomes.TabIndex = 18;
            this.listBoxNomes.Visible = false;
            this.listBoxNomes.SelectedIndexChanged += new System.EventHandler(this.listBoxNomes_SelectedIndexChanged);
            // 
            // buttonListaNomesUsuario
            // 
            this.buttonListaNomesUsuario.ImageKey = "Lupa.jpg";
            this.buttonListaNomesUsuario.Location = new System.Drawing.Point(475, 58);
            this.buttonListaNomesUsuario.Name = "buttonListaNomesUsuario";
            this.buttonListaNomesUsuario.Size = new System.Drawing.Size(10, 15);
            this.buttonListaNomesUsuario.TabIndex = 19;
            this.buttonListaNomesUsuario.UseVisualStyleBackColor = true;
            this.buttonListaNomesUsuario.Click += new System.EventHandler(this.buttonListaNomesUsuario_Click);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(87, 209);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(399, 22);
            this.textBoxEndereco.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(25, 174);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 16);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(222, 95);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(126, 16);
            this.labelDataNascimento.TabIndex = 15;
            this.labelDataNascimento.Text = "Data Nascimento";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(13, 259);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(61, 16);
            this.labelNumero.TabIndex = 13;
            this.labelNumero.Text = "Numero";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(23, 58);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(48, 16);
            this.labelNome.TabIndex = 12;
            this.labelNome.Text = "Nome";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(6, 136);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(69, 16);
            this.labelTelefone.TabIndex = 11;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(-3, 215);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(74, 16);
            this.labelEndereco.TabIndex = 10;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(29, 95);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(42, 16);
            this.labelSexo.TabIndex = 9;
            this.labelSexo.Text = "Sexo";
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(247, 259);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(102, 16);
            this.labelComplemento.TabIndex = 8;
            this.labelComplemento.Text = "Complemento";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(32, 18);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(36, 16);
            this.labelCPF.TabIndex = 7;
            this.labelCPF.Text = "CPF";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBoxSexo.Location = new System.Drawing.Point(87, 92);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(129, 24);
            this.comboBoxSexo.TabIndex = 3;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(356, 95);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(130, 22);
            this.dateTimePickerDataNascimento.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(87, 171);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(399, 22);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(87, 55);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(399, 22);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(357, 253);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(130, 22);
            this.textBoxComplemento.TabIndex = 9;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(87, 253);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(129, 22);
            this.textBoxNumero.TabIndex = 8;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUsuario";
            this.Text = "Cadastro de Usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonUltimo;
        private System.Windows.Forms.Button buttonProximo;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonPrimeiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonListaNomesUsuario;
        private System.Windows.Forms.ListBox listBoxNomes;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.TextBox textBoxId;
        public System.Windows.Forms.ComboBox comboBoxSexo;
    }
}

