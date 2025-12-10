using ComidaRapida.Windows.Formularios;
using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComidaRapida.form
{
    public partial class FrmCombosAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Combo? combo;
        private readonly IServicioProducto? _servicios;


        private TipoProducto tipoProd;
        public FrmCombosAE(IServiceProvider? serviceProvider, TipoProducto tipo)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios = _serviceProvider!.GetRequiredService<IServicioProducto>() ??
                throw new ApplicationException("Dependencias no cargadas");
            tipoProd = tipo;
        }


        private void MostrarDatosCombo()
        {
            CombosHelper.CargarComboTamaño(ref cboTamanio, _serviceProvider);
            txtProducto.Text = combo.Nombre;
            txtDescripcion.Text = combo.Descripcion;
            txtPrecioVta.Text = combo.Detalles.Sum(d => d.sumatoriaPrecioventa).ToString("0.00");
            nudStock.Value = combo.Stock;
            cboTamanio.SelectedValue = combo.TamañoId;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var frm = new frmManejarProductosCombo(_serviceProvider) { Text = "Agregar producto al combo" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            DetalleCombo? detalle = frm.GetDetalles();
            if (detalle is null) return;



            if (combo!.Existe(detalle))
            {
                DialogResult drDetalle = MessageBox.Show(
                    $"¿Desea agregar el producto {detalle.producto!.Nombre}?", "Detalle Existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (drDetalle == DialogResult.Yes)
                {

                    detalle.sumatoriaPrecioventa = detalle.producto.Precio * detalle.cantidad;
                    combo!.Agregar(detalle);
                }

            }
            else
            {
                combo!.Agregar(detalle);
            }
            GridHelper.MostrarDatosEnGrilla<DetalleCombo>(combo.Detalles, dgvDatos);
        }

        public Combo? GetCombo()
        {
            return combo;
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                valido = false;
                errorProvider1.SetError(txtProducto, "El nombre del combo es requerido");
            }

            string patron = @"^\d+(\.\d+)?$";
            if (!Regex.IsMatch(txtPrecioVta.Text, patron))
            {
                errorProvider1.SetError(txtPrecioVta, "Precio de costo no es válido");
            }
            else
            {
                if (!decimal.TryParse(txtPrecioVta.Text, out decimal pCosto)
                || pCosto <= 0)
                {
                    valido = false;
                    errorProvider1.SetError(txtPrecioVta, "Precio de costo igual a cero");
                }
            }
            if (cboTamanio.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboTamanio, "Debe seleccionar un tamaño");
            }
            if (combo!.Detalles.Count < 1)
            {
                valido = false;
                errorProvider1.SetError(dgvDatos, "dentro del combo debe haber al menos dos productos");
            }
            return valido;

        }

        public void SetCombo(Combo combo)
        {
            this.combo = combo;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (combo is null)
            {
                txtPrecioVta.Text = "0";



                CombosHelper.CargarComboTamaño(ref cboTamanio, _serviceProvider);

                combo = new Combo();
            }
            if (combo is not null)
            {
                MostrarDatosCombo();
                GridHelper.MostrarDatosEnGrilla<DetalleCombo>(combo.Detalles, dgvDatos);

            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                combo!.Nombre = txtProducto.Text;
                combo.Descripcion = txtDescripcion.Text;
                txtPrecioVta.Text = combo.Precio.ToString("0.00");
                combo.Precio = combo.Detalles.Sum(d => d.sumatoriaPrecioventa);
                combo.Stock = (int)nudStock.Value;


                combo.TipoProductoId = (int)tipoProd;

                combo.TipoProducto = tipoProd;
                combo.TamañoId = (int)cboTamanio.SelectedValue!;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            DetalleCombo detalle = (DetalleCombo)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el producto {detalle.producto!.Nombre}?", "Borrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }

            if (dr == DialogResult.Yes)
            {
                combo!.Borrar(detalle);
                GridHelper.QuitarFila(r, dgvDatos);
                MessageBox.Show("Producto borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridHelper.MostrarDatosEnGrilla<DetalleCombo>(combo.Detalles, dgvDatos);

            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            DetalleCombo detalle = (DetalleCombo)r.Tag;
            var frm = new frmManejarProductosCombo(_serviceProvider) { Text = "Editar producto del combo" };
            frm.SetDetalle(detalle);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            DetalleCombo? detalleEditado = frm.GetDetalles();
            GridHelper.SetearFila(r, detalleEditado);
            MessageBox.Show("Producto editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void FrmCombosAE_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
