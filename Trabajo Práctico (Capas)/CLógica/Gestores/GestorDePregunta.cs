using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;

namespace CLogica.Gestores
{
    public class GestorDePregunta
    {
        public Pregunta getPreguntas(int idPregunta)
        {
            PreguntaDB cdatos = new PreguntaDB();
            try
            {
                return cdatos.getPreguntas(idPregunta);
            }
            catch(Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
