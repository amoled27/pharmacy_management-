using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbms_project
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            addform a = new addform();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update
            updateform u = new updateform();
            u.Show();
        }

        private void searchform_Click(object sender, EventArgs e)
        {
            searchform s = new searchform();
            s.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            deleteform d = new deleteform();
            d.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            history h = new history();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            purchase p = new purchase();
            p.Show();
        }
    }
}
