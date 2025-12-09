using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.form.Helpers;
using GestionDePedidos.form;
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
    public partial class FrmCategoriaAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Categorias categorias;
        public FrmCategoriaAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        public Categorias? GetCategorias()
        {
            return categorias;
        }
        public void SetCategorias(Categorias categorias)
        {
            this.categorias = categorias;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (categorias != null)
            {
                txtCategoria.Text = categorias.Categoria;

            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                valido = false;
                errorProvider1.SetError(txtCategoria, "La categoriaa es requerido");
            }
            if ((!System.Text.RegularExpressions.Regex.IsMatch(txtCategoria.Text, @"^[a-zA-Z ]+$")))
            {
                valido = false;
                errorProvider1.SetError(txtCategoria, "El categoria solo debe contener letras");
            }
            return valido;
        }
        private void Categorias_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (categorias == null)
                {
                    categorias = new Categorias();
                }
                categorias.Categoria = txtCategoria.Text;
                DialogResult = DialogResult.OK;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
