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
    public partial class f17_EmitirRepComparativo : Form
    {
        public f17_EmitirRepComparativo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //reporteComparativo rpC = new reporteComparativo();
           // rpC.Show(this);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emitirOrdenComparativa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //reporteComparativo rpC = new reporteComparativo();
            // rpC.Show(this);
        }

        private void f17_EmitirRepComparativo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
