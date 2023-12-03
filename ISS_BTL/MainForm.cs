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
    public partial class MainForm : Form
    {
        OracleDB OracleDB = new OracleDB();
        public MainForm(string conn = "")
        {
            OracleDB.conn = conn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            try
            {
                string connectionstring = OracleDB.conn;

                string sql = "select a.username, email, ten, phone, phongban,created from user_info u join all_users a on a.username = upper(u.username)";

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
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(OracleDB.conn);
            addUserForm.Show();
        }

        private void btn_listlop_Click(object sender, EventArgs e)
        {
            //TO DO Lay danh sach lop

        }
    }
}
