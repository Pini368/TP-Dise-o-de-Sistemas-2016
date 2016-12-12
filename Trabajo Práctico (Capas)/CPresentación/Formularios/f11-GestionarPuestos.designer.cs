namespace Trabajo_práctico
{
    partial class f11_GestionarPuestos
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
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnOpciones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.pnDatos.SuspendLayout();
            this.pnOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Location = new System.Drawing.Point(51, 231);
            this.dgvPuestos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuestos.Size = new System.Drawing.Size(900, 263);
            this.dgvPuestos.TabIndex = 3;
            this.dgvPuestos.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(313, 30);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(359, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gestión de puestos";
            // 
            // pnDatos
            // 
            this.pnDatos.BackColor = System.Drawing.Color.Transparent;
            this.pnDatos.BackgroundImage = global::CPresentación.Properties.Resources.Fondo1;
            this.pnDatos.Controls.Add(this.tbEmpresa);
            this.pnDatos.Controls.Add(this.tbNombre);
            this.pnDatos.Controls.Add(this.tbCodigo);
            this.pnDatos.Controls.Add(this.label5);
            this.pnDatos.Controls.Add(this.label6);
            this.pnDatos.Controls.Add(this.label7);
            this.pnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.pnDatos.Location = new System.Drawing.Point(131, 76);
            this.pnDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(741, 105);
            this.pnDatos.TabIndex = 0;
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbEmpresa.Location = new System.Drawing.Point(247, 68);
            this.tbEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpresa.MaxLength = 50;
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(367, 27);
            this.tbEmpresa.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbNombre.Location = new System.Drawing.Point(335, 37);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(279, 27);
            this.tbNombre.TabIndex = 1;
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbCodigo.Location = new System.Drawing.Point(223, 6);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigo.MaxLength = 20;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(391, 27);
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(155, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(157, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(157, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre del puesto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnBuscar.FlatAppearance.BorderSize = 3;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(721, 185);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 39);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnOpciones
            // 
            this.pnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnOpciones.Controls.Add(this.btnSalir);
            this.pnOpciones.Controls.Add(this.btnEliminar);
            this.pnOpciones.Controls.Add(this.btnModificar);
            this.pnOpciones.Controls.Add(this.btnIngresar);
            this.pnOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnOpciones.Location = new System.Drawing.Point(51, 500);
            this.pnOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnOpciones.Name = "pnOpciones";
            this.pnOpciones.Size = new System.Drawing.Size(900, 50);
            this.pnOpciones.TabIndex = 2;
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
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(3, 5);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 39);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(504, 5);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 39);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnModificar.FlatAppearance.BorderSize = 3;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(620, 5);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 39);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.button8_Click);
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
            this.btnIngresar.Location = new System.Drawing.Point(736, 5);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(109, 39);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.button9_Click);
            // 
            // f11_GestionarPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.BackgroundImage = global::CPresentación.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnOpciones);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnDatos);
            this.Controls.Add(this.dgvPuestos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "f11_GestionarPuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Puestos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f11_GestionarPuestos_FormClosed);
            this.Load += new System.EventHandler(this.gestionarCandidatos_Load);
            this.VisibleChanged += new System.EventHandler(this.f11_GestionarPuestos_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            this.pnOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.TextBox tbEmpresa;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnOpciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnIngresar;
    }
}