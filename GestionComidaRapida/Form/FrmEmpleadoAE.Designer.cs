namespace GestionComidaRapida.form
{
    partial class FrmEmpleadoAE
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
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            BtnCancelar = new Button();
            BtnAgregar = new Button();
            pictureBox2 = new PictureBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtGmail = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            txtDNI = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            DTPFechaNaci = new DateTimePicker();
            CBGenero = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(194, 280);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.MaxLength = 120;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(371, 31);
            txtDireccion.TabIndex = 37;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 109);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 31);
            txtNombre.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(17, 412);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 34;
            label4.Text = "Ingrese la gmail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(17, 280);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 33;
            label3.Text = "Ingrese el Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 169);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 32;
            label2.Text = "Ingrese el Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 31;
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
            panel1.Size = new Size(702, 90);
            panel1.TabIndex = 30;
            panel1.Paint += panel1_Paint;
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
            pictureBox2.BackgroundImage = Properties.Resources.IconLogo;
            pictureBox2.Location = new Point(41, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(194, 166);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.MaxLength = 25;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(361, 31);
            txtApellido.TabIndex = 39;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(194, 342);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(229, 31);
            txtTelefono.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 348);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 40;
            label5.Text = "Ingrese el telefono:";
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(194, 412);
            txtGmail.Margin = new Padding(4, 5, 4, 5);
            txtGmail.MaxLength = 120;
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(371, 31);
            txtGmail.TabIndex = 42;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(502, 222);
            txtDNI.Margin = new Padding(4, 5, 4, 5);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(156, 31);
            txtDNI.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(362, 228);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 45;
            label7.Text = "Ingrese su DNI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(17, 225);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 47;
            label6.Text = "Ingrese el Genero:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(17, 476);
            label8.Name = "label8";
            label8.Size = new Size(237, 25);
            label8.TabIndex = 49;
            label8.Text = "Ingrese la Fecha Nacimiento:";
            // 
            // DTPFechaNaci
            // 
            DTPFechaNaci.Location = new Point(293, 476);
            DTPFechaNaci.MaxDate = new DateTime(2006, 1, 1, 0, 0, 0, 0);
            DTPFechaNaci.Name = "DTPFechaNaci";
            DTPFechaNaci.Size = new Size(300, 31);
            DTPFechaNaci.TabIndex = 50;
            DTPFechaNaci.Value = new DateTime(2006, 1, 1, 0, 0, 0, 0);
            // 
            // CBGenero
            // 
            CBGenero.FormattingEnabled = true;
            CBGenero.Location = new Point(177, 222);
            CBGenero.Name = "CBGenero";
            CBGenero.Size = new Size(182, 33);
            CBGenero.TabIndex = 51;
            CBGenero.SelectedIndexChanged += CBGenero_SelectedIndexChanged_1;
            // 
            // FrmEmpleadoAE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(702, 534);
            Controls.Add(CBGenero);
            Controls.Add(DTPFechaNaci);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtDNI);
            Controls.Add(label7);
            Controls.Add(txtGmail);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximumSize = new Size(724, 590);
            MinimumSize = new Size(724, 590);
            Name = "FrmEmpleadoAE";
            Text = "FrmEmpleadoAE";
            Load += FrmEmpleadoAE_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button BtnCancelar;
        private Button BtnAgregar;
        private PictureBox pictureBox2;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtGmail;
        private ErrorProvider errorProvider1;
        private TextBox txtDNI;
        private Label label7;
        private Label label6;
        private DateTimePicker DTPFechaNaci;
        private Label label8;
        private ComboBox CBGenero;
    }
}