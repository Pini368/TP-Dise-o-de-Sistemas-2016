namespace Trabajo_práctico
{
    partial class f3_IngresoConsultor
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnCampos = new System.Windows.Forms.Panel();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.tbNomUs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnMovForm = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnCampos.SuspendLayout();
            this.pnMovForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(327, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingreso Consultor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // pnCampos
            // 
            this.pnCampos.BackgroundImage = global::CPresentación.Properties.Resources.Fondo1;
            this.pnCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnCampos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCampos.Controls.Add(this.tbContra);
            this.pnCampos.Controls.Add(this.tbNomUs);
            this.pnCampos.Controls.Add(this.label4);
            this.pnCampos.Controls.Add(this.label5);
            this.pnCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCampos.ForeColor = System.Drawing.Color.White;
            this.pnCampos.Location = new System.Drawing.Point(251, 150);
            this.pnCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCampos.Name = "pnCampos";
            this.pnCampos.Size = new System.Drawing.Size(500, 149);
            this.pnCampos.TabIndex = 0;
            // 
            // tbContra
            // 
            this.tbContra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbContra.Location = new System.Drawing.Point(165, 90);
            this.tbContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContra.MaxLength = 20;
            this.tbContra.Name = "tbContra";
            this.tbContra.PasswordChar = '*';
            this.tbContra.Size = new System.Drawing.Size(316, 27);
            this.tbContra.TabIndex = 1;
            this.tbContra.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbNomUs
            // 
            this.tbNomUs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbNomUs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomUs.Location = new System.Drawing.Point(205, 36);
            this.tbNomUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNomUs.MaxLength = 15;
            this.tbNomUs.Name = "tbNomUs";
            this.tbNomUs.Size = new System.Drawing.Size(276, 27);
            this.tbNomUs.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre Usuario";
            // 
            // pnMovForm
            // 
            this.pnMovForm.BackColor = System.Drawing.Color.Transparent;
            this.pnMovForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMovForm.Controls.Add(this.button2);
            this.pnMovForm.Controls.Add(this.button1);
            this.pnMovForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMovForm.Location = new System.Drawing.Point(251, 491);
            this.pnMovForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMovForm.Name = "pnMovForm";
            this.pnMovForm.Size = new System.Drawing.Size(500, 50);
            this.pnMovForm.TabIndex = 1;
            this.pnMovForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button2.Location = new System.Drawing.Point(69, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button1.Location = new System.Drawing.Point(301, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // f3_IngresoConsultor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPresentación.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(980, 549);
            this.Controls.Add(this.pnMovForm);
            this.Controls.Add(this.pnCampos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 596);
            this.MinimumSize = new System.Drawing.Size(998, 596);
            this.Name = "f3_IngresoConsultor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo práctico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f3_IngresoConsultor_FormClosed);
            this.Load += new System.EventHandler(this.ingresoConsultor_Load);
            this.pnCampos.ResumeLayout(false);
            this.pnCampos.PerformLayout();
            this.pnMovForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnCampos;
        private System.Windows.Forms.TextBox tbContra;
        private System.Windows.Forms.TextBox tbNomUs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnMovForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}