using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;
using CDatos.ClasesDAO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace CLogica.Gestores
{
    public class GestorDeEvaluacion
    {
        public Evaluacion getEvaluaciones(int idEvaluacion)
        {
            EvaluacionDAO cdatos = new EvaluacionDB();
            try
            {
                return cdatos.getEvaluaciones(idEvaluacion);
            }
            catch(Exception ex){
                throw ex;
            }
        }
       
        public void alta(Evaluacion evaluacion,List <Cuestionario> listaCuest,List<Candidato> listaCand)
        {
            EvaluacionDAO cdatos = new EvaluacionDB();
            try
            {
                cdatos.alta(evaluacion, listaCuest, listaCand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
