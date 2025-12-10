namespace GestionComidaRapida.form
{
    partial class FrmCombosAE
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            btnCancelar = new Button();
            btnOk = new Button();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            btnEditarProducto = new Button();
            btnBorrarProducto = new Button();
            btnAgregarProducto = new Button();
            cboTamanio = new ComboBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            txtPrecioVta = new TextBox();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label8 = new Label();
            txtProducto = new TextBox();
            label1 = new Label();
            nudStock = new NumericUpDown();
            label7 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Purple;
            btnCancelar.Location = new Point(788, 758);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(303, 81);
            btnCancelar.TabIndex = 84;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Purple;
            btnOk.Location = new Point(204, 758);
            btnOk.Margin = new Padding(4, 5, 4, 5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(413, 81);
            btnOk.TabIndex = 85;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(139, 353);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEditarProducto);
            splitContainer1.Panel2.Controls.Add(btnBorrarProducto);
            splitContainer1.Panel2.Controls.Add(btnAgregarProducto);
            splitContainer1.Size = new Size(1241, 374);
            splitContainer1.SplitterDistance = 976;
            splitContainer1.TabIndex = 101;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colProducto, colCantidad, colPrecio });
            dgvDatos.Location = new Point(13, 22);
            dgvDatos.Margin = new Padding(4, 5, 4, 5);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(939, 347);
            dgvDatos.TabIndex = 1;
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
            // colProducto
            // 
            colProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 8;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 8;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 150;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 8;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.Purple;
            btnEditarProducto.Location = new Point(37, 247);
            btnEditarProducto.Margin = new Padding(4, 5, 4, 5);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(167, 93);
            btnEditarProducto.TabIndex = 1;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditarProducto.UseVisualStyleBackColor = false;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.BackColor = Color.Purple;
            btnBorrarProducto.Location = new Point(37, 144);
            btnBorrarProducto.Margin = new Padding(4, 5, 4, 5);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(167, 93);
            btnBorrarProducto.TabIndex = 2;
            btnBorrarProducto.Text = "Borrar";
            btnBorrarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBorrarProducto.UseVisualStyleBackColor = false;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.Purple;
            btnAgregarProducto.Location = new Point(37, 41);
            btnAgregarProducto.Margin = new Padding(4, 5, 4, 5);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(167, 93);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // cboTamanio
            // 
            cboTamanio.FormattingEnabled = true;
            cboTamanio.Location = new Point(1005, 117);
            cboTamanio.Name = "cboTamanio";
            cboTamanio.Size = new Size(242, 33);
            cboTamanio.TabIndex = 100;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(920, 120);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(78, 25);
            label10.TabIndex = 86;
            label10.Text = "Tamaño:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecioVta);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(873, 159);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(349, 127);
            groupBox2.TabIndex = 92;
            groupBox2.TabStop = false;
            groupBox2.Text = " Precios ";
            // 
            // txtPrecioVta
            // 
            txtPrecioVta.Location = new Point(125, 42);
            txtPrecioVta.Margin = new Padding(4, 5, 4, 5);
            txtPrecioVta.MaxLength = 16;
            txtPrecioVta.Name = "txtPrecioVta";
            txtPrecioVta.Size = new Size(141, 31);
            txtPrecioVta.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 45);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 2;
            label6.Text = "P. Vta.:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(269, 183);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(465, 149);
            txtDescripcion.TabIndex = 90;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(139, 186);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 89;
            label8.Text = "Descripción:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(315, 120);
            txtProducto.Margin = new Padding(4, 5, 4, 5);
            txtProducto.MaxLength = 50;
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(419, 31);
            txtProducto.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(130, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 88;
            label1.Text = "Nombre Producto:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(988, 292);
            nudStock.Margin = new Padding(4, 5, 4, 5);
            nudStock.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(103, 31);
            nudStock.TabIndex = 104;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(924, 297);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 103;
            label7.Text = "Stock:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1509, 93);
            panel1.TabIndex = 106;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.IconLogo;
            pictureBox2.Location = new Point(41, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // FrmCombosAE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1509, 1050);
            Controls.Add(panel1);
            Controls.Add(nudStock);
            Controls.Add(label7);
            Controls.Add(splitContainer1);
            Controls.Add(cboTamanio);
            Controls.Add(label10);
            Controls.Add(groupBox2);
            Controls.Add(txtDescripcion);
            Controls.Add(label8);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Name = "FrmCombosAE";
            Text = "FrmCombosAE";
            Load += FrmCombosAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOk;
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private Button btnEditarProducto;
        private Button btnBorrarProducto;
        private Button btnAgregarProducto;
        private ComboBox cboTamanio;
        private Label label10;
        private GroupBox groupBox2;
        private TextBox txtDescripcion;
        private Label label8;
        private TextBox txtProducto;
        private Label label1;
        private NumericUpDown nudStock;
        private Label label7;
        private TextBox txtPrecioVta;
        private Label label6;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}