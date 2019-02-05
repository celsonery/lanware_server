using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Npgsql;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace lanware_server
{
    public partial class frm_config : Form
    {
        RegistryKey ch_conf = Registry.LocalMachine;
        NpgsqlConnection conn = new NpgsqlConnection();

        public frm_config()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (edt_proc_pid.Text != "" && edt_proc_nome.Text != "" && edt_proc_desc.Text != "")
            {
                NpgsqlCommand ins_proc = new NpgsqlCommand("insert into processos values('" + edt_proc_pid.Text + "','" + edt_proc_nome.Text + "','" + edt_proc_desc.Text + "')", conn);
                int result = ins_proc.ExecuteNonQuery();
                if (result != 0)
                {
                    status_lb.Text = "Cadastro inserido com sucesso!";
                    edt_proc_pid.Text = null;
                    edt_proc_nome.Text = null;
                    edt_proc_desc.Text = null;
                    busca_proc();
                }
            }
            else
            {
                status_lb.Text = "Deve ser preenchido os 3 campos obrigatoriamente.";
            }
        }


        private void frm_config_Load(object sender, EventArgs e)
        {
            ch_conf = ch_conf.OpenSubKey("SOFTWARE\\Neo Technologia\\Kronos Lanware");
            String vServidor = ch_conf.GetValue("Servidor").ToString();
            String vUsuario = ch_conf.GetValue("Usuario pgsql").ToString();
            String vSenha = ch_conf.GetValue("Senha pgsql").ToString();
            String vBanco = ch_conf.GetValue("Database").ToString();

            conn.ConnectionString = "Server=" + vServidor + ";User Id=" + vUsuario + ";Password=" + vSenha + ";Database=" + vBanco + ";";

            conn.Open();

            busca_usuario();
        }

        private void frm_config_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            switch (tabconfig.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    busca_maquinas();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    busca_proc();
                    break;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NpgsqlCommand add_maq = new NpgsqlCommand("insert into maquinas values('" + edt_maq.Text + "','" + edt_ip.Text + "')", conn);
            NpgsqlCommand add_ativ = new NpgsqlCommand("insert into atividade values('" + edt_maq.Text + "','','00:00:00','00:00:00','00:00:00','00:00:00')", conn);
            add_maq.ExecuteNonQuery();
            add_ativ.ExecuteNonQuery();
        }

        private void edt_proc_pid_TextChanged(object sender, EventArgs e)
        {
            if (edt_proc_pid.Text != "")
            {
                btn_proc_add.Enabled = true;
            }
            else
            {
                btn_proc_add.Enabled = false;
            }
        }

        private void grid_maq_Click(object sender, EventArgs e)
        {
            //string t = grid_maq.SelectedRows.Count;
            if (grid_maq.SelectedRows.Count != 0)
            {
                btn_del_maq.Enabled = true;
            }
            else
            {
                btn_del_maq.Enabled = false;
            }
        }

        private void btn_del_maq_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esta máquina?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NpgsqlCommand del_maq = new NpgsqlCommand("delete from maquinas where nome = '" + grid_maq.SelectedCells[0].Value + "'", conn);
                NpgsqlCommand del_atv = new NpgsqlCommand("delete from atividade where maquina = '" + grid_maq.SelectedCells[0].Value + "'", conn);
                del_maq.ExecuteNonQuery();
                del_atv.ExecuteNonQuery();
            }
                btn_del_maq.Enabled = false;
        }

        private void edt_maq_TextChanged(object sender, EventArgs e)
        {
            if (edt_maq.Text != "")
            {
                btn_regmaq.Enabled = true;
            }
        }

        private void btn_proc_at_Click(object sender, EventArgs e)
        {
        }

        public virtual void  busca_maquinas()
        {
         NpgsqlDataAdapter daMaq = new NpgsqlDataAdapter("select nome, ip from maquinas", conn);
         DataSet dsMaq = new DataSet();
         daMaq.Fill(dsMaq, "maquinas");
         grid_maq.DataSource = dsMaq.Tables["maquinas"];
         daMaq.Dispose();
         dsMaq.Dispose();
        }

        public virtual void busca_proc()
        {
            NpgsqlDataAdapter daProc = new NpgsqlDataAdapter("select * from processos", conn);
            DataSet dsProc = new DataSet();
            daProc.Fill(dsProc, "processos");
            grid_proc.DataSource = dsProc.Tables["processos"];
            daProc.Dispose();
            dsProc.Dispose();
        }

        public virtual void busca_usuario()
        {
            grid_usuarios.Rows.Clear();

            NpgsqlCommand cmdUsr = new NpgsqlCommand("select nick, nome, senha from usuarios order by nick asc", conn);
            NpgsqlDataReader drUsr = cmdUsr.ExecuteReader();

            while (drUsr.Read())
            {
                grid_usuarios.Rows.Add(drUsr[0], drUsr[1]);
            }

            drUsr.Close();
            cmdUsr.Dispose();

            /*
            NpgsqlDataAdapter daUsr = new NpgsqlDataAdapter("select nick, nome from usuarios order by nick asc", conn);
            DataSet dsUsr = new DataSet();
            daUsr.Fill(dsUsr, "usuarios");
            grid_usuarios.DataSource = dsUsr.Tables["usuarios"];
            daUsr.Dispose();
            dsUsr.Dispose();
             */
        }

        private void btn_proc_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir tal processo?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NpgsqlCommand del_proc = new NpgsqlCommand("delete from processos where pid = '" + grid_proc.SelectedCells[0].Value + "'", conn);
                int result = del_proc.ExecuteNonQuery();
                if (result != 0)
                {
                    status_lb.Text = "Remoção do processo realizado com sucesso!";
                    busca_proc();
                }
                else
                {
                    status_lb.Text = "Ocorreu erro ao remover processo!";
                }
            }
        }

        private void grid_proc_Click(object sender, EventArgs e)
        {
            if (grid_proc.SelectedRows.Count != 0)
            {
                btn_proc_del.Enabled = true;
            }
            else
            {
                btn_proc_del.Enabled = false;
            }
        }
       
        private void edt_usr_nick_TextChanged(object sender, EventArgs e)
        {
            edt_usr_nome.Text = null;
            if (edt_usr_nick.Text != "")
            {
                btn_usr_search.Enabled = true;
            }
            else
            {
                btn_usr_search.Enabled = false;
            }
        }
       
        private void edt_usr_nome_TextChanged(object sender, EventArgs e)
        {
            edt_usr_nick.Text = null;
            if (edt_usr_nome.Text != "")
            {
                btn_usr_search.Enabled = true;
            }
            else
            {
                btn_usr_search.Enabled = false;
            }
        }
       
        private void btn_usr_search_Click(object sender, EventArgs e)
        {
            if (edt_usr_nick.Text != "")
            {
                //grid_usuarios.Enabled = false;
                grid_usuarios.Rows.Clear();
                NpgsqlCommand cmdUsr = new NpgsqlCommand("select * from usuarios where nick like '%" + edt_usr_nick.Text + "%' order by nick asc", conn);
                NpgsqlDataReader drUsr = cmdUsr.ExecuteReader();

                while (drUsr.Read())
                {
                    grid_usuarios.Rows.Add(drUsr[0], drUsr[2]);
                }
                drUsr.Close();
                cmdUsr.Dispose();
                edt_usr_nick.Clear();
            }
            
            if(edt_usr_nome.Text != "")
            {
                grid_usuarios.Rows.Clear();

                NpgsqlCommand cmdUsr = new NpgsqlCommand("select * from usuarios where nome like '%" + edt_usr_nome.Text + "%'", conn);
                NpgsqlDataReader drUsr = cmdUsr.ExecuteReader();

                while (drUsr.Read())
                {
                    grid_usuarios.Rows.Add(drUsr[0], drUsr[2]);
                }
                drUsr.Close();
                cmdUsr.Dispose();
                edt_usr_nome.Clear();
            }
        }

        private void btn_usr_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir usuário?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NpgsqlCommand cmdDel = new NpgsqlCommand("delete from usuarios where nick = '" + grid_usuarios.SelectedCells[0].Value + "'", conn);
                int result = cmdDel.ExecuteNonQuery();

                if (result != 0)
                {
                    status_lb.Text = "Exclusão do usuario realizado com sucesso!";
                    busca_usuario();
                }
            }
        }

        private void grid_usuarios_Click(object sender, EventArgs e)
        {
            if (grid_usuarios.SelectedCells.Count != 0)
            {
                btn_usr_del.Enabled = true;
                NpgsqlCommand cmdUsr = new NpgsqlCommand("select senha from usuarios where nick like '%" + grid_usuarios.SelectedCells[0].Value + "%'", conn);
                NpgsqlDataReader drUsr = cmdUsr.ExecuteReader();
                drUsr.Read();
                senha.Text = drUsr[0].ToString();
                reset.Enabled = true;
                drUsr.Close();
                cmdUsr.Dispose();
            }
            else
            {
                btn_usr_del.Enabled = false;
                reset.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (abrir_foto.ShowDialog() == DialogResult.OK)
            {
                foto.Load(abrir_foto.FileName);
            }
        }

        private void grid_usuarios_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void grid_usuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente resetar senha para este usuário?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NpgsqlCommand cmdRes = new NpgsqlCommand("update usuarios set senha = '" + grid_usuarios.SelectedCells[0].Value + "' where nick = '" + grid_usuarios.SelectedCells[0].Value + "'", conn);
                int result = cmdRes.ExecuteNonQuery();

                if (result != 0)
                {
                    status_lb.Text = "Alteração de senha realizada com sucesso!";
                    busca_usuario();
                }
            }

        }
    }
}