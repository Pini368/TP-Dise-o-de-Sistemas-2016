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
    public partial class f20_OrdenDeMérito : Form
    {
        public f20_OrdenDeMérito()
        {
            InitializeComponent();
            p_com_all.Size = new Size(675, 275);
            p_com_apr.Size = p_com_all.Size;
            p_com_apr.Location = p_com_all.Location;
            p_com_desapr.Size = p_com_all.Size;
            p_com_desapr.Location = p_com_all.Location;
            p_incomp.Size = p_com_all.Size;
            p_incomp.Location = p_com_all.Location;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeMérito_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Que vas a imprimir?... Si seguro ni impresora tenés");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p_com_all.Visible = false;
            p_com_apr.Visible = true;
            p_com_desapr.Visible = false;
            p_incomp.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p_com_all.Visible = false;
            p_com_apr.Visible = false;
            p_com_desapr.Visible = false;
            p_incomp.Visible = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void p_com_apr_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            p_com_all.Visible = false;
            p_com_apr.Visible = false;
            p_com_desapr.Visible = true;
            p_incomp.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            p_com_all.Visible = true;
            p_com_apr.Visible = false;
            p_com_desapr.Visible = false;
            p_incomp.Visible = false;
        }
    }
}
