
namespace GestionComidaRapida
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTSalir = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            BtnProducto = new Button();
            BtnEmpleados = new Button();
            panel2 = new Panel();
            button1 = new Button();
            BtnCategorias = new Button();
            ((System.ComponentModel.ISupportInitialize)BTSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BTSalir
            // 
            BTSalir.BackgroundImage = form.Properties.Resources.line_md__logout;
            BTSalir.Location = new Point(691, 11);
            BTSalir.Name = "BTSalir";
            BTSalir.Size = new Size(66, 66);
            BTSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BTSalir.TabIndex = 0;
            BTSalir.TabStop = false;
            BTSalir.Click += BTSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = form.Properties.Resources.IconLogo;
            pictureBox2.Location = new Point(50, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(BTSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 90);
            panel1.TabIndex = 10;
            // 
            // BtnProducto
            // 
            BtnProducto.BackColor = Color.Indigo;
            BtnProducto.ForeColor = Color.Coral;
            BtnProducto.Location = new Point(0, 0);
            BtnProducto.Name = "BtnProducto";
            BtnProducto.Size = new Size(186, 74);
            BtnProducto.TabIndex = 0;
            BtnProducto.Text = "Producto";
            BtnProducto.UseVisualStyleBackColor = false;
            BtnProducto.Click += BtnProducto_Click;
            // 
            // BtnEmpleados
            // 
            BtnEmpleados.BackColor = Color.Indigo;
            BtnEmpleados.ForeColor = Color.Coral;
            BtnEmpleados.Location = new Point(-3, 286);
            BtnEmpleados.Name = "BtnEmpleados";
            BtnEmpleados.Size = new Size(186, 74);
            BtnEmpleados.TabIndex = 1;
            BtnEmpleados.Text = "Empleados";
            BtnEmpleados.UseVisualStyleBackColor = false;
            BtnEmpleados.Click += BtnEmpleados_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(BtnCategorias);
            panel2.Controls.Add(BtnEmpleados);
            panel2.Controls.Add(BtnProducto);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 360);
            panel2.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(0, 160);
            button1.Name = "button1";
            button1.Size = new Size(186, 74);
            button1.TabIndex = 5;
            button1.Text = "Combo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnCategorias
            // 
            BtnCategorias.BackColor = Color.Indigo;
            BtnCategorias.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategorias.ForeColor = Color.Coral;
            BtnCategorias.Location = new Point(0, 80);
            BtnCategorias.Name = "BtnCategorias";
            BtnCategorias.Size = new Size(186, 74);
            BtnCategorias.TabIndex = 4;
            BtnCategorias.Text = "Categorias";
            BtnCategorias.UseVisualStyleBackColor = false;
            BtnCategorias.Click += BtnCategorias_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(770, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(792, 506);
            MinimumSize = new Size(792, 506);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)BTSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private PictureBox BTSalir;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button BtnProducto;
        private Button BtnEmpleados;
        private Panel panel2;
        private Button BtnCategorias;
        private Button button1;
    }
}
