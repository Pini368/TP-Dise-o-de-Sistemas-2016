using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;

namespace CLogica.Gestores
{
    public class GestorDeBloque
    {
        public void modificarBloque(Bloque bloque)
        {
            BloqueDB cdatos = new BloqueDB();
            try
            {
                cdatos.modificarBloque(bloque);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public void modificarRespuestaElegida(RespuestaElegida rtaEleg, int idRespuesta)
        {
            BloqueDB cdatos = new BloqueDB();
            try
            {
                cdatos.modificarRespuestaElegida(rtaEleg, idRespuesta);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
