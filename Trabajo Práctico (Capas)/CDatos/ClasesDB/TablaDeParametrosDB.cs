using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos.ClasesDB
{
    public class TablaDeParametrosDB
    {
        public int obtenerParametroEntero(string nombre)
        {
            try
            {
                using(TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return Int32.Parse(db.TablaDeParametros.FirstOrDefault<TablaDeParametros>(tp => tp.nombre == nombre).valor);
                }
            }
            catch(Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
