using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BalanzaW
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {

            ConexionLocal conexionLocal = new ConexionLocal();
            SqlDataReader datos;

            string select = string.Format("SELECT * FROM dbo.config WHERE Id=1");


            conexionLocal._comandoLocal = new SqlCommand(select, conexionLocal._conexionLocal);
            conexionLocal.AbrirConLocal();
            datos = conexionLocal._comandoLocal.ExecuteReader();

            if (datos.Read())
            {

                txtServer.Text = datos.GetString(1);
                txtport.Text = datos.GetString(2);
                txtDb.Text = datos.GetString(3);
                txtUser.Text = datos.GetString(4);
                txtPass.Text = datos.GetString(5);

                

            }
            else
            {
                txtServer.Text = "";
                txtport.Text = "";
                txtDb.Text = "";
                txtUser.Text = "";
                txtPass.Text = "";
            }
            conexionLocal.CerrarConLocal();
            BtnUpdate.Focus();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            

            DialogResult Result = MessageBox.Show("Desea actualizar el Registro", "Gewicht", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ConexionLocal conexionLocal = new ConexionLocal();
            conexionLocal.AbrirConLocal();
            if (Result == DialogResult.Yes)
            {


                try
                {

                    string QUERY = "UPDATE dbo.config SET Server_Name = @Server_Name, Server_Port = @Server_Port, Data_base = @Data_base, Uid_user = @Uid_user, Pwd_user = @Pwd_user WHERE Id=@Id";

                    
                    conexionLocal._comandoLocal = new SqlCommand(QUERY, conexionLocal._conexionLocal);

                    conexionLocal._comandoLocal.Parameters.AddWithValue("@Id",1);
                    conexionLocal._comandoLocal.Parameters.AddWithValue("@Server_Name", txtServer.Text);
                    conexionLocal._comandoLocal.Parameters.AddWithValue("@Server_Port", txtport.Text);
                    conexionLocal._comandoLocal.Parameters.AddWithValue("@Data_base", txtDb.Text);
                    conexionLocal._comandoLocal.Parameters.AddWithValue("@Uid_user", txtUser.Text);
                    conexionLocal._comandoLocal.Parameters.AddWithValue("@Pwd_user", txtPass.Text);

                  
                   
                    conexionLocal._comandoLocal.ExecuteNonQuery();

                    MessageBox.Show("Registro actualizado con exito.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Information);                


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error y no se pudo actualizar el registro.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.ToString());
                    Console.Write(ex);
                }

                conexionLocal.CerrarConLocal();

            }


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frm = new FrmPrincipal();
            
            frm.Show();
           

        }

        private void CerrarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frm = new FrmPrincipal();

            frm.Show();
        }

        private void MinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
