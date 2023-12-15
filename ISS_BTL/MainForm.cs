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
        
        public MainForm(string conn = "", string UserName = "")
        {
            OracleDB.conn = conn;
            InitializeComponent();

            lbl_username.Text = UserName;
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
                        dataGridView1.DataSource = ds.Tables[0];
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
            DanhSachLop danhSach = new DanhSachLop(OracleDB.conn);
            danhSach.Show();
        }

        private void btn_myinfo_Click(object sender, EventArgs e)
        {
            MyInfo myInfo = new MyInfo(OracleDB.conn);
            myInfo.Show();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            var rowIndex = e.RowIndex;

            DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];

            var username = dataGridViewRow.Cells[0].Value.ToString();
            //MessageBox.Show("mouse click"+ username);

            txt_uname.Text = username;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var uname = txt_uname.Text;
            DialogResult dialogResult = MessageBox.Show($"Xóa user {uname} này ko", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && !string.IsNullOrEmpty(uname))
            {
                //do something
                try
                {
                    string connectionstring = new OracleDB().OracleConnString("localhost", "1521", "qlmhpdb", "adm", "123");


                    using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                    {
                        var sqlDrop = @"begin 
                                     DROP USER :USERNAME;
                                     DELETE USER_INFO WHERE upper(USERNAME) = :USERNAME;
                                    end;";
                        
                        var sqlDropUser = $"DROP USER {uname} CASCADE";
                        var sqlDropInfo = $"DELETE USER_INFO WHERE upper(USERNAME) = :USERNAME";

                        conn.Open(); // open the oracle connection

                        // Begin transaction
                        using (OracleTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // Delete from USER_INFO
                                using (OracleCommand deleteCommand = new OracleCommand(sqlDropInfo, conn))
                                {
                                    deleteCommand.Transaction = transaction; // Associate with the transaction
                                    deleteCommand.Parameters.Add("username", OracleDbType.Varchar2).Value = uname;
                                    deleteCommand.ExecuteNonQuery();
                                }

                                // Drop user
                                using (OracleCommand dropUserCommand = new OracleCommand(sqlDropUser, conn))
                                {
                                    dropUserCommand.Transaction = transaction; // Associate with the transaction
                                    dropUserCommand.Parameters.Add("username", OracleDbType.Varchar2).Value = uname;
                                    dropUserCommand.ExecuteNonQuery();
                                }

                                // Commit the transaction
                                transaction.Commit();

                                Console.WriteLine($"User '{uname}' deleted and dropped successfully.");
                            }
                            catch (Exception ex)
                            {
                                // Rollback the transaction in case of an exception
                                transaction.Rollback();

                                Console.WriteLine($"Error deleting and dropping user: {ex.Message}");
                            }
                            MessageBox.Show($"Xóa thành công");

                        }
                        conn.Close();
                        loadData();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            InfoUser infoUser = new InfoUser(OracleDB.conn, uname: txt_uname.Text);
            infoUser.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RoleForm roleForm = new RoleForm(OracleDB.conn, username: txt_uname.Text);
            roleForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuditForm auditForm = new AuditForm(OracleDB.conn);
            auditForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DKMH dKMH = new DKMH(OracleDB.conn);
            dKMH.Show();
        }

        private void btn_dsmh_Click(object sender, EventArgs e)
        {
            DanhSachMH danhSachMH = new DanhSachMH(OracleDB.conn);
            danhSachMH.Show();
        }
    }
}
