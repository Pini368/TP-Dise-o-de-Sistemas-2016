using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;
using System.Data;
using CDatos.ClasesDB;

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
        public DataSet getCompetencias()
        {
            CompetenciaDB cdatos = new CompetenciaDB();
            DataSet ds;
            try
            {
                ds = cdatos.getCompetencias();
                return ds;
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
