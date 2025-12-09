using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
using GestionComidaRapida.form.Helpers;
using GestionComidaRapida.Servicios.Interfaces;
using GestionComidaRapida.Servicios.Servicios;
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

namespace GestionComidaRapida.form
{
    public partial class FrmCombos : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServicioProducto? _servicio;
        private List<ProductoDtos> lista;
        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;
        private Orden orden = Orden.NombreAZ;
        private TipoProducto tipoProducto = TipoProducto.Combo;
        public FrmCombos(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServicioProducto>() ??
                throw new ApplicationException("Dependencias no cargadas!!!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = int.Parse(cboPaginas.Text);
            RecargarGrilla();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmCombosAE frm = new FrmCombosAE(_serviceProvider, tipoProducto) { Text = "Agregar Combo" };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                Combo? combo = frm.GetCombo();
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                if (combo is null)
                {
                    return;
                }

                if (!_servicio!.Existe(combo))
                {
                    _servicio!.Guardar(combo, tipoProducto);

                    totalRecords = _servicio!.GetCantidad(tipoProducto);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicio!.GetPaginaPorRegistro(tipoProducto, combo.Nombre, pageSize);
                    RecargarGrilla();
                    int row = GridHelper.ObtenerRowIndex(dgvDatos, combo.ProductoId);
                    GridHelper.MarcarRow(dgvDatos, row);

                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Combo Duplicado!!!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }

            }
            catch (Exception)
            {

                throw;
            }
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
                try
                {
                    lista = _servicio!.GetLista(currentPage, pageSize, tipoProducto, orden);
                    if (lista.Count > 0)
                    {
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
                    else
                    {

                        MessageBox.Show("No hay registros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        currentPage = 1;
                        // tsbFiltrar.Enabled = true;

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void LoadData(TipoProducto tipoProducto)
        {
            try
            {
                lista = _servicio!.GetLista(currentPage, pageSize, tipoProducto, orden);
                if (lista.Count > 0)
                {
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
                else
                {

                    MessageBox.Show("No hay registros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentPage = 1;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmCombos_Load(object sender, EventArgs e)
        {
            try
            {
                totalRecords = _servicio!.GetCantidad(tipoProducto);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                currentPage = totalPages;
                RecargarGrilla();
            }
            catch (Exception)
            {

                throw;
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

            CombosDto comboDto = (CombosDto)r.Tag;
            Producto? comb = _servicio!?.GetProductoPorId(tipoProducto, comboDto.ProductoId);
            if (comb is null) return;



            FrmCombosAE frm = new FrmCombosAE(_serviceProvider, tipoProducto) { Text = "Editar Combo" };
            frm.SetCombo((Combo)comb!);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            comb = frm.GetCombo();
            if (comb is null) return;
            try
            {
                if (!_servicio!.Existe(comb))
                {
                    _servicio!.Guardar(comb, tipoProducto);

                    currentPage = _servicio!.GetPaginaPorRegistro(tipoProducto, comb.Nombre, pageSize);
                    RecargarGrilla();
                    int row = GridHelper.ObtenerRowIndex(dgvDatos, comb.ProductoId);
                    GridHelper.MarcarRow(dgvDatos, row);

                    MessageBox.Show("Registro modificado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Nugget Duplicado!!!",
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

            if (r.Tag is null) { return; }
            CombosDto productoDto = (CombosDto)r.Tag;
            Producto? prod = _servicio!?.GetProductoPorId(tipoProducto, productoDto.ProductoId);
            try
            {

                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja el {prod!.Nombre}?",
                       "Confirmar Baja",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!_servicio!.EstaRelacionado(tipoProducto, prod.ProductoId))
                {
                    _servicio!.Borrar(tipoProducto, prod.ProductoId);
                    totalRecords = _servicio!.GetCantidad(tipoProducto);
                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if (currentPage > totalPages) currentPage = totalPages;

                    RecargarGrilla();
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
    }
}
