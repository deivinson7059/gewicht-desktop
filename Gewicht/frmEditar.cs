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
        readonly public Conexion  conexion  = new Conexion();
        public frmEditar()
        {
            InitializeComponent();
        } 


        private void MinimizarEditar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void CerrarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Desea Eliminar el Registro", "Gewicht", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {

               

                try {

                    string IdReg = txtIdReg.Text.Trim();
                    string Conc = txtConc.Text.Trim();
                    string CodIbes = txtCodIbes.Text.Trim();


                    DB2DataReader verificar;
                    DB2DataReader sup;

                    string select = string.Format("SELECT ID_REGISTRO,CONSEC,COALESCE(REG_TABLE,-1) AS REG_TABLE,ANULADO FROM PROD.GEW_BASCULA_DATOS WHERE ID_REGISTRO= '{0}' AND CONSEC='{1}'", IdReg, Conc);


                    conexion._comando = new DB2Command(select, conexion._conexion);
                    conexion.AbrirConexion();
                    verificar = conexion._comando.ExecuteReader();
                    if (verificar.Read())
                    {

                        string id_reg = verificar.GetString(0);
                        string id_consc = verificar.GetString(1);
                        int reg_table=int.Parse(verificar.GetString(2));
                        int anu = int.Parse(verificar.GetString(3));

                        if (reg_table > -1)
                        {
                            MessageBox.Show("El registro ha sido usuado en produccion, no se puede eliminar", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            int Cant = 100;
                            FrmPrincipal.CargaDatosR(Cant);
                            this.Close();
                        }
                        else if (anu > 0)
                        {
                            MessageBox.Show("El registro ya ha sido eliminado", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            int Cant = 100;
                            FrmPrincipal.CargaDatosR(Cant);
                            this.Close();
                        }
                        else
                        {
                            string SQL = string.Format("UPDATE PROD.GEW_BASCULA_DATOS SET ANULADO = '1' ,FECH_ANULADO=CURRENT_TIMESTAMP  WHERE ID_REGISTRO = '{0}' AND CONSEC = '{1}' AND COD_IBES = '{2}';", IdReg, Conc, CodIbes);

                            conexion._comando = new DB2Command(SQL, conexion._conexion);
                            sup = conexion._comando.ExecuteReader();
                            MessageBox.Show("Registro eliminado con exito.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            int Cant = 100;
                            FrmPrincipal.CargaDatosR(Cant);
                            this.Close();

                        }

                    }
                    else
                    {

                        MessageBox.Show("Ocurrio un error y no se pudo eliminar el registro.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        int Cant = 100;
                        FrmPrincipal.CargaDatosR(Cant);
                        this.Close();
                    }
                 

                } catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error y no se pudo eliminar el registro.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.Write(ex);
                }             

                conexion.CerrarConexion();
               
            }
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void GetIdReg(string idReg, string idconc)
        {
            DB2DataReader verificar;
            string select = string.Format("SELECT * FROM PROD.GEW_BASCULA_DATOS WHERE ID_REGISTRO= '{0}' AND CONSEC='{1}'", idReg, idconc);

            try
            {
              

                conexion._comando = new DB2Command(select, conexion._conexion);
                conexion.AbrirConexion();
                verificar = conexion._comando.ExecuteReader();
                if (verificar.Read())
                {

                    txtIdReg.Text = verificar.GetString(0);
                    txtConc.Text = verificar.GetString(1);
                    txtCodIbes.Text = verificar.GetString(2);
                    txtDecrip.Text = verificar.GetString(3);
                    txtBascula.Text = verificar.GetString(6);
                    txtProcess.Text = verificar.GetString(8);
                    txtPresent.Text = verificar.GetString(9);
                    txtFecha.Text = verificar.GetString(10) + ' ' + verificar.GetString(11);

                }
                else
                {
                   
                    MessageBox.Show("El Registro no fue encontrado.", "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString(), "Gewicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
    }
}
