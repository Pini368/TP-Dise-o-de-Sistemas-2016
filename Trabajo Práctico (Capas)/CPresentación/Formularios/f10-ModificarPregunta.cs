using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_práctico.Formularios
{
    public partial class f10_ModificarPregunta : Form
    {
        public f10_ModificarPregunta()
        {
            InitializeComponent();
        }

        private void f10_ModificarPregunta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
