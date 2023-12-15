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
    public partial class InfoMonHoc : Form
    {
        string conn = "";
        string manh_id = "";
        public InfoMonHoc(string conn = "", string maMH = "")
        {
            this.conn = conn;
            manh_id = maMH;
            InitializeComponent();
            loadDefault();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var tenMH = txt_tenmh.Text;
            var soTC = txt_soTC.Text;
            var pban = (this.cbx_pban.SelectedItem ??"N/A").ToString();

            if (string.IsNullOrEmpty(tenMH))
            {
                MessageBox.Show("Ten MON HOC không được trống");
                return;
            }

            try
            {
                string connectionstring = conn;

                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sqlu = @$"update ADM.MONHOC SET 
                                    TENMONHOC = :TENMONHOC,
                                    SOTINCHI = :SOTINCHI,
                                    PHONGBAN = :PHONGBAN
                                WHERE MAMONHOC = {manh_id}";

                    conn.Open(); // open the oracle connection

                    OracleCommand cmd = new OracleCommand(sqlu, conn);

                    cmd.Parameters.Add(":TENMONHOC", "varchar(200)").Value = tenMH;
                    cmd.Parameters.Add(":SOTINCHI", "number").Value = int.Parse(soTC);
                    cmd.Parameters.Add(":PHONGBAN", "varchar(100)").Value = pban;

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

        public void loadDefault()
        {
            try
            {
                string connectionstring = conn;

                string sql = $"SELECT * FROM ADM.MONHOC WHERE MAMONHOC = {manh_id}";

                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    conn.Open(); // open the oracle connection
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txt_tenmh.Text = (reader["TENMONHOC"] + "");
                        txt_soTC.Text = (reader["SOTINCHI"] + "");
                        cbx_pban.SelectedItem = reader["PHONGBAN"].ToString();
                    }

                    conn.Close(); // close the oracle connection
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
