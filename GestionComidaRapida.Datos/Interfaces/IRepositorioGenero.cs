using GestionComidaRapida.Entidades;
using GestionComidaRapida.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Datos
{
    public  interface IRepositorioGenero
    {
        List<Generos> GetLista(SqlConnection conn, SqlTransaction? tran = null);
    }
}
