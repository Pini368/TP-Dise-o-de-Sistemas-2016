using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;
using CDatos.ClasesDAO;
using System.Windows.Forms;

namespace CLogica.Gestores
{
    public class GestorDeCuestionario
    {
        Evaluacion evaluacion;


        public void terminarCuestionario(Cuestionario cuest)
        {
            try
            {
                this.modificarEstado(cuest, "Completado");
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public int siguienteBloque(TabControl tbc, int bloqueAc, Cuestionario cuest)
        {
            try
            {
                if (verificarRespuestasCompletas(tbc))
                {
                    GestorDeRespuesta clogResp = new GestorDeRespuesta();
                    GestorDeBloque clogBloque = new GestorDeBloque();
                    GestorDeCuestionario clogCuest = new GestorDeCuestionario();
                    GestorDeCandidato clogCand = new GestorDeCandidato();
                    int i = 0;
                    Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];
                    foreach (ItemBloque re in bloqueActual.ItemBloque.ToList())
                    {
                        string str = ("lsbRespuestas" + (i + 1).ToString());
                        ListBox lsb = (ListBox)tbc.TabPages[i].Controls[0].Controls[str];
                        Respuesta resp = clogResp.getRespuestas(lsb.SelectedItem.ToString()).First();
                        cuest.Bloque.ToList()[bloqueAc].ItemBloque.ToList()[i].id_respuesta = resp.id_respuesta;
                        clogBloque.modificarItemBloque(re, resp.id_respuesta);
                        i++;
                    }
                    return bloqueAc;
                }
                else
                {
                    throw new ExceptionPersonalizada("Debe responder a todas las preguntas");
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }


        private bool verificarRespuestasCompletas(TabControl tbc)
        {
            bool completos = true;
            int i = 0;
            foreach (TabPage tp in tbc.TabPages)
            {
                string str = ("lsbRespuestas" + (i + 1).ToString());
                ListBox lsb = (ListBox)tp.Controls[0].Controls[str];
                if (lsb.SelectedIndex == -1)
                {
                    completos = false;
                    break;
                }
                i++;
            }
            return completos;
        }

        private void generarBloquesCuestionario(Cuestionario cuest)
        {
            try
            {
                GestorDePuestos clogPuestos = new GestorDePuestos();
                Puesto puesto = clogPuestos.getPuestos(evaluacion.id_puesto);
                List<Competencia> lcomp = new List<Competencia>();
                puesto.Puntaje_Requerido.ToList().ForEach(pr => lcomp.Add(pr.Competencia));
                List<Factor> lfac = new List<Factor>();
                lcomp.ForEach(comp => comp.Factor.ToList().ForEach(fac => lfac.Add(fac)));
                List<Pregunta> preguntas = new List<Pregunta>();

                ItemBloque rel = new ItemBloque();

                foreach (Factor fac in lfac)
                {
                    Random rnd = new Random();
                    int aleatorio = rnd.Next(0, fac.Pregunta.Count - 1);
                    preguntas.Add(fac.Pregunta.ToList()[aleatorio]);
                    int aleatorio1;
                    do
                    {
                        aleatorio1 = rnd.Next(0, fac.Pregunta.Count);
                    }
                    while (aleatorio1 == aleatorio);
                    preguntas.Add(fac.Pregunta.ToList()[aleatorio1]);
                }

                int nroBloque = 0;

                List<Bloque> bloques = new List<Bloque>();

                Bloque bloq = new Bloque();
                bloq.id_cuestionario = cuest.id_cuestionario;
                bloq.num_bloque = nroBloque + 1;
                bloques.Add(bloq);

                int i = 0;

                GestorTablaDeParametros clogTablaPar = new GestorTablaDeParametros();

                int cantidadPreguntasBloque = clogTablaPar.obtenerParametroEntero("PreguntasPorBloque");
                foreach (Pregunta preg in preguntas)
                {
                    if (i < cantidadPreguntasBloque)
                    {
                        ItemBloque resp = new ItemBloque();
                        resp.id_pregunta = preg.id_pregunta;
                        bloques[nroBloque].ItemBloque.Add(resp);
                    }
                    else
                    {
                        i = 0;
                        cuest.Bloque.Add(bloques[nroBloque]);
                        nroBloque++;
                        Bloque bloque = new Bloque();
                        bloque.id_cuestionario = cuest.id_cuestionario;
                        bloque.num_bloque = nroBloque + 1;
                        bloques.Add(bloque);
                    }
                }
                cuest.Bloque = bloques;
                this.agregarBloques(cuest, bloques);
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }


        public Cuestionario empezarCuestionario()
        {
            GestorDeEvaluacion clogEval = new GestorDeEvaluacion();
            GestorDeCandidato clogCand = new GestorDeCandidato();
            GestorDePregunta clogPreg = new GestorDePregunta();
            
            try
            {
                Cuestionario cuest = this.obtenerCuestionario(GestorDeAutenticacion.obtenerCandidatoActual());
                GestorTablaDeParametros clogTablaPar = new GestorTablaDeParametros();

                int tiempoPermitido = clogTablaPar.obtenerParametroEntero("TiempoTotalCuest");
                int cantAccesosMaxima = clogTablaPar.obtenerParametroEntero("CantAccesosMaxima");
                if ((DateTime.Now - cuest.fecha_inicio.Value).TotalSeconds < tiempoPermitido && cuest.cantidad_accesos < cantAccesosMaxima )
                {
                    evaluacion = clogEval.getEvaluaciones(cuest.id_evaluacion.Value);
                    if (this.obtenerUltimoEstado(cuest) == "Activo")
                    {
                        int tiempoActivoPerm = clogTablaPar.obtenerParametroEntero("TiempoEstActivo");
                        if ((DateTime.Now - cuest.fecha_inicio.Value).TotalSeconds < tiempoActivoPerm)
                        {
                            generarBloquesCuestionario(cuest);
                            this.modificarEstado(cuest, "En Proceso");
                        }
                        else
                        {
                            this.modificarEstado(cuest, "Sin Contestar");
                            throw new ExceptionPersonalizada("Se ha excedido el tiempo para el estado Activo del cuestionario");
                        }
                    }

                    this.agregarAcceso(cuest);
                    return cuest;
                }
                else
                {
                    string estadoCuest = this.obtenerUltimoEstado(cuest);
                    if (estadoCuest == "Activo" || estadoCuest == "En Proceso")
                    {
                        this.modificarEstado(cuest, "Incompleto");
                    }
                    string mensaje = "\n";
                    if ((DateTime.Now - cuest.fecha_inicio.Value).TotalSeconds >= tiempoPermitido)
                    {
                        mensaje += "Se ha excedido el tiempo para completar el cuestiopnario.\n";
                    }
                    if (cuest.cantidad_accesos >= cantAccesosMaxima)
                    {
                        mensaje += "Se ha excedido la cantidad de accesos permitidos.\n";
                    }
                    mensaje = mensaje.Remove(mensaje.LastIndexOf('\n'));
                    throw new ExceptionPersonalizada(mensaje);
         
                }
            }
            catch (Exception ex){
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

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
            GestorDeEvaluacion clogEv = new GestorDeEvaluacion();
            try
            {
                clogEv.alta(evaluacion, listaCuest, listaCand);
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
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
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
        public bool verificarCuestionariosActivos(Candidato ca)
        {
            bool tiene;
            CuestionarioDB cdatos = new CuestionarioDB();
            try
            {
                List<Cuestionario> lc = ca.Cuestionario.Where(cu => (cu.Estado_Cuestionario.Where(est => (est.estadoActual == "En Proceso" || est.estadoActual == "Activo") && est.fecha_mod == cu.Estado_Cuestionario.Max(estado => estado.fecha_mod))).Count() > 0).ToList();
                if (lc.Count() == 0)
                {
                    tiene = false;
                    GestorDeAutenticacion.setCandidatoActual(null);
                }
                else
                {
                    tiene = true;
                }
                return tiene;
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }
        }
    }
}
