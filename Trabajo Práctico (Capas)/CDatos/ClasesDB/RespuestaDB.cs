using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos.ClasesDB
{
    public class RespuestaDB
    {
        public List<Respuesta> getRespuestas(string nombre)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Respuesta.Where(rta => rta.nombre == nombre).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
