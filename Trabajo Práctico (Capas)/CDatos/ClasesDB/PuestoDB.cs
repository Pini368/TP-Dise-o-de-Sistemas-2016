using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CEntidades;
using System.Data.Entity.Core.Objects;
using CDatos.ClasesDAO;

namespace CDatos.ClasesDB
{
    public class PuestoDB : PuestoDAO
    {

        public List<Puesto> getPuestos(Puesto pues)
        {
            using (TPDiseñoEntities db = new TPDiseñoEntities())
            {
                List<Puesto> lp = new List<Puesto>();
                if (pues.id_puesto != -1)
                {
                    lp = db.Puesto.Where(pu => pu.id_puesto == pues.id_puesto && pu.id_consultor == null && pu.fecha_ultima_modificacion == db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa  && pues1.id_consultor == null).Max(pues2 => pues2.fecha_ultima_modificacion)).ToList();
                }
                else
                {
                    if (pues.nombre == "")
                    {
                        if (pues.empresa == "")
                        {
                            if (pues.codigo_puesto == -1)
                            {
                                lp = db.Puesto.Where(pu => pu.id_consultor == null && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value).ToList();
                            }
                            else
                            {
                                lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.codigo_puesto == pues.codigo_puesto && pues.id_consultor == null && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value).ToList();
                            }
                        }
                        else
                        {
                            if (pues.codigo_puesto == -1)
                            {
                                lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.empresa == pues.empresa && pues.id_consultor == null && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value).ToList();
                            }
                            else
                            {
                                lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.empresa == pues.empresa && pu.codigo_puesto == pues.codigo_puesto && pues.id_consultor == null && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value).ToList();
                            }
                        }
                    }
                    else
                    {
                        if (pues.empresa == "")
                        {
                            if (pues.codigo_puesto == -1)
                            {
                                lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.nombre == pues.nombre && pues.id_consultor == null && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value).ToList();
                            }
                            else
                            {
                                lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.nombre == pues.nombre && pu.codigo_puesto == pues.codigo_puesto && pues.id_consultor == null && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value).ToList();
                            }
                        }
                        else
                        {
                            if (pues.codigo_puesto == -1)
                            {
                                lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.nombre == pues.nombre && pu.empresa == pues.empresa && pues.id_consultor == null && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value).ToList();
                            }
                            else
                            {
                                lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.nombre == pues.nombre && pu.empresa == pues.empresa && pu.codigo_puesto == pues.codigo_puesto && pues.id_consultor == null && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value).ToList();
                            }
                        }
                    }
                }
                return lp;
            }
        }

        public int obtenerUltimoIDPuesto(int codigo, string nombre)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.spObtenerUltimoIDPuestoCN(codigo, nombre).FirstOrDefault().Value;
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        private int obtenerCantidadPuestos(int codigo, string nombre, string empresa)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return (from pu in db.Puesto where ((pu.codigo_puesto == codigo || pu.nombre == nombre) && pu.empresa == empresa && pu.fecha_eliminado == null) select pu).ToList().Count();
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
      
        public void alta(Puesto puesto)
        {
            try
            {
                int cantPuestos = obtenerCantidadPuestos(puesto.codigo_puesto, puesto.nombre, puesto.empresa);

                if (cantPuestos == 0)
                {
                    using (TPDiseñoEntities db = new TPDiseñoEntities())
                    {
                        db.Puesto.Add(puesto);
                        db.SaveChanges();
                    }
                }
                else
                {
                    throw new ExceptionPersonalizada("Error, el puesto ya existe en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
        public void baja(Puesto puesto, Consultor consultorActual)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    Puesto p = (from pu in db.Puesto where (pu.id_puesto == puesto.id_puesto && pu.fecha_eliminado == null) select pu).FirstOrDefault();
                    p.fecha_eliminado = DateTime.Now;
                    p.fecha_ultima_modificacion = DateTime.Now;
                    p.estado = "NoActivo";
                    p.id_consultor = consultorActual.nombreUsuario;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
        public void modificar(Puesto puesto)
        {
             try
            {
                
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    puesto.fecha_ultima_modificacion = DateTime.Now;
                    db.Puesto.Add(puesto);
                    db.SaveChanges();
                }
                
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
