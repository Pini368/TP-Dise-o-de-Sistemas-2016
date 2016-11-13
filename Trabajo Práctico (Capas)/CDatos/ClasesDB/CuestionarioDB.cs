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
                    return (from cu in db.Cuestionario where (from est in cu.Estado_Cuestionario where ((est.estadoActual == "En Proceso" || est.estadoActual == "Activo") && est.fecha_mod == cu.Estado_Cuestionario.Max(estado => estado.fecha_mod)) select est).Count() > 0 select cu).FirstOrDefault(); ;
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
    }
}
