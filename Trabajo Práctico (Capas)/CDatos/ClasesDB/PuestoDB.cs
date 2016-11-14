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

namespace CDatos.ClasesDB
{
    public class PuestoDB
    {

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

    }
}
