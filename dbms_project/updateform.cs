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
    public partial class updateform : Form
    {
        public updateform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "aa";
        }

        private void updateform_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "aa";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=XE;User Id=system;Password=admin;";

            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "update pharm.DRUG set D_NAME = '" + updatename.Text + "', MFD = '"+ textBox3.Text +"', EXP= '"+ updateexp.Text + "' , COST ="+ updatecost.Text +", QUANTITY =  "+ textBox2.Text + " WHERE DRUG_ID = " + textBox1.Text;

            int rowsUpdated = cmd.ExecuteNonQuery();

            if (rowsUpdated == 0)

                MessageBox.Show("Record not inserted");

            else

                MessageBox.Show("Success!");

            conn.Dispose();

        }

        private void updatename_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatecost_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateexp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
