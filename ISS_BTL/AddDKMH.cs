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
    public partial class AddDKMH : Form
    {
        string conn = "";
        public AddDKMH(string conn = "")
        {
            //conn = new OracleDB().OracleConnString("localhost", "1521", "qlmhpdb", "adm", "123");
            this.conn = conn;
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var textSearch = txt_search.Text;

            loadDSMH(textSearch);
            
        }

        public void loadDSMH(string search = "")
        {
            try
            {
                string where = "";

                if (!string.IsNullOrEmpty(search))
                {
                    where += $"WHERE M.MAMONHOC = {search}";
                }
                string connectionstring = conn;

                string sql = $@"SELECT L.TENLOP, M.MAMONHOC,M.TENMONHOC, M.SOTINCHI, L.NGAYHOC, L.MALOP FROM
                                ADM.LOP L JOIN ADM.MONHOC M ON L.MAMONHOC = M.MAMONHOC {where}";

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

        public void loadSearchOnDGV()
        {
            string searchValue = txt_search.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_maMH.Text = string.Empty;
            txt_tenLop.Text = string.Empty;
            txt_tenMH.Text = string.Empty;
            txt_soTC.Text = string.Empty;
            lbl_malop.Text = string.Empty;
            var countRow = dataGridView1.Rows.Count - 1;

            var rowIndex = e.RowIndex;
            if (rowIndex < countRow && rowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];

                var tenLop = dataGridViewRow.Cells[0].Value.ToString();
                var maMH = dataGridViewRow.Cells[1].Value.ToString();
                var tenMH = dataGridViewRow.Cells[2].Value.ToString();
                var soTC = dataGridViewRow.Cells[3].Value.ToString();
                var malop = dataGridViewRow.Cells[5].Value.ToString();

                txt_maMH.Text = maMH;
                txt_tenLop.Text = tenLop;
                txt_tenMH.Text = tenMH;
                txt_soTC.Text = soTC;
                lbl_malop.Text = malop;
            }
        }

        private void btn_dky_Click(object sender, EventArgs e)
        {
            if (checkDaDangky())
            {
                MessageBox.Show("Đã Đăng Ký rồi");
                return;
            }
            try
            {
                var maLop = lbl_malop.Text;
                var ngayDK = DateTime.Now.ToString("yyyy/MM/dd HH:m");
                var status = 1;

                string connectionstring = conn;
                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sql = $@"INSERT INTO ADM.DANGKY(MaLop,MaSV,NgayDK,Status) VALUES({maLop},user,TO_DATE('{ngayDK}', 'yyyy/mm/dd hh24:mi'),{status})";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close(); // close the oracle connection

                    MessageBox.Show($"Đăng ký thành công");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool checkDaDangky()
        {
            var isDK = false;
            try
            {
                var maLop = lbl_malop.Text;
                var ngayDK = DateTime.Now.ToString("yyyy/MM/dd HH:m");
                var status = 1;

                string connectionstring = conn;
                using (OracleConnection conn = new OracleConnection(connectionstring)) // connect to oracle
                {
                    var sql = $@"SELECT COUNT(*) FROM ADM.DANGKY where malop = {maLop} and masv = user";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    conn.Open();
                    var count = cmd.ExecuteScalar();

                    if (Convert.ToInt16(count) > 0)
                    {
                        return true;
                    }
                    

                    return isDK;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isDK;
        }

        private void AddDKMH_Load(object sender, EventArgs e)
        {

        }
    }
}
