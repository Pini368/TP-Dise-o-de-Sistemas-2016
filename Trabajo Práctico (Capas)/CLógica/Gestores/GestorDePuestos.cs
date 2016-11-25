using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDatos.ClasesDAO;
using CEntidades;
using CDatos.ClasesDB;
using System.Linq.Expressions;

namespace CLogica.Gestores
{
    public class GestorDePuestos
    {

        public void alta(Puesto puesto)
        {
            PuestoDAO cdatos = new PuestoDB();

            try
            {
                int cantPuestos = getPuestos(puesto.codigo_puesto, puesto.nombre, puesto.empresa).Count();
                if (cantPuestos == 0)
                {

                    cdatos.alta(puesto);
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

        public List<Cuestionario> obtenerCuestionarios(Puesto puesto)
        {
            List<Cuestionario> lc = new List<Cuestionario>();
            foreach (Evaluacion ev in puesto.Evaluacion) {
                //foreach(Cuestionario cu in ev.Cuestionario.Where(cu => cu.Estado_Cuestionario.Last().estadoActual == "Activo" || cu.Estado_Cuestionario.Last().estadoActual == "En Proceso"))
                foreach (Cuestionario cu in ev.Cuestionario)
                    {
                    lc.Add(cu);
                }
            }
            return lc;
        }

        public bool contieneCuestionarios(Puesto puesto)
        {
            return (this.obtenerCuestionarios(puesto).Count() > 0);
        }
        public void baja(Puesto puesto)
        {
            PuestoDAO cdatos = new PuestoDB();
            Consultor consultorActual = new Consultor();

            consultorActual.nombreUsuario = 1223334444;//1223334444 es un id consultor auxiliar hasta que implementemos el gestor de autenticación.
            //consultorActual = GestorDeAutenticacion.obtenerConsultorActual();

            if (puesto.Evaluacion.Count() == 0)
            {
                try
                {
                    cdatos.baja(puesto, consultorActual);
                }
                catch (Exception ex)
                {
                    throw new ExceptionPersonalizada(ex.Message);
                }
            }
            else
            {
                throw new ExceptionPersonalizada("El puesto" + puesto.nombre + "está siendo usado en la base de datos y no puede eliminarse");
            }
        }
        public void modificacion()
        {

        }


        //Expression<Func<Puesto, bool>> filtro = (pu => pu.id_consultor == null && pu.fecha_ultima_modificacion == (db.Puesto.Where(pues1 => pues1.codigo_puesto == pu.codigo_puesto && pues1.nombre == pu.nombre && pues1.empresa == pu.empresa && pues1.id_consultor == null)).Max(pues2 => pues2.fecha_ultima_modificacion).Value);

        public Puesto getPuestos(int codigo, string nombre)
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                Expression<Func<Puesto, bool>> filtro = (pu => pu.codigo_puesto == codigo && pu.nombre == nombre);
                return cdP.getPuestos(filtro).First();
            }
            catch(Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public Puesto getPuestos(int idPuesto)
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                Expression<Func<Puesto, bool>> filtro = (pu => pu.id_puesto == idPuesto);
                return cdP.getPuestos(filtro).First();
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public List<Puesto> getPuestos(int codigo, string nombre, string empresa)
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                Expression<Func<Puesto, bool>> filtro;
                if (nombre == "")
                {
                    if (empresa == "")
                    {
                        if (codigo == -1)
                        {
                            filtro = null;
                        }
                        else
                        {
                            filtro = (pu => pu.codigo_puesto == codigo);
                        }
                    }
                    else
                    {
                        if (codigo == -1)
                        {
                            filtro = (pu => pu.empresa == empresa);
                        }
                        else
                        {
                            filtro = (pu => pu.empresa == empresa && pu.codigo_puesto == codigo);
                        }
                    }
                }
                else
                {
                    if (empresa == "")
                    {
                        if (codigo == -1)
                        {
                            filtro = (pu => pu.nombre == nombre);
                        }
                        else
                        {
                            filtro = (pu => pu.nombre == nombre && pu.codigo_puesto == codigo);
                        }
                    }
                    else
                    {
                        if (codigo == -1)
                        {
                            filtro = (pu => pu.nombre == nombre && pu.empresa == empresa);
                        }
                        else
                        {
                            filtro = (pu => pu.nombre == nombre && pu.empresa == empresa && pu.codigo_puesto == codigo);
                        }
                    }
                }
                return cdP.getPuestos(filtro);
            }
            catch(Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
        
        public Puesto getUltimoPuesto(int codigo, string nombre)
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                Expression<Func<Puesto, bool>> filtro = (pu => pu.codigo_puesto == codigo && pu.nombre == nombre);
                return cdP.getPuestos(filtro).First();
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public List<Puesto> getPuestos()
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                Expression<Func<Puesto, bool>> filtro = null;
                return cdP.getPuestos(filtro);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }


        public void modificarSFunc(Puesto puesto)
        {
            PuestoDAO cdatos = new PuestoDB();
            try
            {
                cdatos.modificarSFunc(puesto);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
        public void modificarCFunc(Puesto puesto, Puesto puestoSinMod)
        {
            PuestoDAO cdatos = new PuestoDB();
            try
            {
                cdatos.modificarCFunc(puesto, puestoSinMod);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
