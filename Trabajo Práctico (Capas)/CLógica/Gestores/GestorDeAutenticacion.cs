using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CLogica.Gestores
{
    public class GestorDeAutenticacion
    {
        public static Candidato candActual;
        public static Consultor consActual;

        public static void autenticarUsuario(Candidato cand)
        {
            candActual = cand;
        }

        public static void autenticarUsuario(Consultor cons)
        {
            consActual = cons;
        }

        public static Consultor obtenerConsultorActual()
        {
            return consActual;
        }

        public static Candidato obtenerCandidatoActual()
        {
            return candActual;
        }
    }
}
