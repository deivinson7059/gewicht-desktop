using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Data.DB2;
using System.Windows.Forms;
using Gewicht;
using System.Data.SqlClient;

namespace BalanzaW
{
    public class Conexion
    {
        public DB2Connection _conexion;
        public DB2Command _comando;

        

        public static string server="";
        public static string port = "";
        public static string database = "";
        public static string uid = "";
        public static string pwd = "";
        public Conexion()
        {

            ConexionLocal conexionLocal = new ConexionLocal();
            SqlDataReader datos;

            string select = string.Format("SELECT * FROM dbo.config WHERE Id=1");


            conexionLocal._comandoLocal = new SqlCommand(select, conexionLocal._conexionLocal);
            conexionLocal.AbrirConLocal();
            datos = conexionLocal._comandoLocal.ExecuteReader();

            if (datos.Read())
            {

                server = datos.GetString(1);
                port = datos.GetString(2);
                database = datos.GetString(3);
                uid = datos.GetString(4);
                pwd = datos.GetString(5);

            }
            else
            {
                server = "";
                port = "";
                database = "";
                uid = "";
                pwd = "";
            }


            _conexion = new DB2Connection("Server="+ server + ":"+ port + ";Database="+ database + ";UID="+ uid+";PWD="+ pwd+" ");

        }

        public bool AbrirConexion()
        {

            try
            {
                _conexion.Open();
                return true;

            }

            catch (DB2Exception exeption)
            {
                return false;
                throw exeption;
            }

        }

        public bool CerrarConexion()
        {
            try
            {
                _conexion.Close();
                return true;

            }

            catch (DB2Exception exeption)
            {
                return false;
                throw exeption;
            }
        }

        public void executeDb2Query(string query)
        {
            try
            {
                _conexion.Open();
                _comando = new DB2Command(query, _conexion);



                if (_comando.ExecuteNonQuery() == 1)

                {
                    MessageBox.Show("Query ejecutado con exito");

                }
                else
                {

                    MessageBox.Show("Query  no ejecutado ");

                }

            }

            catch (DB2Exception exeption)
            {
                MessageBox.Show(exeption.Message);


            }

            finally
            {

                _conexion.Close();


            }
        }
    }
}
