using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;

namespace CLogica.Gestores
{
    public class GestorDeCuestionario
    {
        public Cuestionario obtenerCuestionario(Candidato cand)
        {
            try
            {
                CuestionarioDB cdatos = new CuestionarioDB();
                return cdatos.obtenerCuestionario(cand);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public void generarCuestionario(Cuestionario cuest)
        {
            CuestionarioDB cdatos = new CuestionarioDB();
            try
            {
                cdatos.generarCuestionario(cuest);
            }
            catch(Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
