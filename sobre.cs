using System;
using System.IO;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lanware_server
{
    public partial class frm_sobre : Form
    {
        public frm_sobre()
        {
            InitializeComponent();
        }

        private void frm_sobre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_sobre_Load(object sender, EventArgs e)
        {
            lb_nome.Text = Application.ProductName;
            lb_version.Text = Application.ProductVersion;

            //FileInfo sobre_file = new FileInfo("sobre.rtf");
            sobre_txt.LoadFile("lanware.rtf", RichTextBoxStreamType.RichText);
            //lb_licenca.Text = Application.VisualStyleState; 
        }
    }
}