using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp_LED
{
    public partial class Form1 : Form
    {
        private SerialPort myport;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = "COM9";
                myport.Open();
            }
            catch(Exception)
            {
                MessageBox.Show("Error!!");
            }

            //
            onButton.Enabled = true;
            offButton.Enabled = false;
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            myport.WriteLine("1");

            onButton.Enabled = false;
            offButton.Enabled = true;
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            myport.WriteLine("0");

            onButton.Enabled = true;
            offButton.Enabled = false;
        }
    }
}
