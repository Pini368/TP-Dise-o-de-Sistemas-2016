using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos.ClasesDAO
{
    public interface CompetenciaDAO
    {
        void alta();
        void baja();
        void modificacion();
        List<Competencia> getCompetencias();
    }
}
