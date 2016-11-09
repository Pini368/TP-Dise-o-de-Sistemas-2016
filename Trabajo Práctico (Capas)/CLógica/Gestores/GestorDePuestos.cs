using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;
using System.Windows.Forms;
using CDatos.ClasesDB;
using CEntidades;

namespace CLogica.Gestores
{
    public class GestorDePuestos
    {

        public void alta(Puesto puesto, List<Caracteristica> lc)
        {
            PuestoDB cdatos = new PuestoDB();
            try
            {
                cdatos.alta(puesto, lc);
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
        public void getPuestos()
        {
            
        }

        public List<Caracteristica> obtenerCaracteristicasPuesto(int codigo, string nombre)
        {
            PuestoDB cdP = new PuestoDB();
            try
            {
                return cdP.obtenerCaracteristicasPuesto(codigo, nombre);
            }
            catch(Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
