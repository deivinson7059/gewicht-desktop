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
using System.Threading;


namespace Gewicht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*try
            {
                serialPort1 = new SerialPort("COM3", 2400, Parity.None, 8, StopBits.One);
                serialPort1.Handshake = Handshake.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
                serialPort1.Open();
                serialPort1.Write("0P");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(this.Enabled == true){
                Thread.Sleep(500);
                string data = serialPort1.ReadExisting();
                label1.Text = data;

                //this.BeginInvoke(new DelegadoAcceso(si_DataReceived), new object[] {data});
            }
        }

        private void si_DataReceived( string accion)
        {
            label1.Text = accion;
            
        }
    }
}
