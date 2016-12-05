using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDAO;

namespace CDatos.ClasesDB
{
    public class CandidatoDB : CandidatoDAO
    {
        public Candidato getCandidatos(int idCandidato)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Candidato.Include("Cuestionario.Estado_Cuestionario").SingleOrDefault<Candidato>(can => can.nroCandidato == idCandidato);
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
