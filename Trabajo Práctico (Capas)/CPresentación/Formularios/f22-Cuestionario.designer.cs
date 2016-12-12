namespace Trabajo_práctico
{
    partial class f22Cuestionario
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
            this.components = new System.ComponentModel.Container();
            this.lblNroBloquePreg = new System.Windows.Forms.Label();
            this.pnMovForm = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSigBloque = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnOpciones = new System.Windows.Forms.Panel();
            this.btnAntPregunta = new System.Windows.Forms.Button();
            this.btnSigPregunta = new System.Windows.Forms.Button();
            this.lbTiempoRestante = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbPregunta1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lsbRespuestas1 = new System.Windows.Forms.ListBox();
            this.lbRespuestas = new System.Windows.Forms.Label();
            this.tbcPreguntas = new System.Windows.Forms.TabControl();
            this.tbpPregunta1 = new System.Windows.Forms.TabPage();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.tbTiempoRestante = new System.Windows.Forms.TextBox();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pnMovForm.SuspendLayout();
            this.pnOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tbcPreguntas.SuspendLayout();
            this.tbpPregunta1.SuspendLayout();
            this.pnDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroBloquePreg
            // 
            this.lblNroBloquePreg.AutoSize = true;
            this.lblNroBloquePreg.BackColor = System.Drawing.Color.Transparent;
            this.lblNroBloquePreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroBloquePreg.ForeColor = System.Drawing.Color.White;
            this.lblNroBloquePreg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNroBloquePreg.Location = new System.Drawing.Point(188, 28);
            this.lblNroBloquePreg.Name = "lblNroBloquePreg";
            this.lblNroBloquePreg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNroBloquePreg.Size = new System.Drawing.Size(569, 42);
            this.lblNroBloquePreg.TabIndex = 5;
            this.lblNroBloquePreg.Text = "Bloque Nº XX / Pregunta N° XX";
            // 
            // pnMovForm
            // 
            this.pnMovForm.BackColor = System.Drawing.Color.Transparent;
            this.pnMovForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMovForm.Controls.Add(this.btnCancelar);
            this.pnMovForm.Controls.Add(this.btnSigBloque);
            this.pnMovForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMovForm.Location = new System.Drawing.Point(261, 500);
            this.pnMovForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMovForm.Name = "pnMovForm";
            this.pnMovForm.Size = new System.Drawing.Size(500, 50);
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
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(217, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSigBloque
            // 
            this.btnSigBloque.BackColor = System.Drawing.Color.White;
            this.btnSigBloque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSigBloque.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSigBloque.FlatAppearance.BorderSize = 3;
            this.btnSigBloque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnSigBloque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSigBloque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigBloque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigBloque.Location = new System.Drawing.Point(280, 5);
            this.btnSigBloque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSigBloque.Name = "btnSigBloque";
            this.btnSigBloque.Size = new System.Drawing.Size(217, 39);
            this.btnSigBloque.TabIndex = 0;
            this.btnSigBloque.Text = "Siguiente Bloque";
            this.btnSigBloque.UseVisualStyleBackColor = false;
            this.btnSigBloque.Click += new System.EventHandler(this.btnSigBloque_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnOpciones
            // 
            this.pnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnOpciones.Controls.Add(this.btnAntPregunta);
            this.pnOpciones.Controls.Add(this.btnSigPregunta);
            this.pnOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnOpciones.Location = new System.Drawing.Point(261, 434);
            this.pnOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnOpciones.Name = "pnOpciones";
            this.pnOpciones.Size = new System.Drawing.Size(500, 50);
            this.pnOpciones.TabIndex = 0;
            // 
            // btnAntPregunta
            // 
            this.btnAntPregunta.BackColor = System.Drawing.Color.White;
            this.btnAntPregunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntPregunta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAntPregunta.FlatAppearance.BorderSize = 3;
            this.btnAntPregunta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnAntPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnAntPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntPregunta.Location = new System.Drawing.Point(3, 5);
            this.btnAntPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAntPregunta.Name = "btnAntPregunta";
            this.btnAntPregunta.Size = new System.Drawing.Size(217, 39);
            this.btnAntPregunta.TabIndex = 0;
            this.btnAntPregunta.Text = "Anterior Pregunta";
            this.btnAntPregunta.UseVisualStyleBackColor = false;
            this.btnAntPregunta.Click += new System.EventHandler(this.btnAntPregunta_Click);
            // 
            // btnSigPregunta
            // 
            this.btnSigPregunta.BackColor = System.Drawing.Color.White;
            this.btnSigPregunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSigPregunta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSigPregunta.FlatAppearance.BorderSize = 3;
            this.btnSigPregunta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnSigPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSigPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigPregunta.Location = new System.Drawing.Point(280, 5);
            this.btnSigPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSigPregunta.Name = "btnSigPregunta";
            this.btnSigPregunta.Size = new System.Drawing.Size(217, 39);
            this.btnSigPregunta.TabIndex = 1;
            this.btnSigPregunta.Text = "Siguiente Pregunta";
            this.btnSigPregunta.UseVisualStyleBackColor = false;
            this.btnSigPregunta.Click += new System.EventHandler(this.btnSigPregunta_Click);
            // 
            // lbTiempoRestante
            // 
            this.lbTiempoRestante.AutoSize = true;
            this.lbTiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.lbTiempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempoRestante.Location = new System.Drawing.Point(368, 82);
            this.lbTiempoRestante.Name = "lbTiempoRestante";
            this.lbTiempoRestante.Size = new System.Drawing.Size(168, 25);
            this.lbTiempoRestante.TabIndex = 3;
            this.lbTiempoRestante.Text = "Tiempo restante";
            // 
            // tbPregunta1
            // 
            this.tbPregunta1.Location = new System.Drawing.Point(161, 38);
            this.tbPregunta1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPregunta1.Multiline = true;
            this.tbPregunta1.Name = "tbPregunta1";
            this.tbPregunta1.ReadOnly = true;
            this.tbPregunta1.Size = new System.Drawing.Size(720, 100);
            this.tbPregunta1.TabIndex = 0;
            this.tbPregunta1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(68, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pregunta";
            // 
            // lsbRespuestas1
            // 
            this.lsbRespuestas1.FormattingEnabled = true;
            this.lsbRespuestas1.HorizontalScrollbar = true;
            this.lsbRespuestas1.ItemHeight = 20;
            this.lsbRespuestas1.Location = new System.Drawing.Point(188, 151);
            this.lsbRespuestas1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbRespuestas1.Name = "lsbRespuestas1";
            this.lsbRespuestas1.ScrollAlwaysVisible = true;
            this.lsbRespuestas1.Size = new System.Drawing.Size(693, 104);
            this.lsbRespuestas1.TabIndex = 1;
            this.lsbRespuestas1.TabStop = false;
            this.lsbRespuestas1.SelectedIndexChanged += new System.EventHandler(this.lsbRespuestas1_SelectedIndexChanged);
            // 
            // lbRespuestas
            // 
            this.lbRespuestas.AutoSize = true;
            this.lbRespuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbRespuestas.ForeColor = System.Drawing.Color.White;
            this.lbRespuestas.Location = new System.Drawing.Point(65, 151);
            this.lbRespuestas.Name = "lbRespuestas";
            this.lbRespuestas.Size = new System.Drawing.Size(108, 24);
            this.lbRespuestas.TabIndex = 2;
            this.lbRespuestas.Text = "Respuestas";
            // 
            // tbcPreguntas
            // 
            this.tbcPreguntas.Controls.Add(this.tbpPregunta1);
            this.tbcPreguntas.Location = new System.Drawing.Point(43, 116);
            this.tbcPreguntas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcPreguntas.Name = "tbcPreguntas";
            this.tbcPreguntas.SelectedIndex = 0;
            this.tbcPreguntas.Size = new System.Drawing.Size(928, 318);
            this.tbcPreguntas.TabIndex = 2;
            this.tbcPreguntas.SelectedIndexChanged += new System.EventHandler(this.tbcPreguntas_SelectedIndexChanged);
            // 
            // tbpPregunta1
            // 
            this.tbpPregunta1.Controls.Add(this.pnDatos);
            this.tbpPregunta1.Location = new System.Drawing.Point(4, 25);
            this.tbpPregunta1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpPregunta1.Name = "tbpPregunta1";
            this.tbpPregunta1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpPregunta1.Size = new System.Drawing.Size(920, 289);
            this.tbpPregunta1.TabIndex = 0;
            this.tbpPregunta1.Text = "Pregunta 1";
            this.tbpPregunta1.UseVisualStyleBackColor = true;
            // 
            // pnDatos
            // 
            this.pnDatos.BackColor = System.Drawing.Color.Transparent;
            this.pnDatos.BackgroundImage = global::CPresentación.Properties.Resources.Fondo1;
            this.pnDatos.Controls.Add(this.lbRespuestas);
            this.pnDatos.Controls.Add(this.lsbRespuestas1);
            this.pnDatos.Controls.Add(this.label10);
            this.pnDatos.Controls.Add(this.tbPregunta1);
            this.pnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.pnDatos.ForeColor = System.Drawing.Color.White;
            this.pnDatos.Location = new System.Drawing.Point(3, 2);
            this.pnDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(908, 277);
            this.pnDatos.TabIndex = 0;
            // 
            // tbTiempoRestante
            // 
            this.tbTiempoRestante.Location = new System.Drawing.Point(560, 85);
            this.tbTiempoRestante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTiempoRestante.Name = "tbTiempoRestante";
            this.tbTiempoRestante.ReadOnly = true;
            this.tbTiempoRestante.Size = new System.Drawing.Size(84, 22);
            this.tbTiempoRestante.TabIndex = 4;
            this.tbTiempoRestante.TabStop = false;
            this.tbTiempoRestante.Text = "MM:SS";
            this.tbTiempoRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // f22Cuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPresentación.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(984, 559);
            this.Controls.Add(this.tbTiempoRestante);
            this.Controls.Add(this.tbcPreguntas);
            this.Controls.Add(this.lbTiempoRestante);
            this.Controls.Add(this.pnOpciones);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnMovForm);
            this.Controls.Add(this.lblNroBloquePreg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1002, 606);
            this.MinimumSize = new System.Drawing.Size(1002, 606);
            this.Name = "f22Cuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuestionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f22Cuestionario_FormClosed);
            this.Load += new System.EventHandler(this.Cuestionario_Load);
            this.pnMovForm.ResumeLayout(false);
            this.pnOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tbcPreguntas.ResumeLayout(false);
            this.tbpPregunta1.ResumeLayout(false);
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNroBloquePreg;
        private System.Windows.Forms.Panel pnMovForm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSigBloque;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnOpciones;
        private System.Windows.Forms.Button btnAntPregunta;
        private System.Windows.Forms.Button btnSigPregunta;
        private System.Windows.Forms.Label lbTiempoRestante;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox tbPregunta1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lsbRespuestas1;
        private System.Windows.Forms.Label lbRespuestas;
        private System.Windows.Forms.TabControl tbcPreguntas;
        private System.Windows.Forms.TabPage tbpPregunta1;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.TextBox tbTiempoRestante;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}