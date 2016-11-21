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
                if (pues.nombre == "")
                {
                    if(pues.empresa == "")
                    {
                        if(pues.codigo_puesto == -1)
                        {
                            lp = db.Puesto.ToList();
                        }
                        else
                        {
                            lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.codigo_puesto == pues.codigo_puesto).ToList();
                        }
                    }
                    else
                    {
                        if (pues.codigo_puesto == -1)
                        {
                            lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.empresa == pues.empresa).ToList();
                        }
                        else
                        {
                            lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.empresa == pues.empresa && pu.codigo_puesto == pues.codigo_puesto).ToList();
                        }
                    }
                }
                else
                {
                    if (pues.empresa == "")
                    {
                        if (pues.codigo_puesto == -1)
                        {
                            lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.nombre == pues.nombre).ToList();
                        }
                        else
                        {
                            lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.nombre == pues.nombre && pu.codigo_puesto == pues.codigo_puesto).ToList();
                        }
                    }
                    else
                    {
                        if (pues.codigo_puesto == -1)
                        {
                            lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.nombre == pues.nombre && pu.empresa == pues.empresa).ToList();
                        }
                        else
                        {
                            lp = db.Puesto.Include("Puntaje_Requerido.Competencia").Include("Evaluacion.Cuestionario").Where(pu => pu.nombre == pues.nombre && pu.empresa == pues.empresa && pu.codigo_puesto == pues.codigo_puesto).ToList();
                        }
                    }
                }
                return lp;
            }
        }

        public void actualizarPuesto(int codigo, string nombre)
        {
            using (TPDiseñoEntities db = new TPDiseñoEntities())
            {
                Puesto p = (from pu in db.Puesto where (pu.codigo_puesto == codigo && pu.nombre == nombre && pu.fecha_eliminado == null) select pu).FirstOrDefault();
                p.fecha_ultima_modificacion = DateTime.Now;
                db.SaveChanges();
            }
        }

        public Puesto obtenerPuesto(int codigoPuesto, string nombrePuesto)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Puesto.SingleOrDefault<Puesto>(p => p.codigo_puesto == codigoPuesto && p.nombre == nombrePuesto && p.fecha_eliminado == null);
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public Puesto obtenerPuesto(int idPuesto)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    List<Puesto> lp = db.Puesto.Include("Puntaje_Requerido.Competencia.Factor.Pregunta").ToList();
                    return lp.SingleOrDefault<Puesto>(p => p.id_puesto == idPuesto && p.fecha_eliminado == null);
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public List<Puesto> obtenerPuesto()
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Puesto.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
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
                    //Puesto p = (from pu in db.Puesto where (pu.codigo_puesto == puesto.codigo_puesto && pu.nombre == puesto.nombre && pu.fecha_eliminado == null) select pu).FirstOrDefault();

                    //Puesto p = db.Puesto.Find(puesto.id_puesto);

                    puesto.fecha_eliminado = DateTime.Now;
                    puesto.fecha_ultima_modificacion = DateTime.Now;
                    puesto.estado = "NoActivo";
                    puesto.id_consultor = consultorActual.nombreUsuario;
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
