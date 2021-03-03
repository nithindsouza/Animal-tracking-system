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
    public partial class main : Form
    {
        DataLayer dl = new DataLayer();
        public main()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtgps.Text = "";
            txtanimal.Text = "";
            combosec.SelectedIndex = -1;
            txtincharge.Text = "";

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (txtgps.Text == "")
            {
                MessageBox.Show("Enter GPS ID");
            }
            else if (txtanimal.Text == "")
            {
                MessageBox.Show("Enter Animal name");
            }
            else if (txtincharge.Text == "")
            {
                MessageBox.Show("Enter Incharge ");
            }
            else if (combosec.SelectedIndex == -1)
            {
                MessageBox.Show("Select Section");
            } 
            
            String str1 = "Insert into gps(idgps,animal,sec,incharge) values('" + txtgps.Text + "','" + txtanimal.Text + "','" + combosec.Text + "','" + txtincharge.Text + "')";
            try
            {
                dl.DmlCmd(str1);
                MessageBox.Show("Saved");
            }
            catch
            {
                MessageBox.Show("Unable to Save, Try again");
            }
            String str = "select * from gps";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            list.DataSource = ds;
            list.DataMember = "table";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combosec.Items.Add("A");
            combosec.Items.Add("B");
            combosec.Items.Add("C");
            String str = "select * from gps";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str);
            list.DataSource = ds;
            list.DataMember = "table";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (txtgps.Text == null)
            {
                MessageBox.Show("Please select Gps Id");
            }
            String str = "delete from gps where idgps ='"+txtgps.Text+"'";
            try
            {
                dl.DmlCmd(str);
                MessageBox.Show("Deleted");
            }
            catch
            {
                MessageBox.Show("Unable to Delete, Try again");
            }
            String str1 = "select * from gps";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str1);
            list.DataSource = ds;
            list.DataMember = "table";
        }

        private void update_Click(object sender, EventArgs e)
        {
            String str = "update gps where idgps = '" + txtgps.Text + "' set animal='" + txtanimal.Text + "', sec ='" + combosec.Text + "', incharge='" + txtincharge.Text + "'";
            try
            {
                dl.DmlCmd(str);
                MessageBox.Show("Updated");
            }
            catch
            {
                MessageBox.Show("Unable to Update, Try again");
            }
            String str1= "select * from gps";
            DataSet ds = new DataSet();
            ds = dl.GetDataSet(str1);
            list.DataSource = ds;
            list.DataMember = "table";
        }

        private void list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tracker tr = new Tracker();
            tr.ShowDialog();
           
        }
    }
}
