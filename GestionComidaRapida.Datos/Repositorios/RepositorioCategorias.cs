using Dapper;
using GestionComidaRapida.Datos.Interfaces;
using GestionComidaRapida.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Datos.Repositorios
{
    public class RepositorioCategorias : IRepositorioCategorias
    {
        public void Agregar(Categorias tipo, SqlConnection conn, SqlTransaction? tran = null)
        {
            string insertQuery = @"INSERT INTO Categorias (Categoria) 
                    VALUES(@Categoria); SELECT CAST(SCOPE_IDENTITY() as int)";

            var primaryKey = conn.QuerySingle<int>(insertQuery, tipo, tran);
            if (primaryKey > 0)
            {

                tipo.CategoriaId = primaryKey;
                return;
            }

            throw new Exception("No se pudo agregar La categoria");
        }


        public void Borrar(int tipoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            string deleteQuery = @"DELETE FROM Categorias
                    WHERE CategoriaId=@TipoId";
            int registrosAfectados = conn
                .Execute(deleteQuery, new { tipoId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo borrar la categoria");
            }
        }

        public void Editar(Categorias tipo, SqlConnection conn, SqlTransaction? tran = null)
        {
            string updateQuery = @"UPDATE Categorias 
                    SET Categoria=@Categoria 
                    WHERE CategoriaId=@CategoriaId";

            int registrosAfectados = conn.Execute(updateQuery, tipo, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo edita la categoria");
            }
        }


        public bool EstaRelacionado(int tipoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            string selectQuery = @"SELECT COUNT(*) 
                            FROM Productos 
                                WHERE CategoriaId=@TipoId";
            return conn.
                QuerySingle<int>(selectQuery, new { tipoId }) > 0;

        }

        public bool Existe(Categorias tipo, SqlConnection conn, SqlTransaction? tran = null)
        {
            try
            {
                string selectQuery = @"SELECT COUNT(*) FROM Categorias ";
                string finalQuery = string.Empty;
                string conditional = string.Empty;
                if (tipo.CategoriaId == 0)
                {
                    conditional = "WHERE Categoria = @Categoria";
                }
                else
                {
                    conditional = @"WHERE Categoria = @Categoria
                            AND CategoriaId<>@CategoriaId";
                }
                finalQuery = string.Concat(selectQuery, conditional);
                return conn.QuerySingle<int>(finalQuery, tipo) > 0;

            }
            catch (Exception)
            {

                throw new Exception("No se pudo comprobar si existe la categoria");
            }

        }

        public List<Categorias> GetLista(SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT CategoriaId, Categoria FROM 
                    Categorias ORDER BY Categoria";
            return conn.Query<Categorias>(selectQuery).ToList();

        }
    }
}
