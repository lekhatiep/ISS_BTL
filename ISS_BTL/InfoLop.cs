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
    public partial class InfoLop : Form
    {
        string conn = "";
        string malop = "";
        public InfoLop(string conn ="", string malop = "")
        {

            this.conn = conn;
            this.malop = malop;
            InitializeComponent();
        }

        private void InfoLop_Load(object sender, EventArgs e)
        {
            loadDefault();
            loadDefaultDropGV();
        }
        public void loadDefault()
        {
            try
            {
                string connectionstring = conn;

                string sql = $"SELECT * FROM LOP WHERE MALOP = {malop}";

                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    conn.Open(); // open the oracle connection
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txt_malop.Text = (reader["MALOP"] + "");
                        txt_tenlop.Text = (reader["TENLOP"] + "");
                        ngayhocDT.Text = (reader["NGAYHOC"] + "");
                        cbx_maMH.Text = (reader["MAMONHOC"] + "");
                        cbx_maGV.Text = (reader["MAGV"] + "");
                        txt_tienlop.Text = (reader["TIENLOP"] + "");

                        cbx_maGV.SelectedItem = reader["MAGV"].ToString();
                    }

                    conn.Close(); // close the oracle connection
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenLop = txt_tenlop.Text;
            var ngayhoc = ngayhocDT.Text;
            var tienThue = txt_tienlop.Text;

            var idMH = (this.cbx_maMH.SelectedItem ?? "-1 - N/A").ToString().Split('-')[0];
            var maMH = cbx_maMH.GetItemText(idMH);

            var idMV = (this.cbx_maGV.SelectedItem ?? "-1 - N/A").ToString().Split('-')[0];
            var maGV = cbx_maGV.GetItemText(idMV);

            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Ten lop name không được trống");
                return;
            }

            try
            {
                string connectionstring = conn;

                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sqlu = @$"update ADM.LOP SET 
                                    TENLOP = :TENLOP,
                                    NGAYHOC = TO_DATE(:NGAYHOC, 'yyyy/mm/dd hh24:mi'),
                                    MAMONHOC = :MAMONHOC,
                                    MAGV = :MAGIAOVIEN,
                                    TIENLOP = :TIENLOP
                                WHERE MALOP = {malop}";

                    conn.Open(); // open the oracle connection

                    OracleCommand cmd = new OracleCommand(sqlu, conn);

                    cmd.Parameters.Add(":TENLOP", "Varchar(200)").Value = tenLop;
                    cmd.Parameters.Add(":NGAYHOC", "date").Value = ngayhoc;
                    cmd.Parameters.Add(":MAMONHOC", "number").Value = maMH;
                    cmd.Parameters.Add(":MAGIAOVIEN", "number").Value = maGV;
                    cmd.Parameters.Add(":TIENLOP", "float").Value = tienThue;

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadDefaultDropGV()
        {
            try
            {
                string connStr = conn;
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
                            var item = $"{rd["ID"].ToString()} - {rd["USERNAME"].ToString()}";
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
                string connStr = conn;
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
                            var item = $"{rd["ID"].ToString()} - {rd["USERNAME"].ToString()}";
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
    }
}
