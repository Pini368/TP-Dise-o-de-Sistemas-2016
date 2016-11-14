using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;

namespace CLogica.Gestores
{
    public class GestorDeEvaluacion
    {
        public Evaluacion getEvaluaciones(int idEvaluacion)
        {
            EvaluacionDB cdatos = new EvaluacionDB();
            try
            {
                return cdatos.getEvaluaciones(idEvaluacion);
            }
            catch(Exception ex){
                throw new ExceptionPersonalizada(ex.Message);
            }
        } 
    }
}
