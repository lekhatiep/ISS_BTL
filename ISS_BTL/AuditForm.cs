using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace ISS_BTL
{
    public partial class AuditForm : Form
    {
        string conn = "";
        public AuditForm(string conn = "")
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void AuditForm_Load(object sender, EventArgs e)
        {
            loadDefault();
        }

        public void loadDefault()
        {
            try
            {
                string connectionstring = conn;

                string sql = "SELECT * FROM DBA_FGA_AUDIT_TRAIL";

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
    }
}
