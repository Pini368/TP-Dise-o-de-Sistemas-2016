using CDatos.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CDatos
{
    public class Conexion {
        public SqlConnection conectar()
        {
            SqlConnection sqlconnection = new SqlConnection(CDatos.Properties.Settings.Default.Conexion);
            return sqlconnection;
        }

        /*
            CLogica.Conexion cn = new CLogica.Conexion();
            SqlConnection conn = cn.conectar();
            try
            {
                conn.Open();
                MessageBox.Show("Conecto");
                conn.Dispose();
                conn.Close();
            }
            catch(Exception ex)
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Conecto");
                    conn.Dispose();
                    conn.Close();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Ha ocurrido un problema:\n" + ex1);
                }
            }
        */
    }
}
