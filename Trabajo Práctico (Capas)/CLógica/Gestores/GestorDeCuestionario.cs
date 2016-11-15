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
    public class GestorDeCuestionario
    {

        public int obtenerPuntajeCuestionario(Cuestionario cuest)
        {
            int puntTotal = 0;
            Dictionary<Factor, int> puntFac = new Dictionary<Factor, int>();
            Dictionary<Competencia, int> puntComp = new Dictionary<Competencia, int>();
            foreach (Bloque bl in cuest.Bloque)
            {
                foreach(RespuestaElegida re in bl.RespuestaElegida)
                {
                    if (re.id_respuesta != null)
                    {
                        if (!puntFac.ContainsKey(re.Pregunta.Factor))
                        {
                            puntFac.Add(re.Pregunta.Factor, re.Respuesta.ValorRespuesta.Where(vr => vr.id_pregunta == re.id_pregunta).First().ponderacion);
                        }
                        else
                        {
                            puntFac[re.Pregunta.Factor] += re.Respuesta.ValorRespuesta.Where(vr => vr.id_pregunta == re.id_pregunta).First().ponderacion;
                        }
                    }
                }
            }
            foreach(Factor key in puntFac.Keys)
            {
                puntFac[key] = puntFac[key] / 2;
                if (!puntComp.ContainsKey(key.Competencia))
                {
                    puntComp.Add(key.Competencia, puntFac[key]);
                }
                else
                {
                    puntComp[key.Competencia] += puntFac[key];
                }
            }
            foreach(Competencia key in puntComp.Keys)
            {
                puntComp[key] = puntComp[key] / puntFac.Keys.Where(fac => fac.codigo_competencia == key.id_competencia).Count();
                puntTotal += puntComp[key];
            }
            return puntTotal;
        }

        public string obtenerUltimoEstado(Cuestionario cuest)
        {
            return cuest.Estado_Cuestionario.Where(est => est.fecha_mod == cuest.Estado_Cuestionario.Max(est1 => est1.fecha_mod)).FirstOrDefault().estadoActual;
        }
        public Cuestionario obtenerCuestionario(Candidato cand)
        {
            try
            {
                CuestionarioDAO cdatos = new CuestionarioDB();
                return cdatos.obtenerCuestionario(cand);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }


        public void agregarAcceso(Cuestionario cuest)
        {
            CuestionarioDB cdatos = new CuestionarioDB();
            try
            {
                cdatos.agregarAcceso(cuest);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public int obtenerBloqueACargar(Cuestionario cuest)
        {
            GestorDeBloque clogBloque = new GestorDeBloque();
            try
            {
                int nroBloque = 0;
                for (int i=0; i<cuest.Bloque.Count(); i++)
                {
                    if (!clogBloque.verificarCompleto(cuest.Bloque.ToList()[i]))
                    {
                        nroBloque = i;
                        break;
                    }
                }
                return nroBloque;
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public void modificarEstado(Cuestionario cuest, string estado)
        {
            CuestionarioDB cdatos = new CuestionarioDB();
            try
            {
                cdatos.modificarEstado(cuest, estado);
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

        public void modificarCuestionario(Cuestionario cuest)
        {
            CuestionarioDB cdatos = new CuestionarioDB();
            try
            {
                cdatos.modificarCuestionario(cuest);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public void agregarBloques(Cuestionario cuest, List<Bloque> listaBloques)
        {
            CuestionarioDB cdatos = new CuestionarioDB();
            try
            {
                cdatos.agregarBloques(cuest, listaBloques);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
