using GestionComidaRapida.Datos;
using GestionComidaRapida.Datos.Interfaces;
using GestionComidaRapida.Datos.Repositorios;
using GestionComidaRapida.Servicios;
using GestionComidaRapida.Servicios.Interfaces;
using GestionComidaRapida.Servicios.Servicios;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace GestionComidaRapida.Di
{
    public static class DI
    {
        public static IServiceProvider ConfigurarServicios()
        {
            var service = new ServiceCollection();

            var cadena = ConfigurationManager
                .ConnectionStrings["MiConexion"].ToString();

            service.AddScoped<IRepositorioEmpleados, RepositorioEmpleados>();
            service.AddScoped<IRepositorioCategorias, RepositorioCategorias>();
            service.AddScoped<IRepositorioGenero, RepositorioGenero>();
            service.AddScoped<IRepositorioTamaño,RepositorioTamaño>();
            service.AddScoped<IRepositorioProducto, RepositorioProducto>();

            service.AddScoped<IServicioTamaño>(sp =>
            {
                var repositorio = new RepositorioTamaño();
                return new ServicioTamaño(repositorio, cadena);
            });
            service.AddScoped<IServicioProducto>(sp =>
            {
                var repositorio = new RepositorioProducto();
                return new ServicioProducto(repositorio, cadena);
            });

            service.AddScoped<IServicioGenero>(sp =>
            {
                var repositorio = new RepositorioGenero();
                return new ServicioGenero(repositorio, cadena);
            });

            service.AddScoped<IServicioEmpleado>(sp =>
            {
                var repositorio = new RepositorioEmpleados();
                return new ServicioEmpleado(repositorio, cadena);
            });

            service.AddScoped<IServiciosCategorias>(sp =>
            {
                var repositorio = new RepositorioCategorias();
                return new ServiciosCategorias(repositorio, cadena);
            });
            return service.BuildServiceProvider();
        }
    }
}
