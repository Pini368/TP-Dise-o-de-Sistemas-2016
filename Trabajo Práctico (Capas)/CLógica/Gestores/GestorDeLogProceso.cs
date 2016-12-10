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
    public class GestorDeLogProceso
    {
        public void agregarLog(LogProcesos log)
        {
            try
            {
                LogProcesosDAO cdatos = new LogProcesosDB();
                cdatos.agregarLog(log);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
