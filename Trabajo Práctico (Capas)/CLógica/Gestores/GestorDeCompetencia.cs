using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CDatos.ClasesDB;
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
            CompetenciaDB cdatos = new CompetenciaDB();
            try
            {
                return cdatos.getCompetencias();
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
