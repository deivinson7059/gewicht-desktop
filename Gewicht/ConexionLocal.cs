using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BalanzaW
{
    class ConexionLocal
    {
        public SqlConnection _conexionLocal;
        public SqlCommand _comandoLocal;
        public ConexionLocal()
        {
            _conexionLocal = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ConfigDb.mdf; Integrated Security = True");

        }

        public bool AbrirConLocal()
        {

            try
            {
                _conexionLocal.Open();
                return true;

            }

            catch (Exception exeption)
            {
                return false;
                throw exeption;
            }

        }

        public bool CerrarConLocal()
        {
            try
            {
                _conexionLocal.Close();
                return true;

            }

            catch (Exception exeption)
            {
                return false;
                throw exeption;
            }
        }

        public void executeQueryLocal(string query)
        {
            try
            {
                _conexionLocal.Open();
                _comandoLocal = new SqlCommand(query, _conexionLocal);

                if (_comandoLocal.ExecuteNonQuery() == 1)

                {
                    MessageBox.Show("Query ejecutado con exito");
                }
                else
                {
                  MessageBox.Show("Query  no ejecutado ");
                }

            }

            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            finally
            {
                _conexionLocal.Close();

            }
        }

    }
}
