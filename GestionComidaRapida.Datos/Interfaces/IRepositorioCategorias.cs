using GestionComidaRapida.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Datos.Interfaces
{
    public interface IRepositorioCategorias
    {
        void Agregar(Categorias categorias, SqlConnection conn, SqlTransaction? tran = null);
        void Borrar(int categoriaId, SqlConnection conn, SqlTransaction? tran = null);
        void Editar(Categorias categorias, SqlConnection conn, SqlTransaction? tran = null);
        bool EstaRelacionado(int tipoId, SqlConnection conn, SqlTransaction? tran = null);
        bool Existe(Categorias categorias, SqlConnection conn, SqlTransaction? tran = null);
        List<Categorias> GetLista(SqlConnection conn, SqlTransaction? tran = null);

    }
}
