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
            this.MinimizarLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarLogin
            // 
            this.CerrarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("CerrarLogin.Image")));
            this.CerrarLogin.Location = new System.Drawing.Point(681, 12);
            this.CerrarLogin.Name = "CerrarLogin";
            this.CerrarLogin.Size = new System.Drawing.Size(15, 15);
            this.CerrarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarLogin.TabIndex = 14;
            this.CerrarLogin.TabStop = false;
            // 
            // MinimizarLogin
            // 
            this.MinimizarLogin.BackColor = System.Drawing.Color.Blue;
            this.MinimizarLogin.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarLogin.Image")));
            this.MinimizarLogin.Location = new System.Drawing.Point(649, 12);
            this.MinimizarLogin.Name = "MinimizarLogin";
            this.MinimizarLogin.Size = new System.Drawing.Size(15, 15);
            this.MinimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizarLogin.TabIndex = 15;
            this.MinimizarLogin.TabStop = false;
            this.MinimizarLogin.Click += new System.EventHandler(this.MinimizarEditar_Click);
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(734, 334);
            this.Controls.Add(this.MinimizarLogin);
            this.Controls.Add(this.CerrarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditar";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CerrarLogin;
        private System.Windows.Forms.PictureBox MinimizarLogin;
    }
}