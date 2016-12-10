using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDAO;

namespace CDatos.ClasesDB
{
    public class CuestionarioDB : CuestionarioDAO
    {
        public List<Cuestionario> obtenerCuestionariosDB(Candidato cand)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Cuestionario.Include("Estado_Cuestionario").Include("Bloque.ItemBloque.Pregunta.Factor.Competencia").Include("Bloque.ItemBloque.Respuesta.ValorRespuesta").Where(cu => cu.nroCandidato == cand.nroCandidato).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public Cuestionario obtenerCuestionarioDB(int idCuest)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Cuestionario.Include("Estado_Cuestionario").Include("Bloque.ItemBloque.Pregunta.Factor.Competencia").Include("Bloque.ItemBloque.Respuesta.ValorRespuesta").FirstOrDefault<Cuestionario>(cu => cu.id_cuestionario == idCuest);
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                throw ex;
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
                throw ex;
            }
        }

        public void modificarEstado(Cuestionario cuest, string estado)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    Cuestionario c = (from cu in db.Cuestionario where (cu.id_cuestionario == cuest.id_cuestionario) select cu).FirstOrDefault();
                    Estado_Cuestionario est = new Estado_Cuestionario();
                    est.fecha_mod = DateTime.Now;
                    est.id_cuestionario = cuest.id_cuestionario;
                    est.estadoActual = estado;
                    est.estadoAnterior = cuest.Estado_Cuestionario.Where(est1 => est1.fecha_mod == cuest.Estado_Cuestionario.Max(est2 => est2.fecha_mod)).FirstOrDefault().estadoActual;
                    c.Estado_Cuestionario.Add(est);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                throw ex;
            }
        }

        public void agregarAcceso(Cuestionario cuest)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    Cuestionario c = (from cu in db.Cuestionario where (cu.id_cuestionario == cuest.id_cuestionario) select cu).FirstOrDefault();
                    c.cantidad_accesos+=1;
                    c.ultimo_acceso = DateTime.Now;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void altaCuestionarios(List<Cuestionario> listaCuest, TPDiseñoEntities db)
        {
            foreach (Cuestionario cuest in listaCuest)
            {
                    db.Cuestionario.Add(cuest);
            }  
        }
    }
}
