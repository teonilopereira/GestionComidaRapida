namespace GestionComidaRapida.form
{
    partial class FrmCategoriaAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoriaAE));
            panel1 = new Panel();
            BtnOk = new Button();
            BtnCancelar = new Button();
            pictureBox1 = new PictureBox();
            BTSalir = new PictureBox();
            label1 = new Label();
            txtCategoria = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnOk);
            panel1.Controls.Add(BtnCancelar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BTSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 90);
            panel1.TabIndex = 14;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(249, -1);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(151, 90);
            BtnOk.TabIndex = 4;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(471, -1);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(151, 90);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // BTSalir
            // 
            BTSalir.BackgroundImage = (Image)resources.GetObject("BTSalir.BackgroundImage");
            BTSalir.Location = new Point(1196, 11);
            BTSalir.Name = "BTSalir";
            BTSalir.Size = new Size(66, 66);
            BTSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BTSalir.TabIndex = 0;
            BTSalir.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 194);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 15;
            label1.Text = "Ingrese la categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(213, 194);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(443, 31);
            txtCategoria.TabIndex = 16;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCategoriaAE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(812, 317);
            Controls.Add(txtCategoria);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximumSize = new Size(834, 373);
            MinimumSize = new Size(834, 373);
            Name = "FrmCategoriaAE";
            Text = "Categorias";
            Load += Categorias_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox BTSalir;
        private Button BtnOk;
        private Button BtnCancelar;
        private Label label1;
        private TextBox txtCategoria;
        private ErrorProvider errorProvider1;
    }
}