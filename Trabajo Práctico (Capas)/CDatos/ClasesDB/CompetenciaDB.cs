using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades.Entidades;

namespace CDatos.ClasesDB
{
    public class CompetenciaDB
    {
        SqlConnection conn;
        SqlDataAdapter da;
        Conexion cn = new Conexion();


        public Competencia getCompetencias(int idComp)
        {
            DataSet ds = new DataSet();
            Competencia comp = new Competencia();
            conn = cn.obtenerConexion();
            try
            {
                cn.conectar(conn);
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "spObtenerCompetenciaID";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIDCompetencia = new SqlParameter();
                parIDCompetencia.ParameterName = "@idComp";
                parIDCompetencia.SqlDbType = SqlDbType.Int;
                parIDCompetencia.Value = idComp;

                cmd.Parameters.Add(parIDCompetencia);

                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter(cmd);

                da.Fill(ds, "PuntajeRequerido");

                DataTable dt = ds.Tables[0];

                comp.Codigo = idComp;
                comp.Nombre = (dt.AsEnumerable().Select(x => x[0].ToString()).ToList())[0];
                comp.Descripcion = (dt.AsEnumerable().Select(x => x[1].ToString()).ToList())[0];
                comp.Estado = (dt.AsEnumerable().Select(x => x[2].ToString()).ToList())[0];
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
            return comp;
        }

        public DataSet getCompetencias()
        {
            DataSet ds = new DataSet();
            conn = cn.obtenerConexion();
            try
            {
                cn.conectar(conn);

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "spObtenerTodasCompetencias";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                da = new SqlDataAdapter(cmd);

                da.Fill(ds, "Competencias");

                conn.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
            return ds;
        }
    }
}
