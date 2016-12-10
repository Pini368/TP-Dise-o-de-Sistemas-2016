using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDAO;

namespace CDatos.ClasesDB
{
    public class BloqueDB : BloqueDAO
    {
        public void modificarBloque(Bloque bloque)
        {
            using (TPDiseñoEntities db = new TPDiseñoEntities())
            {
                db.Bloque.Attach(bloque);
                db.SaveChanges();
            }
        }
        public void modificarItemBloque(ItemBloque rtaEleg, int idRespuesta)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    ItemBloque rta = (from re in db.ItemBloque where (re.id_bloque == rtaEleg.id_bloque && re.id_pregunta == rtaEleg.id_pregunta) select re).FirstOrDefault();
                    rta.id_respuesta = idRespuesta;
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
