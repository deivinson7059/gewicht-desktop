using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using IBM.Data.DB2;
using System.Net;

namespace BalanzaW
{
    public partial class FrmPrincipal : Form
    {
        readonly Conexion conexion = new Conexion();


        public static int id_registro = 0;
        public static bool nuevo = true;
        public static bool basculaConect = false;
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
        public static string data_recibida = "0.0";
        
        public static string hora_reg = "";
        public static int anulado = 0;
        public static int cant_atado = 0;
        public static Double peso = 0.0;

        public static string valtest = "";



        public static string Items = "";
        public static DataGridView DgvDat;



        public FrmPrincipal()
        {
            InitializeComponent();

        }

        public static void SaveRegistros()
        {

            string nValor = data_recibida;
            //nValor = nValor.Replace(",", ".");



            Conexion conexion = new Conexion();
          

            string sql;

            if (nuevo == true) {
                sql = "INSERT INTO PROD.GEW_BASCULA_DATOS (ID_REGISTRO, CONSEC, COD_IBES, REF_IBES, CAT_IBES, ID_BASCULA, BASCULA, ID_PROCESO, PROCESO, PRESENTACION, FECHA_REG, HORA_REG, PESO, DOC_REF, USER_REG, ANULADO,N_ATADO) VALUES ((SELECT COALESCE(MAX(ID_REGISTRO),0)+1 AS ID FROM PROD.GEW_BASCULA_DATOS), 1, '" + cod_ibes + "', '" + ref_ibes + "', '" + cat_ibes + "','" + id_bascula + "' , '" + bascula + "','" + id_proceso + "' , '" + proceso + "', '" + presentacion + "',CURRENT DATE , '" + hora_reg + "','" + nValor + "' , '" + doc_ref + "', '" + user_reg + "',0,'" + cant_atado + "');";
            }
            else 
            {              
                sql = "INSERT INTO PROD.GEW_BASCULA_DATOS (ID_REGISTRO, CONSEC, COD_IBES, REF_IBES, CAT_IBES, ID_BASCULA, BASCULA, ID_PROCESO, PROCESO, PRESENTACION, FECHA_REG, HORA_REG, PESO, DOC_REF, USER_REG, ANULADO,N_ATADO) VALUES ('" + id_registro + "',(SELECT COALESCE(MAX(CONSEC),0)+1 AS CONSEC FROM PROD.GEW_BASCULA_DATOS WHERE ID_REGISTRO='" + id_registro + "' ), '" + cod_ibes + "', '" + ref_ibes + "', '" + cat_ibes + "','" + id_bascula + "' , '" + bascula + "','" + id_proceso + "' , '" + proceso + "', '" + presentacion + "',CURRENT DATE , '" + hora_reg + "','" + nValor + "' , '" + doc_ref + "', '" + user_reg + "',0,'" + cant_atado + "');";
            }


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
                Console.Write(ex);
                CargaDatos(DgvDat, 100);
                MessageBox.Show("Datos Capturados.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               // MessageBox.Show("Error al Guardar los datos.. Error: " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        char anterior;
        string dato = "";
        private void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)

        {

            /* SerialPort sp = (SerialPort)sender;
             string sred = sp.ReadExisting();*/

            //s//tring dato_reciv = (string)serialPort1.ReadLine();
            //txtPeso.Text = dato_reciv.ToString();

            //MessageBox.Show(dato_reciv);
            //txtPeso.Text = sred.ToString();
            try
            {

                char dato_reciv = (char)serialPort1.ReadChar();
                //txtPeso.Text = dato_reciv.ToString();
                //char t = ' ';
                //string ra = "";

                //char dato_reciv = (char)e.

                dato += dato_reciv;

                /*if (dato_reciv == '\r')
                {
                    Console.WriteLine("<CR>");
                }
                else if (dato_reciv == '\n')
                {
                    Console.WriteLine("<LF>");
                    goDato(dato);
                    dato = "";
                }
                else
                {
                    //Console.WriteLine(dato_reciv);
                    
                }
                */
               // Console.WriteLine(dato);

                if (dato_reciv == '\r')
                {
                    //Console.WriteLine(dato);
                    goDato(dato);
                   // Console.WriteLine("Fin del dato");
                    dato = "";

                }
                else
                {
                    anterior = dato_reciv;

                }

               

                //txtPeso.Text = ra;

                //string txtrecibe = "";
                //txtrecibe = dato_reciv.ToString();


            }
            catch(TimeoutException ex)
            {
                Console.WriteLine(ex.Message);
                //dato = "";
            }

        }

        private void goDato(String valor)
        {

            valor= valor.Replace("N", "");
            valor= valor.Replace("1G", "");
            valor= valor.Replace("1GM", "");
            valor= valor.Replace("KG G", "");
            valor= valor.Replace("CZ", "");
            valor= valor.Replace("G", "");
            valor= valor.Replace("MO", "");
            valor = valor.Replace("kg", "");
            valor = valor.Replace("g", "");
            valor = valor.Replace("gr", "");
            valor= valor.Trim();
            //Console.WriteLine("valor");
            Console.WriteLine(valor);

         


            Invoke(new MethodInvoker(() =>
            {

                try
                {
                    if (!Double.IsNaN(Double.Parse(valor.Trim())))
                    {
                        data_recibida = valor;
                        if (txtAutomatic.Text=="ON")
                        {
                            saveRecord();
                        }
                    }
                    else
                    {
                        data_recibida = "0.0";
                    }


                    txtPeso.Text = data_recibida;
                }
                catch (Exception)
                {

                    data_recibida = "0.0";
                    txtPeso.Text = data_recibida;
                }

            }));


          

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

        private void GetRandoPeso() {
            Random ran = new Random();
            Double valor = ran.Next(75, 99999) / 10.00;
            peso = valor;

            String nValor = valor.ToString();
            txtPeso.Text = nValor.Replace(",", ".");

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

        private void CmbCat_SelectedIndexChanged(object sender, EventArgs e)
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

                GetCbRef(txtcateg);

                cmbRefIbes.Focus();
            }
            else
            {
                GetCbRef("");
            }
        }

        private void GetCbBascula()
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

        private void GetcbPres()
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


        private void GetCbRef(string cat)
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

        private void GetcbCat()
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

        private void GetCbProcess()
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
            GetCbBascula();
            GetCbProcess();
            GetcbCat();
            GetcbPres();
            lblUsers.Text = Dns.GetHostName().ToUpper();
            CmbItems.Text = "100";
            CargaDatos(DgvDat, 100);


        }
        public static void CargaDatosR(int Items)
        {
            CargaDatos(DgvDat, Items);

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
                string sql = string.Format("SELECT ID_REGISTRO AS ID ,CONSEC,COD_IBES,BASCULA, PROCESO,PRESENTACION,FECHA_REG AS FECHA,HORA_REG AS HORA,PESO,N_ATADO,DOC_REF,USER_REG FROM PROD.GEW_BASCULA_DATOS WHERE USER_REG='{0}' AND ANULADO='0' AND REG_TABLE IS NULL  ORDER BY ID DESC,CONSEC DESC LIMIT {1};", Users, Items);
                conexion._comando = new DB2Command(sql, conexion._conexion);
                
                da = new DB2DataAdapter(conexion._comando);
                
                da.Fill(dt);
                dgv.DataSource = dt;               


                string[] titulos = new string[] { "No. REG", "CONSEC", "COD IBES", "BASCULA", "PROCESO", "PRESENTACION", "FECHA", "HORA", "PESO","CANT_X_ATADO", "DOC_REF",  "USUARIO" };
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
                dgv.Columns[11].HeaderText = titulos[11];
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
                dgv.Columns[11].ReadOnly = true;

                conexion.CerrarConexion();
                da.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void conectarBascula()
        {
            if (Btnconectar.Text == "CONECTAR BASCULA")
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

                        serialPort1.Write("P");
                        serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1DataReceived);
                        basculaConect = true;

                    }
                    else
                    {
                        MessageBox.Show("CONEXION FALLIDA!", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        basculaConect = false;
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
                basculaConect = false;
                serialPort1.Close();
            }




        }
        private void Btnconectar_Click(object sender, EventArgs e)
        {
            conectarBascula();
        }
        private void desconectarBascula()
        {
            lblestado.Text = "DESCONECTADO";
            Btnconectar.Text = "CONECTAR BASCULA";
            Btnconectar.BackColor = Color.FromArgb(0, 0, 192);
            cmbPort.Enabled = true;
            cmbBascula.Enabled = true;
            basculaConect = false;
            serialPort1.Close();

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

        private void saveRecord()
        {
            if (basculaConect == false)
            {
                MessageBox.Show("Debe Conectar la bascula", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Btnconectar.Focus();

            }
            else if (cmbCat.Text == "")
            {
                MessageBox.Show("Debe elegir la categoria", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCat.Focus();
            }
            else if (cmbRefIbes.Text == "")
            {
                MessageBox.Show("Debe elegir la referencia", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRefIbes.Focus();
            }
            else if (cmbProcess.Text == "")
            {
                MessageBox.Show("Debe elegir el proceso", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProcess.Focus();
            }
            else if (cmbPresent.Text == "")
            {
                MessageBox.Show("Debe elegir la presentacion", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPresent.Focus();
            }
            else if (txtCant.Text == "")
            {
                MessageBox.Show("Debe digitar el numero de valor", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCant.Focus();
            }
            else
            {
                if (nuevo == true)
                {

                    try
                    {
                        DB2DataReader verificar;
                        string select = "SELECT COALESCE(MAX(ID_REGISTRO),0)+1 AS NEXT FROM PROD.GEW_BASCULA_DATOS;";

                        conexion._comando = new DB2Command(select, conexion._conexion);
                        conexion.AbrirConexion();
                        verificar = conexion._comando.ExecuteReader();
                        if (verificar.Read())
                        {

                            int reg = int.Parse(verificar.GetString(0));
                            id_registro = reg;
                            nuevo = false;

                        }
                        else
                        {
                            id_registro = 0;
                            nuevo = true;
                        }
                        conexion.CerrarConexion();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


                cod_ibes = cmbRefIbes.SelectedValue.ToString();
                ref_ibes = cmbRefIbes.Text;
                cat_ibes = cmbCat.SelectedValue.ToString();
                id_bascula = int.Parse(cmbBascula.SelectedValue.ToString());
                bascula = cmbBascula.Text;
                id_proceso = int.Parse(cmbProcess.SelectedValue.ToString());
                proceso = cmbProcess.Text;
                presentacion = cmbPresent.Text;
                doc_ref = txtDocRef.Text;
                cant_atado = int.Parse(txtCant.Text);
                data_recibida = txtPeso.Text;

                fecha_reg = "2021-02-01";
                hora_reg = labelhora.Text;
                user_reg = lblUsers.Text;


                Items = CmbItems.Text;
                DgvDat = DgvDatos;
                SaveRegistros();
                //frmModal Modal = new frmModal();
                //Modal.ShowDialog(this);

                //Modal.Dispose();


            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveRecord();
        }


        private void Reloj_Tick_1(object sender, EventArgs e)
        {
            labelhora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelfecha.Text = DateTime.Now.ToLongDateString();
           
        }

        private void DgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           string ValorId =  DgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
           string ValorId2 =  DgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();            
           

            frmEditar frmEditModal = new frmEditar();
            frmEditModal.GetIdReg(ValorId, ValorId2);

            frmEditModal.ShowDialog(this);
            

            frmEditModal.Dispose();
            
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
                //ticket.AbreCajon();//Para abrir el cajon de dinero.

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

        private void SerialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void TimerPeso_Tick(object sender, EventArgs e)
        {
            GetRandoPeso();
        }

              

        private void CmbBascula_SelectedIndexChanged(object sender, EventArgs e)
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
                        txtAutomatic.Text = verificar.GetString(10);
                        txtLabelText.Text = verificar.GetString(11);

                        labelAtado.Text= verificar.GetString(11);

                        if(labelAtado.Text== "Num.Mezcla:")
                        {
                            txtCant.Text = "1";
                        }
                        else
                        {
                            txtCant.Text = "";
                        }


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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            cmbCat.Text = "";
            cmbRefIbes.Text = "";

            id_registro = 0;
            cod_ibes = "";
            ref_ibes = "";
            cat_ibes = "";
            cmbCat.Focus();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Desea Cambiar la Configuracion", "Gewicht", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ConexionLocal conexionLocal = new ConexionLocal();
            conexionLocal.AbrirConLocal();
            if (Result == DialogResult.Yes)
            {

                desconectarBascula();
                this.Hide();
                FrmConfig frm = new FrmConfig();

                frm.Show();
            }
        }
    }
}
