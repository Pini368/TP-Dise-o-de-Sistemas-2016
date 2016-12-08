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

        public float obtenerPuntajeCuestionario(Cuestionario cuest)
        {
            float puntTotal = 0;
            Dictionary<Factor, float> puntFac = new Dictionary<Factor, float>();
            Dictionary<Competencia, float> puntComp = new Dictionary<Competencia, float>();
            foreach (Bloque bl in cuest.Bloque)
            {
                foreach(ItemBloque re in bl.ItemBloque)
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
            for(int i=0; i<puntFac.Count(); i++)
            {
                Factor key = puntFac.Keys.ToList()[i];
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
            for(int i = 0; i < puntComp.Count(); i++)
            {
                Competencia key = puntComp.Keys.ToList()[i];
                puntComp[key] = puntComp[key] / puntFac.Keys.Where(fac => fac.codigo_competencia == key.id_competencia).Count();
                puntTotal += puntComp[key];
            }
            return puntTotal;
        }

        public void finalizar(Evaluacion evaluacion, List<Cuestionario> listaCuest, List<Candidato> listaCand)
        {
            EvaluacionDAO cdatos = new EvaluacionDB();
            try
            {
                cdatos.alta(evaluacion, listaCuest, listaCand);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public List<Cuestionario> generarCuestionarios(Evaluacion ev, List<Candidato> lc)
        {
            List<Cuestionario> listaCuest = new List<Cuestionario>();
            foreach(Candidato ca in lc)
            {
                Cuestionario cu = new Cuestionario();
                cu.fecha_inicio = DateTime.Now;
                cu.nroCandidato = ca.nroCandidato;
                cu.cantidad_accesos = 0;
                cu.ultimo_acceso = DateTime.Now;
                cu.id_evaluacion=ev.id_evaluacion;
                Estado_Cuestionario EstCu = new Estado_Cuestionario();
                EstCu.estadoActual = "Activo";
                EstCu.estadoAnterior = "Activo";
                EstCu.fecha_mod = DateTime.Now;
                cu.Estado_Cuestionario.Add(EstCu);
                ca.contraseña = generarContraseña(8);
                listaCuest.Add(cu);
            }
            return listaCuest;
        }

        private string generarContraseña(int longitud)
        {
            Random rnd = new Random();
            string contraseña = "";
            for(int i=0; i<longitud; i++)
            {
                int nroLetra = rnd.Next() % 2;
                if (nroLetra == 0)
                {
                    int nro = rnd.Next()%10;
                    contraseña += nro.ToString();
                }
                else
                {
                    int letraASCII = rnd.Next() % 26;
                    char letra = (char)(letraASCII + 65);
                    contraseña += letra;
                }
            }
            return contraseña;
        }

        public string obtenerUltimoEstado(Cuestionario cuest)
        {
            return cuest.Estado_Cuestionario.Where(est => est.fecha_mod == cuest.Estado_Cuestionario.Max(est1 => est1.fecha_mod)).FirstOrDefault().estadoActual;
        }
        public Cuestionario obtenerCuestionario(Candidato cand)
        {
            try
            {
                return cand.Cuestionario.Where(cu => (cu.Estado_Cuestionario.Where(est => (est.estadoActual == "En Proceso" || est.estadoActual == "Activo") && est.fecha_mod == cu.Estado_Cuestionario.Max(estado => estado.fecha_mod))).Count() > 0).FirstOrDefault();
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
