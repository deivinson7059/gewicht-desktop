using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using IBM.Data.DB2;
using System.Net;

namespace BalanzaW
{
    public partial class frmPrincipal : Form
    {
        readonly Conexion conexion = new Conexion();

        public static int id_registro = 0;
        public static bool nuevo = true;
        public static int consec = 0;
        public static string cod_ibes = "";
        public static string ref_ibes = "";
        public static string cat_ibes = "";
        public static int id_bascula = 0;
        public static string bascula = "";
        public static int id_proceso = 0;
        public static string proceso = "";
        public static string presentacion = "";
        public static string doc_ref = "";
        public static string notas = "";
        public static string user_reg = "";
        public static string fecha_reg = "";
        public static string hora_reg = "";
        public static int anulado = 0;
        public static string peso = "0.0";



        public static string Items = "";
        public static DataGridView DgvDat;



        public frmPrincipal()
        {
            InitializeComponent();

        }

        public static void SaveRegistros()
        {

            Conexion conexion = new Conexion();
            string sql = string.Format("INSERT INTO PROD.GEW_BASCULA_DATOS (ID_REGISTRO,CONSEC, COD_IBES, REF_IBES,CAT_IBES,ID_BASCULA,BASCULA,ID_PROCESO,PROCESO,PRESENTACION,FECHA_REG,HORA_REG,PESO, DOC_REF,NOTAS, USER_REG, ANULADO) VALUES ((SELECT COALESCE(MAX(ID_REGISTRO),0)+1 AS ID FROM PROD.GEW_BASCULA_DATOS),'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}');", consec,cod_ibes,ref_ibes,cat_ibes,id_bascula,bascula,id_proceso,proceso,presentacion,fecha_reg, hora_reg,peso,doc_ref,notas,user_reg,anulado);
            MessageBox.Show(sql);



            try
            {

                conexion.AbrirConexion();
                conexion._comando = new DB2Command(sql, conexion._conexion);
                conexion._comando.ExecuteReader();
                conexion.CerrarConexion();
                int Cant = int.Parse(Items);
                CargaDatos(DgvDat, Cant);
                MessageBox.Show("Datos Capturados.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los datos.. Error: " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void getRandoPeso() {
            Random ran = new Random();
            var valor = ran.Next(10, 10000) / 10.0;

            String nValor = valor.ToString();
            lbl_peso.Text = nValor.Replace(",", ".");

        }

        
        public static DataTable Datos(String sql, String tabla = "tableResul")
        {
            Conexion conexion = new Conexion();
            DB2DataAdapter da;
            DataSet dts = new DataSet();

            try
            {

                conexion.AbrirConexion();
                da = new DB2DataAdapter(sql, conexion._conexion);
                da.Fill(dts, tabla);
                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return dts.Tables[tabla];
        }

        public static AutoCompleteStringCollection AutoComplete(DataTable dt,String campo= "TEXT")
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach(DataRow row in dt.Rows)
            {
                collection.Add(Convert.ToString(row[campo]));
            }
            
            return collection;
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCat.Text != "")
            {
                string  txtcateg = cmbCat.SelectedValue.ToString();

                if (cmbRefIbes.Items.Count > 0)
                {
                    cmbRefIbes.Text = "";
                    cmbRefIbes.DataSource = null;
                    cmbRefIbes.Items.Clear();


                }
                cmbRefIbes.Text = "";

                getCbRef(txtcateg);

                cmbRefIbes.Focus();
            }
            else
            {
                getCbRef("");
            }
        }

        private void getCbBascula()
        {
            string sql = "SELECT ID_BASCULA ID, DES_BASCULA TEXT FROM PROD.GEW_BASCULA WHERE ACTIVO='SI';";

            try
            {

                DataTable dtBasc = Datos(sql, "tableBasc");

                cmbBascula.DataSource = dtBasc;
                cmbBascula.ValueMember = "ID";
                cmbBascula.DisplayMember = "TEXT";

                cmbBascula.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbBascula.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cmbBascula.AutoCompleteCustomSource = AutoComplete(dtBasc, "TEXT");
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getcbPres()
        {
            string sql = "SELECT TRIM(ID) ID, TRIM(PRESENTACION) TEXT FROM PROD.GEW_TYPE_PRE WHERE ACTIVO='SI';";

            try
            {

                DataTable dtPresent = Datos(sql, "tablePresent");

                cmbPresent.DataSource = dtPresent;
                cmbPresent.ValueMember = "ID";
                cmbPresent.DisplayMember = "TEXT";

                cmbPresent.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbPresent.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cmbPresent.AutoCompleteCustomSource = AutoComplete(dtPresent, "TEXT");
                cmbPresent.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void getCbRef(string cat)
        {
            try
            {
                string sql = string.Format("SELECT TRIM(PR_ID) ID, TRIM(PR_ID)||' - '||TRIM(PR_DESC) TEXT FROM IBES.ITEMMAIN WHERE PR_CMPY ='{0}' AND PR_PROD ='{1}' ORDER BY ID DESC", "02", cat);
           

                DataTable dtRef = Datos(sql, "tableRef");

                cmbRefIbes.DataSource = dtRef;
                cmbRefIbes.ValueMember = "ID";
                cmbRefIbes.DisplayMember = "TEXT";

                cmbRefIbes.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbRefIbes.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cmbRefIbes.AutoCompleteCustomSource = AutoComplete(dtRef, "TEXT");

                cmbRefIbes.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void getcbCat()
        {
            try
            {
                string sql = "SELECT TRIM(PRD_CAT) ID, TRIM(PRD_CAT) TEXT FROM IBES.PRODCAT WHERE PRD_CMPY='02';";

                DataTable dt = Datos(sql, "tableCat");

                cmbCat.DataSource = dt;
                cmbCat.ValueMember = "ID";
                cmbCat.DisplayMember = "TEXT";

                cmbCat.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbCat.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cmbCat.AutoCompleteCustomSource = AutoComplete(dt, "TEXT");
                cmbCat.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void getCbProcess()
        {
            try
            {
                string sql = "SELECT ID, DESCRIPCION  AS TEXT FROM PROD.GEW_PRODMETALURGIA_PROCESOS WHERE BASC='1';";

                DataTable dtProc = Datos(sql, "tableProcess");

                cmbProcess.DataSource = dtProc;
                cmbProcess.ValueMember = "ID";
                cmbProcess.DisplayMember = "TEXT";

                cmbProcess.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbProcess.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cmbProcess.AutoCompleteCustomSource = AutoComplete(dtProc, "TEXT");
                cmbProcess.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
          
        private void Form1_Load(object sender, EventArgs e)
        {
            DgvDat = DgvDatos;
            Buscapuerto();
            getCbBascula();
            getCbProcess();
            getcbCat();
            getcbPres();
            lblUsers.Text = Dns.GetHostName().ToUpper();

            CargaDatos(DgvDatos, 5);

        }

        

            public static void CargaDatos(DataGridView dgv,int Items)
        {

            string Users= Dns.GetHostName().ToUpper();
            try
            {
                Conexion conexion = new Conexion();
                conexion.AbrirConexion();
                DB2DataAdapter da;
                DataTable dt = new DataTable();
                string sql = string.Format("SELECT ID_REGISTRO AS ID ,CONSEC,COD_IBES,BASCULA, PROCESO,PRESENTACION,FECHA_REG AS FECHA,HORA_REG AS HORA,PESO,DOC_REF,USER_REG FROM PROD.GEW_BASCULA_DATOS WHERE USER_REG='{0}'  ORDER BY ID DESC LIMIT {1};", Users, Items);
                conexion._comando = new DB2Command(sql, conexion._conexion);
                
                da = new DB2DataAdapter(conexion._comando);
                
                da.Fill(dt);
                dgv.DataSource = dt;               


                string[] titulos = new string[] { "No. REG", "CONSEC", "COD IBES", "BASCULA", "PROCESO", "PRESENTACION", "FECHA", "HORA", "PESO", "DOC_REF",  "USUARIO" };
                dgv.Columns[0].HeaderText = titulos[0];
                dgv.Columns[1].HeaderText = titulos[1];
                dgv.Columns[2].HeaderText = titulos[2];
                dgv.Columns[3].HeaderText = titulos[3];
                dgv.Columns[4].HeaderText = titulos[4];
                dgv.Columns[5].HeaderText = titulos[5];
                dgv.Columns[6].HeaderText = titulos[6];
                dgv.Columns[7].HeaderText = titulos[7];
                dgv.Columns[8].HeaderText = titulos[8];
                dgv.Columns[9].HeaderText = titulos[9];
                dgv.Columns[10].HeaderText = titulos[10];
                //dgv.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[0].ReadOnly = true;
                dgv.Columns[1].ReadOnly = true;
                dgv.Columns[2].ReadOnly = true;
                dgv.Columns[3].ReadOnly = true;
                dgv.Columns[4].ReadOnly = true;
                dgv.Columns[5].ReadOnly = true;
                dgv.Columns[6].ReadOnly = true;
                dgv.Columns[7].ReadOnly = true;
                dgv.Columns[8].ReadOnly = true;
                dgv.Columns[9].ReadOnly = true;
                dgv.Columns[10].ReadOnly = true;

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
                    serialPort1.BaudRate = int.Parse(txtBaudios.Text);
                    serialPort1.DataBits = int.Parse(txtBitCaract.Text);
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;

                    serialPort1.ReadTimeout = int.Parse(txtInterval.Text);
                    serialPort1.WriteTimeout = int.Parse(txtInterval.Text);
                    serialPort1.Open();
                    serialPort1.Write(txtComando.Text);

                   

                    if (serialPort1.IsOpen)
                    {
                        lblestado.Text = "CONECTADO";                        
                        Btnconectar.Text = "DESCONECTAR BASCULA";
                        cmbPort.Enabled = false;
                        cmbBascula.Enabled = false;
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
                cmbBascula.Enabled = true;
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
       
        
        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (nuevo == true)
            {
                id_registro = id_registro+1;
                consec =  1;
            }
            else
            {
                id_registro = 0;
                consec = consec+1;
            }
           

            cod_ibes = cmbRefIbes.SelectedValue.ToString();
            ref_ibes = cmbRefIbes.Text;
            cat_ibes= cmbCat.SelectedValue.ToString();
            id_bascula = int.Parse(cmbBascula.SelectedValue.ToString());
            bascula = cmbBascula.Text;
            id_proceso = int.Parse(cmbProcess.SelectedValue.ToString());
            proceso = cmbProcess.Text;
            presentacion = cmbPresent.Text;
            doc_ref = txtDocRef.Text;

            fecha_reg = "2021-02-01";
            hora_reg = labelhora.Text;
            user_reg = lblUsers.Text;

            peso = lbl_peso.Text;

            MessageBox.Show(peso);



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
            
            string select = string.Format("SELECT * FROM PROD.GEW_BASCULA_DATOS WHERE ID_REGISTRO= '{0}'", ValorId);

            MessageBox.Show(select);
            conexion._comando = new DB2Command(select, conexion._conexion);
            conexion.AbrirConexion();
            verificar = conexion._comando.ExecuteReader();
            if (verificar.Read())
            {
                MessageBox.Show("REGITRO EXISTE");

                //TxtIdR.Text = verificar.GetString(0);

            }
            else
            {
                //gBox4.Visible = false;
                //TxtIdR.Text = "";
               // TxtFechR.Text = "";
                //TxtHoraR.Text = "";
                //TxtTurnR.Text = "";
                //TxtSeccR.Text = "";
                //TxtPesoR.Text = "";
                //TextOperR.Text = "";
                //MessageBox.Show("El Registro no fue encontrado.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            conexion.CerrarConexion();

            
        }

        private void CmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Cant = int.Parse(CmbItems.Text);
            CargaDatos(DgvDatos, Cant);
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

                //string Id = TxtIdR.Text.Trim();
                //string Sec = TxtSeccR.Text.Trim();
                string SQL = string.Format("DELETE FROM PROD.GEW_BASCULA_DATOS WHERE ID='{0}' AND SECCION='{1}';", 0, 0);

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

                //gBox4.Visible = false;
               // TxtIdR.Text = "";
                //TxtFechR.Text = "";
                //TxtHoraR.Text = "";
               // TxtTurnR.Text = "";
                //TxtSeccR.Text = "";
                //TxtPesoR.Text = "";
               // TextOperR.Text = "";
                conexion.CerrarConexion();
                int Cant = int.Parse(CmbItems.Text);
                CargaDatos(DgvDatos, Cant);                
            }
        }

        private void SerialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void timerPeso_Tick(object sender, EventArgs e)
        {
            getRandoPeso();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBascula_SelectedIndexChanged(object sender, EventArgs e)
        {

            DB2DataReader verificar;

            if (cmbBascula.Text != "")
            {

                string bascula = cmbBascula.Text;

                string select = string.Format("SELECT * FROM PROD.GEW_BASCULA_CONFIG WHERE BASCULA= '{0}'", bascula);

                try
                {
                    Conexion conexion = new Conexion();
                    conexion._comando = new DB2Command(select, conexion._conexion);
                    conexion.AbrirConexion();
                    verificar = conexion._comando.ExecuteReader();
                    if (verificar.Read())
                    {

                        txtBaudios.Text = verificar.GetString(2);
                        txtParid.Text = verificar.GetString(3);
                        txtBitCaract.Text = verificar.GetString(4);
                        txtBitPara.Text = verificar.GetString(5);
                        txtCadena.Text = verificar.GetString(6);
                        txtSubcadena.Text = verificar.GetString(7);
                        txtComando.Text = verificar.GetString(8);
                        txtInterval.Text = verificar.GetString(9);


                        Btnconectar.Enabled = true;

                    }
                    else
                    {

                        txtBaudios.Text = "";
                        txtParid.Text = "";
                        txtBitCaract.Text = "";
                        txtBitPara.Text = "";
                        txtCadena.Text = "";
                        txtSubcadena.Text = "";
                        txtComando.Text = "";
                        txtInterval.Text = "";
                        Btnconectar.Enabled = false;


                    }

                    conexion.CerrarConexion();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            txtIdReg.Text = "";
            txtConsc.Text = "";
            cmbCat.Text = "";
            cmbRefIbes.Text = "";

            id_registro = 0;
            consec = 0;
            cod_ibes = "";
            ref_ibes = "";
            cat_ibes = "";
            cmbCat.Focus();

        }
    }
}
