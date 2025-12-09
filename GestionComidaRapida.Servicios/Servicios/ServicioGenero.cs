using GestionComidaRapida.Datos;
using GestionComidaRapida.Entidades;
using System.Data.SqlClient;

namespace GestionComidaRapida.Servicios
{
    public class ServicioGenero : IServicioGenero
    {
        private readonly IRepositorioGenero? _repositorio;
        private readonly string? _cadena;
        public ServicioGenero(IRepositorioGenero? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _cadena = cadena;
        }


        public List<Generos> GetLista()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                return _repositorio!.GetLista(conn);

            }
        }

    }
}
