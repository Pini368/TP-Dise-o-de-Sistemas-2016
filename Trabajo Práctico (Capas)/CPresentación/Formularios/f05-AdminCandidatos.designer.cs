﻿namespace Trabajo_práctico
{
    partial class f5_AdminCandidatos
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
            this.pnOpciones = new System.Windows.Forms.Panel();
            this.btnGesCandidatos = new System.Windows.Forms.Button();
            this.btnImportarCandidatos = new System.Windows.Forms.Button();
            this.btnEvaluarCandidatos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NºCandidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCandidatosAEvaluar = new System.Windows.Forms.DataGridView();
            this.c_apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_n_candidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.tbNroCandidato = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panel_EC = new System.Windows.Forms.Panel();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.pnOpciones.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatosAEvaluar)).BeginInit();
            this.pnDatos.SuspendLayout();
            this.panel_EC.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnOpciones
            // 
            this.pnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnOpciones.BackgroundImage = global::CPresentación.Properties.Resources.Fondo1;
            this.pnOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOpciones.Controls.Add(this.btnGesCandidatos);
            this.pnOpciones.Controls.Add(this.btnImportarCandidatos);
            this.pnOpciones.Controls.Add(this.btnEvaluarCandidatos);
            this.pnOpciones.Controls.Add(this.btnVolver);
            this.pnOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnOpciones.Location = new System.Drawing.Point(12, 31);
            this.pnOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnOpciones.Name = "pnOpciones";
            this.pnOpciones.Size = new System.Drawing.Size(199, 510);
            this.pnOpciones.TabIndex = 0;
            // 
            // btnGesCandidatos
            // 
            this.btnGesCandidatos.BackColor = System.Drawing.Color.White;
            this.btnGesCandidatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGesCandidatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGesCandidatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGesCandidatos.FlatAppearance.BorderSize = 3;
            this.btnGesCandidatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnGesCandidatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnGesCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGesCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesCandidatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGesCandidatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGesCandidatos.Location = new System.Drawing.Point(3, 95);
            this.btnGesCandidatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGesCandidatos.Name = "btnGesCandidatos";
            this.btnGesCandidatos.Size = new System.Drawing.Size(191, 65);
            this.btnGesCandidatos.TabIndex = 0;
            this.btnGesCandidatos.Text = "Gestionar\r\nCandidatos";
            this.btnGesCandidatos.UseVisualStyleBackColor = false;
            this.btnGesCandidatos.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnImportarCandidatos
            // 
            this.btnImportarCandidatos.BackColor = System.Drawing.Color.White;
            this.btnImportarCandidatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImportarCandidatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarCandidatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnImportarCandidatos.FlatAppearance.BorderSize = 3;
            this.btnImportarCandidatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnImportarCandidatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnImportarCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarCandidatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImportarCandidatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportarCandidatos.Location = new System.Drawing.Point(4, 225);
            this.btnImportarCandidatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportarCandidatos.Name = "btnImportarCandidatos";
            this.btnImportarCandidatos.Size = new System.Drawing.Size(191, 65);
            this.btnImportarCandidatos.TabIndex = 1;
            this.btnImportarCandidatos.Text = "Importar \r\nCandidatos";
            this.btnImportarCandidatos.UseVisualStyleBackColor = false;
            this.btnImportarCandidatos.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnEvaluarCandidatos
            // 
            this.btnEvaluarCandidatos.BackColor = System.Drawing.Color.White;
            this.btnEvaluarCandidatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEvaluarCandidatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvaluarCandidatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnEvaluarCandidatos.FlatAppearance.BorderSize = 3;
            this.btnEvaluarCandidatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnEvaluarCandidatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnEvaluarCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluarCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluarCandidatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEvaluarCandidatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEvaluarCandidatos.Location = new System.Drawing.Point(4, 353);
            this.btnEvaluarCandidatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvaluarCandidatos.Name = "btnEvaluarCandidatos";
            this.btnEvaluarCandidatos.Size = new System.Drawing.Size(191, 65);
            this.btnEvaluarCandidatos.TabIndex = 2;
            this.btnEvaluarCandidatos.Text = "Evaluar \r\nCandidatos";
            this.btnEvaluarCandidatos.UseVisualStyleBackColor = false;
            this.btnEvaluarCandidatos.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnVolver.FlatAppearance.BorderSize = 3;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(27, 465);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(149, 39);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(979, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarProgramaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.archivoToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.cerrarProgramaToolStripMenuItem.Text = "Cerrar programa";
            this.cerrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.cerrarProgramaToolStripMenuItem_Click);
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.AllowUserToDeleteRows = false;
            this.dgvCandidatos.AllowUserToResizeRows = false;
            this.dgvCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.NºCandidato});
            this.dgvCandidatos.Location = new System.Drawing.Point(3, 194);
            this.dgvCandidatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCandidatos.MultiSelect = false;
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.RowTemplate.Height = 24;
            this.dgvCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatos.Size = new System.Drawing.Size(721, 100);
            this.dgvCandidatos.TabIndex = 5;
            this.dgvCandidatos.TabStop = false;
            this.dgvCandidatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // NºCandidato
            // 
            this.NºCandidato.HeaderText = "Nº Candidato";
            this.NºCandidato.Name = "NºCandidato";
            this.NºCandidato.ReadOnly = true;
            // 
            // dgvCandidatosAEvaluar
            // 
            this.dgvCandidatosAEvaluar.AllowUserToAddRows = false;
            this.dgvCandidatosAEvaluar.AllowUserToDeleteRows = false;
            this.dgvCandidatosAEvaluar.AllowUserToResizeRows = false;
            this.dgvCandidatosAEvaluar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatosAEvaluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatosAEvaluar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_apellido2,
            this.c_nombre2,
            this.c_n_candidato});
            this.dgvCandidatosAEvaluar.Location = new System.Drawing.Point(3, 340);
            this.dgvCandidatosAEvaluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCandidatosAEvaluar.MultiSelect = false;
            this.dgvCandidatosAEvaluar.Name = "dgvCandidatosAEvaluar";
            this.dgvCandidatosAEvaluar.ReadOnly = true;
            this.dgvCandidatosAEvaluar.RowTemplate.Height = 24;
            this.dgvCandidatosAEvaluar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatosAEvaluar.Size = new System.Drawing.Size(721, 100);
            this.dgvCandidatosAEvaluar.TabIndex = 4;
            this.dgvCandidatosAEvaluar.TabStop = false;
            // 
            // c_apellido2
            // 
            this.c_apellido2.HeaderText = "Apellido";
            this.c_apellido2.Name = "c_apellido2";
            this.c_apellido2.ReadOnly = true;
            // 
            // c_nombre2
            // 
            this.c_nombre2.HeaderText = "Nombre";
            this.c_nombre2.Name = "c_nombre2";
            this.c_nombre2.ReadOnly = true;
            // 
            // c_n_candidato
            // 
            this.c_n_candidato.HeaderText = "Nº Candidato";
            this.c_n_candidato.Name = "c_n_candidato";
            this.c_n_candidato.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Candidatos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Candidatos a evaluar";
            // 
            // pnDatos
            // 
            this.pnDatos.BackColor = System.Drawing.Color.Transparent;
            this.pnDatos.BackgroundImage = global::CPresentación.Properties.Resources.Fondo1;
            this.pnDatos.Controls.Add(this.tbNroCandidato);
            this.pnDatos.Controls.Add(this.tbNombre);
            this.pnDatos.Controls.Add(this.tbApellido);
            this.pnDatos.Controls.Add(this.label7);
            this.pnDatos.Controls.Add(this.label8);
            this.pnDatos.Controls.Add(this.label9);
            this.pnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.pnDatos.Location = new System.Drawing.Point(3, 60);
            this.pnDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(741, 105);
            this.pnDatos.TabIndex = 0;
            // 
            // tbNroCandidato
            // 
            this.tbNroCandidato.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbNroCandidato.Location = new System.Drawing.Point(277, 70);
            this.tbNroCandidato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNroCandidato.MaxLength = 8;
            this.tbNroCandidato.Name = "tbNroCandidato";
            this.tbNroCandidato.Size = new System.Drawing.Size(337, 27);
            this.tbNroCandidato.TabIndex = 2;
            this.tbNroCandidato.TextChanged += new System.EventHandler(this.tbNroCandidato_TextChanged);
            this.tbNroCandidato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroCandidato_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbNombre.Location = new System.Drawing.Point(243, 37);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.MaxLength = 30;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(372, 27);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbApellido
            // 
            this.tbApellido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbApellido.Location = new System.Drawing.Point(243, 6);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbApellido.MaxLength = 30;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(372, 27);
            this.tbApellido.TabIndex = 0;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(155, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "N° candidato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(157, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(157, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(172, 5);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(363, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Evaluar Candidatos";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.White;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 3;
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(573, 453);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(149, 39);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel_EC
            // 
            this.panel_EC.BackColor = System.Drawing.Color.Transparent;
            this.panel_EC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_EC.Controls.Add(this.btnBajar);
            this.panel_EC.Controls.Add(this.btnSubir);
            this.panel_EC.Controls.Add(this.btnSiguiente);
            this.panel_EC.Controls.Add(this.label2);
            this.panel_EC.Controls.Add(this.pnDatos);
            this.panel_EC.Controls.Add(this.label6);
            this.panel_EC.Controls.Add(this.label3);
            this.panel_EC.Controls.Add(this.dgvCandidatosAEvaluar);
            this.panel_EC.Controls.Add(this.dgvCandidatos);
            this.panel_EC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.panel_EC.Location = new System.Drawing.Point(219, 31);
            this.panel_EC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_EC.Name = "panel_EC";
            this.panel_EC.Size = new System.Drawing.Size(751, 510);
            this.panel_EC.TabIndex = 1;
            this.panel_EC.Visible = false;
            // 
            // btnBajar
            // 
            this.btnBajar.BackColor = System.Drawing.Color.White;
            this.btnBajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnBajar.FlatAppearance.BorderSize = 3;
            this.btnBajar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnBajar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnBajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBajar.Location = new System.Drawing.Point(320, 298);
            this.btnBajar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(40, 39);
            this.btnBajar.TabIndex = 1;
            this.btnBajar.Text = "↓";
            this.btnBajar.UseVisualStyleBackColor = false;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.White;
            this.btnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSubir.FlatAppearance.BorderSize = 3;
            this.btnSubir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnSubir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSubir.Location = new System.Drawing.Point(429, 298);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(40, 39);
            this.btnSubir.TabIndex = 2;
            this.btnSubir.Text = "↑";
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // f5_AdminCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.BackgroundImage = global::CPresentación.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(979, 548);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_EC);
            this.Controls.Add(this.pnOpciones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(997, 595);
            this.MinimumSize = new System.Drawing.Size(997, 595);
            this.Name = "f5_AdminCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de candidatos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f5_AdminCandidatos_FormClosed);
            this.Load += new System.EventHandler(this.f5_AdminCandidatos_Load);
            this.VisibleChanged += new System.EventHandler(this.f5_AdminCandidatos_VisibleChanged);
            this.pnOpciones.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatosAEvaluar)).EndInit();
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            this.panel_EC.ResumeLayout(false);
            this.panel_EC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnOpciones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEvaluarCandidatos;
        private System.Windows.Forms.Button btnImportarCandidatos;
        private System.Windows.Forms.Button btnGesCandidatos;
        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.DataGridView dgvCandidatosAEvaluar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.TextBox tbNroCandidato;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panel_EC;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NºCandidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_n_candidato;
    }
}