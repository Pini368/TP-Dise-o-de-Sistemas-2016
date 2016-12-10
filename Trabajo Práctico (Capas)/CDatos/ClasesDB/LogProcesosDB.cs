using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.ClasesDAO;
using CEntidades;

namespace CDatos.ClasesDB
{
    public class LogProcesosDB : LogProcesosDAO
    {
        public void agregarLog(LogProcesos log)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    db.LogProcesos.Add(log);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
