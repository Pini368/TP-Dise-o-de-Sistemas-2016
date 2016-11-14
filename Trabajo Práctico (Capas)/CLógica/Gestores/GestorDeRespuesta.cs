using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;

namespace CLogica.Gestores
{
    public class GestorDeRespuesta
    {
        public List<Respuesta> getRespuestas(string nombre)
        {
            RespuestaDB capaDatos = new RespuestaDB();
            try
            {
                return capaDatos.getRespuestas(nombre);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
