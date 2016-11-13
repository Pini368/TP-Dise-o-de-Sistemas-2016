namespace Trabajo_práctico
{
    partial class f16_GenResultados
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
            Owner.Show();
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnOpciones = new System.Windows.Forms.Panel();
            this.btnEmitirOrdenMerito = new System.Windows.Forms.Button();
            this.btnReporteComparativo = new System.Windows.Forms.Button();
            this.btnExportarResultados = new System.Windows.Forms.Button();
            this.pnMovForm = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnOpciones.SuspendLayout();
            this.pnMovForm.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(229, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(294, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generar Resultados";
            // 
            // pnOpciones
            // 
            this.pnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnOpciones.BackgroundImage = global::CPresentación.Properties.Resources.Fondo1;
            this.pnOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnOpciones.Controls.Add(this.btnEmitirOrdenMerito);
            this.pnOpciones.Controls.Add(this.btnReporteComparativo);
            this.pnOpciones.Controls.Add(this.btnExportarResultados);
            this.pnOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnOpciones.Location = new System.Drawing.Point(60, 112);
            this.pnOpciones.Margin = new System.Windows.Forms.Padding(0);
            this.pnOpciones.Name = "pnOpciones";
            this.pnOpciones.Size = new System.Drawing.Size(618, 188);
            this.pnOpciones.TabIndex = 0;
            // 
            // btnEmitirOrdenMerito
            // 
            this.btnEmitirOrdenMerito.BackColor = System.Drawing.Color.White;
            this.btnEmitirOrdenMerito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmitirOrdenMerito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmitirOrdenMerito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnEmitirOrdenMerito.FlatAppearance.BorderSize = 3;
            this.btnEmitirOrdenMerito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnEmitirOrdenMerito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnEmitirOrdenMerito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirOrdenMerito.Location = new System.Drawing.Point(209, 120);
            this.btnEmitirOrdenMerito.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmitirOrdenMerito.Name = "btnEmitirOrdenMerito";
            this.btnEmitirOrdenMerito.Size = new System.Drawing.Size(195, 53);
            this.btnEmitirOrdenMerito.TabIndex = 2;
            this.btnEmitirOrdenMerito.Text = "Emitir Orden de Mérito";
            this.btnEmitirOrdenMerito.UseVisualStyleBackColor = false;
            this.btnEmitirOrdenMerito.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnReporteComparativo
            // 
            this.btnReporteComparativo.BackColor = System.Drawing.Color.White;
            this.btnReporteComparativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReporteComparativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteComparativo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnReporteComparativo.FlatAppearance.BorderSize = 3;
            this.btnReporteComparativo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnReporteComparativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnReporteComparativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteComparativo.Location = new System.Drawing.Point(335, 20);
            this.btnReporteComparativo.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteComparativo.Name = "btnReporteComparativo";
            this.btnReporteComparativo.Size = new System.Drawing.Size(195, 53);
            this.btnReporteComparativo.TabIndex = 1;
            this.btnReporteComparativo.Text = "Emitir Reporte Comparativo";
            this.btnReporteComparativo.UseVisualStyleBackColor = false;
            this.btnReporteComparativo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExportarResultados
            // 
            this.btnExportarResultados.BackColor = System.Drawing.Color.White;
            this.btnExportarResultados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportarResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarResultados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExportarResultados.FlatAppearance.BorderSize = 3;
            this.btnExportarResultados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnExportarResultados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnExportarResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarResultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExportarResultados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportarResultados.Location = new System.Drawing.Point(88, 20);
            this.btnExportarResultados.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarResultados.Name = "btnExportarResultados";
            this.btnExportarResultados.Size = new System.Drawing.Size(195, 53);
            this.btnExportarResultados.TabIndex = 0;
            this.btnExportarResultados.Text = "Exportar Resultados";
            this.btnExportarResultados.UseVisualStyleBackColor = false;
            this.btnExportarResultados.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnMovForm
            // 
            this.pnMovForm.BackColor = System.Drawing.Color.Transparent;
            this.pnMovForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMovForm.Controls.Add(this.btnSalir);
            this.pnMovForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMovForm.Location = new System.Drawing.Point(11, 404);
            this.pnMovForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnMovForm.Name = "pnMovForm";
            this.pnMovForm.Size = new System.Drawing.Size(91, 41);
            this.pnMovForm.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(2, 4);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 32);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
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
            // f16_GenResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.BackgroundImage = global::CPresentación.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(740, 462);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnMovForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnOpciones);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(756, 501);
            this.MinimumSize = new System.Drawing.Size(756, 501);
            this.Name = "f16_GenResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Resultados";
            this.pnOpciones.ResumeLayout(false);
            this.pnMovForm.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnOpciones;
        private System.Windows.Forms.Button btnEmitirOrdenMerito;
        private System.Windows.Forms.Button btnReporteComparativo;
        private System.Windows.Forms.Button btnExportarResultados;
        private System.Windows.Forms.Panel pnMovForm;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
    }
}