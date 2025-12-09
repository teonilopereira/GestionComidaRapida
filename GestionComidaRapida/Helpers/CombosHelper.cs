using GestionComidaRapida.Entidades;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Servicios;
using GestionComidaRapida.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GestionComidaRapida.form.Helpers
{
    public static class CombosHelper
    {
        private static IServiceProvider? _serviceProvider;

        public static void CargarComboGenero(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServicioGenero? servicio = _serviceProvider?.GetService<IServicioGenero>();
            var lista = servicio?.GetLista();
            var defaultTipo = new Generos()
            {
                GeneroId = 0,
                Genero = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Genero";
            cbo.ValueMember = "GeneroId";
            cbo.SelectedIndex = 0;

        }
        public static void CargarComboCategoria(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosCategorias? servicio = _serviceProvider?.GetService<IServiciosCategorias>();
            var lista = servicio?.GetLista();
            var defaultTipo = new Categorias()
            {
                CategoriaId = 0,
                Categoria = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Categoria";
            cbo.ValueMember = "CategoriaId";
            cbo.SelectedIndex = 0;

        }
        public static void CargarComboTamaño(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServicioTamaño? servicio = _serviceProvider?.GetService<IServicioTamaño>();
            var lista = servicio?.GetLista();
            var defaultTipo = new Tamaños()
            {
                TamañoId = 0,
                Tamaño = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Tamaño";
            cbo.ValueMember = "TamañoId";
            cbo.SelectedIndex = 0;

        }



        public static void CargarComboPaginas(ref ComboBox cbo, int totalPages)
        {
            cbo.Items.Clear();
            for (int i = 1; i <= totalPages; i++)
            {
                cbo.Items.Add(i.ToString());
            }

        }
        public static void CargarComboProductos(ref ComboBox cbo, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServicioProducto? servicio = _serviceProvider?.GetService<IServicioProducto>();
            var lista = servicio?.GetListaProductoCombo();
            var defaultTipo = new Producto()
            {

                ProductoId = 0,
                Nombre = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "ProductoId";
            cbo.SelectedIndex = 0;
        }

    }
}
