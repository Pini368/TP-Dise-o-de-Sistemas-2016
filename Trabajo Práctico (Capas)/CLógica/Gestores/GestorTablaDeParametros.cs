using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;

namespace CLogica.Gestores
{
    public class GestorTablaDeParametros
    {
        public int obtenerParametroEntero(string nombre)
        {
            TablaDeParametrosDB cdatos = new TablaDeParametrosDB();
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
