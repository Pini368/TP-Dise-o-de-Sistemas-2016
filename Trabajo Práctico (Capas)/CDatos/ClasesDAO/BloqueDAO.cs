using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.ClasesDB;
using CEntidades;

namespace CDatos.ClasesDAO
{
    public interface BloqueDAO
    {
        void modificarBloque(Bloque bloque);
        void modificarRespuestaElegida(RespuestaElegida rtaEleg, int idRespuesta);
    }
}
