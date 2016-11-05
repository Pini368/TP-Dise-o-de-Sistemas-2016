using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CDatos.ClasesDB
{
    public class PuestoDB
    {
        SqlConnection conn;
        SqlDataAdapter da;
        Conexion cn = new Conexion();

        private int obtenerUltimoPuesto(int codigo, string nombre)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spObtenerUltimoIDPuestoCN";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIDPuesto = new SqlParameter();
            parIDPuesto.ParameterName = "@idPuesto";
            parIDPuesto.SqlDbType = SqlDbType.Int;
            parIDPuesto.Direction = ParameterDirection.Output;

            SqlParameter parCodPuesto = new SqlParameter();
            parCodPuesto.ParameterName = "@codigoPuesto";
            parCodPuesto.SqlDbType = SqlDbType.Int;
            parCodPuesto.Value = codigo;


            SqlParameter parNom = new SqlParameter();
            parNom.ParameterName = "@nombre";
            parNom.SqlDbType = SqlDbType.VarChar;
            parNom.Size = 20;
            parNom.Value = nombre;

            cmd.Parameters.Add(parIDPuesto);
            cmd.Parameters.Add(parCodPuesto);
            cmd.Parameters.Add(parNom);

            cmd.ExecuteNonQuery();

            return (int)parIDPuesto.Value;
        }

        private int obtenerCantidadPuestos(int codigo, string nombre)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spObtenerCantPuestosCodigoNombre";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parCantPuestos = new SqlParameter();
            parCantPuestos.ParameterName = "@cantPuestos";
            parCantPuestos.SqlDbType = SqlDbType.Int;
            parCantPuestos.Direction = ParameterDirection.Output;

            SqlParameter parCodPuesto = new SqlParameter();
            parCodPuesto.ParameterName = "@codigoPuesto";
            parCodPuesto.SqlDbType = SqlDbType.Int;
            parCodPuesto.Value = codigo;


            SqlParameter parNom = new SqlParameter();
            parNom.ParameterName = "@nombre";
            parNom.SqlDbType = SqlDbType.VarChar;
            parNom.Size = 20;
            parNom.Value = nombre;

            cmd.Parameters.Add(parCantPuestos);
            cmd.Parameters.Add(parCodPuesto);
            cmd.Parameters.Add(parNom);

            cmd.ExecuteNonQuery();

            return (int)parCantPuestos.Value;
        }

        private int insertarPuesto(Puesto puesto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spInsertarPuesto";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIDPuesto = new SqlParameter();
            parIDPuesto.ParameterName = "@idPuesto";
            parIDPuesto.SqlDbType = SqlDbType.Int;
            parIDPuesto.Direction = ParameterDirection.Output;

            SqlParameter parCodigoPuesto = new SqlParameter();
            parCodigoPuesto.ParameterName = "@codigoPuesto";
            parCodigoPuesto.SqlDbType = SqlDbType.Int;
            parCodigoPuesto.Value = puesto.Codigo;


            SqlParameter parNombre = new SqlParameter();
            parNombre.ParameterName = "@nombre";
            parNombre.SqlDbType = SqlDbType.VarChar;
            parNombre.Size = 20;
            parNombre.Value = puesto.Nombre;

            SqlParameter parDescripcion = new SqlParameter();
            parDescripcion.ParameterName = "@descripcion";
            parDescripcion.SqlDbType = SqlDbType.Text;
            parDescripcion.Value = puesto.Descripcion;

            SqlParameter parEmpresa = new SqlParameter();
            parEmpresa.ParameterName = "@empresa";
            parEmpresa.SqlDbType = SqlDbType.VarChar;
            parEmpresa.Size = 50;
            parEmpresa.Value = puesto.Empresa;

            cmd.Parameters.Add(parIDPuesto);
            cmd.Parameters.Add(parCodigoPuesto);
            cmd.Parameters.Add(parNombre);
            cmd.Parameters.Add(parDescripcion);
            cmd.Parameters.Add(parEmpresa);

            cmd.ExecuteNonQuery();

            return (int)parIDPuesto.Value;
        }

        private void insertarCaracteristica(int idPuesto, int idCompetencia, int ponderacion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "spInsertarPuntajeRequerido";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPuesto = new SqlParameter();
            parIdPuesto.ParameterName = "@idPuesto";
            parIdPuesto.SqlDbType = SqlDbType.Int;
            parIdPuesto.Value = idPuesto;

            SqlParameter parCodigoCompetencia = new SqlParameter();
            SqlParameter parPonderacion = new SqlParameter();

            parCodigoCompetencia.ParameterName = "@codigoCompetencia";
            parCodigoCompetencia.SqlDbType = SqlDbType.Int;
            parCodigoCompetencia.Value = idCompetencia;

            parPonderacion.ParameterName = "@ponderacion";
            parPonderacion.SqlDbType = SqlDbType.Int;
            parPonderacion.Value = ponderacion;

            cmd.Parameters.Add(parIdPuesto);
            cmd.Parameters.Add(parCodigoCompetencia);
            cmd.Parameters.Add(parPonderacion);

            cmd.ExecuteNonQuery();
        }

        public void alta(Puesto puesto)
        {
            conn = cn.conectar();
            try
            {
                conn.Open();

                int cantPuestos = obtenerCantidadPuestos(puesto.Codigo, puesto.Nombre);

                if(cantPuestos == 0)
                {
                    int idPuesto = insertarPuesto(puesto);

                    for (int i = 0; i < puesto.Caracteristicas.Count; i++)
                    {
                        insertarCaracteristica(idPuesto, puesto.Caracteristicas[i].Competencia.Codigo, puesto.Caracteristicas[i].Ponderacion);
                    }
                    conn.Dispose();
                    conn.Close();
                }
                else
                {
                    conn.Dispose();
                    conn.Close();
                    throw new ExceptionPersonalizada("Error, el puesto ya existe en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                conn.Dispose();
                conn.Close();
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
