namespace BalanzaW
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblestado = new System.Windows.Forms.Label();
            this.Btnconectar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CmbItems = new System.Windows.Forms.ComboBox();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gBox3 = new System.Windows.Forms.GroupBox();
            this.txtSecc = new System.Windows.Forms.TextBox();
            this.txtCCoper = new System.Windows.Forms.TextBox();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOper = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.gBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ImgWillard = new System.Windows.Forms.PictureBox();
            this.MinimizarLogin = new System.Windows.Forms.PictureBox();
            this.CerrarLogin = new System.Windows.Forms.PictureBox();
            this.TextoLogin = new System.Windows.Forms.Label();
            this.gBox0 = new System.Windows.Forms.GroupBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gBox4 = new System.Windows.Forms.GroupBox();
            this.TxtSeccR = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtPesoR = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TextOperR = new System.Windows.Forms.TextBox();
            this.TxtHoraR = new System.Windows.Forms.TextBox();
            this.TxtTurnR = new System.Windows.Forms.TextBox();
            this.TxtFechR = new System.Windows.Forms.TextBox();
            this.TxtIdR = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.labelfecha = new System.Windows.Forms.Label();
            this.labelhora = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.gBox3.SuspendLayout();
            this.gBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWillard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarLogin)).BeginInit();
            this.gBox0.SuspendLayout();
            this.gBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(66, 72);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(107, 16);
            this.lblestado.TabIndex = 13;
            this.lblestado.Text = "DESCONECTADO";
            // 
            // Btnconectar
            // 
            this.Btnconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnconectar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnconectar.ForeColor = System.Drawing.Color.White;
            this.Btnconectar.Location = new System.Drawing.Point(147, 16);
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
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // gBox1
            // 
            this.gBox1.Controls.Add(this.label17);
            this.gBox1.Controls.Add(this.CmbItems);
            this.gBox1.Controls.Add(this.DgvDatos);
            this.gBox1.Controls.Add(this.label1);
            this.gBox1.Location = new System.Drawing.Point(462, 213);
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
            this.DgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
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
            this.DgvDatos.EnableHeadersVisualStyles = false;
            this.DgvDatos.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvDatos.Location = new System.Drawing.Point(4, 35);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
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
            this.gBox3.Controls.Add(this.txtSecc);
            this.gBox3.Controls.Add(this.txtCCoper);
            this.gBox3.Controls.Add(this.txtPerfil);
            this.gBox3.Controls.Add(this.label15);
            this.gBox3.Controls.Add(this.label14);
            this.gBox3.Controls.Add(this.txtOper);
            this.gBox3.Controls.Add(this.TxtFecha);
            this.gBox3.Controls.Add(this.label7);
            this.gBox3.Controls.Add(this.label6);
            this.gBox3.Controls.Add(this.cmbTurno);
            this.gBox3.Controls.Add(this.label2);
            this.gBox3.Controls.Add(this.BtnSave);
            this.gBox3.Location = new System.Drawing.Point(461, 107);
            this.gBox3.Name = "gBox3";
            this.gBox3.Size = new System.Drawing.Size(789, 102);
            this.gBox3.TabIndex = 17;
            this.gBox3.TabStop = false;
            this.gBox3.Text = "Datos de Producción";
            // 
            // txtSecc
            // 
            this.txtSecc.Enabled = false;
            this.txtSecc.Location = new System.Drawing.Point(217, 75);
            this.txtSecc.Name = "txtSecc";
            this.txtSecc.Size = new System.Drawing.Size(194, 20);
            this.txtSecc.TabIndex = 31;
            // 
            // txtCCoper
            // 
            this.txtCCoper.Enabled = false;
            this.txtCCoper.Location = new System.Drawing.Point(416, 75);
            this.txtCCoper.Name = "txtCCoper";
            this.txtCCoper.Size = new System.Drawing.Size(208, 20);
            this.txtCCoper.TabIndex = 29;
            this.txtCCoper.Visible = false;
            // 
            // txtPerfil
            // 
            this.txtPerfil.Enabled = false;
            this.txtPerfil.Location = new System.Drawing.Point(9, 75);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(194, 20);
            this.txtPerfil.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(214, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Sección:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 26;
            this.label14.Text = "Perfil:";
            // 
            // txtOper
            // 
            this.txtOper.Enabled = false;
            this.txtOper.Location = new System.Drawing.Point(432, 35);
            this.txtOper.Name = "txtOper";
            this.txtOper.Size = new System.Drawing.Size(342, 20);
            this.txtOper.TabIndex = 25;
            // 
            // TxtFecha
            // 
            this.TxtFecha.CustomFormat = "yyyy-MM-dd";
            this.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFecha.Location = new System.Drawing.Point(6, 34);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(200, 20);
            this.TxtFecha.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Operador:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.ItemHeight = 13;
            this.cmbTurno.Location = new System.Drawing.Point(217, 35);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(208, 21);
            this.cmbTurno.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Turno:";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Green;
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(630, 63);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(153, 33);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "CAPTURAR PESO";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // gBox2
            // 
            this.gBox2.Controls.Add(this.label5);
            this.gBox2.Controls.Add(this.lblestado);
            this.gBox2.Controls.Add(this.label4);
            this.gBox2.Controls.Add(this.cmbPort);
            this.gBox2.Controls.Add(this.pictureBox1);
            this.gBox2.Controls.Add(this.label3);
            this.gBox2.Controls.Add(this.Btnconectar);
            this.gBox2.Location = new System.Drawing.Point(12, 190);
            this.gBox2.Name = "gBox2";
            this.gBox2.Size = new System.Drawing.Size(441, 101);
            this.gBox2.TabIndex = 18;
            this.gBox2.TabStop = false;
            this.gBox2.Text = "Datos del Equipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Estado: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Unidad medida: KG";
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.ItemHeight = 13;
            this.cmbPort.Location = new System.Drawing.Point(9, 35);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 21);
            this.cmbPort.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Puerto:";
            // 
            // ImgWillard
            // 
            this.ImgWillard.Image = global::Gewicht.Properties.Resources.logoW2;
            this.ImgWillard.Location = new System.Drawing.Point(918, 45);
            this.ImgWillard.Name = "ImgWillard";
            this.ImgWillard.Size = new System.Drawing.Size(327, 56);
            this.ImgWillard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgWillard.TabIndex = 21;
            this.ImgWillard.TabStop = false;
            // 
            // MinimizarLogin
            // 
            this.MinimizarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.CerrarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.TextoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextoLogin.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoLogin.ForeColor = System.Drawing.Color.White;
            this.TextoLogin.Location = new System.Drawing.Point(341, 11);
            this.TextoLogin.Name = "TextoLogin";
            this.TextoLogin.Size = new System.Drawing.Size(582, 35);
            this.TextoLogin.TabIndex = 23;
            this.TextoLogin.Text = "SISTEMA CONTROL DE PESAJE GEWICHT";
            // 
            // gBox0
            // 
            this.gBox0.Controls.Add(this.lbl_peso);
            this.gBox0.Location = new System.Drawing.Point(10, 47);
            this.gBox0.Name = "gBox0";
            this.gBox0.Size = new System.Drawing.Size(443, 143);
            this.gBox0.TabIndex = 17;
            this.gBox0.TabStop = false;
            // 
            // lbl_peso
            // 
            this.lbl_peso.BackColor = System.Drawing.Color.Black;
            this.lbl_peso.Font = new System.Drawing.Font("Elephant", 54.74999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.ForeColor = System.Drawing.Color.White;
            this.lbl_peso.Location = new System.Drawing.Point(6, 16);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(432, 110);
            this.lbl_peso.TabIndex = 0;
            this.lbl_peso.Text = "0.0";
            this.lbl_peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(1122, 463);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(123, 38);
            this.BtnSalir.TabIndex = 24;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.Red;
            this.BtnDel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.ForeColor = System.Drawing.Color.White;
            this.BtnDel.Location = new System.Drawing.Point(312, 165);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(123, 33);
            this.BtnDel.TabIndex = 25;
            this.BtnDel.Text = "Anular";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Blue;
            this.BtnPrint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(177, 165);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(123, 33);
            this.BtnPrint.TabIndex = 26;
            this.BtnPrint.Text = "Imprimir";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 14);
            this.label9.TabIndex = 25;
            this.label9.Text = "Id Reg:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "Turno:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "Hora:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(157, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 14);
            this.label12.TabIndex = 29;
            this.label12.Text = "Operador:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(157, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 14);
            this.label13.TabIndex = 30;
            this.label13.Text = "Fecha:";
            // 
            // gBox4
            // 
            this.gBox4.Controls.Add(this.TxtSeccR);
            this.gBox4.Controls.Add(this.label19);
            this.gBox4.Controls.Add(this.TxtPesoR);
            this.gBox4.Controls.Add(this.label18);
            this.gBox4.Controls.Add(this.TextOperR);
            this.gBox4.Controls.Add(this.TxtHoraR);
            this.gBox4.Controls.Add(this.TxtTurnR);
            this.gBox4.Controls.Add(this.TxtFechR);
            this.gBox4.Controls.Add(this.TxtIdR);
            this.gBox4.Controls.Add(this.label16);
            this.gBox4.Controls.Add(this.label9);
            this.gBox4.Controls.Add(this.BtnPrint);
            this.gBox4.Controls.Add(this.BtnDel);
            this.gBox4.Controls.Add(this.label12);
            this.gBox4.Controls.Add(this.label13);
            this.gBox4.Controls.Add(this.label10);
            this.gBox4.Controls.Add(this.label11);
            this.gBox4.Location = new System.Drawing.Point(12, 296);
            this.gBox4.Name = "gBox4";
            this.gBox4.Size = new System.Drawing.Size(441, 203);
            this.gBox4.TabIndex = 21;
            this.gBox4.TabStop = false;
            this.gBox4.Visible = false;
            // 
            // TxtSeccR
            // 
            this.TxtSeccR.Enabled = false;
            this.TxtSeccR.Location = new System.Drawing.Point(159, 100);
            this.TxtSeccR.Name = "TxtSeccR";
            this.TxtSeccR.Size = new System.Drawing.Size(273, 20);
            this.TxtSeccR.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(156, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 14);
            this.label19.TabIndex = 39;
            this.label19.Text = "Seccion:";
            // 
            // TxtPesoR
            // 
            this.TxtPesoR.Enabled = false;
            this.TxtPesoR.Location = new System.Drawing.Point(13, 138);
            this.TxtPesoR.Name = "TxtPesoR";
            this.TxtPesoR.Size = new System.Drawing.Size(117, 20);
            this.TxtPesoR.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 14);
            this.label18.TabIndex = 37;
            this.label18.Text = "Peso:";
            // 
            // TextOperR
            // 
            this.TextOperR.Enabled = false;
            this.TextOperR.Location = new System.Drawing.Point(159, 138);
            this.TextOperR.Name = "TextOperR";
            this.TextOperR.Size = new System.Drawing.Size(273, 20);
            this.TextOperR.TabIndex = 36;
            // 
            // TxtHoraR
            // 
            this.TxtHoraR.Enabled = false;
            this.TxtHoraR.Location = new System.Drawing.Point(13, 100);
            this.TxtHoraR.Name = "TxtHoraR";
            this.TxtHoraR.Size = new System.Drawing.Size(117, 20);
            this.TxtHoraR.TabIndex = 35;
            // 
            // TxtTurnR
            // 
            this.TxtTurnR.Enabled = false;
            this.TxtTurnR.Location = new System.Drawing.Point(299, 63);
            this.TxtTurnR.Name = "TxtTurnR";
            this.TxtTurnR.Size = new System.Drawing.Size(133, 20);
            this.TxtTurnR.TabIndex = 34;
            // 
            // TxtFechR
            // 
            this.TxtFechR.Enabled = false;
            this.TxtFechR.Location = new System.Drawing.Point(159, 59);
            this.TxtFechR.Name = "TxtFechR";
            this.TxtFechR.Size = new System.Drawing.Size(117, 20);
            this.TxtFechR.TabIndex = 33;
            // 
            // TxtIdR
            // 
            this.TxtIdR.Enabled = false;
            this.TxtIdR.Location = new System.Drawing.Point(13, 60);
            this.TxtIdR.Name = "TxtIdR";
            this.TxtIdR.Size = new System.Drawing.Size(117, 20);
            this.TxtIdR.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(135, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 19);
            this.label16.TabIndex = 28;
            this.label16.Text = "DETALLE DEL REGISTRO";
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
            this.labelfecha.ForeColor = System.Drawing.Color.White;
            this.labelfecha.Location = new System.Drawing.Point(467, 478);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(42, 13);
            this.labelfecha.TabIndex = 25;
            this.labelfecha.Text = "Fecha";
            // 
            // labelhora
            // 
            this.labelhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelhora.AutoSize = true;
            this.labelhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhora.ForeColor = System.Drawing.Color.White;
            this.labelhora.Location = new System.Drawing.Point(681, 476);
            this.labelhora.Name = "labelhora";
            this.labelhora.Size = new System.Drawing.Size(64, 16);
            this.labelhora.TabIndex = 26;
            this.labelhora.Text = "00:00:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "label8";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1262, 511);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelhora);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.gBox4);
            this.Controls.Add(this.gBox0);
            this.Controls.Add(this.TextoLogin);
            this.Controls.Add(this.MinimizarLogin);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.ImgWillard);
            this.Controls.Add(this.CerrarLogin);
            this.Controls.Add(this.gBox2);
            this.Controls.Add(this.gBox3);
            this.Controls.Add(this.gBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gewicht";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
            this.gBox4.ResumeLayout(false);
            this.gBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblestado;
        internal System.Windows.Forms.Button Btnconectar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gBox1;
        private System.Windows.Forms.GroupBox gBox3;
        private System.Windows.Forms.GroupBox gBox2;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ImgWillard;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox MinimizarLogin;
        private System.Windows.Forms.PictureBox CerrarLogin;
        private System.Windows.Forms.Label TextoLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox CmbItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBox0;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnDel;
        internal System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gBox4;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.Label labelfecha;
        public System.Windows.Forms.TextBox txtOper;
        public System.Windows.Forms.TextBox txtCCoper;
        public System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtSecc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox TextOperR;
        public System.Windows.Forms.TextBox TxtHoraR;
        public System.Windows.Forms.TextBox TxtTurnR;
        public System.Windows.Forms.TextBox TxtFechR;
        public System.Windows.Forms.TextBox TxtIdR;
        public System.Windows.Forms.TextBox TxtPesoR;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox TxtSeccR;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.ComboBox cmbTurno;
        public System.Windows.Forms.DateTimePicker TxtFecha;
        public System.Windows.Forms.Label labelhora;
        public System.Windows.Forms.Label lbl_peso;
        public System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Label label8;
    }
}

