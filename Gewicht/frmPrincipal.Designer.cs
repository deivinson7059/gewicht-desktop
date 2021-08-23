namespace BalanzaW
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblestado = new System.Windows.Forms.Label();
            this.Btnconectar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CmbItems = new System.Windows.Forms.ComboBox();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gBox3 = new System.Windows.Forms.GroupBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDocRef = new System.Windows.Forms.TextBox();
            this.cmbPresent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRefIbes = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbProcess = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gBox2 = new System.Windows.Forms.GroupBox();
            this.txtBitPara = new System.Windows.Forms.TextBox();
            this.txtBitCaract = new System.Windows.Forms.TextBox();
            this.txtParid = new System.Windows.Forms.TextBox();
            this.txtBaudios = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSubcadena = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBascula = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ImgWillard = new System.Windows.Forms.PictureBox();
            this.MinimizarLogin = new System.Windows.Forms.PictureBox();
            this.CerrarLogin = new System.Windows.Forms.PictureBox();
            this.TextoLogin = new System.Windows.Forms.Label();
            this.gBox0 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.labelfecha = new System.Windows.Forms.Label();
            this.labelhora = new System.Windows.Forms.Label();
            this.timerPeso = new System.Windows.Forms.Timer(this.components);
            this.lblUsers = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.gBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.gBox3.SuspendLayout();
            this.gBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWillard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarLogin)).BeginInit();
            this.gBox0.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(315, 308);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(107, 16);
            this.lblestado.TabIndex = 13;
            this.lblestado.Text = "DESCONECTADO";
            // 
            // Btnconectar
            // 
            this.Btnconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnconectar.Enabled = false;
            this.Btnconectar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnconectar.ForeColor = System.Drawing.Color.White;
            this.Btnconectar.Location = new System.Drawing.Point(287, 12);
            this.Btnconectar.Name = "Btnconectar";
            this.Btnconectar.Size = new System.Drawing.Size(132, 50);
            this.Btnconectar.TabIndex = 8;
            this.Btnconectar.Text = "CONECTAR BASCULA";
            this.Btnconectar.UseVisualStyleBackColor = false;
            this.Btnconectar.Click += new System.EventHandler(this.Btnconectar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.SerialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
            // 
            // gBox1
            // 
            this.gBox1.Controls.Add(this.label17);
            this.gBox1.Controls.Add(this.CmbItems);
            this.gBox1.Controls.Add(this.DgvDatos);
            this.gBox1.Controls.Add(this.label1);
            this.gBox1.Location = new System.Drawing.Point(462, 291);
            this.gBox1.Name = "gBox1";
            this.gBox1.Size = new System.Drawing.Size(788, 244);
            this.gBox1.TabIndex = 16;
            this.gBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(334, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 19);
            this.label17.TabIndex = 27;
            this.label17.Text = "LISTADO DE REGISTROS";
            // 
            // CmbItems
            // 
            this.CmbItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbItems.FormattingEnabled = true;
            this.CmbItems.ItemHeight = 13;
            this.CmbItems.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "50",
            "100"});
            this.CmbItems.Location = new System.Drawing.Point(699, 215);
            this.CmbItems.Name = "CmbItems";
            this.CmbItems.Size = new System.Drawing.Size(77, 21);
            this.CmbItems.TabIndex = 25;
            this.CmbItems.SelectedIndexChanged += new System.EventHandler(this.CmbItems_SelectedIndexChanged);
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToAddRows = false;
            this.DgvDatos.AllowUserToDeleteRows = false;
            this.DgvDatos.AllowUserToResizeRows = false;
            this.DgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.DgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatos.ColumnHeadersHeight = 28;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatos.EnableHeadersVisualStyles = false;
            this.DgvDatos.GridColor = System.Drawing.Color.White;
            this.DgvDatos.Location = new System.Drawing.Point(4, 35);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(207)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            this.DgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDatos.Size = new System.Drawing.Size(778, 174);
            this.DgvDatos.TabIndex = 0;
            this.DgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatos_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "No. Items:";
            // 
            // gBox3
            // 
            this.gBox3.Controls.Add(this.cmbCat);
            this.gBox3.Controls.Add(this.label23);
            this.gBox3.Controls.Add(this.btnNuevo);
            this.gBox3.Controls.Add(this.label22);
            this.gBox3.Controls.Add(this.txtDocRef);
            this.gBox3.Controls.Add(this.cmbPresent);
            this.gBox3.Controls.Add(this.label4);
            this.gBox3.Controls.Add(this.cmbRefIbes);
            this.gBox3.Controls.Add(this.label21);
            this.gBox3.Controls.Add(this.cmbProcess);
            this.gBox3.Controls.Add(this.label2);
            this.gBox3.Controls.Add(this.BtnSave);
            this.gBox3.Location = new System.Drawing.Point(461, 107);
            this.gBox3.Name = "gBox3";
            this.gBox3.Size = new System.Drawing.Size(789, 179);
            this.gBox3.TabIndex = 17;
            this.gBox3.TabStop = false;
            this.gBox3.Text = "Datos de Producción";
            // 
            // cmbCat
            // 
            this.cmbCat.BackColor = System.Drawing.Color.White;
            this.cmbCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.ItemHeight = 13;
            this.cmbCat.Location = new System.Drawing.Point(10, 32);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(187, 21);
            this.cmbCat.TabIndex = 51;
            this.cmbCat.SelectedIndexChanged += new System.EventHandler(this.CmbCat_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 23);
            this.label23.TabIndex = 50;
            this.label23.Text = "Categoria:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(637, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(137, 41);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "NUEVA REFERENCIA";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(635, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 14);
            this.label22.TabIndex = 49;
            this.label22.Text = "Documento Ref:";
            // 
            // txtDocRef
            // 
            this.txtDocRef.Location = new System.Drawing.Point(637, 80);
            this.txtDocRef.Name = "txtDocRef";
            this.txtDocRef.Size = new System.Drawing.Size(140, 20);
            this.txtDocRef.TabIndex = 48;
            // 
            // cmbPresent
            // 
            this.cmbPresent.BackColor = System.Drawing.Color.White;
            this.cmbPresent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPresent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPresent.FormattingEnabled = true;
            this.cmbPresent.ItemHeight = 13;
            this.cmbPresent.Location = new System.Drawing.Point(390, 79);
            this.cmbPresent.Name = "cmbPresent";
            this.cmbPresent.Size = new System.Drawing.Size(225, 21);
            this.cmbPresent.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Presentacion:";
            // 
            // cmbRefIbes
            // 
            this.cmbRefIbes.BackColor = System.Drawing.Color.White;
            this.cmbRefIbes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRefIbes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRefIbes.FormattingEnabled = true;
            this.cmbRefIbes.ItemHeight = 13;
            this.cmbRefIbes.Location = new System.Drawing.Point(211, 32);
            this.cmbRefIbes.Name = "cmbRefIbes";
            this.cmbRefIbes.Size = new System.Drawing.Size(404, 21);
            this.cmbRefIbes.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(207, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 44;
            this.label21.Text = "Referencia Ibes:";
            // 
            // cmbProcess
            // 
            this.cmbProcess.BackColor = System.Drawing.Color.White;
            this.cmbProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProcess.FormattingEnabled = true;
            this.cmbProcess.ItemHeight = 13;
            this.cmbProcess.Location = new System.Drawing.Point(9, 83);
            this.cmbProcess.Name = "cmbProcess";
            this.cmbProcess.Size = new System.Drawing.Size(371, 21);
            this.cmbProcess.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Proceso:";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Green;
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(398, 120);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(340, 45);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "CAPTURAR PESO";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.Black;
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtPeso.Font = new System.Drawing.Font("Elephant", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.White;
            this.txtPeso.Location = new System.Drawing.Point(6, 16);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(302, 78);
            this.txtPeso.TabIndex = 52;
            this.txtPeso.Text = "9999.99";
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 27;
            this.label14.Text = "Bascula:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(856, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Usuario:";
            // 
            // gBox2
            // 
            this.gBox2.Controls.Add(this.txtBitPara);
            this.gBox2.Controls.Add(this.txtBitCaract);
            this.gBox2.Controls.Add(this.txtParid);
            this.gBox2.Controls.Add(this.txtBaudios);
            this.gBox2.Controls.Add(this.label25);
            this.gBox2.Controls.Add(this.txtInterval);
            this.gBox2.Controls.Add(this.label24);
            this.gBox2.Controls.Add(this.txtComando);
            this.gBox2.Controls.Add(this.label19);
            this.gBox2.Controls.Add(this.txtSubcadena);
            this.gBox2.Controls.Add(this.label18);
            this.gBox2.Controls.Add(this.txtCadena);
            this.gBox2.Controls.Add(this.label12);
            this.gBox2.Controls.Add(this.cmbBascula);
            this.gBox2.Controls.Add(this.label14);
            this.gBox2.Controls.Add(this.label11);
            this.gBox2.Controls.Add(this.label10);
            this.gBox2.Controls.Add(this.label9);
            this.gBox2.Controls.Add(this.label5);
            this.gBox2.Controls.Add(this.lblestado);
            this.gBox2.Controls.Add(this.cmbPort);
            this.gBox2.Controls.Add(this.label3);
            this.gBox2.Controls.Add(this.Btnconectar);
            this.gBox2.Location = new System.Drawing.Point(12, 168);
            this.gBox2.Name = "gBox2";
            this.gBox2.Size = new System.Drawing.Size(441, 345);
            this.gBox2.TabIndex = 18;
            this.gBox2.TabStop = false;
            this.gBox2.Text = "Datos del Equipo";
            // 
            // txtBitPara
            // 
            this.txtBitPara.Enabled = false;
            this.txtBitPara.Location = new System.Drawing.Point(226, 152);
            this.txtBitPara.Name = "txtBitPara";
            this.txtBitPara.Size = new System.Drawing.Size(192, 20);
            this.txtBitPara.TabIndex = 63;
            // 
            // txtBitCaract
            // 
            this.txtBitCaract.Enabled = false;
            this.txtBitCaract.Location = new System.Drawing.Point(6, 152);
            this.txtBitCaract.Name = "txtBitCaract";
            this.txtBitCaract.Size = new System.Drawing.Size(192, 20);
            this.txtBitCaract.TabIndex = 62;
            // 
            // txtParid
            // 
            this.txtParid.Enabled = false;
            this.txtParid.Location = new System.Drawing.Point(226, 115);
            this.txtParid.Name = "txtParid";
            this.txtParid.Size = new System.Drawing.Size(192, 20);
            this.txtParid.TabIndex = 61;
            // 
            // txtBaudios
            // 
            this.txtBaudios.Enabled = false;
            this.txtBaudios.Location = new System.Drawing.Point(6, 115);
            this.txtBaudios.Name = "txtBaudios";
            this.txtBaudios.Size = new System.Drawing.Size(192, 20);
            this.txtBaudios.TabIndex = 60;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(230, 260);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 14);
            this.label25.TabIndex = 59;
            this.label25.Text = "Intervalo (Seg)";
            // 
            // txtInterval
            // 
            this.txtInterval.Enabled = false;
            this.txtInterval.Location = new System.Drawing.Point(228, 276);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(190, 20);
            this.txtInterval.TabIndex = 58;
            this.txtInterval.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(7, 261);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(130, 14);
            this.label24.TabIndex = 57;
            this.label24.Text = "Comando de lectura";
            // 
            // txtComando
            // 
            this.txtComando.Enabled = false;
            this.txtComando.Location = new System.Drawing.Point(9, 277);
            this.txtComando.Name = "txtComando";
            this.txtComando.Size = new System.Drawing.Size(189, 20);
            this.txtComando.TabIndex = 56;
            this.txtComando.Text = "P";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 14);
            this.label19.TabIndex = 55;
            this.label19.Text = "Subcadena:";
            // 
            // txtSubcadena
            // 
            this.txtSubcadena.Enabled = false;
            this.txtSubcadena.Location = new System.Drawing.Point(9, 236);
            this.txtSubcadena.Name = "txtSubcadena";
            this.txtSubcadena.Size = new System.Drawing.Size(410, 20);
            this.txtSubcadena.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 14);
            this.label18.TabIndex = 53;
            this.label18.Text = "Formato de cadena:";
            // 
            // txtCadena
            // 
            this.txtCadena.Enabled = false;
            this.txtCadena.Location = new System.Drawing.Point(9, 195);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(410, 20);
            this.txtCadena.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(225, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "Bits de parada:";
            // 
            // cmbBascula
            // 
            this.cmbBascula.BackColor = System.Drawing.Color.White;
            this.cmbBascula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBascula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBascula.FormattingEnabled = true;
            this.cmbBascula.ItemHeight = 13;
            this.cmbBascula.Location = new System.Drawing.Point(9, 75);
            this.cmbBascula.Name = "cmbBascula";
            this.cmbBascula.Size = new System.Drawing.Size(411, 21);
            this.cmbBascula.TabIndex = 19;
            this.cmbBascula.SelectedIndexChanged += new System.EventHandler(this.CmbBascula_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Bits por caracter:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Paridad:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Baudios:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Estado: ";
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.ItemHeight = 13;
            this.cmbPort.Location = new System.Drawing.Point(9, 34);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 21);
            this.cmbPort.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Puerto:";
            // 
            // ImgWillard
            // 
            this.ImgWillard.BackColor = System.Drawing.Color.Transparent;
            this.ImgWillard.Image = global::Gewicht.Properties.Resources.logoW2;
            this.ImgWillard.Location = new System.Drawing.Point(918, 50);
            this.ImgWillard.Name = "ImgWillard";
            this.ImgWillard.Size = new System.Drawing.Size(327, 56);
            this.ImgWillard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgWillard.TabIndex = 21;
            this.ImgWillard.TabStop = false;
            // 
            // MinimizarLogin
            // 
            this.MinimizarLogin.BackColor = System.Drawing.Color.Blue;
            this.MinimizarLogin.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarLogin.Image")));
            this.MinimizarLogin.Location = new System.Drawing.Point(1177, 12);
            this.MinimizarLogin.Name = "MinimizarLogin";
            this.MinimizarLogin.Size = new System.Drawing.Size(26, 19);
            this.MinimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizarLogin.TabIndex = 22;
            this.MinimizarLogin.TabStop = false;
            this.MinimizarLogin.Click += new System.EventHandler(this.MinimizarLogin_Click);
            // 
            // CerrarLogin
            // 
            this.CerrarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("CerrarLogin.Image")));
            this.CerrarLogin.Location = new System.Drawing.Point(1209, 12);
            this.CerrarLogin.Name = "CerrarLogin";
            this.CerrarLogin.Size = new System.Drawing.Size(26, 19);
            this.CerrarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarLogin.TabIndex = 21;
            this.CerrarLogin.TabStop = false;
            this.CerrarLogin.Click += new System.EventHandler(this.CerrarLogin_Click);
            // 
            // TextoLogin
            // 
            this.TextoLogin.AutoSize = true;
            this.TextoLogin.BackColor = System.Drawing.Color.Transparent;
            this.TextoLogin.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoLogin.ForeColor = System.Drawing.Color.Black;
            this.TextoLogin.Location = new System.Drawing.Point(341, 11);
            this.TextoLogin.Name = "TextoLogin";
            this.TextoLogin.Size = new System.Drawing.Size(679, 42);
            this.TextoLogin.TabIndex = 23;
            this.TextoLogin.Text = "SISTEMA CONTROL DE PESAJE GEWICHT";
            // 
            // gBox0
            // 
            this.gBox0.Controls.Add(this.maskedTextBox1);
            this.gBox0.Controls.Add(this.txtPeso);
            this.gBox0.Location = new System.Drawing.Point(10, 47);
            this.gBox0.Name = "gBox0";
            this.gBox0.Size = new System.Drawing.Size(443, 114);
            this.gBox0.TabIndex = 17;
            this.gBox0.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Black;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBox1.Font = new System.Drawing.Font("Elephant", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(306, 16);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(126, 78);
            this.maskedTextBox1.TabIndex = 54;
            this.maskedTextBox1.Text = "KG";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(1112, 547);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(123, 38);
            this.BtnSalir.TabIndex = 24;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick_1);
            // 
            // labelfecha
            // 
            this.labelfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelfecha.AutoSize = true;
            this.labelfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecha.ForeColor = System.Drawing.Color.Black;
            this.labelfecha.Location = new System.Drawing.Point(464, 553);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(46, 13);
            this.labelfecha.TabIndex = 25;
            this.labelfecha.Text = "Fecha:";
            // 
            // labelhora
            // 
            this.labelhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelhora.AutoSize = true;
            this.labelhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhora.ForeColor = System.Drawing.Color.Black;
            this.labelhora.Location = new System.Drawing.Point(751, 553);
            this.labelhora.Name = "labelhora";
            this.labelhora.Size = new System.Drawing.Size(64, 16);
            this.labelhora.TabIndex = 26;
            this.labelhora.Text = "00:00:00";
            // 
            // timerPeso
            // 
            this.timerPeso.Enabled = true;
            this.timerPeso.Interval = 2000;
            this.timerPeso.Tick += new System.EventHandler(this.TimerPeso_Tick);
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.Black;
            this.lblUsers.Location = new System.Drawing.Point(915, 553);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(22, 16);
            this.lblUsers.TabIndex = 27;
            this.lblUsers.Text = "xx";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(710, 553);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "Hora:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1262, 590);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.labelhora);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.gBox0);
            this.Controls.Add(this.TextoLogin);
            this.Controls.Add(this.MinimizarLogin);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.ImgWillard);
            this.Controls.Add(this.CerrarLogin);
            this.Controls.Add(this.gBox2);
            this.Controls.Add(this.gBox3);
            this.Controls.Add(this.gBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gewicht";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.gBox3.ResumeLayout(false);
            this.gBox3.PerformLayout();
            this.gBox2.ResumeLayout(false);
            this.gBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWillard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarLogin)).EndInit();
            this.gBox0.ResumeLayout(false);
            this.gBox0.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblestado;
        internal System.Windows.Forms.Button Btnconectar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gBox1;
        private System.Windows.Forms.GroupBox gBox3;
        private System.Windows.Forms.GroupBox gBox2;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ImgWillard;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox MinimizarLogin;
        private System.Windows.Forms.PictureBox CerrarLogin;
        private System.Windows.Forms.Label TextoLogin;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox CmbItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBox0;
        internal System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label labelhora;
        public System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timerPeso;
        public System.Windows.Forms.ComboBox cmbBascula;
        public System.Windows.Forms.ComboBox cmbProcess;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtDocRef;
        public System.Windows.Forms.ComboBox cmbPresent;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbRefIbes;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label lblUsers;
        internal System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtSubcadena;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.TextBox txtBitPara;
        public System.Windows.Forms.TextBox txtBitCaract;
        public System.Windows.Forms.TextBox txtParid;
        public System.Windows.Forms.TextBox txtBaudios;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

