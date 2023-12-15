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
    public partial class DanhSachMH : Form
    {
        string conn = "";
        public DanhSachMH(string conn ="")
        {
            //this.conn = new OracleDB().OracleConnString("localhost", "1521", "qlmhpdb", "adm", "123"); ; ;
            this.conn = conn;
            InitializeComponent();
        }

        private void DanhSachMH_Load(object sender, EventArgs e)
        {
            loadDefault();
        }

        public void loadDefault()
        {
            try
            {
                string connectionstring = conn;

                string sql = "select * from ADM.MONHOC";

                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    conn.Open(); // open the oracle connection
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dataGridView2.DataSource = ds.Tables[0];
                    }
                    conn.Close(); // close the oracle connection
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddMonhoc addMonhoc = new AddMonhoc(conn);
            addMonhoc.Show();
        }

        private void btn_loadPage_Click(object sender, EventArgs e)
        {
            loadDefault();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var uname = txt_monhocID.Text;
            DialogResult dialogResult = MessageBox.Show($"Xóa mon hoc này ko ??", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && !string.IsNullOrEmpty(uname))
            {
                //do something
                try
                {
                    string connectionstring = conn;


                    using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                    {
                        var sqlDrop = @$"
                                      DELETE ADM.MONHOC WHERE MAMONHOC={txt_monhocID.Text}
                                   ";
                        conn.Open(); // open the oracle connection
                        OracleCommand cmd = new OracleCommand(sqlDrop, conn);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        loadDefault();
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

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_monhocID.Text = string.Empty;
            var countRow = dataGridView2.Rows.Count - 1;

            var rowIndex = e.RowIndex;
            if (rowIndex < countRow && rowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = dataGridView2.Rows[rowIndex];

                var idLop = dataGridViewRow.Cells[0].Value.ToString();

                txt_monhocID.Text = idLop;
            }
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            InfoMonHoc infoMonHoc = new InfoMonHoc(conn, txt_monhocID.Text);
            infoMonHoc.Show();
        }
    }
}
