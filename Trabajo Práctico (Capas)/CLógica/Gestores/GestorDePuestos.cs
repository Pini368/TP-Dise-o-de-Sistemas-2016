using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;
using System.Windows.Forms;
using CDatos.ClasesDB;

namespace CLogica.Gestores
{
    public class GestorDePuestos
    {
        public void alta(Puesto puesto)
        {
            PuestoDB cdatos = new PuestoDB();
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
        public void getPuestos()
        {
            
        }
    }
}
