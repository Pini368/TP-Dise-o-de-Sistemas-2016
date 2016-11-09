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
                    return db.spObtenerCantPuestosCodigoNombre(codigo, nombre).FirstOrDefault().Value;
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

        public void alta(Puesto puesto)
        {
            try
            {
                /*
                int cantPuestos = obtenerCantidadPuestos(puesto.codigo_puesto, puesto.nombre);

                if (cantPuestos == 0)
                {
                    using (TPDiseñoEntities db = new TPDiseñoEntities())
                    {
                        db.Puesto.Attach(puesto);
                        db.SaveChanges();
                    }
                }
                else
                {
                    throw new ExceptionPersonalizada("Error, el puesto ya existe en la base de datos.");
                }
                */


                
                int cantPuestos = obtenerCantidadPuestos(puesto.codigo_puesto, puesto.nombre);

                if (cantPuestos == 0)
                {
                    int idPuesto = insertarPuesto(puesto);
                    for (int i = 0; i < puesto.Puntaje_Requerido.ToList().Count(); i++)
                    {
                        insertarCaracteristica(idPuesto, puesto.Puntaje_Requerido.ToList()[i].Competencia.id_competencia, puesto.Puntaje_Requerido.ToList()[i].ponderacion);
                    }
                }
                else
                {
                    throw new ExceptionPersonalizada("Ya existe un puesto con ese mismo código y nombre.");
                }
                
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
