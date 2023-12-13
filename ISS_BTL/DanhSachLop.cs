﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ISS_BTL
{
    public partial class DanhSachLop : Form
    {
        string conn = "";
        public DanhSachLop(string conn = "")
        {
            //this.conn = conn;
            this.conn = new OracleDB().OracleConnString("localhost", "1521", "qlmhpdb", "adm", "123"); ;
            InitializeComponent();
        }

        private void DanhSachLop_Load(object sender, EventArgs e)
        {
            loadDefault();
        }

        public void loadDefault()
        {
            try
            {
                string connectionstring = conn;

                string sql = "select * from LOP";

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
            AddLopForm addLopForm = new AddLopForm(conn);
            addLopForm.Show();
        }

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_lopID.Text = string.Empty;
            var countRow = dataGridView2.Rows.Count - 1;

            var rowIndex = e.RowIndex;
            if (rowIndex < countRow && rowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = dataGridView2.Rows[rowIndex];

                var idLop = dataGridViewRow.Cells[0].Value.ToString();
                //MessageBox.Show("mouse click"+ username);

                txt_lopID.Text = idLop;
            }
           
        }
    }
}
