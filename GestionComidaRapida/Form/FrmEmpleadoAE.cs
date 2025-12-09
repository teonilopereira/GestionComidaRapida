using GestionComidaRapida.Entidades;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.form.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionComidaRapida.form
{
    public partial class FrmEmpleadoAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Generos? generoSeleccionado;
        private Empleado? empleado;
        public FrmEmpleadoAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;


        }
        public Empleado? GetEmpleados()
        {
            return empleado;
        }
        public void SetEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboGenero(ref CBGenero, _serviceProvider);
            if (empleado != null)
            {
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                CBGenero.SelectedValue = empleado.GeneroId;
                txtDNI.Text = empleado.DNI;
                txtDireccion.Text = empleado.Direccion;
                txtTelefono.Text = empleado.Telefono?.ToString();
                DTPFechaNaci.Value = empleado.FechaNacimiento;
                txtGmail.Text = empleado.Gmail;


            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "El nombre es requerido");
            }
            else if ((!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z ]+$")))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras");
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "El apellido es requerido");
            }
            else if ((!System.Text.RegularExpressions.Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z ]+$")))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "El apellido solo debe contener letras");
            }
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                valido = false;
                errorProvider1.SetError(txtDNI, "La DNI es requerido");
            }
            if (txtDNI.Text.Length != 8 || !txtDNI.Text.All(char.IsDigit))
            {
                valido = false;
                errorProvider1.SetError(txtDNI, "El DNI debe tener 8 dígitos numéricos.");

            }
            return valido;
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (empleado == null)
                {
                    empleado = new Empleado();
                }
                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.GeneroId = (int)CBGenero.SelectedValue;
                empleado.DNI = txtDNI.Text.ToString();
                empleado.Direccion = txtDireccion.Text;
                empleado.Telefono = txtTelefono.Text.ToString();
                empleado.Gmail = txtGmail.Text;
                empleado.FechaNacimiento = DTPFechaNaci.Value;
                DialogResult = DialogResult.OK;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEmpleadoAE_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CBGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBGenero_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}
