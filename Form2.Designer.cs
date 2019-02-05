namespace lanware_server
{
    partial class frm_cadastro
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
            this.foto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_nick = new System.Windows.Forms.Label();
            this.edt_nome = new System.Windows.Forms.TextBox();
            this.edt_end = new System.Windows.Forms.TextBox();
            this.edt_nascimento = new System.Windows.Forms.DateTimePicker();
            this.edt_rg = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.edt_sexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.indicacao = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // foto
            // 
            this.foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foto.Location = new System.Drawing.Point(9, 9);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(119, 95);
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RG (Opcional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Endereco (Opcional)";
            // 
            // label_nick
            // 
            this.label_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nick.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_nick.Location = new System.Drawing.Point(6, 111);
            this.label_nick.Name = "label_nick";
            this.label_nick.Size = new System.Drawing.Size(128, 16);
            this.label_nick.TabIndex = 5;
            this.label_nick.Text = "MMMMMMMMMM";
            this.label_nick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // edt_nome
            // 
            this.edt_nome.Location = new System.Drawing.Point(140, 25);
            this.edt_nome.Name = "edt_nome";
            this.edt_nome.Size = new System.Drawing.Size(255, 20);
            this.edt_nome.TabIndex = 0;
            // 
            // edt_end
            // 
            this.edt_end.Location = new System.Drawing.Point(140, 103);
            this.edt_end.Name = "edt_end";
            this.edt_end.Size = new System.Drawing.Size(255, 20);
            this.edt_end.TabIndex = 5;
            // 
            // edt_nascimento
            // 
            this.edt_nascimento.CustomFormat = "dd/MM/yyyy";
            this.edt_nascimento.Enabled = false;
            this.edt_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.edt_nascimento.Location = new System.Drawing.Point(140, 64);
            this.edt_nascimento.Name = "edt_nascimento";
            this.edt_nascimento.Size = new System.Drawing.Size(136, 20);
            this.edt_nascimento.TabIndex = 2;
            // 
            // edt_rg
            // 
            this.edt_rg.Location = new System.Drawing.Point(282, 65);
            this.edt_rg.Name = "edt_rg";
            this.edt_rg.Size = new System.Drawing.Size(113, 20);
            this.edt_rg.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(402, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(402, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // edt_sexo
            // 
            this.edt_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_sexo.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino"});
            this.edt_sexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_sexo.FormattingEnabled = true;
            this.edt_sexo.ItemHeight = 13;
            this.edt_sexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.edt_sexo.Location = new System.Drawing.Point(402, 24);
            this.edt_sexo.MaxDropDownItems = 2;
            this.edt_sexo.Name = "edt_sexo";
            this.edt_sexo.Size = new System.Drawing.Size(75, 21);
            this.edt_sexo.Sorted = true;
            this.edt_sexo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sexo";
            // 
            // indicacao
            // 
            this.indicacao.AutoSize = true;
            this.indicacao.Enabled = false;
            this.indicacao.Location = new System.Drawing.Point(402, 51);
            this.indicacao.Name = "indicacao";
            this.indicacao.Size = new System.Drawing.Size(73, 17);
            this.indicacao.TabIndex = 4;
            this.indicacao.Text = "Indicação";
            this.indicacao.UseVisualStyleBackColor = true;
            this.indicacao.CheckedChanged += new System.EventHandler(this.indicacao_CheckedChanged);
            // 
            // frm_cadastro
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(481, 136);
            this.Controls.Add(this.indicacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edt_sexo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edt_rg);
            this.Controls.Add(this.edt_nascimento);
            this.Controls.Add(this.edt_end);
            this.Controls.Add(this.edt_nome);
            this.Controls.Add(this.label_nick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frm_cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edt_nome;
        private System.Windows.Forms.TextBox edt_end;
        private System.Windows.Forms.DateTimePicker edt_nascimento;
        private System.Windows.Forms.MaskedTextBox edt_rg;
        public System.Windows.Forms.Label label_nick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox edt_sexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox indicacao;
    }
}