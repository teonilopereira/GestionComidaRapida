using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.form.Helpers;
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
    public partial class FrmFiltro : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Categorias categorias;
        public FrmFiltro(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboCategoria(ref cboCategorias, _serviceProvider);
        }
        public Categorias? GetCategorias() 
        {
        
         return categorias;
        }

        private void FrmFiltro_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (cboCategorias.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboCategorias, "Debe seleccionar una categoria");
            }
            return valido;
        }
        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            categorias = (Categorias?)cboCategorias.SelectedItem?? null;
        }
    }
}
