namespace GestionDePedidos.form
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            ColCategoria = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            BtnEditar = new Button();
            BtnBorrar = new Button();
            BtnAgregar = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            BTSalir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, ColCategoria });
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
            dgvDatos.Size = new Size(431, 504);
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
            // ColCategoria
            // 
            ColCategoria.HeaderText = "Categoria";
            ColCategoria.MinimumWidth = 8;
            ColCategoria.Name = "ColCategoria";
            ColCategoria.ReadOnly = true;
            ColCategoria.Width = 150;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(BtnBorrar);
            panel2.Controls.Add(BtnAgregar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 504);
            panel2.TabIndex = 11;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.MediumPurple;
            BtnEditar.Image = (Image)resources.GetObject("BtnEditar.Image");
            BtnEditar.Location = new Point(0, 69);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(186, 74);
            BtnEditar.TabIndex = 2;
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnBorrar
            // 
            BtnBorrar.BackColor = Color.MediumPurple;
            BtnBorrar.Image = (Image)resources.GetObject("BtnBorrar.Image");
            BtnBorrar.Location = new Point(0, 140);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(186, 74);
            BtnBorrar.TabIndex = 1;
            BtnBorrar.UseVisualStyleBackColor = false;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.MediumPurple;
            BtnAgregar.Image = (Image)resources.GetObject("BtnAgregar.Image");
            BtnAgregar.Location = new Point(0, 0);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(186, 74);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BTSalir);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 90);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // BTSalir
            // 
            BTSalir.BackgroundImage = GestionComidaRapida.form.Properties.Resources.line_md__logout;
            BTSalir.Location = new Point(538, 3);
            BTSalir.Name = "BTSalir";
            BTSalir.Size = new Size(66, 66);
            BTSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BTSalir.TabIndex = 53;
            BTSalir.TabStop = false;
            BTSalir.Click += BTSalir_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 594);
            Controls.Add(dgvDatos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(639, 650);
            MinimumSize = new Size(639, 650);
            Name = "FrmCategorias";
            Text = "Categorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private Panel panel2;
        private Button BtnEditar;
        private Button BtnBorrar;
        private Button BtnAgregar;
        private Panel panel1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn ColCategoria;
        private PictureBox BTSalir;
    }
}