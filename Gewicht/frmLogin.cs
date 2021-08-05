using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using IBM.Data.DB2;



namespace BalanzaW
{
    public partial class frmLogin : Form
    {
        Conexion conexion = new Conexion();
        public frmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wPAram, int lParam);


        private void Seccion()
        {
            DB2DataReader leer;
            string sql = "SELECT DISTINCT NAME ID, NAME TEXT FROM PROD.GEW_SEC WHERE ACTIVO='SI' ORDER BY ID;";
            conexion._comando = new DB2Command(sql, conexion._conexion);

            try
            {
                DataTable dt;
                conexion.AbrirConexion();
                leer = conexion._comando.ExecuteReader();

                dt = new DataTable();

                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("COLUMN_NAME", typeof(string));
                dt.Load(leer);
                conexion.CerrarConexion();

                cmbSection.DataSource = dt;
                cmbSection.ValueMember = "ID";
                cmbSection.DisplayMember = "TEXT";

                dt = null;
                leer = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            TxtUsuario.Text = "Digite Cedula";
            TxtUsuario.ForeColor = Color.Gray;
            Seccion();


        }
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {

            if (TxtUsuario.Text == "Digite Cedula")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.LightGray;
            }            
          
        }
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Digite Cedula";
                TxtUsuario.ForeColor = Color.DimGray;
            }
        }
        
       
        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo solo permite numeros.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CerrarLogin_Click(object sender, EventArgs e)
        {
           DialogResult Result = MessageBox.Show("Desea Salir de la Aplicacion", "Gewicht", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                MessageBox.Show("Adios", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            
            
        }

        private void MinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text== "Digite Cedula")
            {
                MessageBox.Show("Usuario en Blanco", "Gewicht", MessageBoxButtons.OK,MessageBoxIcon.Error);
                TxtUsuario.Focus();
                
            }
            else if(cmbSection.Text == "")
            {
                MessageBox.Show("Seccion en Blanco", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSection.Focus();

            }
            else
            {
                DB2DataReader consultar;
                
                string Usuario = TxtUsuario.Text;

                string sql = string.Format("SELECT U.ID,U.CC,U.NAME,U.ROLE,S.SECC FROM IBES.W_USER_APP U INNER JOIN PROD.GEW_SEC_USER S ON S.DOC=U.CC WHERE U.CC= '{0}' AND S.SECC='{1}' AND  U.APP='GEWICHT' AND U.ACTIVO='SI' ;", Usuario, cmbSection.Text);

                conexion._comando = new DB2Command(sql, conexion._conexion);
                conexion.AbrirConexion();
                consultar = conexion._comando.ExecuteReader();
                

                if (consultar.Read())
                {
                    
                  
                    frmPrincipal Principal = new frmPrincipal();
                    MessageBox.Show("Bienvenido", "Gewicht", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    TxtUsuario.Text = "";                    
                    this.Hide();
                    
                    //Principal.txtCCoper.Text = consultar.GetString(1);
                    //Principal.txtUsers.Text = consultar.GetString(2);                     
                    //Principal.txtPerfil.Text = consultar.GetString(3);
                    //Principal.txtSecc.Text = consultar.GetString(4);

                    Principal.CmbItems.Text = "50";
                    int Cant = int.Parse(Principal.CmbItems.Text);
                    string Seccion = consultar.GetString(4);                                   
                    frmPrincipal.CargaDatos(Principal.DgvDatos, Cant, Seccion);
                    Principal.Show();
                }

                else
                {
                    MessageBox.Show("Error de usuario o Clave", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conexion.CerrarConexion();

            }

        }

    }
}
