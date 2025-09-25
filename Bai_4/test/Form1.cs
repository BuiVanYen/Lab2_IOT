using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            if(!serCOM.IsOpen)
            {
                butConnect.Text = "Disconnect";
                serCOM.PortName = "COM8";
                serCOM.BaudRate = Convert.ToInt32("9600");
                serCOM.Open();
            }
            else
            {
                butConnect.Text = "Connected";
                serCOM.Close();
            }    
        }

        private void butLed1_on_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("Bạn chưa kết nối cổng Serial");
            }
            else
                serCOM.Write("B1");
        }

        private void butLed1_off_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("Bạn chưa kết nối cổng Serial");
            }
            else
                serCOM.Write("T1");
        }

        private void butLed2_on_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("Bạn chưa kết nối cổng Serial");
            }
            else
                serCOM.Write("B2");
        }

        private void butLed2_off_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("Bạn chưa kết nối cổng Serial");
            }
            else
                serCOM.Write("T2");
        }
    }
}
