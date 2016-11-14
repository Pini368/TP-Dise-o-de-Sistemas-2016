using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos.ClasesDB
{
    public class CuestionarioDB
    {
        public Cuestionario obtenerCuestionario(Candidato cand)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    List<Cuestionario> lc = db.Cuestionario.Include("Bloque.RespuestaElegida").Include("Estado_Cuestionario").Include("Evaluacion").ToList();
                    return lc.Where(cu => (cu.Estado_Cuestionario.Where(est => (est.estadoActual == "En Proceso" || est.estadoActual == "Activo") && est.fecha_mod == cu.Estado_Cuestionario.Max(estado => estado.fecha_mod))).Count() > 0).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
        public void generarCuestionario(Cuestionario cuest)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    db.Cuestionario.Add(cuest);
                    db.SaveChanges();
                }
            }
            catch(Exception ex){
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public void modificarCuestionario(Cuestionario cuest)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    db.Cuestionario.Attach(cuest);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public void agregarBloques(Cuestionario cuest, List<Bloque> listaBloques)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    Cuestionario c = (from cu in db.Cuestionario where (cu.id_cuestionario == cuest.id_cuestionario) select cu).FirstOrDefault();
                    c.Bloque = listaBloques;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
