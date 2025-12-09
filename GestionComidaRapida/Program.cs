using GestionComidaRapida.Di;

namespace GestionComidaRapida
{
    internal static class Program
    {
        private static IServiceProvider? _serviceProvider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            _serviceProvider = DI.ConfigurarServicios();
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuPrincipal(_serviceProvider));
        }
    }
}