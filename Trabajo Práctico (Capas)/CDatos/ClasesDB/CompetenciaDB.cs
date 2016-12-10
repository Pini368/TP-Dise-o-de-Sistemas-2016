using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CDatos.ClasesDAO;

namespace CDatos.ClasesDB
{
    public class CompetenciaDB : CompetenciaDAO
    {


        public Competencia getCompetencias(int idComp)
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Competencia.SingleOrDefault<Competencia>(c => c.id_competencia == idComp && c.id_consultor == null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Competencia> getCompetencias()
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Competencia.Where(c => c.id_consultor == null).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void alta()
        {
            throw new NotImplementedException();
        }

        public void baja()
        {
            throw new NotImplementedException();
        }

        public void modificacion()
        {
            throw new NotImplementedException();
        }
    }
}
