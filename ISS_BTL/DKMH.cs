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
            //this.conn = new OracleDB().OracleConnString("localhost", "1521", "qlmhpdb", "adm", "123"); ; ;
            this.conn = conn;
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddDKMH dKMH = new AddDKMH(conn);
            dKMH.Show();
        }
    }
}
