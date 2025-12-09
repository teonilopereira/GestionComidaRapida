namespace GestionDePedidos.form
{
    partial class FrmProductoAE
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
            CBTamaño = new ComboBox();
            label6 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            BtnCancelar = new Button();
            BtnAgregar = new Button();
            pictureBox2 = new PictureBox();
            CBCategoria = new ComboBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            btnBuscarImagen = new Button();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            nudStock = new NumericUpDown();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // CBTamaño
            // 
            CBTamaño.FormattingEnabled = true;
            CBTamaño.Location = new Point(167, 372);
            CBTamaño.Name = "CBTamaño";
            CBTamaño.Size = new Size(182, 33);
            CBTamaño.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(7, 372);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 65;
            label6.Text = "Ingrese el Tamaño:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 117);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(391, 31);
            txtNombre.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 225);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 54;
            label2.Text = "Ingrese el Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(8, 123);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 53;
            label1.Text = "Ingrese el Nombre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnCancelar);
            panel1.Controls.Add(BtnAgregar);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 90);
            panel1.TabIndex = 52;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(420, 3);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(134, 74);
            BtnCancelar.TabIndex = 29;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(193, 3);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(134, 74);
            BtnAgregar.TabIndex = 28;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = GestionComidaRapida.form.Properties.Resources.IconLogo;
            pictureBox2.Location = new Point(41, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // CBCategoria
            // 
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(559, 372);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(182, 33);
            CBCategoria.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(382, 375);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 69;
            label3.Text = "Ingrese el Categoria:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(194, 200);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MaxLength = 256;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(391, 149);
            txtDescripcion.TabIndex = 71;
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Location = new Point(799, 436);
            btnBuscarImagen.Margin = new Padding(4, 5, 4, 5);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(260, 82);
            btnBuscarImagen.TabIndex = 73;
            btnBuscarImagen.Text = "Buscar";
            btnBuscarImagen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarImagen.UseVisualStyleBackColor = true;
            btnBuscarImagen.Click += btnBuscarImagen_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(795, 112);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(264, 313);
            groupBox3.TabIndex = 72;
            groupBox3.TabStop = false;
            groupBox3.Text = " Imágen ";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(24, 35);
            picImagen.Margin = new Padding(4, 5, 4, 5);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(217, 253);
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(189, 448);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.MaxLength = 25;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(391, 31);
            txtPrecio.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 454);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 74;
            label4.Text = "Ingrese el Precio:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(188, 505);
            nudStock.Margin = new Padding(4, 5, 4, 5);
            nudStock.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(103, 31);
            nudStock.TabIndex = 106;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudStock.ValueChanged += nudStock_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(107, 507);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 107;
            label7.Text = "Stock:";
            // 
            // FrmProductoAE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1086, 549);
            Controls.Add(label7);
            Controls.Add(nudStock);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(btnBuscarImagen);
            Controls.Add(groupBox3);
            Controls.Add(txtDescripcion);
            Controls.Add(CBCategoria);
            Controls.Add(label3);
            Controls.Add(CBTamaño);
            Controls.Add(label6);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximumSize = new Size(1108, 605);
            MinimumSize = new Size(1108, 605);
            Name = "FrmProductoAE";
            Text = "ProductoAE";
            Load += Reportes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBTamaño;
        private Label label6;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button BtnCancelar;
        private Button BtnAgregar;
        private PictureBox pictureBox2;
        private ComboBox CBCategoria;
        private Label label3;
        private TextBox txtDescripcion;
        private Button btnBuscarImagen;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private TextBox txtPrecio;
        private Label label4;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private NumericUpDown nudStock;
        private Label label7;
    }
}