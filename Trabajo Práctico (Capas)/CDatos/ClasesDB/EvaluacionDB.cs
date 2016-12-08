using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDAO;

namespace CDatos.ClasesDB
{
    public class EvaluacionDB : EvaluacionDAO
    {
        public Evaluacion getEvaluaciones(int idEvaluacion)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Evaluacion.SingleOrDefault<Evaluacion>(ev => ev.id_evaluacion == idEvaluacion);
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
        public void alta(Evaluacion evaluacion, List<Cuestionario> listaCuest)
        {
            using (TPDiseñoEntities db = new TPDiseñoEntities())
            {
                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        CuestionarioDAO cdatosCuest = new CuestionarioDB();
                        cdatosCuest.altaCuestionarios(listaCuest, db);
                        CandidatoDAO cdatosCand = new CandidatoDB();
                        cdatosCand.cambiarContraseña(evaluacion.Candidato.ToList(),db);
                        db.Evaluacion.Add(evaluacion);
                        db.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                    }
                }
            }
        }
    }
}
