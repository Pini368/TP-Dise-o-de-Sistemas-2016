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
        public void baja()
        {

        }
        public void modificacion()
        {

        }

        public Puesto getPuestos(int codigo, string nombre)
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                return cdP.obtenerPuesto(codigo, nombre);
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
                return cdP.obtenerPuesto(idPuesto);
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
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public Puesto getUltimoPuesto(int codigo, string nombre)
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                return cdP.obtenerPuesto(cdP.obtenerUltimoIDPuesto(codigo, nombre));
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
                return cdP.obtenerPuesto();
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public void actualizarPuesto(int codigo, string nombre)
        {
            PuestoDAO cdP = new PuestoDB();
            try
            {
                cdP.actualizarPuesto(codigo, nombre);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
