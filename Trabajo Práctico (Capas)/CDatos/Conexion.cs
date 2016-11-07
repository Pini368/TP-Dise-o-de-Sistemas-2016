using CDatos.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CDatos
{
    public class Conexion {
        public SqlConnection obtenerConexion()
        {
            SqlConnection sqlconnection = new SqlConnection(CDatos.Properties.Settings.Default.Conexion);
            return sqlconnection;
        }

        public void conectar(SqlConnection conn)
        {
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex1)
                {
                    throw new ExceptionPersonalizada(ex1.Message);
                }
            }
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
