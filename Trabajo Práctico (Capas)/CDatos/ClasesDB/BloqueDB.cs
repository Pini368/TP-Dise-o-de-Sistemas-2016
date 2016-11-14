using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos.ClasesDB
{
    public class BloqueDB
    {
        public void modificarBloque(Bloque bloque)
        {
            using (TPDiseñoEntities db = new TPDiseñoEntities())
            {
                db.Bloque.Attach(bloque);
                db.SaveChanges();
            }
        }
        public void modificarRespuestaElegida(RespuestaElegida rtaEleg, int idRespuesta)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    RespuestaElegida rta = (from re in db.RespuestaElegida where (re.id_bloque == rtaEleg.id_bloque && re.id_pregunta == rtaEleg.id_pregunta) select re).FirstOrDefault();
                    rta.id_respuesta = idRespuesta;
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
