namespace GestionDePedidos.form
{
    partial class Empleados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColGenero = new DataGridViewTextBoxColumn();
            ColDni = new DataGridViewTextBoxColumn();
            ColDireccion = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColGmail = new DataGridViewTextBoxColumn();
            ColFechaNaci = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtnBorrar = new Button();
            panel1 = new Panel();
            BtnApellidoZA = new Button();
            BtnApellidoAZ = new Button();
            BtnNombreZA = new Button();
            BtnNombreAZ = new Button();
            pictureBox1 = new PictureBox();
            BTSalir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTSalir).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, ColNombre, ColApellido, ColGenero, ColDni, ColDireccion, ColTelefono, ColGmail, ColFechaNaci });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.GridColor = SystemColors.ScrollBar;
            dgvDatos.Location = new Point(186, 90);
            dgvDatos.Margin = new Padding(4, 5, 4, 5);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1240, 433);
            dgvDatos.TabIndex = 12;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 150;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 8;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 150;
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.MinimumWidth = 8;
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            ColApellido.Width = 150;
            // 
            // ColGenero
            // 
            ColGenero.HeaderText = "Genero";
            ColGenero.MinimumWidth = 8;
            ColGenero.Name = "ColGenero";
            ColGenero.ReadOnly = true;
            ColGenero.Width = 150;
            // 
            // ColDni
            // 
            ColDni.HeaderText = "DNI";
            ColDni.MinimumWidth = 8;
            ColDni.Name = "ColDni";
            ColDni.ReadOnly = true;
            ColDni.Width = 150;
            // 
            // ColDireccion
            // 
            ColDireccion.HeaderText = "Direccion";
            ColDireccion.MinimumWidth = 8;
            ColDireccion.Name = "ColDireccion";
            ColDireccion.ReadOnly = true;
            ColDireccion.Width = 150;
            // 
            // ColTelefono
            // 
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.MinimumWidth = 8;
            ColTelefono.Name = "ColTelefono";
            ColTelefono.ReadOnly = true;
            ColTelefono.Width = 150;
            // 
            // ColGmail
            // 
            ColGmail.HeaderText = "Gmail";
            ColGmail.MinimumWidth = 8;
            ColGmail.Name = "ColGmail";
            ColGmail.ReadOnly = true;
            ColGmail.Width = 150;
            // 
            // ColFechaNaci
            // 
            ColFechaNaci.HeaderText = "FechaNacimiento";
            ColFechaNaci.MinimumWidth = 8;
            ColFechaNaci.Name = "ColFechaNaci";
            ColFechaNaci.ReadOnly = true;
            ColFechaNaci.Width = 150;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(BtnAgregar);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(BtnBorrar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 433);
            panel2.TabIndex = 11;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Indigo;
            BtnAgregar.Image = GestionComidaRapida.form.Properties.Resources.line_md__plus_circle;
            BtnAgregar.Location = new Point(0, 0);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(186, 74);
            BtnAgregar.TabIndex = 14;
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Indigo;
            BtnEditar.Image = GestionComidaRapida.form.Properties.Resources.mdi_light__pencil;
            BtnEditar.Location = new Point(0, 71);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(186, 74);
            BtnEditar.TabIndex = 2;
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnBorrar
            // 
            BtnBorrar.BackColor = Color.Indigo;
            BtnBorrar.Image = GestionComidaRapida.form.Properties.Resources.ic__baseline_delete_sweep;
            BtnBorrar.Location = new Point(0, 141);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(186, 74);
            BtnBorrar.TabIndex = 1;
            BtnBorrar.UseVisualStyleBackColor = false;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnApellidoZA);
            panel1.Controls.Add(BtnApellidoAZ);
            panel1.Controls.Add(BtnNombreZA);
            panel1.Controls.Add(BtnNombreAZ);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BTSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1426, 90);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // BtnApellidoZA
            // 
            BtnApellidoZA.BackColor = Color.Indigo;
            BtnApellidoZA.ForeColor = Color.Red;
            BtnApellidoZA.Location = new Point(653, -1);
            BtnApellidoZA.Name = "BtnApellidoZA";
            BtnApellidoZA.Size = new Size(150, 37);
            BtnApellidoZA.TabIndex = 15;
            BtnApellidoZA.Text = "ApellidoZA";
            BtnApellidoZA.UseVisualStyleBackColor = false;
            BtnApellidoZA.Click += BtnApellidoZA_Click;
            // 
            // BtnApellidoAZ
            // 
            BtnApellidoAZ.BackColor = Color.Indigo;
            BtnApellidoAZ.ForeColor = Color.Red;
            BtnApellidoAZ.Location = new Point(497, -1);
            BtnApellidoAZ.Name = "BtnApellidoAZ";
            BtnApellidoAZ.Size = new Size(150, 37);
            BtnApellidoAZ.TabIndex = 14;
            BtnApellidoAZ.Text = "ApellidoAZ";
            BtnApellidoAZ.UseVisualStyleBackColor = false;
            BtnApellidoAZ.Click += BtnApellidoAZ_Click;
            // 
            // BtnNombreZA
            // 
            BtnNombreZA.BackColor = Color.Indigo;
            BtnNombreZA.ForeColor = Color.Red;
            BtnNombreZA.Location = new Point(341, -1);
            BtnNombreZA.Name = "BtnNombreZA";
            BtnNombreZA.Size = new Size(150, 37);
            BtnNombreZA.TabIndex = 13;
            BtnNombreZA.Text = "NombreZA";
            BtnNombreZA.UseVisualStyleBackColor = false;
            BtnNombreZA.Click += BtnNombreZA_Click;
            // 
            // BtnNombreAZ
            // 
            BtnNombreAZ.BackColor = Color.Indigo;
            BtnNombreAZ.ForeColor = Color.Red;
            BtnNombreAZ.Location = new Point(185, -1);
            BtnNombreAZ.Name = "BtnNombreAZ";
            BtnNombreAZ.Size = new Size(150, 37);
            BtnNombreAZ.TabIndex = 2;
            BtnNombreAZ.Text = "NombreAZ";
            BtnNombreAZ.UseVisualStyleBackColor = false;
            BtnNombreAZ.Click += BtnNombreAZ_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = GestionComidaRapida.form.Properties.Resources.IconLogo;
            pictureBox1.Location = new Point(52, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BTSalir
            // 
            BTSalir.BackgroundImage = GestionComidaRapida.form.Properties.Resources.line_md__logout;
            BTSalir.Location = new Point(1347, 15);
            BTSalir.Name = "BTSalir";
            BTSalir.Size = new Size(66, 66);
            BTSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BTSalir.TabIndex = 0;
            BTSalir.TabStop = false;
            BTSalir.Click += BTSalir_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 523);
            Controls.Add(dgvDatos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1448, 579);
            MinimumSize = new Size(1448, 579);
            Name = "Empleados";
            Text = "Empleados";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private Panel panel2;
        private Button BtnEditar;
        private Button BtnBorrar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox BTSalir;
        private Button BtnAgregar;
        private Button BtnNombreAZ;
        private Button BtnNombreZA;
        private Button BtnApellidoZA;
        private Button BtnApellidoAZ;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColGenero;
        private DataGridViewTextBoxColumn ColDni;
        private DataGridViewTextBoxColumn ColDireccion;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColGmail;
        private DataGridViewTextBoxColumn ColFechaNaci;
    }
}