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
        public Cuestionario obtenerCuestionario(Candidato cand)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    List<Cuestionario> lc = db.Cuestionario.Include("Bloque.RespuestaElegida.Respuesta.ValorRespuesta").Include("Bloque.RespuestaElegida.Pregunta.Factor.Competencia").Include("Estado_Cuestionario").Include("Evaluacion").ToList();
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
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
