
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

namespace ComidaRapida.Windows.Formularios
{
    public partial class frmManejarProductosCombo : Form
    {
        private readonly IServiceProvider serviceProvider;
        private DetalleCombo detalleCombo;
        private Producto? productoSeleccionado;

        public frmManejarProductosCombo(IServiceProvider _serviceProvider)
        {
            InitializeComponent();
            serviceProvider = _serviceProvider;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboProductos(ref cboProductos, serviceProvider);
            if (detalleCombo is not null)
            {
                cboProductos.SelectedValue = detalleCombo.productoId;
                nudCantidad.Value = detalleCombo.cantidad;
            }
        }
        public DetalleCombo? GetDetalles()
        {
            return detalleCombo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (detalleCombo is null)
                {
                    detalleCombo = new DetalleCombo();

                }               
                detalleCombo.productoId = productoSeleccionado!.ProductoId;
                detalleCombo.producto= productoSeleccionado;

                detalleCombo.cantidad =(int)nudCantidad.Value;
                detalleCombo.sumatoriaPrecioventa = detalleCombo.cantidad * productoSeleccionado.Precio;
                productoSeleccionado=detalleCombo.producto;
                DialogResult = DialogResult.OK;
            }

        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (cboProductos.SelectedIndex == 0)
            {
                valid = false;
                errorProvider1.SetError(cboProductos, "Debe seleccionarse un producto");

            }

            return valid;
        }
        public DetalleCombo? GetDetalle()
        {
            return detalleCombo;
        }

        public void SetDetalle(DetalleCombo detalleCombo)
        {
            this.detalleCombo = detalleCombo;
        }
        private void frmManejarProductosCombo_Load(object sender, EventArgs e)
        {

        }

       

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            productoSeleccionado=cboProductos.SelectedIndex>0?(Producto)cboProductos.SelectedItem!:null;

        }
    }
}
