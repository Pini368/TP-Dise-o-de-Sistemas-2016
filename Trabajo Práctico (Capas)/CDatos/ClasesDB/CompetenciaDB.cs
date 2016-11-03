using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDatos.ClasesDB
{
    public class CompetenciaDB
    {
        SqlConnection conn;
        SqlDataAdapter da;
        Conexion cn = new Conexion();
        public DataSet getCompetencias()
        {
            conn = cn.conectar();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "spObtenerNombreTodasCompetencias";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Competencias");

                conn.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "spObtenerNombreTodasCompetencias";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Competencias");

                    conn.Dispose();
                    conn.Close();
                }
                catch (Exception ex1)
                {
                    throw new ExceptionPersonalizada(ex1.ToString());
                }
            }
            return ds;
        }
    }
}
