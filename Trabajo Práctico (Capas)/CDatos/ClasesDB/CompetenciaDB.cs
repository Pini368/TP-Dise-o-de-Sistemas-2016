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
                    return db.Competencia.SingleOrDefault<Competencia>(c => c.id_competencia == idComp);
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
        public List<Competencia> getCompetencias()
        {
            try
            {
                using (TPDiseñoEntities db = new TPDiseñoEntities())
                {
                    return db.Competencia.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
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
