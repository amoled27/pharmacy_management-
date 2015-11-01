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
    public partial class deleteform : Form
    {
        public deleteform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=XE;User Id=system;Password=admin;";

            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "Delete from pharm.DRUG where DRUG_ID=" + textBox1.Text + " ";

            int rowsUpdated = cmd.ExecuteNonQuery();

            if (rowsUpdated == 0)

                MessageBox.Show("Record not deleted");

            else

                MessageBox.Show("Successfully deleted!");

            conn.Dispose();
        }
    }
}
