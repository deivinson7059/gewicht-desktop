namespace BalanzaW
{
    partial class frmEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar));
            this.CerrarLogin = new System.Windows.Forms.PictureBox();
            this.txtIdReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConc = new System.Windows.Forms.TextBox();
            this.txtCodIbes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDecrip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBascula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPresent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarLogin
            // 
            this.CerrarLogin.BackColor = System.Drawing.Color.Transparent;
            this.CerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("CerrarLogin.Image")));
            this.CerrarLogin.Location = new System.Drawing.Point(765, 12);
            this.CerrarLogin.Name = "CerrarLogin";
            this.CerrarLogin.Size = new System.Drawing.Size(46, 42);
            this.CerrarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarLogin.TabIndex = 14;
            this.CerrarLogin.TabStop = false;
            this.CerrarLogin.Click += new System.EventHandler(this.CerrarLogin_Click);
            // 
            // txtIdReg
            // 
            this.txtIdReg.Enabled = false;
            this.txtIdReg.Location = new System.Drawing.Point(29, 78);
            this.txtIdReg.Name = "txtIdReg";
            this.txtIdReg.ReadOnly = true;
            this.txtIdReg.Size = new System.Drawing.Size(140, 20);
            this.txtIdReg.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "ELIMINAR REGISTRO BASCULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id Registro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Concecutivo:";
            // 
            // txtConc
            // 
            this.txtConc.Enabled = false;
            this.txtConc.Location = new System.Drawing.Point(175, 78);
            this.txtConc.Name = "txtConc";
            this.txtConc.ReadOnly = true;
            this.txtConc.Size = new System.Drawing.Size(146, 20);
            this.txtConc.TabIndex = 23;
            // 
            // txtCodIbes
            // 
            this.txtCodIbes.Enabled = false;
            this.txtCodIbes.Location = new System.Drawing.Point(327, 78);
            this.txtCodIbes.Name = "txtCodIbes";
            this.txtCodIbes.ReadOnly = true;
            this.txtCodIbes.Size = new System.Drawing.Size(154, 20);
            this.txtCodIbes.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Codigo IBES:";
            // 
            // txtDecrip
            // 
            this.txtDecrip.Enabled = false;
            this.txtDecrip.Location = new System.Drawing.Point(487, 78);
            this.txtDecrip.Name = "txtDecrip";
            this.txtDecrip.ReadOnly = true;
            this.txtDecrip.Size = new System.Drawing.Size(324, 20);
            this.txtDecrip.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Descripcion IBES:";
            // 
            // txtBascula
            // 
            this.txtBascula.Enabled = false;
            this.txtBascula.Location = new System.Drawing.Point(29, 134);
            this.txtBascula.Name = "txtBascula";
            this.txtBascula.ReadOnly = true;
            this.txtBascula.Size = new System.Drawing.Size(292, 20);
            this.txtBascula.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bascula:";
            // 
            // txtProcess
            // 
            this.txtProcess.Enabled = false;
            this.txtProcess.Location = new System.Drawing.Point(327, 134);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.ReadOnly = true;
            this.txtProcess.Size = new System.Drawing.Size(321, 20);
            this.txtProcess.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Proceso:";
            // 
            // txtPresent
            // 
            this.txtPresent.Enabled = false;
            this.txtPresent.Location = new System.Drawing.Point(654, 134);
            this.txtPresent.Name = "txtPresent";
            this.txtPresent.ReadOnly = true;
            this.txtPresent.Size = new System.Drawing.Size(157, 20);
            this.txtPresent.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Presentacion:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDelete.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(573, 182);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(206, 45);
            this.BtnDelete.TabIndex = 34;
            this.BtnDelete.Text = "ELIMINAR";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Blue;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(336, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(206, 45);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(29, 182);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(264, 20);
            this.txtFecha.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Fecha y Hora de Registro:";
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(823, 252);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.txtPresent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBascula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDecrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodIbes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdReg);
            this.Controls.Add(this.CerrarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditar";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Registro";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CerrarLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIdReg;
        public System.Windows.Forms.TextBox txtConc;
        public System.Windows.Forms.TextBox txtCodIbes;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDecrip;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtBascula;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPresent;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label9;
    }
}