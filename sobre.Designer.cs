namespace lanware_server
{
    partial class frm_sobre
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_licenca = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sobre_txt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lanware_server.Properties.Resources.Net1;
            this.pictureBox1.Location = new System.Drawing.Point(303, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(132, 88);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.neo-tech.net";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_licenca);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lb_version);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_nome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 70);
            this.panel1.TabIndex = 3;
            // 
            // lb_licenca
            // 
            this.lb_licenca.AutoSize = true;
            this.lb_licenca.Location = new System.Drawing.Point(109, 36);
            this.lb_licenca.Name = "lb_licenca";
            this.lb_licenca.Size = new System.Drawing.Size(35, 13);
            this.lb_licenca.TabIndex = 5;
            this.lb_licenca.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Licenciado para:";
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.Location = new System.Drawing.Point(109, 18);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(35, 13);
            this.lb_version.TabIndex = 3;
            this.lb_version.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Versão do Produto:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(109, 0);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto:";
            // 
            // sobre_txt
            // 
            this.sobre_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sobre_txt.Location = new System.Drawing.Point(17, 12);
            this.sobre_txt.Name = "sobre_txt";
            this.sobre_txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sobre_txt.Size = new System.Drawing.Size(280, 72);
            this.sobre_txt.TabIndex = 4;
            this.sobre_txt.Text = "";
            this.sobre_txt.Click += new System.EventHandler(this.frm_sobre_Click);
            // 
            // frm_sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(361, 187);
            this.Controls.Add(this.sobre_txt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre o Lanware";
            this.Click += new System.EventHandler(this.frm_sobre_Click);
            this.Load += new System.EventHandler(this.frm_sobre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_licenca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox sobre_txt;
    }
}