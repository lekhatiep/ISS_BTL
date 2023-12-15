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
    public partial class AddLopForm : Form
    {
        string connectionstring = "";
        public AddLopForm(string conn = "")
        {
            //connectionstring = new OracleDB().OracleConnString("localhost", "1521", "qlmhpdb", "adm", "123");
            this.connectionstring = conn;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var tenLop = txt_tenlop.Text;
                var ngayhoc = ngayhocDT.Text;
                var tienThue = txt_tienlop.Text;

                var idMH = (this.cbx_maMH.SelectedItem ?? "NULL").ToString().Split('-')[0];
                var maMH = cbx_maMH.GetItemText(idMH);

                var idMV = (this.cbx_maGV.SelectedItem ?? "NULL").ToString();
                var maGV = cbx_maGV.GetItemText(idMV);

                if (string.IsNullOrEmpty(tenLop))
                {
                    MessageBox.Show("Ten lop name không được trống");
                    return;
                }
                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sql = $@"insert into LOP (TENLOP,NGAYHOC,MAMONHOC,MAGV,TIENLOP)
                                VALUES('{tenLop}',
                                        TO_DATE('{ngayhoc}', 'yyyy/mm/dd hh24:mi'),
                                        {maMH},
                                        '{maGV}',
                                        {tienThue})";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close(); // close the oracle connection

                    MessageBox.Show($"Thêm Lop thành công");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddLopForm_Load(object sender, EventArgs e)
        {
            loadDefaultDropGV();
            loadDefaultDropMonhoc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_maGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadDefaultDropGV()
        {
            try
            {
                string connStr = connectionstring;
                ngayhocDT.CustomFormat = "yyyy/M/dd hh:mm";
                using (OracleConnection conn = new OracleConnection(connStr)) // connect to oracle
                {
                    var sql = $@"SELECT UI.ID, UI.USERNAME
                                FROM DBA_USERS DU
                                JOIN DBA_ROLE_PRIVS R ON DU.USERNAME = R.GRANTEE
                                JOIN user_info UI ON DU.USERNAME = upper(ui.username)
                                WHERE R.GRANTED_ROLE = 'GIAOVIEN'";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    conn.Open();
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            var mgv = rd.GetInt16(0).ToString();
                            var item = $"{rd["USERNAME"].ToString()}";
                            cbx_maGV.Items.Add(item);
                        }
                    }
                    conn.Close(); // close the oracle connection
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDefaultDropMonhoc()
        {
            try
            {
                string connStr = connectionstring;
                using (OracleConnection conn = new OracleConnection(connStr)) // connect to oracle
                {
                    var sql = $@"SELECT MAMONHOC, TENMONHOC FROM ADM.MONHOC";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    conn.Open();
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            var item = $"{rd["MAMONHOC"].ToString()} - {rd["TENMONHOC"].ToString()}";
                            cbx_maMH.Items.Add(item);
                        }
                    }
                    conn.Close(); // close the oracle connection
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
