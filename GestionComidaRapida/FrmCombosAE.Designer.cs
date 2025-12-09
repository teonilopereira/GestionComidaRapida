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
            txtTipoProductos = new TextBox();
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
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtPrecioCosto = new TextBox();
            label5 = new Label();
            txtDescripcion = new TextBox();
            label8 = new Label();
            txtProducto = new TextBox();
            label1 = new Label();
            nudStock = new NumericUpDown();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(788, 687);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(303, 81);
            btnCancelar.TabIndex = 84;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(204, 687);
            btnOk.Margin = new Padding(4, 5, 4, 5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(413, 81);
            btnOk.TabIndex = 85;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtTipoProductos
            // 
            txtTipoProductos.Location = new Point(1055, 9);
            txtTipoProductos.Name = "txtTipoProductos";
            txtTipoProductos.ReadOnly = true;
            txtTipoProductos.Size = new Size(150, 31);
            txtTipoProductos.TabIndex = 102;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(139, 305);
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
            dgvDatos.Location = new Point(13, 5);
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
            btnEditarProducto.Location = new Point(37, 259);
            btnEditarProducto.Margin = new Padding(4, 5, 4, 5);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(167, 93);
            btnEditarProducto.TabIndex = 1;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.Location = new Point(37, 144);
            btnBorrarProducto.Margin = new Padding(4, 5, 4, 5);
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.Size = new Size(167, 93);
            btnBorrarProducto.TabIndex = 2;
            btnBorrarProducto.Text = "Borrar";
            btnBorrarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBorrarProducto.UseVisualStyleBackColor = true;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(37, 41);
            btnAgregarProducto.Margin = new Padding(4, 5, 4, 5);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(167, 93);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // cboTamanio
            // 
            cboTamanio.FormattingEnabled = true;
            cboTamanio.Location = new Point(1004, 51);
            cboTamanio.Name = "cboTamanio";
            cboTamanio.Size = new Size(242, 33);
            cboTamanio.TabIndex = 100;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(919, 54);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(78, 25);
            label10.TabIndex = 86;
            label10.Text = "Tamaño:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(919, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 87;
            label2.Text = "Tipo Producto:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecioCosto);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(872, 93);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(349, 112);
            groupBox2.TabIndex = 92;
            groupBox2.TabStop = false;
            groupBox2.Text = " Precios ";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(163, 44);
            txtPrecioCosto.Margin = new Padding(4, 5, 4, 5);
            txtPrecioCosto.MaxLength = 16;
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(141, 31);
            txtPrecioCosto.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 48);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 0;
            label5.Text = "Pecio Costo:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(269, 88);
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
            label8.Location = new Point(153, 91);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 89;
            label8.Text = "Descripción:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(315, 24);
            txtProducto.Margin = new Padding(4, 5, 4, 5);
            txtProducto.MaxLength = 50;
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(419, 31);
            txtProducto.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 88;
            label1.Text = "Nombre Producto:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(988, 244);
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
            label7.Location = new Point(924, 249);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 103;
            label7.Text = "Stock:";
            // 
            // FrmCombosAE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 1050);
            Controls.Add(nudStock);
            Controls.Add(label7);
            Controls.Add(txtTipoProductos);
            Controls.Add(splitContainer1);
            Controls.Add(cboTamanio);
            Controls.Add(label10);
            Controls.Add(label2);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtTipoProductos;
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
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtPrecioCosto;
        private Label label5;
        private TextBox txtDescripcion;
        private Label label8;
        private TextBox txtProducto;
        private Label label1;
        private NumericUpDown nudStock;
        private Label label7;
    }
}