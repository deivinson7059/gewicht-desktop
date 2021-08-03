using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using IBM.Data.DB2;

namespace BalanzaW
{
    public partial class frmPrincipal : Form
    {
        readonly  Conexion conexion = new Conexion();
        public static string fecha = "";
        public static string hora = "";
        public static string turno = "";
        public static string sec = "";
        public static Double peso = 0;
        public static string cc = "";
        public static string oper = "";
        public static string est = "";
        public static string Items = "";
        public static DataGridView DgvDat;

        

        public frmPrincipal()
        {
            InitializeComponent();
            
        }
        private void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)

        {

            SerialPort sp = (SerialPort)sender;
            string sred = sp.ReadExisting();

            MessageBox.Show(sred);
            lbl_peso.Text = sred;


           /* char dato_reciv = (char)serialPort1.ReadChar();
            lbl_peso.Text = dato_reciv.ToString();
            //char t = ' ';
            string ra = "";
            MessageBox.Show(serialPort1.ReadExisting());

            if (dato_reciv == (char)(2))
            {
                dato_reciv = (char)serialPort1.ReadChar();
                
                while (true)
                {
                    char t = (char)serialPort1.ReadChar();
                    ra += t;
                    if (t == ' ')
                    {
                        break;
                    }
                }

            }

            lbl_peso.Text = ra;
            Console.WriteLine(ra);
           string txtrecibe = "";
           txtrecibe = dato_reciv;*/

        }
        
        private void Buscapuerto()
        {
            string[] ports = SerialPort.GetPortNames();
            try
            {
                cmbPort.Items.Clear();
                foreach (string port in ports)
                {
                    cmbPort.Items.Add(port);
                }

               
                if (cmbPort.Items.Count > 0)
                {
                    cmbPort.SelectedIndex = 0;
                }
                else
                {


                    MessageBox.Show("NO HAY PUERTOS DISPONIBLES EN TU SISTEMA", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Turnos()
        {
            DB2DataReader leer;
            string sql = "SELECT HORARIO ID, REPLACE (DESCRIPCION, 'TURNO ', 'T') TEXT FROM ADMIN.SIRH_HORARIOS WHERE HORARIO IN('T3','T4','T5','T6','T7');";
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

                cmbTurno.DataSource = dt;
                cmbTurno.ValueMember = "ID";
                cmbTurno.DisplayMember = "TEXT";

                dt = null;
                leer = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DgvDat = DgvDatos;
            Buscapuerto();
           // Turnos();

        }

        public static void CargaDatos(DataGridView dgv,int Items, string Seccion)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.AbrirConexion();
                DB2DataAdapter da;
                DataTable dt = new DataTable();
                string sql = string.Format("SELECT ID ,FECHA,HORA,TURNO,PESO,SECCION,USER_REG FROM PROD.GEW_DATOS WHERE SECCION='{0}'  ORDER BY ID DESC LIMIT {1};", Seccion, Items);
                conexion._comando = new DB2Command(sql, conexion._conexion);
                
                da = new DB2DataAdapter(conexion._comando);
                
                da.Fill(dt);
                dgv.DataSource = dt;               


                string[] titulos = new string[] { "No. REG", "FECHA", "HORA", "TURNO", "PESO", "SECCION", "OPERADOR" };
                dgv.Columns[0].HeaderText = titulos[0];
                dgv.Columns[1].HeaderText = titulos[1];
                dgv.Columns[2].HeaderText = titulos[2];
                dgv.Columns[3].HeaderText = titulos[3];
                dgv.Columns[4].HeaderText = titulos[4];
                dgv.Columns[5].HeaderText = titulos[5];
                dgv.Columns[6].HeaderText = titulos[6];
                dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[0].ReadOnly = true;
                dgv.Columns[1].ReadOnly = true;
                dgv.Columns[2].ReadOnly = true;
                dgv.Columns[3].ReadOnly = true;
                dgv.Columns[4].ReadOnly = true;
                dgv.Columns[5].ReadOnly = true;
                dgv.Columns[6].ReadOnly = true;

                conexion.CerrarConexion();
                da.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btnconectar_Click(object sender, EventArgs e)
        {

            if (Btnconectar.Text== "CONECTAR BASCULA")
            {
                try
                {
                    serialPort1.PortName = cmbPort.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;

                    serialPort1.ReadTimeout = 500;
                    serialPort1.WriteTimeout = 500;
                    serialPort1.Open();
                    serialPort1.Write("0P");

                   

                    if (serialPort1.IsOpen)
                    {
                        lblestado.Text = "CONECTADO";                        
                        Btnconectar.Text = "DESCONECTAR BASCULA";
                        cmbPort.Enabled = false;
                        Btnconectar.BackColor = Color.Red;
                        serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1DataReceived);

                    }
                    else
                    {
                        MessageBox.Show("CONEXION FALLIDA!", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblestado.Text = "DESCONECTADO";
                Btnconectar.Text = "CONECTAR BASCULA";
                Btnconectar.BackColor = Color.FromArgb(0, 0, 192); 
                cmbPort.Enabled = true;
                serialPort1.Close();
            }


           
        }

        
        private void Btnenviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("");


            }
            else
            {
                MessageBox.Show("NO ESTAS CONECTADO", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Desea Salir de la Aplicacion", "Gewicht", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                MessageBox.Show("Adios", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

        }
       
        public static void SaveRegistros()
        {

            Conexion conexion = new Conexion();
            string sql = string.Format("INSERT INTO PROD.GEW_DATOS (ID, FECHA, HORA, TURNO, SECCION, PESO, LIDER_ID, USER_REG, ESTADO) VALUES ((SELECT COALESCE(MAX(ID),0)+1 AS ID FROM PROD.GEW_DATOS WHERE SECCION='{0}'),'{1}' , '{2}', '{3}', '{4}','{5}' , '{6}', '{7}', '{8}');", sec, fecha, hora, turno, sec, peso, cc, oper, est);
            
            try
            {

                conexion.AbrirConexion();                
                conexion._comando = new DB2Command(sql, conexion._conexion);                
                conexion._comando.ExecuteReader();
                conexion.CerrarConexion();
                int Cant = int.Parse(Items);
                string Seccion = sec;
                CargaDatos(DgvDat, Cant, Seccion);
                MessageBox.Show("Datos Capturados.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los datos.. Error: " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            fecha = TxtFecha.Text;
            hora = labelhora.Text;
            turno = cmbTurno.SelectedValue.ToString();
            sec = txtSecc.Text;
            peso = Convert.ToDouble(lbl_peso.Text);
            cc = txtCCoper.Text;
            oper = txtOper.Text;
            est = "A";
            Items = CmbItems.Text;
            DgvDat = DgvDatos;            
            frmModal Modal = new frmModal();
            Modal.ShowDialog(this);

            Modal.Dispose();



        }

        private void Reloj_Tick_1(object sender, EventArgs e)
        {
            labelhora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void DgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           string ValorId =  DgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            DB2DataReader verificar;
            
            string select = string.Format("SELECT * FROM PROD.GEW_DATOS WHERE ID= '{0}'", ValorId);
            conexion._comando = new DB2Command(select, conexion._conexion);
            conexion.AbrirConexion();
            verificar = conexion._comando.ExecuteReader();
            if (verificar.Read())
            {

                TxtIdR.Text = verificar.GetString(0);
                TxtFechR.Text = verificar.GetString(2);
                TxtHoraR.Text = verificar.GetString(3);
                TxtTurnR.Text = verificar.GetString(4);
                TxtSeccR.Text = verificar.GetString(5);
                TxtPesoR.Text = verificar.GetString(7);
                TextOperR.Text = verificar.GetString(9);
                
                gBox4.Visible = true;

                if (txtPerfil.Text.Equals("OPERARIO"))
                {
                    BtnDel.Visible = false;
                    
                }
                else
                {
                    BtnDel.Visible = true;
                }
            }
            else
            {
                gBox4.Visible = false;
                TxtIdR.Text = "";
                TxtFechR.Text = "";
                TxtHoraR.Text = "";
                TxtTurnR.Text = "";
                TxtSeccR.Text = "";
                TxtPesoR.Text = "";
                TextOperR.Text = "";
                MessageBox.Show("El Registro no fue encontrado.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            conexion.CerrarConexion();

            
        }

        private void CmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Cant = int.Parse(CmbItems.Text);
            string Seccion = txtSecc.Text;
            CargaDatos(DgvDatos, Cant, Seccion);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Desea Imprimir el Registro", "Gewicht", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {



                CrearTicket ticket = new CrearTicket();
                //Ya podemos usar todos sus metodos
                ticket.AbreCajon();//Para abrir el cajon de dinero.

                //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

                //Datos de la cabecera del Ticket.
                ticket.TextoCentro("BATERIAS WILLARD S.A");
                ticket.TextoCentro("SISTEMA CONTROL DE PESAJE GEWICHT");
                ticket.TextoIzquierda("SECCION: METALURGIA");
                ticket.TextoIzquierda("");
                ticket.TextoExtremos("Imp.", "Reg.");
                ticket.lineasAsteriscos();

                //Sub cabecera.-
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("OPERADOR: ");
                ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
                ticket.TextoIzquierda("");
                ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
                ticket.TextoExtremos("TURNO: " + DateTime.Now.ToShortDateString(), "OPERADOR: " + DateTime.Now.ToShortTimeString());
                ticket.lineasAsteriscos();


                ticket.lineasIgual();

                //Resumen de la venta. Sólo son ejemplos
                ticket.AgregarTotales("         PESO.......", 100);


                //Texto final del Ticket.
                ticket.TextoIzquierda("");
                ticket.CortaTicket();
                ticket.ImprimirTicket("EPSON L3110 Series");//Nombre de la impresora ticketera
                MessageBox.Show("Datos enviados a la impresora ", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Desea Eliminar el Registro", "Gewicht", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {

                DB2DataReader sup;

                string Id = TxtIdR.Text.Trim();
                string Sec = TxtSeccR.Text.Trim();
                string SQL = string.Format("DELETE FROM PROD.GEW_DATOS WHERE ID='{0}' AND SECCION='{1}';", Id, Sec);

                conexion._comando = new DB2Command(SQL, conexion._conexion);
                conexion.AbrirConexion();
                sup = conexion._comando.ExecuteReader();

                if (sup.Read())
                {
                    MessageBox.Show("Ocurrio un error y no se pudo eliminar el registro.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                     
                }
                else
                {

                    MessageBox.Show("Registro eliminado con exito.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

                gBox4.Visible = false;
                TxtIdR.Text = "";
                TxtFechR.Text = "";
                TxtHoraR.Text = "";
                TxtTurnR.Text = "";
                TxtSeccR.Text = "";
                TxtPesoR.Text = "";
                TextOperR.Text = "";
                conexion.CerrarConexion();
                int Cant = int.Parse(CmbItems.Text);
                string Seccion = txtSecc.Text;
                CargaDatos(DgvDatos, Cant, Seccion);                
            }
        }

        private void SerialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}
