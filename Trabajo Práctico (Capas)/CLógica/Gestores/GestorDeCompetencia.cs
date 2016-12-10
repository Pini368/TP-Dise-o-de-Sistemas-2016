using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CDatos.ClasesDB;
using CDatos.ClasesDAO;
using CEntidades;
using System.Windows.Forms;

namespace CLogica.Gestores
{
    public class GestorDeCompetencia
    {
        public void alta()
        {

        }
        public void baja()
        {

        }
        public void modificacion()
        {

        }
        public List<Competencia> getCompetencias()
        {
            CompetenciaDAO cdatos = new CompetenciaDB();
            try
            {
                return cdatos.getCompetencias();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
