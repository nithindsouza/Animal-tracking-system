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
    public partial class Change : Form
    {
        DataLayer dl = new DataLayer();

        public Change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newpass.Text == confirmpass.Text)
            {
                string str = "select * from users where userid = '" + DataLayer.uname + "' ";
                DataSet ds = new DataSet();
                ds = dl.GetDataSet(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    str = "update users set pass='" + newpass.Text + "' where userid ='" + DataLayer.uname + "'";
                    dl.DmlCmd(str);
                }
            }
            else
                MessageBox.Show("Password not matching,Try Again");



        }
    }
}
