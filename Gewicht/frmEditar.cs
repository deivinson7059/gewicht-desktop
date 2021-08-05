using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using IBM.Data.DB2;



namespace BalanzaW
{
    public partial class frmEditar : Form
    {
        Conexion conexion = new Conexion();
        public frmEditar()
        {
            InitializeComponent();
        } 


        private void MinimizarEditar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
