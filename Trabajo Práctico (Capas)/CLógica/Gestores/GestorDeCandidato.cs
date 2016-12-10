using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;
using CDatos.ClasesDAO;
using System.Linq.Expressions;

namespace CLogica.Gestores
{
    public class GestorDeCandidato
    {
        public List<Candidato> getCandidatosCuestionariosActivos(List<Candidato> lcand)
        {
            List<Candidato> lc = new List<Candidato>();
            foreach (Candidato ca in lcand)
            {
                if(ca.Cuestionario.Where(cu => cu.Estado_Cuestionario.Last().estadoActual.ToUpper() == "ACTIVO" || cu.Estado_Cuestionario.Last().estadoActual.ToUpper() == "EN PROCESO").Count() > 0)
                {
                    lc.Add(ca);
                }
            }
            return lc;
        }
  
        public Candidato getCandidatos(int idCandidato)
        {
            CandidatoDAO cdatos = new CandidatoDB();
            try
            {
                return cdatos.getCandidatos(idCandidato);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Candidato> getCandidatos(string apellido, string nombre, string nroCandidato)
        {
            CandidatoDAO cdatos = new CandidatoDB();
            try
            {
                Expression<Func<Candidato, bool>> filtro = null;
                if (apellido != "")
                {
                    if(nombre != "")
                    {
                        if(nroCandidato != "")
                        {
                            int nroCand = Int32.Parse(nroCandidato);
                            filtro = (ca => ca.apellido.StartsWith(apellido) && ca.nombre.StartsWith(nombre) && ca.nroCandidato == nroCand);
                        }
                        else
                        {
                            filtro = (ca => ca.apellido.StartsWith(apellido) && ca.nombre.StartsWith(nombre));
                        }
                    }
                    else
                    {
                        if (nroCandidato != "")
                        {
                            int nroCand = Int32.Parse(nroCandidato);
                            filtro = (ca => ca.apellido.StartsWith(apellido) && ca.nroCandidato == nroCand);
                        }
                        else
                        {
                            filtro = (ca => ca.apellido.StartsWith(apellido));
                        }

                    }
                }
                else
                {
                    if (nombre != "")
                    {
                        if (nroCandidato != "")
                        {
                            int nroCand = Int32.Parse(nroCandidato);
                            filtro = (ca => ca.nombre.StartsWith(nombre) && ca.nroCandidato == nroCand);
                        }
                        else
                        {
                            filtro = (ca => ca.nombre.StartsWith(nombre));
                        }
                    }
                    else
                    {
                        if (nroCandidato != "")
                        {
                            int nroCand = Int32.Parse(nroCandidato);
                            filtro = (ca => ca.nroCandidato == nroCand);
                        }
                        else
                        {
                            filtro = null;
                        }
                    }
                }
                return cdatos.getCandidatos(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
