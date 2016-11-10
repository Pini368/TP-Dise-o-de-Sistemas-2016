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

        public Puesto obtenerPuesto(int codigoPuesto, string nombrePuesto)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Puesto.SingleOrDefault<Puesto>(p => p.codigo_puesto == codigoPuesto && p.nombre == nombrePuesto && !(p.fecha_eliminado.HasValue));
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
                    return db.Puesto.SingleOrDefault<Puesto>(p => p.id_puesto == idPuesto && !(p.fecha_eliminado.HasValue));
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

        private int obtenerCantidadPuestos(int codigo, string nombre)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Puesto.ToList().Select(p => p.codigo_puesto == codigo && p.nombre == nombre && !(p.fecha_eliminado.HasValue)).Count();
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
                int cantPuestos = obtenerCantidadPuestos(puesto.codigo_puesto, puesto.nombre);

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
