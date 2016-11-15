using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;
using CDatos.ClasesDAO;

namespace CLogica.Gestores
{
    public class GestorTablaDeParametros
    {
        public int obtenerParametroEntero(string nombre)
        {
            TablaDeParametrosDAO cdatos = new TablaDeParametrosDB();
            try
            {
                return cdatos.obtenerParametroEntero(nombre);
            }
            catch(Exception ex){
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
