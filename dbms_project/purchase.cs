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
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            string y;
            a = Convert.ToInt32(textBox4.Text);
            a = int.Parse(textBox4.Text);
            b = Convert.ToInt32(textBox6.Text);
            b = int.Parse(textBox6.Text);
            c = a * b;
            y = c.ToString();
            this.textBox5.Text = y;

            string oradb = "Data Source=XE;User Id=system;Password=admin;";

            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "Insert into pharm.HIST (DRUG_ID,PURCHASE_ID,DIS,PRICE,QUANTITY) values (" + textBox1.Text + "," + textBox2.Text + ",'" + textBox3.Text + "' ," + textBox4.Text + " ," + textBox6.Text + ")";

            cmd.CommandText = "update pharm.DRUG set QUANTITY =QUANTITY - "+a+"";

            int rowsUpdated = cmd.ExecuteNonQuery();

            if (rowsUpdated == 0)

                MessageBox.Show("Record not inserted");

            else

                MessageBox.Show("Success!");

            conn.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox4.Text);
            a = int.Parse(textBox4.Text);
            string oradb = "Data Source=XE;User Id=system;Password=admin;";

            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "update pharm.DRUG set QUANTITY =QUANTITY - " + a + "";

            int rowsUpdated = cmd.ExecuteNonQuery();

            if (rowsUpdated == 0)

                MessageBox.Show("Record not inserted");

            else

                MessageBox.Show("Success!");

            conn.Dispose();
        }
    }
}
