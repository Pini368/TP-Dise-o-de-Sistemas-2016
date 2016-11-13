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

                RespuestaElegida rel = new RespuestaElegida();

                foreach (Factor fac in lfac)
                {
                    Random rnd = new Random();
                    int aleatorio = rnd.Next(0, (fac.Pregunta.Count - 1));
                    preguntas.Add(fac.Pregunta.ToList()[aleatorio]);
                    int aleatorio1;
                    do
                    {
                        aleatorio1 = rnd.Next(0, (fac.Pregunta.Count - 1));
                    }
                    while (aleatorio1 == aleatorio);
                    preguntas.Add(fac.Pregunta.ToList()[aleatorio1]);
                }

                int nroBloque = 0;

                List<Bloque> bloques = new List<Bloque>();

                Bloque bloq = new Bloque();
                bloq.id_cuestionario = cuest.id_cuestionario;
                bloq.num_bloque = nroBloque+1;
                bloques[nroBloque] = bloq;

                int i = 0;

                int cantidadPreguntasBloque = 3; //Esto es una variable que va a ir en la tabla de parametros

                foreach(Pregunta preg in preguntas)
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
                        bloques[nroBloque] = bloque;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cuestionario_Load(object sender, EventArgs e)
        {

            GestorDeCuestionario clogCuest = new GestorDeCuestionario();

            bloqueAc = 0;

            try
            {
                cuest = clogCuest.obtenerCuestionario(GestorDeAutenticacion.obtenerCandidatoActual());
                if (clogCuest.obtenerUltimoEstado(cuest) == "Activo")
                {
                    generarBloquesCuestionario(cuest);
                }

                Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];

                int nroBloque = bloqueActual.num_bloque;
                nroPregunta = 1;


                lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + nroPregunta.ToString();

                Pregunta pregunta = bloqueActual.RespuestaElegida.ToList()[nroPregunta].Pregunta;

                List<string> listStr = new List<string>();
                listStr = (from re in bloqueActual.RespuestaElegida where re.id_pregunta == pregunta.id_pregunta select re.Respuesta.nombre).ToList();
                //La lista listStr se llena con los nombres de las respuestas posibles a esa pregunta
                cargarRespuestas(lsbRespuestas1, listStr);

                for (int N = 2; N < cuest.Bloque.ToList()[bloqueAc].RespuestaElegida.Count(); N++)
                {
                    listStr = new List<string>();
                    listStr = (from re in cuest.Bloque.ToList()[bloqueAc].RespuestaElegida where re.id_pregunta == pregunta.id_pregunta select re.Respuesta.nombre).ToList();
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
                bloqueAc++;
                Bloque bloqueActual = cuest.Bloque.ToList()[bloqueAc];
                int nroBloque = bloqueActual.num_bloque;
                lblNroBloquePreg.Text = "Bloque Nº " + nroBloque + " Pregunta N° " + nroPregunta.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Se ha producido un error:\n" + ex.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
