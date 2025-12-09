namespace GestionComidaRapida.form
{
    partial class FrmCombos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCombos));
            dgvDatos = new DataGridView();
            panel2 = new Panel();
            BtnActualizar = new Button();
            BtnFiltrar = new Button();
            BtnEditar = new Button();
            BtnBorrar = new Button();
            BtnAgregar = new Button();
            panel1 = new Panel();
            BTSalir = new PictureBox();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            txtCantidadPaginas = new TextBox();
            cboPaginas = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            colId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColTamaño = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BTSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, ColNombre, ColPrecio, ColStock, ColTamaño });
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
            dgvDatos.Size = new Size(1136, 594);
            dgvDatos.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(BtnActualizar);
            panel2.Controls.Add(BtnFiltrar);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(BtnBorrar);
            panel2.Controls.Add(BtnAgregar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 594);
            panel2.TabIndex = 11;
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = Color.Indigo;
            BtnActualizar.ForeColor = SystemColors.ButtonHighlight;
            BtnActualizar.Location = new Point(0, 418);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(186, 74);
            BtnActualizar.TabIndex = 5;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.BackColor = Color.Indigo;
            BtnFiltrar.ForeColor = SystemColors.ButtonHighlight;
            BtnFiltrar.Location = new Point(0, 317);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(186, 74);
            BtnFiltrar.TabIndex = 4;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Indigo;
            BtnEditar.Image = (Image)resources.GetObject("BtnEditar.Image");
            BtnEditar.Location = new Point(0, 127);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(186, 74);
            BtnEditar.TabIndex = 2;
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnBorrar
            // 
            BtnBorrar.BackColor = Color.Indigo;
            BtnBorrar.Image = (Image)resources.GetObject("BtnBorrar.Image");
            BtnBorrar.Location = new Point(0, 220);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(186, 74);
            BtnBorrar.TabIndex = 1;
            BtnBorrar.UseVisualStyleBackColor = false;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Indigo;
            BtnAgregar.Image = (Image)resources.GetObject("BtnAgregar.Image");
            BtnAgregar.Location = new Point(0, 28);
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
            panel1.Controls.Add(btnUltimo);
            panel1.Controls.Add(btnSiguiente);
            panel1.Controls.Add(btnAnterior);
            panel1.Controls.Add(btnPrimero);
            panel1.Controls.Add(txtCantidadPaginas);
            panel1.Controls.Add(cboPaginas);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1322, 90);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // BTSalir
            // 
            BTSalir.BackgroundImage = Properties.Resources.line_md__logout;
            BTSalir.Location = new Point(1411, 12);
            BTSalir.Name = "BTSalir";
            BTSalir.Size = new Size(66, 66);
            BTSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BTSalir.TabIndex = 52;
            BTSalir.TabStop = false;
            // 
            // btnUltimo
            // 
            btnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUltimo.Location = new Point(2273, 5);
            btnUltimo.Margin = new Padding(4, 5, 4, 5);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(94, 35);
            btnUltimo.TabIndex = 48;
            btnUltimo.Text = "Ultimo";
            btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSiguiente.Location = new Point(2154, 5);
            btnSiguiente.Margin = new Padding(4, 5, 4, 5);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(97, 35);
            btnSiguiente.TabIndex = 49;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnterior.Location = new Point(2046, 5);
            btnAnterior.Margin = new Padding(4, 5, 4, 5);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(90, 35);
            btnAnterior.TabIndex = 50;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            btnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrimero.Location = new Point(1934, 5);
            btnPrimero.Margin = new Padding(4, 5, 4, 5);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(86, 35);
            btnPrimero.TabIndex = 51;
            btnPrimero.Text = "Primero";
            btnPrimero.UseVisualStyleBackColor = true;
            // 
            // txtCantidadPaginas
            // 
            txtCantidadPaginas.Location = new Point(1047, 48);
            txtCantidadPaginas.Margin = new Padding(4, 5, 4, 5);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.ReadOnly = true;
            txtCantidadPaginas.Size = new Size(120, 31);
            txtCantidadPaginas.TabIndex = 47;
            // 
            // cboPaginas
            // 
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(900, 48);
            cboPaginas.Margin = new Padding(4, 5, 4, 5);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(95, 33);
            cboPaginas.TabIndex = 46;
            cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1006, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 44;
            label2.Text = "de:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(845, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 45;
            label1.Text = "Pág.:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
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
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.MinimumWidth = 8;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 150;
            // 
            // ColStock
            // 
            ColStock.HeaderText = "Stock";
            ColStock.MinimumWidth = 8;
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            ColStock.Width = 150;
            // 
            // ColTamaño
            // 
            ColTamaño.HeaderText = "Tamaño";
            ColTamaño.MinimumWidth = 8;
            ColTamaño.Name = "ColTamaño";
            ColTamaño.ReadOnly = true;
            ColTamaño.Width = 150;
            // 
            // FrmCombos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 684);
            Controls.Add(dgvDatos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmCombos";
            Text = "FrmCombos";
            Load += FrmCombos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BTSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private Panel panel2;
        private Button BtnActualizar;
        private Button BtnFiltrar;
        private Button BtnEditar;
        private Button BtnBorrar;
        private Button BtnAgregar;
        private Panel panel1;
        private PictureBox BTSalir;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private TextBox txtCantidadPaginas;
        private ComboBox cboPaginas;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColTamaño;
    }
}