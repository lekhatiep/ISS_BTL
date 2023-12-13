using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ISS_BTL
{
    public partial class InfoUser : Form
    {
        public string strConn = "";
        public string uname = "";
        public InfoUser(string conn = "", string uname = "" )
        {
            this.uname = uname;
            strConn = conn;
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            loadDefault();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadDefault()
        {
            txt_username.Enabled = false;
           

            try
            {
                string connectionstring = strConn;

                string sql = @$"select 
                                a.username,
                                email,
                                ten,
                                phone,
                                phongban,
                                created,
                                addr 
                            from adm.user_info u join all_users a on a.username = upper(u.username) WHERE upper(u.username) = '{uname}'";

                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    conn.Open(); // open the oracle connection
                    OracleCommand cmd = new OracleCommand(sql, conn);

                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txt_username.Text = (reader["USERNAME"] + "");
                        txt_email.Text = (reader["EMAIL"] + "");
                        txt_phone.Text = (reader["PHONE"] + "");
                        txt_name.Text = (reader["TEN"] + "");
                        txt_pban.Text = (reader["PHONGBAN"] + "");
                        txt_addr.Text = (reader["ADDR"] + "");
                    }

                    conn.Close(); // close the oracle connection
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var uname = txt_username.Text;
            var ten = txt_name.Text;
            var sdt = txt_phone.Text;
            var email = txt_email.Text;
            var addr = txt_addr.Text;
            var pban = txt_pban.Text;

            try
            {
                string connectionstring = strConn;

                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sqlu = @$"update ADM.USER_INFO SET 
                                    TEN = :TEN,
                                    PHONE = :SDT,
                                    EMAIL = :EMAIL,
                                    ADDR = :ADDR,
                                    PHONGBAN = :PBAN
                                WHERE upper(username) = '{uname}'";

                    conn.Open(); // open the oracle connection

                    OracleCommand cmd = new OracleCommand(sqlu, conn);

                    cmd.Parameters.Add(":TEN", "Varchar2(200)").Value = ten;
                    cmd.Parameters.Add(":PHONE", "Varchar2(200)").Value = sdt;
                    cmd.Parameters.Add(":EMAIL", "varchar2(255)").Value = email;
                    cmd.Parameters.Add(":ADDR", "varchar2(200)").Value = addr;
                    cmd.Parameters.Add(":PBAN", "varchar2(100)").Value = pban;

                    var re = cmd.ExecuteNonQuery();

                    conn.Close(); // close the oracle connection

                    MessageBox.Show($"Update thành công");
                    loadDefault();
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
