using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;
using CDatos.ClasesDAO;

namespace CLogica.Gestores
{
    public class GestorDePregunta
    {
        public Pregunta getPreguntas(int idPregunta)
        {
            PreguntaDAO cdatos = new PreguntaDB();
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
