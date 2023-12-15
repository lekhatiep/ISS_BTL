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
    public partial class AddMonhoc : Form
    {
        string conn = "";
        public AddMonhoc(string conn = "")
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                var tenMH = txt_tenmh.Text;
                var soTc = txt_soTC.Text;
                var pban = (this.cbx_pban.SelectedItem ?? "N/A").ToString();

                string connectionstring = conn;
                if (string.IsNullOrEmpty(tenMH))
                {
                    MessageBox.Show("Ten lop name không được trống");
                    return;
                }
                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sql = $@"insert into ADM.MONHOC (TENMONHOC,PHONGBAN,SOTINCHI)
                                VALUES('{tenMH}',
                                        '{pban}',
                                        {soTc})";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close(); // close the oracle connection

                    MessageBox.Show($"Thêm MON HOC thành công");
                    txt_tenmh.Text = "";
                    txt_soTC.Text = "";
                    this.cbx_pban.SelectedItem = -1;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
