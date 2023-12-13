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
    public partial class RoleForm : Form
    {
        string connectionstring = "";
        string username = "";
        public RoleForm(string conn = "", string username = "")
        {
            this.connectionstring = conn;
            InitializeComponent();
            this.username = username;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var listRole = "";
            if (radioButton1.Checked)
            {
                listRole = "SINHVIEN";
            }
            if (radioButton2.Checked)
            {
                listRole = "GIAOVIEN";
            }

            try
            {
               
                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sql = $"GRANT {listRole} TO {username}";
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                    conn.Close(); // close the oracle connection

                    MessageBox.Show($"Update thành công");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_revoke_Click(object sender, EventArgs e)
        {
            var listRole = "";
            if (radioButton1.Checked)
            {
                listRole = "SINHVIEN";
            }
            if (radioButton2.Checked)
            {
                listRole = "GIAOVIEN";
            }

            try
            {

                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sql = $"REVOKE {listRole} FROM {username}";
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                    conn.Close(); // close the oracle connection

                    MessageBox.Show($"Update thành công");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
