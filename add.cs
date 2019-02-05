using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lanware_server
{
    public partial class frm_add : Form
    {
        public frm_add()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void frm_add_Shown(object sender, EventArgs e)
        {
            this.hora.Focus();
        }
    }
}