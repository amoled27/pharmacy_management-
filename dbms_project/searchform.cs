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
    public partial class searchform : Form
    {
        public searchform()
        {
            InitializeComponent();
        }

        private void searchform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DRUG' table. You can move, or remove it, as needed.
          //  this.dRUGTableAdapter.Fill(this.dataSet1.DRUG);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string oradb1 = "Data Source=XE;User Id=system;Password=admin;";

            string query2 = "select * from  pharm.DRUG  WHERE DRUG_ID = " + textBox1.Text + " ";

            OracleConnection conn1 = new OracleConnection(oradb1);

            conn1.Open();

            OracleCommand cmd1 = new OracleCommand();

            cmd1.Connection = conn1;

            OracleDataAdapter da = new OracleDataAdapter(query2, conn1);

            DataSet d = new DataSet();

            da.Fill(d, "DRUG");

            dataGridView1.DataSource = d.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
