using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Data.DB2;
using System.Windows.Forms;

namespace BalanzaW
{
    public class Conexion
    {
        public DB2Connection _conexion;
        public DB2Command _comando;
        public Conexion()
        {
            _conexion = new DB2Connection("Server=192.168.40.4:50000;Database=WLRDB091;UID=sistemas;PWD=willard1505");

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
