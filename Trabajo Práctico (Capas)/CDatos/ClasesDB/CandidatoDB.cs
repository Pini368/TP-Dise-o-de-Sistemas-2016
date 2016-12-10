using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDAO;
using System.Linq.Expressions;

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
                    return db.Candidato.Include("Cuestionario.Estado_Cuestionario").Include("Cuestionario.Bloque.ItemBloque.Pregunta.Factor.Competencia").Include("Cuestionario.Bloque.ItemBloque.Respuesta.ValorRespuesta").SingleOrDefault<Candidato>(can => can.nroCandidato == idCandidato);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Candidato> getCandidatos(Expression<Func<Candidato, bool>> filtro)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    if (filtro != null)
                    {
                        return db.Candidato.Include("Cuestionario.Estado_Cuestionario").Include("Cuestionario.Bloque.ItemBloque.Pregunta.Factor.Competencia").Include("Cuestionario.Bloque.ItemBloque.Respuesta.ValorRespuesta").Where(filtro).ToList();
                    }
                    else
                    {
                        return db.Candidato.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void cambiarContraseña(List<Candidato> listCandidato, TPDiseñoEntities db)
        {            
            foreach (Candidato cand in listCandidato)
            {
                Candidato c = (from ca in db.Candidato where (ca.nroCandidato == cand.nroCandidato) select ca).FirstOrDefault();
                c.contraseña = cand.contraseña;
            }
        }
    }
}
