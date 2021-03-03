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
    public partial class Form1 : Form
    {
        DataLayer dl = new DataLayer();
         public Form1()
         {
             InitializeComponent();
         }

         private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
         {
             reg frm = new reg();
           // frm.MdiParent = this;
          frm.ShowDialog();
          panel1.Visible = false;

         }

         private void btnlogin_Click(object sender, EventArgs e)
         {

         }
     
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            
            
               if (txtusername.Text == null)
                   MessageBox.Show("Enter Username");
               else if(txtpass.Text == null)
                   MessageBox.Show("Enter Valid Password");
               else{
                   try
                   {
                       String uid = "admin";
                       String pw = "admin";
                        


                      // String str = "select * from users where userid = '" + txtusername.Text + "' and pass = '" + txtpass.Text + "'";
                      // DataSet ds = new DataSet();
                      // ds = dl.GetDataSet(str);
                     //  if (ds.Tables[0].Rows.Count > 0)
                     //  {
                           //str = "select * from users where userid = '" + txtusername.Text + "' and pass == '" + txtpass.Text + "'";
                           // DataSet dsp = new DataSet();
                           //dsp = dl.GetDataSet(str);


                       //    DataLayer.uname = txtusername.Text;
                           //Change frm = new Change();
                           //frm.ShowDialog();
                          panel1.Visible = false;
                           menuStrip1.Visible = true;

                       }
                   
                   catch (Exception ex)
                   {
                       MessageBox.Show("Please Enter Valid Username and Password");
                   }
           
               } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpass.Text = "";
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.ShowDialog();
            panel1.Visible = false;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change ch = new Change();
            ch.ShowDialog();
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change ch = new Change();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reg rg = new reg();
            rg.ShowDialog();
        }
    }
}
