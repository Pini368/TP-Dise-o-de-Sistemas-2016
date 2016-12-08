using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLogica.Gestores;
using CEntidades;

namespace Trabajo_práctico
{
    public partial class f21_CuestionarioInstrucciones : Form
    {
        public f21_CuestionarioInstrucciones()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f22Cuestionario cu = new f22Cuestionario();
            cu.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void f21_CuestionarioInstrucciones_Load(object sender, EventArgs e)
        {
            GestorTablaDeParametros clogTablaPar = new GestorTablaDeParametros();
            string instrucciones = clogTablaPar.obtenerParametroString("InstruccionesCuest");
            //Hace un salto de línea en las instrucciones cada vez que aparezca el caracter |
            string[] instruccionesArr = instrucciones.Split('|');
            instrucciones = "";
            foreach(string str in instruccionesArr)
            {
                instrucciones += str + '\r' + '\n';
            }
            tbInstrucciones.Text = instrucciones;
        }

        private void f21_CuestionarioInstrucciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
