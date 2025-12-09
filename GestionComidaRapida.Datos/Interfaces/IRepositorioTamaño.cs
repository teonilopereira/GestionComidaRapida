using GestionComidaRapida.Entidades;
using GestionComidaRapida.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Datos.Interfaces
{
    public interface IRepositorioTamaño
    {
        List<Tamaños> GetLista(SqlConnection conn, SqlTransaction? tran = null);
    }
}
