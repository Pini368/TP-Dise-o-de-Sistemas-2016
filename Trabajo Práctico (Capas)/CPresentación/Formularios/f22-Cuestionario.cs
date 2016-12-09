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
        private void mostrarBloque(Bloque bloqueActual)
        {
            GestorDePregunta clogPreg = new GestorDePregunta();

            nroPregunta = 0;
            int nroBloque = bloqueActual.num_bloque;

            lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + (nroPregunta + 1).ToString();

            tbcPreguntas.Controls.Clear();

            Pregunta pregunta;

            List<string> listStr = new List<string>();

            for (int N = 0; N < cuest.Bloque.ToList()[bloqueAc].ItemBloque.Count(); N++)
            {
                nroPregunta = N;
                pregunta = clogPreg.getPreguntas(bloqueActual.ItemBloque.ToList()[nroPregunta].id_pregunta);
                listStr = pregunta.OpcionRespuesta.Respuesta.Select(rta => rta.nombre).ToList();
                tbcPreguntas.TabPages.Add(generarPreguntaFormulario(N, listStr, pregunta));
                if (bloqueActual.ItemBloque.ToList()[N].id_respuesta != null)
                {
                    string str = ("lsbRespuestas" + (N + 1).ToString());
                    ListBox lsb = (ListBox)tbcPreguntas.TabPages[N].Controls[0].Controls[str];
                    lsb.SelectedItem = bloqueActual.ItemBloque.ToList()[N].Respuesta.nombre.ToUpper();
                }
            }
        }

        private void Cuestionario_Load(object sender, EventArgs e)
        {
            GestorDeCuestionario clogCuest = new GestorDeCuestionario();

            try
            {
                cuest = clogCuest.empezarCuestionario();
                GestorDeLogProceso clogProc = new GestorDeLogProceso();
                LogProcesos log = new LogProcesos();
                log.id_cuestionario = cuest.id_cuestionario;
                log.fechaHora = DateTime.Now;
                log.accion = "Abierto";
                clogProc.agregarLog(log);
                bloqueAc = clogCuest.obtenerBloqueACargar(cuest);
                Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];
                mostrarBloque(bloqueActual);
                GestorTablaDeParametros clogTablaPar = new GestorTablaDeParametros();
                int tiempoPermitido = clogTablaPar.obtenerParametroEntero("TiempoTotalCuest");
                tbTiempoRestante.Text = ((int)((tiempoPermitido - (int)(DateTime.Now - cuest.fecha_inicio.Value).TotalSeconds) / 60)).ToString() + ":" + ((int)((tiempoPermitido - (int)(DateTime.Now - cuest.fecha_inicio.Value).TotalSeconds) % 60)).ToString();
                Temporizador.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            GestorDeCuestionario clogCuest = new GestorDeCuestionario();
            GestorDeCandidato clogCand = new GestorDeCandidato();
            try
            {
                bloqueAc = clogCuest.siguienteBloque(tbcPreguntas, bloqueAc, cuest);
                cuest = clogCuest.obtenerCuestionario(GestorDeAutenticacion.obtenerCandidatoActual());
                if (bloqueAc < (cuest.Bloque.Count() - 1))
                {
                    bloqueAc++;
                    Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];
                    mostrarBloque(bloqueActual);
                }
                else
                {
                    float puntaje = clogCuest.obtenerPuntajeCuestionario(cuest);
                    clogCuest.terminarCuestionario(cuest);
                    MessageBox.Show("Felicitaciones, usted ha completado el cuestionario\nSu puntaje fue de " + puntaje.ToString() + " puntos", "Cuestionario Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            GestorDeLogProceso clogProc = new GestorDeLogProceso();
            LogProcesos log = new LogProcesos();
            log.id_cuestionario = cuest.id_cuestionario;
            log.fechaHora = DateTime.Now;
            log.accion = "Cerrado";
            clogProc.agregarLog(log);
        }
    }
}
