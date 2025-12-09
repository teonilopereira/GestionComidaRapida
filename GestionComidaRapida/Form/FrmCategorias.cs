using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.form;
using GestionComidaRapida.form.Helpers;
using GestionComidaRapida.Servicios;
using GestionComidaRapida.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GestionDePedidos.form
{
    public partial class FrmCategorias : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosCategorias? _servicio;
        private List<Categorias>? lista;

        public FrmCategorias(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            if (serviceProvider == null)
            {
                throw new ApplicationException("Dependencias no cargadas");
            }
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServiciosCategorias>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                lista = _servicio!.GetLista();
                GridHelper.MostrarDatosEnGrilla<Categorias>(lista, dgvDatos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmCategoriaAE frm = new FrmCategoriaAE(_serviceProvider) { Text = "Agregar Categoria" };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                Categorias? tipo = frm.GetCategorias();
                if (tipo is null) return;
                if (!_servicio!.Existe(tipo))
                {
                    _servicio!.Guardar(tipo);
                    DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, tipo);
                    GridHelper.AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Categoria Duplicado!!!",
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
            Categorias? categorias = (Categorias)r.Tag;
            FrmCategoriaAE frm = new FrmCategoriaAE(_serviceProvider) { Text = "Editar categoria" };
            frm.SetCategorias(categorias);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            categorias = frm.GetCategorias();
            if (categorias is null) return;
            try
            {
                if (!_servicio!.Existe(categorias))
                {
                    _servicio!.Guardar(categorias);

                    GridHelper.SetearFila(r, categorias);
                    MessageBox.Show("Registro modificado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("País Duplicado!!!",
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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            Categorias tipo = (Categorias)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja el categorias {tipo.Categoria}?",
                        "Confirmar Baja",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!_servicio!.EstaRelacionado(tipo.CategoriaId))
                {
                    _servicio!.Borrar(tipo.CategoriaId);
                    GridHelper.QuitarFila(r,
                                      dgvDatos);
                    MessageBox.Show("Registro eliminado",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro relacionado\nBaja Denegada",
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
    }
}
