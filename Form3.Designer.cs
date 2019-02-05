namespace lanware_server
{
    partial class frm_config
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
            this.tabconfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.senha = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_usr_del = new System.Windows.Forms.Button();
            this.btn_usr_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_usr_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_usr_nick = new System.Windows.Forms.TextBox();
            this.comboDRV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.grid_usuarios = new System.Windows.Forms.DataGridView();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usr_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_del_maq = new System.Windows.Forms.Button();
            this.btn_at_maq = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_regmaq = new System.Windows.Forms.Button();
            this.edt_ip = new System.Windows.Forms.MaskedTextBox();
            this.edt_maq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_maq = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edt_srv_ip = new System.Windows.Forms.MaskedTextBox();
            this.edt_srv_port = new System.Windows.Forms.MaskedTextBox();
            this.combo_tipo_srv = new System.Windows.Forms.ComboBox();
            this.edt_srv_senha = new System.Windows.Forms.TextBox();
            this.edt_srv_user = new System.Windows.Forms.TextBox();
            this.edt_nome_banco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_proc_del = new System.Windows.Forms.Button();
            this.btn_proc_add = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_proc_desc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.edt_proc_nome = new System.Windows.Forms.TextBox();
            this.edt_proc_pid = new System.Windows.Forms.TextBox();
            this.grid_proc = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.status_lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.abrir_foto = new System.Windows.Forms.OpenFileDialog();
            this.tabconfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_maq)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_proc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabconfig
            // 
            this.tabconfig.Controls.Add(this.tabPage1);
            this.tabconfig.Controls.Add(this.tabPage2);
            this.tabconfig.Controls.Add(this.tabPage3);
            this.tabconfig.Controls.Add(this.tabPage4);
            this.tabconfig.Controls.Add(this.tabPage5);
            this.tabconfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabconfig.Location = new System.Drawing.Point(0, 0);
            this.tabconfig.Name = "tabconfig";
            this.tabconfig.SelectedIndex = 0;
            this.tabconfig.Size = new System.Drawing.Size(482, 238);
            this.tabconfig.TabIndex = 0;
            this.tabconfig.Click += new System.EventHandler(this.tabControl1_Click);
            this.tabconfig.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.senha);
            this.tabPage1.Controls.Add(this.reset);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.comboDRV);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.foto);
            this.tabPage1.Controls.Add(this.grid_usuarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuários";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.ForeColor = System.Drawing.Color.Blue;
            this.senha.Location = new System.Drawing.Point(364, 194);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(77, 13);
            this.senha.TabIndex = 13;
            this.senha.Text = "0000000000";
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Image = global::lanware_server.Properties.Resources.RepeatHS;
            this.reset.Location = new System.Drawing.Point(442, 191);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(25, 20);
            this.reset.TabIndex = 12;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(328, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Senha:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(213, 194);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "10/10/2006 10:20";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(141, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Último acesso:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_usr_del);
            this.groupBox1.Controls.Add(this.btn_usr_search);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edt_usr_nome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edt_usr_nick);
            this.groupBox1.Location = new System.Drawing.Point(145, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Procurar por: ";
            // 
            // btn_usr_del
            // 
            this.btn_usr_del.Enabled = false;
            this.btn_usr_del.Location = new System.Drawing.Point(250, 17);
            this.btn_usr_del.Name = "btn_usr_del";
            this.btn_usr_del.Size = new System.Drawing.Size(64, 43);
            this.btn_usr_del.TabIndex = 6;
            this.btn_usr_del.Text = "Excluir Usuário";
            this.btn_usr_del.UseVisualStyleBackColor = true;
            this.btn_usr_del.Click += new System.EventHandler(this.btn_usr_del_Click);
            // 
            // btn_usr_search
            // 
            this.btn_usr_search.Enabled = false;
            this.btn_usr_search.Location = new System.Drawing.Point(174, 17);
            this.btn_usr_search.Name = "btn_usr_search";
            this.btn_usr_search.Size = new System.Drawing.Size(66, 43);
            this.btn_usr_search.TabIndex = 5;
            this.btn_usr_search.Text = "Procurar Usuário";
            this.btn_usr_search.UseVisualStyleBackColor = true;
            this.btn_usr_search.Click += new System.EventHandler(this.btn_usr_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // edt_usr_nome
            // 
            this.edt_usr_nome.Location = new System.Drawing.Point(45, 42);
            this.edt_usr_nome.Name = "edt_usr_nome";
            this.edt_usr_nome.Size = new System.Drawing.Size(122, 20);
            this.edt_usr_nome.TabIndex = 2;
            this.edt_usr_nome.TextChanged += new System.EventHandler(this.edt_usr_nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nick:";
            // 
            // edt_usr_nick
            // 
            this.edt_usr_nick.Location = new System.Drawing.Point(45, 18);
            this.edt_usr_nick.Name = "edt_usr_nick";
            this.edt_usr_nick.Size = new System.Drawing.Size(122, 20);
            this.edt_usr_nick.TabIndex = 0;
            this.edt_usr_nick.TextChanged += new System.EventHandler(this.edt_usr_nick_TextChanged);
            // 
            // comboDRV
            // 
            this.comboDRV.FormattingEnabled = true;
            this.comboDRV.Items.AddRange(new object[] {
            "Scanner",
            "Camera Digital",
            "WebCam"});
            this.comboDRV.Location = new System.Drawing.Point(10, 19);
            this.comboDRV.Name = "comboDRV";
            this.comboDRV.Size = new System.Drawing.Size(121, 21);
            this.comboDRV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capturar de:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(99, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Abrir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Capturar agora";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // foto
            // 
            this.foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foto.Location = new System.Drawing.Point(11, 79);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(122, 108);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 1;
            this.foto.TabStop = false;
            // 
            // grid_usuarios
            // 
            this.grid_usuarios.AllowDrop = true;
            this.grid_usuarios.AllowUserToAddRows = false;
            this.grid_usuarios.AllowUserToResizeColumns = false;
            this.grid_usuarios.AllowUserToResizeRows = false;
            this.grid_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nick,
            this.usr_nome});
            this.grid_usuarios.Location = new System.Drawing.Point(146, 78);
            this.grid_usuarios.MultiSelect = false;
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.ReadOnly = true;
            this.grid_usuarios.RowHeadersVisible = false;
            this.grid_usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_usuarios.Size = new System.Drawing.Size(320, 112);
            this.grid_usuarios.TabIndex = 0;
            this.grid_usuarios.Click += new System.EventHandler(this.grid_usuarios_Click);
            // 
            // nick
            // 
            this.nick.DataPropertyName = "nick";
            this.nick.FillWeight = 68.83714F;
            this.nick.HeaderText = "Nick";
            this.nick.MaxInputLength = 20;
            this.nick.Name = "nick";
            this.nick.ReadOnly = true;
            this.nick.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // usr_nome
            // 
            this.usr_nome.DataPropertyName = "nome";
            this.usr_nome.FillWeight = 139.7923F;
            this.usr_nome.HeaderText = "Nome";
            this.usr_nome.MaxInputLength = 40;
            this.usr_nome.Name = "usr_nome";
            this.usr_nome.ReadOnly = true;
            this.usr_nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_del_maq);
            this.tabPage2.Controls.Add(this.btn_at_maq);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.grid_maq);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Máquinas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_del_maq
            // 
            this.btn_del_maq.Enabled = false;
            this.btn_del_maq.Location = new System.Drawing.Point(387, 46);
            this.btn_del_maq.Name = "btn_del_maq";
            this.btn_del_maq.Size = new System.Drawing.Size(75, 23);
            this.btn_del_maq.TabIndex = 4;
            this.btn_del_maq.Text = "Excluir";
            this.btn_del_maq.UseVisualStyleBackColor = true;
            this.btn_del_maq.Click += new System.EventHandler(this.btn_del_maq_Click);
            // 
            // btn_at_maq
            // 
            this.btn_at_maq.Enabled = false;
            this.btn_at_maq.Location = new System.Drawing.Point(387, 15);
            this.btn_at_maq.Name = "btn_at_maq";
            this.btn_at_maq.Size = new System.Drawing.Size(75, 23);
            this.btn_at_maq.TabIndex = 3;
            this.btn_at_maq.Text = "Atualizar";
            this.btn_at_maq.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_regmaq);
            this.groupBox2.Controls.Add(this.edt_ip);
            this.groupBox2.Controls.Add(this.edt_maq);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Registrar maquina: ";
            // 
            // btn_regmaq
            // 
            this.btn_regmaq.Enabled = false;
            this.btn_regmaq.Location = new System.Drawing.Point(282, 15);
            this.btn_regmaq.Name = "btn_regmaq";
            this.btn_regmaq.Size = new System.Drawing.Size(80, 43);
            this.btn_regmaq.TabIndex = 4;
            this.btn_regmaq.Text = "Registrar Maquina";
            this.btn_regmaq.UseVisualStyleBackColor = true;
            this.btn_regmaq.Click += new System.EventHandler(this.button8_Click);
            // 
            // edt_ip
            // 
            this.edt_ip.Location = new System.Drawing.Point(148, 40);
            this.edt_ip.Name = "edt_ip";
            this.edt_ip.Size = new System.Drawing.Size(100, 20);
            this.edt_ip.TabIndex = 3;
            this.edt_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edt_maq
            // 
            this.edt_maq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edt_maq.Location = new System.Drawing.Point(148, 17);
            this.edt_maq.MaxLength = 20;
            this.edt_maq.Name = "edt_maq";
            this.edt_maq.Size = new System.Drawing.Size(100, 20);
            this.edt_maq.TabIndex = 2;
            this.edt_maq.TextChanged += new System.EventHandler(this.edt_maq_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Endereço IP da maquina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome da maquina:";
            // 
            // grid_maq
            // 
            this.grid_maq.AllowUserToAddRows = false;
            this.grid_maq.AllowUserToDeleteRows = false;
            this.grid_maq.AllowUserToResizeColumns = false;
            this.grid_maq.AllowUserToResizeRows = false;
            this.grid_maq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_maq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_maq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_maq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_maq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.ip});
            this.grid_maq.Location = new System.Drawing.Point(9, 83);
            this.grid_maq.MultiSelect = false;
            this.grid_maq.Name = "grid_maq";
            this.grid_maq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_maq.RowHeadersVisible = false;
            this.grid_maq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_maq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_maq.Size = new System.Drawing.Size(453, 123);
            this.grid_maq.TabIndex = 1;
            this.grid_maq.Click += new System.EventHandler(this.grid_maq_Click);
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Maquina";
            this.nome.MaxInputLength = 10;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ip
            // 
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "endereco ip";
            this.ip.MaxInputLength = 40;
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            this.ip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(474, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Identificação do Servidor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edt_srv_ip);
            this.groupBox3.Controls.Add(this.edt_srv_port);
            this.groupBox3.Controls.Add(this.combo_tipo_srv);
            this.groupBox3.Controls.Add(this.edt_srv_senha);
            this.groupBox3.Controls.Add(this.edt_srv_user);
            this.groupBox3.Controls.Add(this.edt_nome_banco);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(9, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 173);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Servidor: ";
            // 
            // edt_srv_ip
            // 
            this.edt_srv_ip.Location = new System.Drawing.Point(34, 81);
            this.edt_srv_ip.Mask = "000,000,000,000";
            this.edt_srv_ip.Name = "edt_srv_ip";
            this.edt_srv_ip.Size = new System.Drawing.Size(100, 20);
            this.edt_srv_ip.TabIndex = 11;
            this.edt_srv_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edt_srv_port
            // 
            this.edt_srv_port.Location = new System.Drawing.Point(177, 81);
            this.edt_srv_port.Mask = "0";
            this.edt_srv_port.Name = "edt_srv_port";
            this.edt_srv_port.Size = new System.Drawing.Size(61, 20);
            this.edt_srv_port.TabIndex = 10;
            this.edt_srv_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // combo_tipo_srv
            // 
            this.combo_tipo_srv.FormattingEnabled = true;
            this.combo_tipo_srv.Location = new System.Drawing.Point(117, 22);
            this.combo_tipo_srv.Name = "combo_tipo_srv";
            this.combo_tipo_srv.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_srv.TabIndex = 9;
            // 
            // edt_srv_senha
            // 
            this.edt_srv_senha.Location = new System.Drawing.Point(139, 129);
            this.edt_srv_senha.Name = "edt_srv_senha";
            this.edt_srv_senha.Size = new System.Drawing.Size(100, 20);
            this.edt_srv_senha.TabIndex = 8;
            // 
            // edt_srv_user
            // 
            this.edt_srv_user.Location = new System.Drawing.Point(18, 130);
            this.edt_srv_user.Name = "edt_srv_user";
            this.edt_srv_user.Size = new System.Drawing.Size(100, 20);
            this.edt_srv_user.TabIndex = 7;
            // 
            // edt_nome_banco
            // 
            this.edt_nome_banco.Location = new System.Drawing.Point(117, 55);
            this.edt_nome_banco.Name = "edt_nome_banco";
            this.edt_nome_banco.Size = new System.Drawing.Size(121, 20);
            this.edt_nome_banco.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Senha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Usuário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Porta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "IP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Banco de dados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipo de servidor:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(474, 212);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Módulo cliente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(306, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_proc_del);
            this.tabPage5.Controls.Add(this.btn_proc_add);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.grid_proc);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(474, 212);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Processos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_proc_del
            // 
            this.btn_proc_del.Enabled = false;
            this.btn_proc_del.Location = new System.Drawing.Point(387, 144);
            this.btn_proc_del.Name = "btn_proc_del";
            this.btn_proc_del.Size = new System.Drawing.Size(75, 23);
            this.btn_proc_del.TabIndex = 11;
            this.btn_proc_del.Text = "Excluir";
            this.btn_proc_del.UseVisualStyleBackColor = true;
            this.btn_proc_del.Click += new System.EventHandler(this.btn_proc_del_Click);
            // 
            // btn_proc_add
            // 
            this.btn_proc_add.Enabled = false;
            this.btn_proc_add.Location = new System.Drawing.Point(388, 112);
            this.btn_proc_add.Name = "btn_proc_add";
            this.btn_proc_add.Size = new System.Drawing.Size(75, 23);
            this.btn_proc_add.TabIndex = 9;
            this.btn_proc_add.Text = "Adicionar";
            this.btn_proc_add.UseVisualStyleBackColor = true;
            this.btn_proc_add.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Processos cadastrados:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.edt_proc_desc);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.edt_proc_nome);
            this.groupBox4.Controls.Add(this.edt_proc_pid);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(458, 90);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Incluir processo para ser finalizado: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(235, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome do Programa: ";
            // 
            // edt_proc_desc
            // 
            this.edt_proc_desc.Location = new System.Drawing.Point(238, 60);
            this.edt_proc_desc.MaxLength = 40;
            this.edt_proc_desc.Name = "edt_proc_desc";
            this.edt_proc_desc.Size = new System.Drawing.Size(211, 20);
            this.edt_proc_desc.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Nome PID:";
            // 
            // edt_proc_nome
            // 
            this.edt_proc_nome.Location = new System.Drawing.Point(10, 60);
            this.edt_proc_nome.MaxLength = 20;
            this.edt_proc_nome.Name = "edt_proc_nome";
            this.edt_proc_nome.Size = new System.Drawing.Size(210, 20);
            this.edt_proc_nome.TabIndex = 8;
            // 
            // edt_proc_pid
            // 
            this.edt_proc_pid.Location = new System.Drawing.Point(68, 18);
            this.edt_proc_pid.MaxLength = 15;
            this.edt_proc_pid.Name = "edt_proc_pid";
            this.edt_proc_pid.Size = new System.Drawing.Size(100, 20);
            this.edt_proc_pid.TabIndex = 7;
            this.edt_proc_pid.TextChanged += new System.EventHandler(this.edt_proc_pid_TextChanged);
            // 
            // grid_proc
            // 
            this.grid_proc.AllowUserToAddRows = false;
            this.grid_proc.AllowUserToDeleteRows = false;
            this.grid_proc.AllowUserToResizeColumns = false;
            this.grid_proc.AllowUserToResizeRows = false;
            this.grid_proc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_proc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_proc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.Programa,
            this.desc});
            this.grid_proc.Location = new System.Drawing.Point(8, 113);
            this.grid_proc.MultiSelect = false;
            this.grid_proc.Name = "grid_proc";
            this.grid_proc.RowHeadersVisible = false;
            this.grid_proc.RowTemplate.ReadOnly = true;
            this.grid_proc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_proc.Size = new System.Drawing.Size(373, 95);
            this.grid_proc.TabIndex = 1;
            this.grid_proc.Click += new System.EventHandler(this.grid_proc_Click);
            // 
            // PID
            // 
            this.PID.DataPropertyName = "pid";
            this.PID.HeaderText = "Nome PID";
            this.PID.MaxInputLength = 15;
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Programa
            // 
            this.Programa.DataPropertyName = "nome";
            this.Programa.HeaderText = "Programa";
            this.Programa.MaxInputLength = 20;
            this.Programa.Name = "Programa";
            this.Programa.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.DataPropertyName = "descricao";
            this.desc.HeaderText = "Descrição";
            this.desc.MaxInputLength = 40;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // statusbar
            // 
            this.statusbar.Location = new System.Drawing.Point(0, 238);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(482, 22);
            this.statusbar.TabIndex = 1;
            // 
            // status_lb
            // 
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(0, 17);
            // 
            // abrir_foto
            // 
            this.abrir_foto.Title = "Abrir foto existente.";
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 260);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.tabconfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_config_FormClosed);
            this.Load += new System.EventHandler(this.frm_config_Load);
            this.tabconfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_maq)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_proc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grid_usuarios;
        private System.Windows.Forms.DataGridView grid_maq;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView grid_proc;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edt_usr_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edt_usr_nick;
        private System.Windows.Forms.ComboBox comboDRV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox edt_ip;
        private System.Windows.Forms.TextBox edt_maq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo_tipo_srv;
        private System.Windows.Forms.TextBox edt_srv_senha;
        private System.Windows.Forms.TextBox edt_srv_user;
        private System.Windows.Forms.TextBox edt_nome_banco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox edt_srv_ip;
        private System.Windows.Forms.MaskedTextBox edt_srv_port;
        private System.Windows.Forms.Button btn_proc_add;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_proc_desc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox edt_proc_nome;
        private System.Windows.Forms.TextBox edt_proc_pid;
        private System.Windows.Forms.Button btn_del_maq;
        private System.Windows.Forms.Button btn_at_maq;
        private System.Windows.Forms.Button btn_regmaq;
        private System.Windows.Forms.Button btn_proc_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.ToolStripStatusLabel status_lb;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.Button btn_usr_search;
        private System.Windows.Forms.Button btn_usr_del;
        private System.Windows.Forms.OpenFileDialog abrir_foto;
        public System.Windows.Forms.TabControl tabconfig;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn usr_nome;
    }
}