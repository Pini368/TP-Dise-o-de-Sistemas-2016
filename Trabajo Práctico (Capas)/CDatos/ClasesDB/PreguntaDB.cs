using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDAO;

namespace CDatos.ClasesDB
{
    public class PreguntaDB : PreguntaDAO
    {
        public Pregunta getPreguntas(int idPregunta)
        {
            PreguntaDB cdatos = new PreguntaDB();
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    List<Pregunta> lp = db.Pregunta.Include("OpcionRespuesta.Respuesta").ToList();
                    return lp.FirstOrDefault<Pregunta>(preg => preg.id_pregunta == idPregunta);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
