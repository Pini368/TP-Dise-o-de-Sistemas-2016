namespace Trabajo_práctico.Formularios
{
    partial class f9_NuevaPregunta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.dgvOpcionesRespuestas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOpcionesRespuestas = new System.Windows.Forms.ComboBox();
            this.cmbFactores = new System.Windows.Forms.ComboBox();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescripcionPregunta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInterrogantePregunta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombrePregunta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMovForm = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcionesRespuestas)).BeginInit();
            this.pnMovForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarProgramaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.archivoToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cerrarProgramaToolStripMenuItem.Text = "Cerrar programa";
            // 
            // pnDatos
            // 
            this.pnDatos.BackColor = System.Drawing.Color.Transparent;
            this.pnDatos.BackgroundImage = global::CPresentación.Properties.Resources.Fondo1;
            this.pnDatos.Controls.Add(this.dgvOpcionesRespuestas);
            this.pnDatos.Controls.Add(this.cmbOpcionesRespuestas);
            this.pnDatos.Controls.Add(this.cmbFactores);
            this.pnDatos.Controls.Add(this.cmbCompetencias);
            this.pnDatos.Controls.Add(this.label7);
            this.pnDatos.Controls.Add(this.tbDescripcionPregunta);
            this.pnDatos.Controls.Add(this.label3);
            this.pnDatos.Controls.Add(this.tbInterrogantePregunta);
            this.pnDatos.Controls.Add(this.label11);
            this.pnDatos.Controls.Add(this.label5);
            this.pnDatos.Controls.Add(this.tbNombrePregunta);
            this.pnDatos.Controls.Add(this.label6);
            this.pnDatos.Controls.Add(this.label10);
            this.pnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.pnDatos.Location = new System.Drawing.Point(84, 106);
            this.pnDatos.Margin = new System.Windows.Forms.Padding(2);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(600, 246);
            this.pnDatos.TabIndex = 0;
            // 
            // dgvOpcionesRespuestas
            // 
            this.dgvOpcionesRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpcionesRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvOpcionesRespuestas.Location = new System.Drawing.Point(227, 165);
            this.dgvOpcionesRespuestas.Name = "dgvOpcionesRespuestas";
            this.dgvOpcionesRespuestas.Size = new System.Drawing.Size(322, 75);
            this.dgvOpcionesRespuestas.TabIndex = 6;
            this.dgvOpcionesRespuestas.TabStop = false;
            this.dgvOpcionesRespuestas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Orden";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Ponderacion";
            this.Column3.Name = "Column3";
            // 
            // cmbOpcionesRespuestas
            // 
            this.cmbOpcionesRespuestas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbOpcionesRespuestas.FormattingEnabled = true;
            this.cmbOpcionesRespuestas.Location = new System.Drawing.Point(71, 196);
            this.cmbOpcionesRespuestas.Name = "cmbOpcionesRespuestas";
            this.cmbOpcionesRespuestas.Size = new System.Drawing.Size(140, 25);
            this.cmbOpcionesRespuestas.TabIndex = 5;
            this.cmbOpcionesRespuestas.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cmbFactores
            // 
            this.cmbFactores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbFactores.FormattingEnabled = true;
            this.cmbFactores.Location = new System.Drawing.Point(120, 30);
            this.cmbFactores.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFactores.Name = "cmbFactores";
            this.cmbFactores.Size = new System.Drawing.Size(429, 25);
            this.cmbFactores.TabIndex = 1;
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(164, 6);
            this.cmbCompetencias.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(385, 25);
            this.cmbCompetencias.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(68, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Opción de respuesta";
            // 
            // tbDescripcionPregunta
            // 
            this.tbDescripcionPregunta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbDescripcionPregunta.Location = new System.Drawing.Point(155, 120);
            this.tbDescripcionPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescripcionPregunta.Multiline = true;
            this.tbDescripcionPregunta.Name = "tbDescripcionPregunta";
            this.tbDescripcionPregunta.Size = new System.Drawing.Size(394, 40);
            this.tbDescripcionPregunta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripción";
            // 
            // tbInterrogantePregunta
            // 
            this.tbInterrogantePregunta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbInterrogantePregunta.Location = new System.Drawing.Point(137, 79);
            this.tbInterrogantePregunta.Margin = new System.Windows.Forms.Padding(2);
            this.tbInterrogantePregunta.Multiline = true;
            this.tbInterrogantePregunta.Name = "tbInterrogantePregunta";
            this.tbInterrogantePregunta.Size = new System.Drawing.Size(412, 40);
            this.tbInterrogantePregunta.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(68, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Pregunta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre de pregunta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbNombrePregunta
            // 
            this.tbNombrePregunta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbNombrePregunta.Location = new System.Drawing.Point(212, 55);
            this.tbNombrePregunta.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombrePregunta.Name = "tbNombrePregunta";
            this.tbNombrePregunta.Size = new System.Drawing.Size(337, 23);
            this.tbNombrePregunta.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Competencia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(68, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Factor";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(263, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(238, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva Pregunta";
            // 
            // pnMovForm
            // 
            this.pnMovForm.BackColor = System.Drawing.Color.Transparent;
            this.pnMovForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMovForm.Controls.Add(this.btnCancelar);
            this.pnMovForm.Controls.Add(this.btnAceptar);
            this.pnMovForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMovForm.Location = new System.Drawing.Point(188, 398);
            this.pnMovForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnMovForm.Name = "pnMovForm";
            this.pnMovForm.Size = new System.Drawing.Size(375, 41);
            this.pnMovForm.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(52, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 32);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAceptar.FlatAppearance.BorderSize = 3;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(210, 4);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 32);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // f9_NuevaPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.BackgroundImage = global::CPresentación.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(736, 453);
            this.Controls.Add(this.pnMovForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnDatos);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(752, 492);
            this.MinimumSize = new System.Drawing.Size(752, 492);
            this.Name = "f9_NuevaPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f9_NuevaPregunta_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcionesRespuestas)).EndInit();
            this.pnMovForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNombrePregunta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFactores;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescripcionPregunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInterrogantePregunta;
        private System.Windows.Forms.Panel pnMovForm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvOpcionesRespuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cmbOpcionesRespuestas;
    }
}