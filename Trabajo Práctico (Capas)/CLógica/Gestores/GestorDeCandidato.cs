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
    public class GestorDeCandidato
    {
        public Candidato getCandidatos(int idCandidato)
        {
            CandidatoDAO cdatos = new CandidatoDB();
            try
            {
                return cdatos.getCandidatos(idCandidato);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
