using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace dbms_project
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
        {
            string oradb = "Data Source=XE;User Id=system;Password=admin;";
            using(OracleConnection conn = new OracleConnection(oradb))
            using(OracleCommand cmd = new OracleCommand("select * from HIST", conn))
            {
                conn.Open();
                using(OracleDataReader reader = cmd.ExecuteReader())
                {
                     DataTable dataTable = new DataTable();
                     dataTable.Load(reader);
                     dataGridView1.DataSource = dataTable;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
        }
   
    }

