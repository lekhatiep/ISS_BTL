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

                OracleConnection conn = new OracleConnection();
                conn.ConnectionString = connectionstring;
                conn.Open();

                //
                MainForm mainForm = new MainForm(connectionstring, userName);
                mainForm.Show();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Login fails:" + ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
