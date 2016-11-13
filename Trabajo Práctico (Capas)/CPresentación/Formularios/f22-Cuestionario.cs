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

        private int nroBloque;
        private int nroPregunta;
        private int bloqueAc;
        List<Bloque> bloquesCuest;

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
                lsb.Items.Add(str);
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
            textoPregunta.Name = "tbPregunta" + N.ToString();
            textoPregunta.Text = pregunta.interrogante;
            textoPregunta.Location = new Point(121, 31);
            textoPregunta.Size = new Size(541, 82);
            textoPregunta.Multiline = true;
            textoPregunta.ReadOnly = true;

            ListBox listBoxPregunta = new ListBox();
            listBoxPregunta.Name = "lsbRespuestas" + N.ToString();
            listBoxPregunta.Location = new Point(141, 123);
            listBoxPregunta.Size = new Size(521, 89);
            cargarRespuestas(listBoxPregunta, opciones);

            Panel panelPregunta = new Panel();
            panelPregunta.Name = "pnDatos" + N.ToString();
            panelPregunta.Location = new Point(2, 2);
            panelPregunta.Size = new Size(681, 225);
            panelPregunta.BackgroundImage = CPresentación.Properties.Resources.Fondo1;
            panelPregunta.Font = pnDatos.Font;
            panelPregunta.ForeColor = pnDatos.ForeColor;
            panelPregunta.BackColor = pnDatos.BackColor;
            panelPregunta.Controls.Add(textoPregunta);
            panelPregunta.Controls.Add(listBoxPregunta);
            panelPregunta.Controls.Add(labelPreguntas);
            panelPregunta.Controls.Add(labelRespuestas);


            TabPage tabPagePregunta = new TabPage();
            tabPagePregunta.Text = "Preguntas " + N.ToString();
            tabPagePregunta.Name = "tbpPregunta" + N.ToString();
            tabPagePregunta.Controls.Add(panelPregunta);

            return tabPagePregunta;
        }

        private Cuestionario generarCuestionario()
        {
            GestorDeCuestionario clogCuest = new GestorDeCuestionario();
            Cuestionario cuest = new Cuestionario();

            Evaluacion eval = new Evaluacion(); //Cambiar esto para que sea la evaluacion que se esta evaluando actualmente

            try
            {
                cuest.id_evaluacion = eval.id_evaluacion;
                cuest.cantidad_accesos = 0;
                cuest.nroCandidato = GestorDeAutenticacion.obtenerCandidatoActual().nroCandidato;
                cuest.fecha_inicio = DateTime.Now;
                cuest.ultimo_acceso = DateTime.Now;
                clogCuest.generarCuestionario(cuest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cuest;
        }

        private void Cuestionario_Load(object sender, EventArgs e)
        {

            GestorDeCuestionario clogCuest = new GestorDeCuestionario();

            bloqueAc = 0;

            try
            {
                Cuestionario cuest = generarCuestionario();

                bloquesCuest = cuest.Bloque.ToList();
                Bloque bloqueActual = bloquesCuest[bloqueAc];

                nroBloque = bloqueActual.num_bloque;
                nroPregunta = 1;


                lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + nroPregunta.ToString();

                Pregunta pregunta = bloqueActual.RespuestaElegida.ToList()[nroPregunta].Pregunta;

                List<string> listStr = new List<string>();
                listStr = (from re in bloqueActual.RespuestaElegida where re.id_pregunta == pregunta.id_pregunta select re.Respuesta.nombre).ToList();
                //La lista listStr se llena con los nombres de las respuestas posibles a esa pregunta
                cargarRespuestas(lsbRespuestas1, listStr);

                for (int N = 2; N < bloquesCuest[bloqueAc].RespuestaElegida.Count(); N++)
                {
                    listStr = new List<string>();
                    listStr = (from re in bloquesCuest[bloqueAc].RespuestaElegida where re.id_pregunta == pregunta.id_pregunta select re.Respuesta.nombre).ToList();
                    //La lista listStr se llena con los nombres de las respuestas posibles a esa pregunta
                    tbcPreguntas.TabPages.Add(generarPreguntaFormulario(N, listStr, pregunta));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSigPregunta_Click(object sender, EventArgs e)
        {
            if(tbcPreguntas.SelectedIndex < (tbcPreguntas.TabCount - 1))
            {
                nroPregunta += 1;
                tbcPreguntas.SelectedIndex += 1;
                lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + nroPregunta.ToString();
            }
        }

        private void btnAntPregunta_Click(object sender, EventArgs e)
        {
            if (tbcPreguntas.SelectedIndex > 0)
            {
                nroPregunta -= 1;
                tbcPreguntas.SelectedIndex -= 1;
                lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + nroPregunta.ToString();
            }
        }

        private void btnSigBloque_Click(object sender, EventArgs e)
        {
            try
            {
                bloqueAc += 1;
                Bloque bloqueActual = bloquesCuest[bloqueAc];
                nroBloque = bloqueActual.num_bloque;
                lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + nroPregunta.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
