using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.form;
using GestionDePedidos.form;
using System;

namespace GestionComidaRapida
{
    public partial class MenuPrincipal : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        public MenuPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            var frm = new Empleados(_serviceProvider);
            frm.ShowDialog();
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            var frm = new FrmCategorias(_serviceProvider);
            frm.ShowDialog();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            var frm = new FrmProducto(_serviceProvider);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmCombos(_serviceProvider);
            frm.ShowDialog();
        }
    }
}
