using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
using GestionComidaRapida.form;
using GestionComidaRapida.form.Helpers;
using GestionComidaRapida.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePedidos.form
{
    public partial class FrmProducto : Form
    {
        private List<ProductoDtos> lista = null!;
        private readonly IServicioProducto? _servicio;
        private readonly IServiceProvider? _serviceProvider;
        private Categorias? categoriasFilter = null;

        private bool filterOn = false;

        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;

        private TipoProducto tipoProducto = TipoProducto.Producto;
        private Orden orden = Orden.NombreAZ;
        public FrmProducto(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServicioProducto>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {

                RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            try
            {
                totalRecords = _servicio!.GetCantidad(tipoProducto);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                LoadData(tipoProducto);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LoadData(TipoProducto tipoProducto)
        {
            try
            {
                lista = _servicio!.GetLista(currentPage, pageSize,tipoProducto);
               
                GridHelper.MostrarDatosEnGrilla<ProductoDtos>(lista, dgvDatos);
                if (cboPaginas.Items.Count != totalPages)
                {
                    CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
                }
                txtCantidadPaginas.Text = totalPages.ToString();
                cboPaginas.SelectedIndexChanged -= cboPaginas_SelectedIndexChanged;
                cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;
                cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaginas.SelectedIndex >= 0)
            {
                currentPage = int.Parse(cboPaginas.Text);
                LoadData(tipoProducto);

            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(tipoProducto);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(tipoProducto);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            currentPage = totalPages;
            LoadData(tipoProducto);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData(tipoProducto);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmProductoAE frm = new FrmProductoAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Producto? producto = frm.GetProducto();
                if (producto is null) return;
                if (!_servicio!.Existe(producto))
                {
                    _servicio.Guardar(producto,tipoProducto);


                    totalRecords = _servicio?.GetCantidad(tipoProducto) ?? 0;
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicio?.GetPaginaPorRegistro(tipoProducto,producto.Nombre, pageSize) ?? 0;
                    RecargarGrilla();

                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente\nAlta denegada",
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
            if (r.Tag == null) return;
            ProductoDtos productoDto = (ProductoDtos)r.Tag;
            Producto? producto = _servicio!.GetProductoPorId(tipoProducto,productoDto.ProductoId);
            if (producto is null) return;
            FrmProductoAE frm = new FrmProductoAE(_serviceProvider) { Text = "Editar Producto" };
            frm.SetProducto(producto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            producto = frm.GetProducto();

            if (producto == null) return;
            try
            {

                if (!_servicio!.Existe(producto))
                {
                    _servicio!.Guardar(producto, tipoProducto);


                    currentPage = _servicio!.GetPaginaPorRegistro(tipoProducto, producto.Nombre, pageSize);
                    RecargarGrilla();
                    int row = GridHelper.ObtenerRowIndex(dgvDatos, producto.ProductoId);
                    GridHelper.MarcarRow(dgvDatos, row);
                    MessageBox.Show("Registro editado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro existente\nEdición denegada",
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
            var productoDto = (ProductoDtos)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el Producto {productoDto.Nombre}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                // Comprobar relaciones antes de borrar para evitar excepción por FK
                bool relacionado;
                try
                {
                    relacionado = _servicio!.EstaRelacionado(tipoProducto, productoDto.ProductoId);
                }
                catch (Exception ex)
                {
                    // Mensaje amistoso si hay problema al comprobar relaciones (p. ej. tabla inexistente)
                    MessageBox.Show("Error comprobando dependencias: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (relacionado)
                {
                    MessageBox.Show("No se puede eliminar el registro porque está relacionado con ventas o con un combo.",
                        "Registro relacionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                //if (!_servicio!.EstaRelacionado(tipoProducto, productoDto.ProductoId))
                //{
                _servicio!.Borrar(tipoProducto, productoDto.ProductoId);
                    totalRecords = _servicio!.GetCantidad(tipoProducto);
                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if (currentPage > totalPages) currentPage = totalPages;

                    RecargarGrilla();
                    MessageBox.Show("Registro eliminado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Registro relacionado!!", "Error",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            FrmFiltro frm = new FrmFiltro(_serviceProvider) { Text = "Filtro categoria" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            categoriasFilter = frm.GetCategorias();
            totalRecords = _servicio!?.GetCantidad(tipoProducto,categoriasFilter) ?? 0;
            totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);

            RecargarGrilla()
            ;
                filterOn = true;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            categoriasFilter = null;
            totalRecords = _servicio!?.GetCantidad(tipoProducto) ?? 0;
            totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);

            RecargarGrilla();
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
