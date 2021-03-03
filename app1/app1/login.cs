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
    public partial class login : Form
    {
        DataLayer dl = new DataLayer();
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            String str = "select * from users where userid = '" + txtusername.Text + "' and pass = '" + txtpass.Text + "'";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            if (ds.Tables[0].Rows.Count > 0)
            {
                str = "select * from users where userid = '" + txtusername.Text + "' and pass == '" + txtpass.Text + "'";
               DataSet dsp = new DataSet();
                dsp = dl.GetDataSet(str);

               
                    DataLayer.uname = txtusername.Text;
                   main frm = new main();
                   frm.ShowDialog();
                 this.Hide();
                

            } 
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpass.Text = "";
        }
    }
}
