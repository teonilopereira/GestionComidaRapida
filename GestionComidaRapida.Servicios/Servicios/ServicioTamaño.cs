using GestionComidaRapida.Datos.Interfaces;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Servicios.Interfaces;
using System.Data.SqlClient;

namespace GestionComidaRapida.Servicios.Servicios
{
    public class ServicioTamaño : IServicioTamaño
    {
        private readonly IRepositorioTamaño? _repositorio;
        private readonly string? _cadena;
        public ServicioTamaño(IRepositorioTamaño? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _cadena = cadena;
        }


        public List<Tamaños> GetLista()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                return _repositorio!.GetLista(conn);

            }
        }

    }
}
