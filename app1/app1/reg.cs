using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace app1
{
    public partial class reg : Form
    {
        
        DataLayer dl = new DataLayer();
        public reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
                MessageBox.Show("Enter a name");
            else if (phone.Text == "")
                MessageBox.Show("Enter a phone number");
            else if (email.Text == "")
                MessageBox.Show("Enter a email");
            else if (userid.Text == "")
                MessageBox.Show("Enter a User ID");
            else if (pass.Text == "")
                MessageBox.Show("Enter a Password");
            else if (pass.Text != confirmpass.Text)
                MessageBox.Show("Password Not Matching");
            else
            {
                String str = "Insert into users(name,email,userid,pass,phone) values('"+name.Text+"','"+email.Text+"','"+userid.Text+"','"+pass.Text+"','"+phone.Text+"')";
                try
                {
                    dl.DmlCmd(str);
                    MessageBox.Show("Registered Successfully");
                    this.Hide();
                    new login().Show();
                }
                catch
                {
                    MessageBox.Show("Unable to Register, Try again");
                }

            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Text = "";
            phone.Text = "";
            email.Text = "";
            userid.Text = "";
            pass.Text = "";
            confirmpass.Text = "";

        }

        private void reg_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
