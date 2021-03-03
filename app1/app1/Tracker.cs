using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace app1
{
    public partial class Tracker : Form
    {
        public Tracker()
        {
            InitializeComponent();
        }
        SerialPort serialPort;

        string data = string.Empty;
        private delegate void SetTextDeleg(string text);
        void Fun_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(500);
                data = serialPort.ReadLine();
                this.BeginInvoke(new SetTextDeleg(Fun_IsDataReceived), new object[] { data });
            }
            catch (Exception ex)
            {
            }
        }
        private void Fun_IsDataReceived(string data)
        {
            try
            {

                String s = data.Trim();



                String str = "select * from gps";
                DataSet ds = new DataSet();
                DataLayer dl = new DataLayer();
                ds = dl.GetDataSet(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblAnimal.Text = ds.Tables[0].Rows[0]["animal"].ToString();
                    lblSection.Text = ds.Tables[0].Rows[0]["sec"].ToString();
                }

                String m = s.Substring(9, 10);

                label1.Text = m;




                s = s.Substring(30, 11);
                label2.Text = s;



              


            }
            catch (Exception ex)
            {
            }
          
        }



        private void Tracker_Load(object sender, EventArgs e)
        {
            serialPort = new SerialPort();// if u r not used Serial Port Tool
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Open();
            serialPort.ReadTimeout = 2000;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(Fun_DataReceived);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.Write("1");
        }

        private void lblAnimal_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblSection_Click(object sender, EventArgs e)
        {

        }
    }
}
