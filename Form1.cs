using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using System.Drawing;
using System.IO;
using System.Text;
using System.Net;
using Microsoft.Win32;
using System.Windows.Forms;
//using System.Runtime.InteropServices;


namespace lanware_server
{

    public partial class frm_principal : Form
    {
        //[DllImport("winmm.dll")]
        //static extern bool PlaySound(string file, int module, int flags );

        NpgsqlConnection kronos_con = new NpgsqlConnection();
        RegistryKey ch_conf = Registry.LocalMachine;

        public frm_principal()
        {
            InitializeComponent();
            this.Text = "Kronos Lanware Server - Versão : " + Application.ProductVersion;
            ch_conf = ch_conf.OpenSubKey("SOFTWARE\\Neo Technologia\\Kronos Lanware");
        }

        public void log(string text)
        {
            string agora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            StreamWriter log_file = new StreamWriter("lanware_server.log", true, Encoding.ASCII);

            try
            {
                log_file.WriteLine(agora + " - " + text);
                log_txt.AppendText(agora + " - " + text + "\n");
                log_file.Close();
            }
            catch(Exception error)
            {
                log_file.WriteLine(agora + " - " + error.Message);
                log_txt.Text = log_txt.Text + agora + " - " + error.Message + "\n";
                //PlaySound("C:\\Windows\\Media\\notify.wav", 0, 0);
            }
        }

        public void frm_principal_Shown(object sender, EventArgs e)
        {
            edt_nick.Focus();
            String visao = ch_conf.GetValue("Visao").ToString();
            switch (visao)
            {
                case "icones":
                    stilo.SelectedIndex = 0;
                    LView.View = View.LargeIcon;
                    break;
                case "lista":
                    stilo.SelectedIndex = 1;
                    LView.View = View.Details;
                    break;
            }
            /*
            String visao_est = ch_conf.GetValue("Visao est").ToString();
            switch (visao_est)
            {
                case "nick":
                    stilo_est.SelectedIndex = 0;
                    break;
                case "tmp_rest":
                    stilo_est.SelectedIndex = 1;
                    break;
            }
            */
            relogio.Interval = Convert.ToInt32(ch_conf.GetValue("intervalo")) * 1000;

            /* 
             * acessa o registro do windows para pegar o ip do servidor
             * apos realiza ping para saber se esta vivo.
             */

            String vServidor = ch_conf.GetValue("Servidor").ToString();
            String vUsuario = ch_conf.GetValue("Usuario pgsql").ToString();
            String vSenha = ch_conf.GetValue("Senha pgsql").ToString();
            String vBanco = ch_conf.GetValue("Database").ToString();
            
            log("Iniciando a aplicação...");
            //log("Verificando se o servidor está ativo...");
            /*
            System.Net.NetworkInformation.Ping Ping = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingReply reply = Ping.Send(vServidor);

            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                log("Servidor ativo iniciando programa...");
            }
            else
            {
                log("Servidor não encontrado... o programa não pode funcionar corretamente...");
                MessageBox.Show("Servidor não encontrado, o programa não pode funcionar corretamente.", "Erro ao conectar servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                edt_nick.Focus();
            }
             */

            /*
             * acessa o registro do windows para pegar variaveis 
             * apos tenta conectar ao banco de dados criado em postgresql.
             * grava o resultado no log e mostra no status.
             */

            log("Verificando se o banco de dados está ativo...");

            try
            {
                kronos_con.ConnectionString = "Server=" + vServidor +";User Id=" + vUsuario +";Password=" + vSenha + ";Database=" + vBanco +";";
                kronos_con.Open();
                log("Conexao com banco de dados realizada com sucesso... o programa esta ativo...");
                statusbar.Text = "Status: Conectado";
                relogio.Enabled = true;
            }
            catch (Exception error)
            {
                log("ATENÇÃO - Não foi possível conectar ao banco de dados, o programa não pode funcionar corretamente..." + error.Message);
                statusbar.Text = "Status: Não conectado";
            }

            /*
             * apos acesso ao bando de dados para pegar maquinas registradas
             * conta quantos itens existem no listView
             */
            NpgsqlCommand vMaq = new NpgsqlCommand("select nome from maquinas", kronos_con);
            NpgsqlDataReader drMaq = vMaq.ExecuteReader();
            
            // cria a lista dos icones...
            ListViewItem lvm_new;
               while(drMaq.Read())
               {
                   lvm_new = LView.Items.Add(drMaq[0].ToString(), 0);
               }
            total_maq.Text = LView.Items.Count.ToString();

            verifica_maquinas();
            verifica_espera();
        }

        private void min_CheckedChanged(object sender, EventArgs e)
        {
            if(min.Checked)
            {
                hora.Enabled = false;
                btn_ok.Focus();
            }
            else
            {
                hora.Enabled = true;
                hora.Focus();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (min.Checked)
            {
                NpgsqlCommand sel_com = new NpgsqlCommand("select tmp_rest from espera where nick = '" + edt_nick.Text + "'", kronos_con);
                NpgsqlDataReader drSel = sel_com.ExecuteReader();
                if(drSel.Read())
                {
                    DateTime rest = Convert.ToDateTime(drSel[0]);
                    //DateTime restm = rest.AddMinutes(33);
                    //rest_str = Convert.ToString(rest.AddMinutes(33));
                    
                    NpgsqlCommand ins_com = new NpgsqlCommand("update espera set tmp_add = '" + rest.AddMinutes(33).ToLongTimeString() + "', tmp_rest = '" + rest.AddMinutes(33).ToLongTimeString() + "', chegada = '" + DateTime.Now.ToLongTimeString() + "', status = 'novo' where nick = '" + edt_nick.Text + "'", kronos_con);
                    if (MessageBox.Show("Deseja adicionar 30 minutos para " + edt_nick.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Int32 result = ins_com.ExecuteNonQuery();
                        min.Checked = false;
                        edt_nick.Text = "";
                        edt_nick.Focus();
                    }
                    drSel.Close();
                }
                else
                {
                    NpgsqlCommand ins_com = new NpgsqlCommand("insert into espera values('" + edt_nick.Text + "','00:33:00','00:33:00','" + DateTime.Now.ToLongTimeString() + "', 'novo')", kronos_con);
                    if (MessageBox.Show("Deseja adicionar 30 minutos para " + edt_nick.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Int32 result = ins_com.ExecuteNonQuery();
                        min.Checked = false;
                        edt_nick.Text = "";
                        edt_nick.Focus();
                    }
                }
            }
            else
            {
                NpgsqlCommand sel_com = new NpgsqlCommand("select tmp_rest from espera where nick = '" + edt_nick.Text + "'", kronos_con);
                NpgsqlDataReader drSel = sel_com.ExecuteReader();
                if (drSel.Read())
                {
                    DateTime rest = Convert.ToDateTime(drSel[0]);
                    NpgsqlCommand upd_com = new NpgsqlCommand("update espera set tmp_add = '" + rest.AddHours(Convert.ToInt32(hora.Text)).ToLongTimeString() + "', tmp_rest = '" + rest.AddHours(Convert.ToInt32(hora.Text)).ToLongTimeString() + "', chegada = '" + DateTime.Now.ToLongTimeString() + "', status = 'novo' where nick = '" + edt_nick.Text + "'", kronos_con);
                    
                    if (MessageBox.Show("Deseja adicionar " + hora.Text + ":00 horas para " + edt_nick.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Int32 result = upd_com.ExecuteNonQuery();
                        edt_nick.Text = "";
                        edt_nick.Focus();
                    }
                    drSel.Close();
                }
                else
                {
                    NpgsqlCommand ins_com = new NpgsqlCommand("insert into espera values('" + edt_nick.Text + "','" + hora.Text + ":03','" + hora.Text + ":03', '" + DateTime.Now.ToLongTimeString() + "', 'novo')", kronos_con);
                    if (MessageBox.Show("Deseja adicionar " + hora.Text + ":00 horas para " + edt_nick.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Int32 result = ins_com.ExecuteNonQuery();
                        edt_nick.Text = "";
                        edt_nick.Focus();
                    }
                }
            }
            verifica_maquinas();
            verifica_espera();
            relogio.Enabled = true;
        }
       
        private void edt_nick_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //edt_nick.Text = 
                    log("Procurando " + edt_nick.Text + " ...");
                    
                    NpgsqlCommand nick_val = new NpgsqlCommand("select * from usuarios where nick = '" + edt_nick.Text + "'", kronos_con);
                    NpgsqlDataReader DataR = nick_val.ExecuteReader();

                    // Verifica o nick no bando de dados.
                    if (DataR.Read())
                    {
                        NpgsqlCommand nick_esp = new NpgsqlCommand("select tmp_rest from espera where nick = '" + edt_nick.Text + "'", kronos_con);
                        NpgsqlDataReader DrEsp = nick_esp.ExecuteReader();

                        lb_nome.Text = DataR[2].ToString();

                        if (DrEsp.Read())
                        {
                            if (Convert.ToDateTime(DrEsp[0]) != Convert.ToDateTime("01/01/0001 00:00:00"))
                            {
                                lb_rest.ForeColor = Color.Blue;
                                lb_rest.Text = Convert.ToDateTime(DrEsp[0]).ToString("HH:mm");
                                btn_volta.Enabled = true;
                            }
                            else
                            {
                                lb_rest.ForeColor = Color.Red;
                                lb_rest.Text = Convert.ToDateTime(DrEsp[0]).ToString("HH:mm");
                            }
                        }
                        else
                        {
                            lb_rest.ForeColor = Color.Red;
                            lb_rest.Text = "00:00";
                        }
                        log("Usuário " + edt_nick.Text + " encontrado...");
                        hora.Enabled = true;
                        min.Enabled = true;
                        btn_ok.Enabled = true;
                        min.Focus();
                        DataR.Close();
                        DrEsp.Close();
                    }
                    else
                    {
                        log("Usuário " + edt_nick.Text + " não encontrado realizando cadastramento.");
                        frm_cadastro frm_cad = new frm_cadastro();
                        frm_cad.label_nick.Text = edt_nick.Text;
                        if(frm_cad.ShowDialog() == DialogResult.OK)
                        {
                            log("Cadastro realizado.");
                            hora.Enabled = true;
                            min.Enabled = true;
                            btn_ok.Enabled = true;
                            min.Focus();
                            frm_cad.Close();
                        }
                        else
                        {
                            edt_nick.Text = "";
                        }
                        DataR.Close();
                    }
                }
                catch(NpgsqlException error)
                {
                    log("Erro ao conectar bando de dados: " + error.Message);
                }
            }
        }

        private void sobreOProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sobre sobre = new frm_sobre();
            sobre.Show();
        }

        private void stilo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RegistryKey view_key = Registry.LocalMachine;
            RegistryKey new_key = view_key.CreateSubKey("SOFTWARE\\Neo Technologia\\Kronos Lanware");
            switch (stilo.SelectedIndex)
            {
                case 1:
                    LView.View = View.Details;
                    new_key.SetValue("Visao", "lista");
                    break;
                case 0:
                    LView.View = View.LargeIcon;
                    new_key.SetValue("Visao", "icones");
                    break;
            }
        }

        private void edt_nick_TextChanged(object sender, EventArgs e)
        {
            if (edt_nick.Text == "")
            {
                min.Enabled = false;
                hora.Enabled = false;
                btn_ok.Enabled = false;
                lb_nome.Text = null;
                lb_rest.Text = null;
                btn_volta.Enabled = false;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            verifica_maquinas();
            verifica_espera();
        }

        private void log_txt_TextChanged(object sender, EventArgs e)
        {
            log_txt.ScrollToCaret();
        }

        private void desistênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;
            if (MessageBox.Show("Deseja retirar da lista de espera o usuário " + grid_espera.SelectedCells[0].Value, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                String qry_desiste = "delete from espera where nick = '" + grid_espera.SelectedCells[0].Value + "'";
                NpgsqlCommand desiste = new NpgsqlCommand(qry_desiste, kronos_con);

                int result = desiste.ExecuteNonQuery();
            }
            verifica_maquinas();
            verifica_espera();
            relogio.Enabled = true;
        }

        private void popup_esp_Opened(object sender, EventArgs e)
        {
            relogio.Enabled = false;
        }

        private void adicionarTempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;

            frm_add add = new frm_add();

            if (add.ShowDialog() == DialogResult.OK)
            {
                NpgsqlCommand sel_rest = new NpgsqlCommand("select tmp_rest from espera where nick = '" + grid_espera.SelectedCells[0].Value + "'", kronos_con);
                NpgsqlDataReader drSelhora = sel_rest.ExecuteReader();

                if(drSelhora.Read())
                {
                    DateTime res_h = Convert.ToDateTime(drSelhora[0]);
                    DateTime total = res_h.AddMinutes(Convert.ToInt32(add.hora.Text));
                    NpgsqlCommand upd_tempo = new NpgsqlCommand("update espera set tmp_add = '" + total.ToString("HH:mm:ss") + "', tmp_rest = '" + total.ToString("HH:mm:ss") + "' where nick = '" + grid_espera.SelectedCells[0].Value + "'", kronos_con);
                    
                    Int32 upd_result = upd_tempo.ExecuteNonQuery();
                    if (upd_result != 0)
                    {
                        MessageBox.Show("Adicionado " + res_h.ToString("HH:mm") + " total de " + total.ToString("HH:mm"));
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu erro ao adicionar tempo para " + grid_espera.SelectedCells[0].Value);
                    }
                }
            }
            verifica_maquinas();
            verifica_espera();
            relogio.Enabled = true;
        }

        private void adicionarHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;

            if (grid_espera.RowCount != 0)
            {
                if (MessageBox.Show("Existe usuário na lista de espera. Deseja adicionar tempo assim mesmo?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    frm_add add = new frm_add();

                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        String qry_selhora = "select tmp_rest from atividade where nick = '" + grid_user.SelectedCells[0].Value + "'";
                        NpgsqlCommand sel_rest = new NpgsqlCommand(qry_selhora, kronos_con);
                        NpgsqlDataReader drSelhora = sel_rest.ExecuteReader();

                        if (drSelhora.Read())
                        {
                            DateTime res_h = Convert.ToDateTime(drSelhora[0]);
                            DateTime total = res_h.AddMinutes(Convert.ToInt32(add.hora.Text));
                            String qry_upd_tempo = "update atividade set tmp_add = '" + total.ToString("HH:mm:ss") + "', tmp_rest = '" + total.ToString("HH:mm:ss") + "' where nick = '" + grid_user.SelectedCells[0].Value + "'";
                            NpgsqlCommand upd_tempo = new NpgsqlCommand(qry_upd_tempo, kronos_con);

                            Int32 upd_result = upd_tempo.ExecuteNonQuery();
                            if (upd_result != 0)
                            {
                                MessageBox.Show("Adicionado " + res_h.ToString("HH:mm") + " total de " + total.ToString("HH:mm"));
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu erro ao adicionar tempo para " + grid_user.SelectedCells[0].Value);
                            }
                        }
                        drSelhora.Close();
                    }
                }
            }
            else
            {
                frm_add add = new frm_add();

                if (add.ShowDialog() == DialogResult.OK)
                {
                    String qry_selhora = "select tmp_rest from atividade where nick = '" + grid_user.SelectedCells[0].Value + "'";
                    NpgsqlCommand sel_rest = new NpgsqlCommand(qry_selhora, kronos_con);
                    NpgsqlDataReader drSelhora = sel_rest.ExecuteReader();

                    if (drSelhora.Read())
                    {
                        DateTime res_h = Convert.ToDateTime(drSelhora[0]);
                        DateTime total = res_h.AddMinutes(Convert.ToInt32(add.hora.Text));
                        String qry_upd_tempo = "update atividade set tmp_add = '" + total.ToString("HH:mm:ss") + "', tmp_rest = '" + total.ToString("HH:mm:ss") + "' where nick = '" + grid_user.SelectedCells[0].Value + "'";
                        NpgsqlCommand upd_tempo = new NpgsqlCommand(qry_upd_tempo, kronos_con);

                        Int32 upd_result = upd_tempo.ExecuteNonQuery();
                        if (upd_result != 0)
                        {
                            MessageBox.Show("Adicionado " + res_h.ToString("HH:mm") + " total de " + total.ToString("HH:mm"));
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu erro ao adicionar tempo para " + grid_user.SelectedCells[0].Value);
                        }
                    }
                    drSelhora.Close();
                }
            }

            verifica_maquinas();
            relogio.Enabled = true;
        }

        private void configuraçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_config fconf = new frm_config();
            fconf.ShowDialog();
        }

        public void verifica_maquinas()
        {
            //log("Verificando status das maquinas...");
            NpgsqlCommand vAtividade = new NpgsqlCommand("select * from atividade order by maquina", kronos_con);
            NpgsqlDataReader drAtividade = vAtividade.ExecuteReader();
            
            //int total = drAtividade.FieldCount;
            
            grid_user.Rows.Clear();
            int i = 0;
            while (drAtividade.Read())
            {
                if (drAtividade[1].ToString() != "")
                {
                    if ((Convert.ToDateTime(drAtividade[5])) < (Convert.ToDateTime("1/1/0001 00:05:00")))
                    {
                        LView.Update();
                        LView.Items[i].ImageIndex = 2;
                        LView.Items[i].SubItems.Clear();
                        LView.Items[i].ForeColor = Color.Orange;
                        LView.Items[i].Text = drAtividade[0].ToString();
                        LView.Items[i].SubItems.Add(drAtividade[1].ToString());
                        LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[2]).ToString("HH:mm:ss"));
                        LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[3]).ToString("HH:mm:ss"));
                        LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[4]).ToString("HH:mm:ss"));
                        LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[5]).ToString("HH:mm:ss"));
                        LView.EndUpdate();
                        grid_user.Rows.Add(drAtividade[1], drAtividade[5]);
                    }
                    else
                    {
                        LView.Update();
                        LView.Items[i].ImageIndex = 1;
                        LView.Items[i].SubItems.Clear();
                        LView.Items[i].ForeColor = Color.Red;
                        LView.Items[i].Text = drAtividade[0].ToString();
                        LView.Items[i].SubItems.Add(drAtividade[1].ToString());
                        LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[2]).ToString("HH:mm:ss"));
                        LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[3]).ToString("HH:mm:ss"));
                        LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[4]).ToString("HH:mm:ss"));
                        LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[5]).ToString("HH:mm:ss"));
                        LView.EndUpdate();
                        grid_user.Rows.Add(drAtividade[1], drAtividade[5]);
                    }
                }
                else
                {
                    LView.Update();
                    LView.Items[i].ImageIndex = 0;
                    LView.Items[i].SubItems.Clear();
                    LView.Items[i].ForeColor = Color.Black;
                    LView.Items[i].Text = drAtividade[0].ToString();
                    LView.Items[i].SubItems.Add(drAtividade[1].ToString());
                    LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[2]).ToString("HH:mm:ss"));
                    LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[3]).ToString("HH:mm:ss"));
                    LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[4]).ToString("HH:mm:ss"));
                    LView.Items[i].SubItems.Add(Convert.ToDateTime(drAtividade[5]).ToString("HH:mm:ss"));
                    LView.EndUpdate();
                }
                i++;
            }

            lb_totuser.Text = grid_user.RowCount.ToString();
            
            drAtividade.Close();
            vAtividade.Dispose();
        }

        public void verifica_espera()
        {
            grid_espera.Rows.Clear();
            
            NpgsqlCommand cmdEsp = new NpgsqlCommand("select nick, tmp_add, chegada from espera where status = 'novo' order by chegada asc", kronos_con);
            NpgsqlDataReader drEsp = cmdEsp.ExecuteReader();

            while (drEsp.Read())
            {
                grid_espera.Rows.Add(drEsp[0], drEsp[1], drEsp[2]);
            }

            lb_totesp.Text = grid_espera.RowCount.ToString();

            drEsp.Close();
            cmdEsp.Dispose();

            /*
            grid_estoque.Rows.Clear();
            NpgsqlCommand cmdEst = new NpgsqlCommand("select nick, tmp_rest from espera where status = 'velho' order by " + ch_conf.GetValue("Visao est").ToString() + " asc", kronos_con);
            NpgsqlDataReader drEst = cmdEst.ExecuteReader();
            while (drEst.Read())
            {
                grid_estoque.Rows.Add(drEst[0], drEst[1]);
            }
            lb_totest.Text = grid_estoque.RowCount.ToString();
            drEst.Close();
            cmdEst.Dispose();
             */
        }

        private void LView_Click(object sender, EventArgs e)
        {
            verifica_maquinas();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opção está em desenvolvimento...", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void terminarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;

            NpgsqlCommand cmdVolta = new NpgsqlCommand("insert into espera values('" + grid_user.SelectedCells[0].Value  + "','" + grid_user.SelectedCells[1].Value + "','" + grid_user.SelectedCells[1].Value + "', '" + DateTime.Now.ToLongTimeString() + "','novo')", kronos_con);
            NpgsqlCommand cmdAtivdel = new NpgsqlCommand("update atividade set nick = '', tmp_inicio = '00:00:00', tmp_fim = '00:00:00', tmp_add = '00:00:00', tmp_rest = '00:00:00' where nick = '" + grid_user.SelectedCells[0].Value + "'", kronos_con);

            cmdVolta.ExecuteNonQuery();
            cmdAtivdel.ExecuteNonQuery();

            verifica_maquinas();
            verifica_espera();
            relogio.Enabled = true;
        }

        private void grid_espera_Click(object sender, EventArgs e)
        {
            popup_esp.Show(MousePosition.X, MousePosition.Y);
        }

        private void grid_user_Click(object sender, EventArgs e)
        {
            popup_con.Show(MousePosition.X, MousePosition.Y);
        }

        private void maquinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_config fconf = new frm_config();
            fconf.tabconfig.SelectTab(1);
            fconf.ShowDialog();
        }

        /*
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;
            if (MessageBox.Show("Deseja retirar da lista de espera o usuário " + grid_estoque.SelectedCells[0].Value, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                String qry_desiste = "delete from espera where nick = '" + grid_estoque.SelectedCells[0].Value + "'";
                NpgsqlCommand desiste = new NpgsqlCommand(qry_desiste, kronos_con);

                int result = desiste.ExecuteNonQuery();
            }
            verifica_espera();
            relogio.Enabled = true;
        }
        
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;

            frm_add add = new frm_add();

            if (add.ShowDialog() == DialogResult.OK)
            {
                NpgsqlCommand sel_rest = new NpgsqlCommand("select tmp_rest from espera where nick = '" + grid_estoque.SelectedCells[0].Value + "'", kronos_con);
                NpgsqlDataReader drSelhora = sel_rest.ExecuteReader();

                if (drSelhora.Read())
                {
                    DateTime res_h = Convert.ToDateTime(drSelhora[0]);
                    DateTime total = res_h.AddMinutes(Convert.ToInt32(add.hora.Text));
                    NpgsqlCommand upd_tempo = new NpgsqlCommand("update espera set tmp_add = '" + total.ToString("HH:mm:ss") + "', tmp_rest = '" + total.ToString("HH:mm:ss") + "' where nick = '" + grid_estoque.SelectedCells[0].Value + "'", kronos_con);

                    Int32 upd_result = upd_tempo.ExecuteNonQuery();
                    if (upd_result != 0)
                    {
                        MessageBox.Show("Adicionado " + res_h.ToString("HH:mm") + " total de " + total.ToString("HH:mm"));
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu erro ao adicionar tempo para " + grid_estoque.SelectedCells[0].Value);
                    }
                }
            }
            verifica_espera();
            relogio.Enabled = true;
        }
        */
        /*
        private void grid_estoque_Click(object sender, EventArgs e)
        {
            popup_est.Show(MousePosition.X, MousePosition.Y);
        }
        */
        /*
        private void stilo_est_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RegistryKey view_key = Registry.LocalMachine;
            RegistryKey new_key = view_key.CreateSubKey("SOFTWARE\\Neo Technologia\\Kronos Lanware");
            switch (stilo_est.SelectedIndex)
            {
                case 0:
                    // LView.View = View.Details;
                    new_key.SetValue("Visao est", "nick");
                    break;
                case 1:
                    //LView.View = View.LargeIcon;
                    new_key.SetValue("Visao est", "tmp_rest");
                    break;
            }
        }
       

        private void voltarParaEsperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;

            NpgsqlCommand cmdVolta = new NpgsqlCommand("update espera set status = 'novo', chegada = '" + DateTime.Now.ToLongTimeString() + "' where nick = '" + grid_estoque.SelectedCells[0].Value + "'", kronos_con);
            
            cmdVolta.ExecuteNonQuery();
            
            verifica_maquinas();
            verifica_espera();
            
            relogio.Enabled = true;
        }

        
        private void popup_est_Opened(object sender, EventArgs e)
        {
            relogio.Enabled = false;
        }
        */

        private void btn_volta_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmdVolta = new NpgsqlCommand("update espera set status = 'novo', chegada = '" + DateTime.Now.ToLongTimeString() + "' where nick = '" + edt_nick.Text + "'", kronos_con);

            cmdVolta.ExecuteNonQuery();
            min.Checked = false;
            edt_nick.Text = "";
            edt_nick.Focus();
            btn_volta.Enabled = false;

            verifica_maquinas();
            verifica_espera();
        }

        /*
        private void popup_est_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            relogio.Enabled = true;
        }

        private void popup_esp_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            relogio.Enabled = true;
        }
        */

        private void guardarTempoParaDepoisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;

            NpgsqlCommand cmdVolta = new NpgsqlCommand("update espera set status = 'velho' where nick = '" + grid_espera.SelectedCells[0].Value + "'", kronos_con);

            cmdVolta.ExecuteNonQuery();

            verifica_maquinas();
            verifica_espera();

            relogio.Enabled = true;
        }

        private void popup_con_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            relogio.Enabled = true;
        }
    }
}