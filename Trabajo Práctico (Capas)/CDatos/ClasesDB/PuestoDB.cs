using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CEntidades;
using System.Data.Entity.Core.Objects;

namespace CDatos.ClasesDB
{
    public class PuestoDB
    {
        SqlConnection conn;
        SqlDataAdapter da;
        Conexion cn = new Conexion();

        public List<Caracteristica> obtenerCaracteristicasPuesto(int codigoPuesto, string nombrePuesto)
        {
            List <Caracteristica> lc = new List <Caracteristica>();
            conn = cn.obtenerConexion();
            try
            {
                int idPuesto = obtenerUltimoPuesto(codigoPuesto, nombrePuesto);

                if(idPuesto == -1)
                {
                    throw new ExceptionPersonalizada("No existe ningun puesto con ese codigo y nombre.");
                }


                ObjectResult<spObtenerPuntajesRequeridos_Result> rdo;
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    rdo = db.spObtenerPuntajesRequeridos(idPuesto);
                    var rdoLs = rdo.ToList();
                    List<int> listaIDCompetencia = rdoLs.Select(x => x.codigo_competencia).ToList();

                    List<int> listaPonderacion = rdoLs.AsEnumerable().Select(x => x.ponderacion).ToList();

                    for (int i = 0; i < listaIDCompetencia.Count; i++)
                    {
                        Caracteristica c = new Caracteristica();
                        c.Ponderacion = listaPonderacion[i];
                        CompetenciaDB compdb = new CompetenciaDB();
                        c.Competencia = compdb.getCompetencias(listaIDCompetencia[i]);
                        lc.Add(c);
                    }
                }
                return lc;
            }
            catch (Exception ex)
            {
                conn.Dispose();
                conn.Close();
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        private int obtenerUltimoPuesto(int codigo, string nombre)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    ObjectParameter parIDPuesto = new ObjectParameter("idPuesto", typeof(Int32));
                    var results = db.spObtenerUltimoIDPuestoCN(parIDPuesto, codigo, nombre);
                    if (parIDPuesto.Value.ToString() == "")
                    {
                        return -1;
                    }
                    else
                    {
                        return (int)parIDPuesto.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        private int obtenerCantidadPuestos(int codigo, string nombre)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    ObjectParameter parCantPuestos = new ObjectParameter("cantPuestos", typeof(Int32));
                    var results = db.spObtenerCantPuestosCodigoNombre(parCantPuestos, codigo, nombre);
                    return (int)parCantPuestos.Value;
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        private int insertarPuesto(Puesto puesto)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    ObjectParameter parIDPuesto = new ObjectParameter("idPuesto", typeof(Int32));
                    var results = db.spInsertarPuesto(parIDPuesto, puesto.codigo_puesto, puesto.nombre, puesto.descripcion, puesto.empresa);
                    return (int)parIDPuesto.Value;
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        private void insertarCaracteristica(int idPuesto, int idCompetencia, int ponderacion)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    db.spInsertarPuntajeRequerido(idPuesto, idCompetencia, ponderacion);
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public void alta(Puesto puesto, List<Caracteristica> lc)
        {
            try
            {
                int cantPuestos = obtenerCantidadPuestos(puesto.codigo_puesto, puesto.nombre);

                if (cantPuestos == 0)
                {
                    int idPuesto = insertarPuesto(puesto);

                    for (int i = 0; i < lc.Count; i++)
                    {
                        insertarCaracteristica(idPuesto, lc[i].Competencia.id_competencia, lc[i].Ponderacion);
                    }
                }
                else
                {
                    throw new ExceptionPersonalizada("Error, el puesto ya existe en la base de datos.");
                }
            }
            catch(Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
