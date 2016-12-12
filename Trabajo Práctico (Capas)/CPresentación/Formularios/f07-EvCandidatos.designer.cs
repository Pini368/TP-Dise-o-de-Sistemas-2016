namespace Trabajo_práctico
{
    partial class f7_EvCandidatos
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pnMovForm = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.pnMovForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(980, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // pnMovForm
            // 
            this.pnMovForm.BackColor = System.Drawing.Color.Transparent;
            this.pnMovForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMovForm.Controls.Add(this.btnCancelar);
            this.pnMovForm.Controls.Add(this.btnFinalizar);
            this.pnMovForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMovForm.Location = new System.Drawing.Point(251, 491);
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
            this.btnCancelar.Location = new System.Drawing.Point(69, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 3;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(280, 5);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(149, 39);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(251, 34);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(470, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Evaluación de candidatos";
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.AllowUserToDeleteRows = false;
            this.dgvCandidatos.AllowUserToResizeRows = false;
            this.dgvCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Location = new System.Drawing.Point(51, 80);
            this.dgvCandidatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCandidatos.MultiSelect = false;
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.RowTemplate.Height = 24;
            this.dgvCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatos.Size = new System.Drawing.Size(900, 407);
            this.dgvCandidatos.TabIndex = 0;
            // 
            // f7_EvCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.BackgroundImage = global::CPresentación.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(980, 549);
            this.Controls.Add(this.dgvCandidatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnMovForm);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 596);
            this.MinimumSize = new System.Drawing.Size(998, 596);
            this.Name = "f7_EvCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluación de candidatos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f7_EvCandidatos_FormClosed);
            this.Load += new System.EventHandler(this.f7_EvCandidatos_Load);
            this.pnMovForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Panel pnMovForm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCandidatos;
    }
}