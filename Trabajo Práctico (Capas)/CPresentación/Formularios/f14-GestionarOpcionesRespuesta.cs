using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_práctico
{
    public partial class f14_GestionarOpcionesRespuesta : Form
    {
        public f14_GestionarOpcionesRespuesta()
        {
            InitializeComponent();
        }

        private void GestionarOpcionesRespuesta_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaOpcionRespuesta aor = new AltaOpcionRespuesta();
            aor.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void f14_GestionarOpcionesRespuesta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}