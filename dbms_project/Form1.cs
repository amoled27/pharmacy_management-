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
    public partial class loginform : Form
    {
        bool user=false , pass=false;
        public loginform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                user = true;

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            if (textBox2.Text == "admin")
            {
                pass = true;

            }

        }
        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (user) {
                if (pass) {
                    admin a = new admin();
                    a.Show();
                }
            
            }

           

        }

       

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        
    }
}
