using CEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.ClasesDAO
{
    public interface CandidatoDAO
    {
        Candidato getCandidatos(int idCandidato);
        List<Candidato> getCandidatos(Expression<Func<Candidato, bool>> filtro);
    }
}
