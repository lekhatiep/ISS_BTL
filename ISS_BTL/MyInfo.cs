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
    public partial class MyInfo : Form
    {
        public string strConn = "";

        public MyInfo(string conn = "")
        {
            strConn = conn;
            InitializeComponent();
            loadDefault();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyInfo_Load(object sender, EventArgs e)
        {

        }

        public void loadDefault()
        {
            txt_username.Enabled = false;
            txt_name.Enabled = false;
            txt_phone.Enabled = false;
            txt_email.Enabled = false;
            txt_addr.Enabled = false;
            txt_pban.Enabled = false;
            btn_save.Enabled = false;

            try
            {
                string connectionstring = strConn;

                string sql = @"select 
                                a.username,
                                email,
                                ten,
                                phone,
                                phongban,
                                created,
                                addr 
                            from adm.user_info u join all_users a on a.username = upper(u.username)";

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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true; 
            txt_name.Enabled = true;
            txt_phone.Enabled = true;
            txt_email.Enabled = true;
            txt_addr.Enabled = true;
            txt_pban.Enabled = true;
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
                    var sqlu = @"update ADM.USER_INFO SET 
                                    EMAIL = :EMAIL,
                                    ADDR = :ADDR
                                WHERE upper(username) = user";

                    conn.Open(); // open the oracle connection

                    OracleCommand cmd = new OracleCommand(sqlu,conn);
                 
                    cmd.Parameters.Add(":EMAIL", "varchar2(255)").Value = email;
                    cmd.Parameters.Add(":ADDR", "varchar2(200)").Value = addr;
                    //cmd.Parameters.Add(":TEN", "Varchar2(200)").Value = ten;

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
