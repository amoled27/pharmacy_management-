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
    public partial class addform : Form
    {
        public addform()
        {
            InitializeComponent();
        }

        private void drug_id_text_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=XE;User Id=system;Password=admin;";

            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "Insert into pharm.DRUG values (" + drug_id_text.Text + ",'" + textBox1.Text + "','" + textBox2.Text + "' ,'" + textBox3.Text + "' ," + cost.Text + "," + quantity.Text + ")";

            int rowsUpdated = cmd.ExecuteNonQuery();

            if (rowsUpdated == 0)

                MessageBox.Show("Record not inserted");

            else

                MessageBox.Show("Success!");

            conn.Dispose();


            //MessageBox.Show(textBox2.Text);
            //MessageBox.Show(textBox3.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void expdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void addform_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
