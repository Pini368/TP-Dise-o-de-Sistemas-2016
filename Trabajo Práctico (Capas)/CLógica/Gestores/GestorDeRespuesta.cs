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
    public class GestorDeRespuesta
    {
        public List<Respuesta> getRespuestas(string nombre)
        {
            RespuestaDAO capaDatos = new RespuestaDB();
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
