﻿namespace Trabajo_práctico
{
    partial class f2_RealizarCuestionario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCampos = new System.Windows.Forms.Panel();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.tbNroDto = new System.Windows.Forms.TextBox();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnMovForm = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnCampos.SuspendLayout();
            this.pnMovForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(289, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(388, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Realizar cuestionario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnCampos
            // 
            this.pnCampos.BackgroundImage = global::CPresentación.Properties.Resources.Fondo1;
            this.pnCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnCampos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCampos.Controls.Add(this.tbClave);
            this.pnCampos.Controls.Add(this.tbNroDto);
            this.pnCampos.Controls.Add(this.tbTipo);
            this.pnCampos.Controls.Add(this.label5);
            this.pnCampos.Controls.Add(this.label6);
            this.pnCampos.Controls.Add(this.label7);
            this.pnCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCampos.ForeColor = System.Drawing.Color.White;
            this.pnCampos.Location = new System.Drawing.Point(251, 150);
            this.pnCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCampos.Name = "pnCampos";
            this.pnCampos.Size = new System.Drawing.Size(500, 200);
            this.pnCampos.TabIndex = 0;
            this.pnCampos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCampos_Paint);
            // 
            // tbClave
            // 
            this.tbClave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbClave.Location = new System.Drawing.Point(107, 135);
            this.tbClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClave.MaxLength = 8;
            this.tbClave.Name = "tbClave";
            this.tbClave.PasswordChar = '*';
            this.tbClave.Size = new System.Drawing.Size(351, 27);
            this.tbClave.TabIndex = 2;
            this.tbClave.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbNroDto
            // 
            this.tbNroDto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbNroDto.Location = new System.Drawing.Point(185, 86);
            this.tbNroDto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNroDto.MaxLength = 10;
            this.tbNroDto.Name = "tbNroDto";
            this.tbNroDto.Size = new System.Drawing.Size(271, 27);
            this.tbNroDto.TabIndex = 1;
            this.tbNroDto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroDto_KeyPress);
            // 
            // tbTipo
            // 
            this.tbTipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTipo.Location = new System.Drawing.Point(107, 36);
            this.tbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTipo.MaxLength = 4;
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(351, 27);
            this.tbTipo.TabIndex = 0;
            this.tbTipo.TextChanged += new System.EventHandler(this.tbTipo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "N° documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tipo";
            // 
            // pnMovForm
            // 
            this.pnMovForm.BackColor = System.Drawing.Color.Transparent;
            this.pnMovForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMovForm.Controls.Add(this.btnVolver);
            this.pnMovForm.Controls.Add(this.btnIngresar);
            this.pnMovForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMovForm.Location = new System.Drawing.Point(251, 490);
            this.pnMovForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMovForm.Name = "pnMovForm";
            this.pnMovForm.Size = new System.Drawing.Size(500, 50);
            this.pnMovForm.TabIndex = 1;
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
            this.btnVolver.Location = new System.Drawing.Point(71, 5);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 39);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnIngresar.FlatAppearance.BorderSize = 3;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(303, 5);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(109, 39);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // f2_RealizarCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CPresentación.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(980, 549);
            this.Controls.Add(this.pnMovForm);
            this.Controls.Add(this.pnCampos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 596);
            this.MinimumSize = new System.Drawing.Size(998, 596);
            this.Name = "f2_RealizarCuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo práctico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f2_RealizarCuestionario_FormClosed);
            this.Load += new System.EventHandler(this.f2_RealizarCuestionario_Load);
            this.pnCampos.ResumeLayout(false);
            this.pnCampos.PerformLayout();
            this.pnMovForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnCampos;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbNroDto;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnMovForm;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIngresar;
    }
}

