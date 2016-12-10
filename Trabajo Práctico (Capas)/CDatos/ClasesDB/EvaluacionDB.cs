using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDAO;
using System.Data.Entity;

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
                throw ex;
            }
        }
        public void alta(Evaluacion evaluacion, List<Cuestionario> listaCuest, List<Candidato> listaCand)
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
                        cdatosCand.cambiarContraseña(listaCand,db);
                        db.Evaluacion.Add(evaluacion);
                        db.SaveChanges();
                        db.Entry(evaluacion).State = EntityState.Unchanged;
                        foreach (Candidato cand in listaCand)
                        {
                            Candidato c = (from ca in db.Candidato where (ca.nroCandidato == cand.nroCandidato) select ca).FirstOrDefault();
                            db.Entry(c).State = EntityState.Unchanged;
                            evaluacion.Candidato.Add(c);
                        }
                        db.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch (Exception)
                    {
                        try
                        {
                            dbContextTransaction.Rollback();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
            }
        }
    }
}
