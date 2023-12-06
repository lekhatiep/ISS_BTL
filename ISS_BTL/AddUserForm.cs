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
    public partial class AddUserForm : Form
    {
        string connectionstring = "";
        public AddUserForm(string conn = "")
        {
            connectionstring = conn;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var uname = txt_username.Text;
                var ten = txt_name.Text;
                var sdt = txt_phone.Text;
                var email = txt_email.Text;
                var pbname = cbx_pban.GetItemText(this.cbx_pban.SelectedItem);

                if (string.IsNullOrEmpty(uname))
                {
                    MessageBox.Show("User name không được trống");
                    
                }
                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sql = $"execute ADM.CREATE_USER('{uname}','{email}','{sdt}','{ten}','{pbname}')";
                    
                    //OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleCommand cmd = new OracleCommand("CREATE_USER", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("V_USERNAME", "varchar(200)").Value = uname;
                    cmd.Parameters.Add("V_EMAIL", "VARCHAR2(255)").Value = email;
                    cmd.Parameters.Add("V_PHONE", "VARCHAR2(20)").Value = sdt;
                    cmd.Parameters.Add("V_TEN", "Varchar2(200)").Value = ten;
                    cmd.Parameters.Add("V_PHONGBAN", "varchar(100)").Value = pbname;


                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close(); // close the oracle connection

                    MessageBox.Show($"Thêm user thành công");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
