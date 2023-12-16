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
    public partial class DKMH : Form
    {
        string conn = "";
        public DKMH(string conn = "")
        {
            //this.conn = new OracleDB().OracleConnString("localhost", "1521", "qlmhpdb", "sinhvien1", "123"); ; ;
            this.conn = conn;
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddDKMH dKMH = new AddDKMH(conn);
            dKMH.Show();
        }

        private void DKMH_Load(object sender, EventArgs e)
        {
            loadDefault();
        }

        public void loadDefault()
        {
            try
            {
                string connectionstring = conn;

                string sql = @"SELECT  DK.MASV, L.TENLOP, M.MAMONHOC,M.TENMONHOC, M.SOTINCHI, L.NGAYHOC, L.MALOP FROM
                                ADM.LOP L JOIN ADM.MONHOC M ON L.MAMONHOC = M.MAMONHOC
                                JOIN ADM.DANGKY DK on DK.MALOP = L.MALOP";

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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadDefault();
        }

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_malopID.Text = string.Empty;
            txt_masv.Text = string.Empty;
            var countRow = dataGridView2.Rows.Count - 1;

            var rowIndex = e.RowIndex;
            if (rowIndex < countRow && rowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = dataGridView2.Rows[rowIndex];

                var masv = dataGridViewRow.Cells[0].Value.ToString();
                var idLop = dataGridViewRow.Cells[6].Value.ToString();
                //MessageBox.Show("mouse click"+ username);

                txt_malopID.Text = idLop;
                txt_masv.Text = masv;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var malop = txt_malopID.Text;
            DialogResult dialogResult = MessageBox.Show($"Xóa dang ky  này ko", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && !string.IsNullOrEmpty(malop))
            {
                //do something
                try
                {
                    string connectionstring = conn;


                    using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                    {
                        var sqlDrop = @$"
                                     DELETE ADM.DANGKY WHERE malop = {txt_malopID.Text} and masv = user
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
    }
}
