using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using Microsoft.Win32;

namespace lanware_server
{
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void indicacao_CheckedChanged(object sender, EventArgs e)
        {
            if (indicacao.Checked)
            {
              MessageBox.Show("Indicacao");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey ch_conf = Registry.LocalMachine;
            ch_conf = ch_conf.OpenSubKey("SOFTWARE\\Neo Technologia\\Kronos Lanware");
            String vServidor = ch_conf.GetValue("Servidor").ToString();
            String vUsuario = ch_conf.GetValue("Usuario pgsql").ToString();
            String vSenha = ch_conf.GetValue("Senha pgsql").ToString();
            String vBanco = ch_conf.GetValue("Database").ToString();

            String qry_cadastro = "insert into usuarios values('"
                + label_nick.Text + "','"
                + label_nick.Text + "','"
                + edt_nome.Text + "','"
                + edt_sexo.Text + "',null,'"
                + edt_rg.Text + "',null,'"
                + edt_end.Text + "',null,'N')";
            
            NpgsqlConnection conn = new NpgsqlConnection("Server=" + vServidor + ";User Id="+ vUsuario + ";Password=" + vSenha + ";Database=" + vBanco + ";");
            NpgsqlCommand cad_ins = new NpgsqlCommand(qry_cadastro, conn);
            conn.Open();
            Int32 ins_result = cad_ins.ExecuteNonQuery();
            if (ins_result == 0)
            {
                MessageBox.Show("Cadastro não pode ser realizado.");
            }
            else
            {
                MessageBox.Show("Usuario cadastrado com sucesso!");
            }
            conn.Close();
            this.Close();
        }
    }
}