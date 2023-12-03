using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

namespace ISS_BTL
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                var userName = txt_username.Text;
                var pw = txt_pwd.Text;

                string connectionstring = new OracleDB().OracleConnString("localhost", "1521", "qlmhpdb", userName, pw);
                string sql = "select u.username, email, ten, phone, phongban,created from user_info u join all_users a on a.username = upper(u.username)";

                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    conn.Open(); // open the oracle connection
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                    conn.Close(); // close the oracle connection
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login fails");
                throw;
            }
            
        }

        
    }
}
