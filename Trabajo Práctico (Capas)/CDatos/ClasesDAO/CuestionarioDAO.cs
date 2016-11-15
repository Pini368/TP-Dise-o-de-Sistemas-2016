using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos.ClasesDAO
{
    public interface CuestionarioDAO
    {
        Cuestionario obtenerCuestionario(Candidato cand);
        void generarCuestionario(Cuestionario cuest);
        void modificarCuestionario(Cuestionario cuest);
        void modificarEstado(Cuestionario cuest, string estado);
        void agregarBloques(Cuestionario cuest, List<Bloque> listaBloques);
        void agregarAcceso(Cuestionario cuest);
    }
}
