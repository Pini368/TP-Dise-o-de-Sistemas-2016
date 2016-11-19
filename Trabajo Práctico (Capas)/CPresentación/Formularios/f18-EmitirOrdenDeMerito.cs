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
    public partial class f19_EmitirOrdenDeMerito : Form
    {
        public f19_EmitirOrdenDeMerito()
        {
            InitializeComponent();
        }

        private void emitirOrdenDeMerito_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f20_OrdenDeMérito odm = new f20_OrdenDeMérito();
            odm.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f20_OrdenDeMérito Om = new f20_OrdenDeMérito();
            Om.Show(Owner);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void f19_EmitirOrdenDeMerito_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
