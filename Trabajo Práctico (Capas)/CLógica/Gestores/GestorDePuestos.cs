using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDatos.ClasesDAO;
using CEntidades;
using CDatos.ClasesDB;

namespace CLogica.Gestores
{
    public class GestorDePuestos
    {

        public void alta(Puesto puesto)
        {
            PuestoDAO cdatos = new PuestoDB();
            try
            {
                cdatos.alta(puesto);
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
                foreach(Cuestionario cu in ev.Cuestionario.Where(cu => cu.Estado_Cuestionario.Last().estadoActual == "Activo" || cu.Estado_Cuestionario.Last().estadoActual == "En Proceso"))
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

        public Puesto getPuestos(int codigo, string nombre)
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                Puesto p = new Puesto();
                p.codigo_puesto = codigo;
                p.nombre = nombre;
                p.empresa = "";
                p.id_puesto = -1;
                return cdP.getPuestos(p).First();
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
                Puesto p = new Puesto();
                p.id_puesto = idPuesto;
                return cdP.getPuestos(p).First();
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public List<Puesto> getPuestos(Puesto pu)
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                return cdP.getPuestos(pu);
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
                Puesto p = new Puesto();
                p.id_puesto = cdP.obtenerUltimoIDPuesto(codigo, nombre);
                return cdP.getPuestos(p).First();
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
                Puesto p = new Puesto();
                p.codigo_puesto = -1;
                p.nombre = "";
                p.empresa = "";
                p.id_puesto = -1;
                return cdP.getPuestos(p);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }


        public void modificar(Puesto puesto)
        {
            PuestoDAO cdatos = new PuestoDB();
            try
            {
                cdatos.modificar(puesto);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
