﻿using System;
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
    public partial class f18_EvaluacionesPuesto : Form
    {
        public f18_EvaluacionesPuesto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f19_EmitirOrdenDeMerito eOm = new f19_EmitirOrdenDeMerito();
            eOm.Show(this);
        }

        private void evaluacionesPuesto_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            f19_EmitirOrdenDeMerito eOm = new f19_EmitirOrdenDeMerito();
            eOm.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void f18_EvaluacionesPuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
