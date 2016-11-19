using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CLogica.Gestores;

namespace Trabajo_práctico
{
    public partial class f22Cuestionario : Form
    {
        public Evaluacion evaluacion;
        int bloqueAc;
        int nroPregunta;
        Cuestionario cuest;

        public f22Cuestionario(Evaluacion eval)
        {
            InitializeComponent();
            evaluacion = eval;
        }

        public f22Cuestionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void cargarRespuestas(ListBox lsb, List<string> opciones)
        {
            foreach (string str in opciones)
            {
                lsb.Items.Add(str.ToUpper());
            }
        }

        private TabPage generarPreguntaFormulario(int N, List<string> opciones, Pregunta pregunta)
        {
            Label labelPreguntas = new Label();
            labelPreguntas.Text = "Pregunta";
            labelPreguntas.Location = new Point(51, 32);

            Label labelRespuestas = new Label();
            labelRespuestas.Text = "Respuestas";
            labelRespuestas.Location = new Point(49, 123);

            TextBox textoPregunta = new TextBox();
            textoPregunta.Name = "tbPregunta" + (N+1).ToString();
            textoPregunta.CharacterCasing = CharacterCasing.Upper;
            textoPregunta.Text = pregunta.interrogante;
            textoPregunta.Location = new Point(121, 31);
            textoPregunta.Size = new Size(541, 82);
            textoPregunta.Multiline = true;
            textoPregunta.ReadOnly = true;

            ListBox listBoxPregunta = new ListBox();
            listBoxPregunta.Name = "lsbRespuestas" + (N+1).ToString();
            listBoxPregunta.Location = new Point(141, 123);
            listBoxPregunta.Size = new Size(521, 89);
            cargarRespuestas(listBoxPregunta, opciones);

            Panel panelPregunta = new Panel();
            panelPregunta.Name = "pnDatos" + (N+1).ToString();
            panelPregunta.Location = new Point(2, 2);
            panelPregunta.Size = new Size(681, 225);
            panelPregunta.BackgroundImage = CPresentación.Properties.Resources.Fondo1;
            panelPregunta.Font = pnDatos.Font;
            panelPregunta.ForeColor = pnDatos.ForeColor;
            panelPregunta.BackColor = pnDatos.BackColor;
            panelPregunta.Controls.Add(listBoxPregunta);
            panelPregunta.Controls.Add(textoPregunta);
            panelPregunta.Controls.Add(labelPreguntas);
            panelPregunta.Controls.Add(labelRespuestas);


            TabPage tabPagePregunta = new TabPage();
            tabPagePregunta.Text = "Preguntas " + (N+1).ToString();
            tabPagePregunta.Name = "tbpPregunta" + (N+1).ToString();
            tabPagePregunta.Controls.Add(panelPregunta);

            return tabPagePregunta;
        }

        private void generarBloquesCuestionario(Cuestionario cuest)
        {
            try
            {
                GestorDeCuestionario clogCuest = new GestorDeCuestionario();
                GestorDePuestos clogPuestos = new GestorDePuestos();
                Puesto puesto = clogPuestos.getPuestos(evaluacion.id_puesto);
                List<Competencia> lcomp = new List<Competencia>();
                puesto.Puntaje_Requerido.ToList().ForEach(pr => lcomp.Add(pr.Competencia));
                List<Factor> lfac = new List<Factor>();
                lcomp.ForEach(comp => comp.Factor.ToList().ForEach(fac => lfac.Add(fac)));
                List<Pregunta> preguntas = new List<Pregunta>();

                RespuestaElegida rel = new RespuestaElegida();

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
                bloq.num_bloque = nroBloque+1;
                bloques.Add(bloq);

                int i = 0;

                GestorTablaDeParametros clogTablaPar = new GestorTablaDeParametros();

                int cantidadPreguntasBloque = clogTablaPar.obtenerParametroEntero("PreguntasPorBloque");
                foreach (Pregunta preg in preguntas)
                {
                    if (i < cantidadPreguntasBloque)
                    {
                        RespuestaElegida resp = new RespuestaElegida();
                        resp.id_pregunta = preg.id_pregunta;
                        bloques[nroBloque].RespuestaElegida.Add(resp);
                    }
                    else{
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
                clogCuest.agregarBloques(cuest, bloques);
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarBloque(Bloque bloqueActual)
        {
            GestorDePregunta clogPreg = new GestorDePregunta();

            nroPregunta = 0;
            int nroBloque = bloqueActual.num_bloque;

            lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + (nroPregunta + 1).ToString();

            tbcPreguntas.Controls.Clear();

            Pregunta pregunta;

            List<string> listStr = new List<string>();

            for (int N = 0; N < cuest.Bloque.ToList()[bloqueAc].RespuestaElegida.Count(); N++)
            {
                nroPregunta = N;
                pregunta = clogPreg.getPreguntas(bloqueActual.RespuestaElegida.ToList()[nroPregunta].id_pregunta);
                listStr = pregunta.OpcionRespuesta.Respuesta.Select(rta => rta.nombre).ToList();
                tbcPreguntas.TabPages.Add(generarPreguntaFormulario(N, listStr, pregunta));
                if (bloqueActual.RespuestaElegida.ToList()[N].id_respuesta != null)
                {
                    string str = ("lsbRespuestas" + (N + 1).ToString());
                    ListBox lsb = (ListBox)tbcPreguntas.TabPages[N].Controls[0].Controls[str];
                    lsb.SelectedItem = bloqueActual.RespuestaElegida.ToList()[N].Respuesta.nombre.ToUpper();
                }
            }
        }

        private void Cuestionario_Load(object sender, EventArgs e)
        {
            GestorDeCuestionario clogCuest = new GestorDeCuestionario();
            GestorDeEvaluacion clogEval = new GestorDeEvaluacion();
            GestorDeCandidato clogCand = new GestorDeCandidato();
            GestorDePregunta clogPreg = new GestorDePregunta();

            try
            {
                //cuest = clogCuest.obtenerCuestionario(GestorDeAutenticacion.obtenerCandidatoActual());
                cuest = clogCuest.obtenerCuestionario(clogCand.getCandidatos(1));
                if (cuest != null)
                {
                    GestorTablaDeParametros clogTablaPar = new GestorTablaDeParametros();

                    int tiempoPermitido = clogTablaPar.obtenerParametroEntero("TiempoTotalCuest");
                    if ((DateTime.Now - cuest.fecha_inicio).TotalSeconds < tiempoPermitido)
                    {
                        evaluacion = clogEval.getEvaluaciones(cuest.id_evaluacion.Value);
                        if (clogCuest.obtenerUltimoEstado(cuest) == "Activo")
                        {
                            int tiempoActivoPerm = clogTablaPar.obtenerParametroEntero("TiempoEstActivo");
                            if ((DateTime.Now - cuest.fecha_inicio).TotalSeconds < tiempoActivoPerm)
                            {
                                generarBloquesCuestionario(cuest);
                                clogCuest.modificarEstado(cuest, "En Proceso");
                            }
                            else
                            {
                                MessageBox.Show(("Se ha producido un error:\n" + "Se ha excedido el tiempo para el estado Activo del cuestionario"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clogCuest.modificarEstado(cuest, "Sin Contestar");
                                this.Close();
                            }
                        }
                        clogCuest.agregarAcceso(cuest);

                        bloqueAc = clogCuest.obtenerBloqueACargar(cuest);

                        Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];
                        mostrarBloque(bloqueActual);
                        tbTiempoRestante.Text = ((int)((tiempoPermitido - (int)(DateTime.Now - cuest.fecha_inicio).TotalSeconds) / 60)).ToString() + ":" + ((int)((tiempoPermitido - (int)(DateTime.Now - cuest.fecha_inicio).TotalSeconds) % 60)).ToString();
                        Temporizador.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(("Se ha producido un error:\n" + "Se ha excedido el tiempo para completar el cuestiopnario"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string estadoCuest = clogCuest.obtenerUltimoEstado(cuest);
                        if (estadoCuest == "Activo" || estadoCuest == "En Proceso")
                        {
                            clogCuest.modificarEstado(cuest, "Incompleto");
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(("Se ha producido un error:\n" + "No existe ningún cuestionario activo relacionado con el candidato logeado actualmente"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSigPregunta_Click(object sender, EventArgs e)
        {
            if(tbcPreguntas.SelectedIndex < (tbcPreguntas.TabCount - 1))
            {
                nroPregunta += 1;
                Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];
                int nroBloque = bloqueActual.num_bloque;
                tbcPreguntas.SelectedIndex += 1;
                lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + nroPregunta.ToString();
            }
        }

        private void btnAntPregunta_Click(object sender, EventArgs e)
        {
            if (tbcPreguntas.SelectedIndex > 0)
            {
                nroPregunta -= 1;
                Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];
                int nroBloque = bloqueActual.num_bloque;
                tbcPreguntas.SelectedIndex -= 1;
                lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + nroPregunta.ToString();
            }
        }

        private void btnSigBloque_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarRespuestasCompletas())
                {
                    GestorDeRespuesta clogResp = new GestorDeRespuesta();
                    GestorDeBloque clogBloque = new GestorDeBloque();
                    GestorDeCuestionario clogCuest = new GestorDeCuestionario();
                    GestorDeCandidato clogCand = new GestorDeCandidato();
                    int i = 0;
                    Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];
                    foreach (RespuestaElegida re in bloqueActual.RespuestaElegida.ToList())
                    {
                        string str = ("lsbRespuestas" + (i + 1).ToString());
                        ListBox lsb = (ListBox)tbcPreguntas.TabPages[i].Controls[0].Controls[str];
                        Respuesta resp = clogResp.getRespuestas(lsb.SelectedItem.ToString()).First();
                        cuest.Bloque.ToList()[bloqueAc].RespuestaElegida.ToList()[i].id_respuesta = resp.id_respuesta;
                        clogBloque.modificarRespuestaElegida(re, resp.id_respuesta);
                        i++;
                    }
                    //cuest = clogCuest.obtenerCuestionario(GestorDeAutenticacion.obtenerCandidatoActual());
                    cuest = clogCuest.obtenerCuestionario(clogCand.getCandidatos(1));

                    if (bloqueAc < (cuest.Bloque.Count() - 1))
                    {
                        bloqueAc++;
                        bloqueActual = cuest.Bloque.ToList()[bloqueAc];
                        mostrarBloque(bloqueActual);
                    }
                    else
                    {
                        float puntaje = clogCuest.obtenerPuntajeCuestionario(cuest);
                        clogCuest.modificarEstado(cuest, "Completado");
                        MessageBox.Show("Felicitaciones, usted ha completado el cuestionario\nSu puntaje fue de " + puntaje.ToString() + " puntos", "Cuestionario completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe responder a todas las preguntas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool verificarRespuestasCompletas()
        {
            bool completos = true;
            int i = 0;
            foreach(TabPage tp in tbcPreguntas.TabPages)
            {
                string str = ("lsbRespuestas" + (i + 1).ToString());
                ListBox lsb = (ListBox) tp.Controls[0].Controls[str];
                if(lsb.SelectedIndex == -1)
                {
                    completos = false;
                    break;
                }
                i++;
            }
            return completos;
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            string[] tiempo = tbTiempoRestante.Text.Split(':');
            if (Int32.Parse(tiempo[0]) * 60 + Int32.Parse(tiempo[1]) - 1 > 0)
            {
                string tiempo2 = ((int)((Int32.Parse(tiempo[0]) * 60 + Int32.Parse(tiempo[1]) - 1) / 60)).ToString() + ":" + ((int)((Int32.Parse(tiempo[0]) * 60 + Int32.Parse(tiempo[1]) - 1) % 60)).ToString();
                tbTiempoRestante.Text = tiempo2;
            }
            else
            {
                Temporizador.Enabled = false;
                GestorDeCuestionario clogCuest = new GestorDeCuestionario();
                MessageBox.Show(("Se ha producido un error:\n" + "Se ha excedido el tiempo para completar el cuestiopnario"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clogCuest.modificarEstado(cuest, "Incompleto");
                this.Close();
            }
        }

        private void tbcPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbcPreguntas.SelectedIndex == -1)
            {
                nroPregunta = 1;
            }
            else
            {
                nroPregunta = tbcPreguntas.SelectedIndex + 1;
            }
            Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];
            int nroBloque = bloqueActual.num_bloque;
            lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + nroPregunta.ToString();
        }

        private void f22Cuestionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
