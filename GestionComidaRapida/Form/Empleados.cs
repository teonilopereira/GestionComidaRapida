using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
using GestionComidaRapida.form;
using GestionComidaRapida.form.Helpers;
using GestionComidaRapida.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Printing;

namespace GestionDePedidos.form
{
    public partial class Empleados : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServicioEmpleado? _servicio;
        public Orden orden;

        private List<EmpleadosDtos> lista=null!;
        public Empleados(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            if (serviceProvider == null)
            {
                throw new ApplicationException("Dependencias no cargadas");
            }
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServicioEmpleado>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadData()
        {
            try
            {
                lista = _servicio!.GetLista(orden);
                    GridHelper.MostrarDatosEnGrilla<EmpleadosDtos>(lista, dgvDatos);
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            EmpleadosDtos empleadosDtos = (EmpleadosDtos)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja el empleado {empleadosDtos.Nombre}?",
                        "Confirmar Baja",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }


                _servicio!.Borrar(empleadosDtos.EmpleadoId);
                GridHelper.QuitarFila(r,
                                      dgvDatos);
                MessageBox.Show("Registro eliminado",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEmpleadoAE frm = new FrmEmpleadoAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                Empleado? empleado = frm.GetEmpleados();
                if (empleado is null) return;
                if (!_servicio!.Existe(empleado))
                {
                    _servicio!.Guardar(empleado);
                    LoadData();
                  //  DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                  //  GridHelper.SetearFila(r, empleado);
                  //  GridHelper.AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Empleado Duplicado!!!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            EmpleadosDtos empleadosDtos = (EmpleadosDtos)r.Tag;
            Empleado? empleado = _servicio!.GetEmpleadoPorId(empleadosDtos.EmpleadoId);
            if (empleado is null) return;
            FrmEmpleadoAE frm = new FrmEmpleadoAE(_serviceProvider) { Text = "Editar Empleado" };
            frm.SetEmpleado(empleado);//Acomodar recibe EmpleadoId=0 y no tiene que ser cero
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            empleado = frm.GetEmpleados();
            if (empleado == null) return;
            try
            {
                if (!_servicio!.Existe(empleado))
                {
                    _servicio!.Guardar(empleado);
                    LoadData();
                    MessageBox.Show("Registro modificado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Empleado Duplicado!!!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            }
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnNombreZA_Click(object sender, EventArgs e)
        {
            orden = Orden.NombreZA;
            LoadData();
        }

        private void BtnNombreAZ_Click(object sender, EventArgs e)
        {
            orden = Orden.NombreAZ;
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnApellidoAZ_Click(object sender, EventArgs e)
        {
            orden= Orden.ApellidoAZ;
            LoadData();
        }

        private void BtnApellidoZA_Click(object sender, EventArgs e)
        {
            orden=Orden.ApellidoZA;
            LoadData();

        }
    }
}
