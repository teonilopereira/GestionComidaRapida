using Dapper;
using GestionComidaRapida.Datos.Interfaces;
using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
using System.Data.SqlClient;

namespace GestionComidaRapida.Datos.Repositorios
{
    public class RepositorioProducto : IRepositorioProducto
    {
        public RepositorioProducto() { }
        public void Agregar(Producto producto, TipoProducto tipoProducto, SqlConnection conn, SqlTransaction tran)
        {
            if (tipoProducto != TipoProducto.Combo)
            {
                string query = @"
                    INSERT INTO Productos (Producto, Descripcion,Stock, TamañoId, Precio, CategoriaId,Imagen)
                    VALUES (@Producto, @Descripcion,@Stock ,@TamañoId, @Precio, @CategoriaId,@Imagen );
                    SELECT CAST(SCOPE_IDENTITY() AS INT);
                ";

                int pk = conn.QuerySingle<int>(query, new
                {
                    Producto = producto.Nombre,
                    Descripcion = producto.Descripcion,
                    Stock = producto.Stock,
                    TamañoId = producto.TamañoId,
                    Precio = producto.Precio,
                    CategoriaId = producto.CategoriaId,
                    Imagen = producto.Imagen,
                }, tran);

                if (pk == 0) throw new Exception("No se pudo insertar el producto");

                producto.ProductoId = pk;
                return;
            }

            string queryCombo = @"
                INSERT INTO Combos (NombreCombo, Precio,Stock, Tamaño)
                VALUES (@Nombre, @Precio,@Stock, @Tamaño );
                SELECT CAST(SCOPE_IDENTITY() AS INT);
            ";

            int comboPk = conn.QuerySingle<int>(queryCombo, new
            {
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Stock = producto.Stock,
                Tamaño = producto.TamañoId
            }, tran);

            if (comboPk == 0) throw new Exception("No se pudo insertar el combo");

            producto.ProductoId = comboPk;
        }
        public void Borrar(TipoProducto tipoProducto, int productoId, SqlConnection conn, SqlTransaction tran)
        {
            if (tipoProducto != TipoProducto.Combo)
            {
                var deleteQuery = @"DELETE FROM Productos WHERE ProductoId=@ProductoId";
                int registrosAfectados = conn.Execute(deleteQuery, new { ProductoId = productoId }, tran);
                if (registrosAfectados == 0)
                    throw new Exception("No se pudo borrar el producto");

                return;
            }
            try
            {
                var deleteDetalles = "DELETE FROM DetallesCombos WHERE ComboId=@ProductoId";
                conn.Execute(deleteDetalles, new { ProductoId = productoId }, tran);

                var deleteCombo = "DELETE FROM Combos WHERE ComboId=@ProductoId";
                int rowsCombo = conn.Execute(deleteCombo, new { ProductoId = productoId }, tran);
                if (rowsCombo == 0) throw new Exception("No se pudo borrar el combo");
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException("No se puede eliminar el registro; existen dependencias (ventas u otras relaciones).", ex);
            }
        }
        public void Editar(Producto producto, TipoProducto tipoProducto, SqlConnection conn, SqlTransaction tran)
        {
            if (tipoProducto != TipoProducto.Combo)
            {
                string query = @"
            UPDATE Productos SET
                Producto = @Nombre,
                Stock=@Stock,
                Descripcion = @Descripcion,
                TamañoId = @TamañoId,
                Precio = @Precio,
                CategoriaId = @CategoriaId,
                Imagen = @Imagen
            WHERE ProductoId = @ProductoId;
        ";

                int rows = conn.Execute(query, new
                {
                    producto.Nombre,
                    producto.Descripcion,
                    producto.Stock,
                    producto.TamañoId,
                    producto.Precio,
                    producto.CategoriaId,
                    producto.Imagen,
                    producto.ProductoId
                }, tran);

                if (rows == 0)
                    throw new Exception("No se pudo editar el producto");

                return;
            }

            if (producto is Combo combo)
            {
                string queryCombo = @"
            UPDATE Combos SET
                NombreCombo = @Nombre,
                Descripcion = @Descripcion,
                Precio = @Precio,
                Stock=@Stock,
                Tamaño = @Tamaño
            WHERE ComboId = @ProductoId;
        ";

                int registrosAfectados = conn.Execute(queryCombo, new
                {
                    Nombre = combo.Nombre,
                    Descripcion = combo.Descripcion,
                    Precio = combo.Precio,
                    Stock = producto.Stock,
                    Tamaño = producto.TamañoId,
                    ProductoId = producto.ProductoId
                }, tran);

                if (registrosAfectados == 0)
                    throw new Exception("No se pudo editar el combo");
            }
        }
        public bool EstaRelacionado(TipoProducto tipoProducto, int productoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            if (tipoProducto is not TipoProducto.Combo)
            {
                var selectQuery = @"
            SELECT COUNT(*) 
            FROM DetallesCombos
            WHERE ProductoId = @ProductoId
        ";

                return conn.QuerySingle<int>(selectQuery, new { ProductoId = productoId }, tran) > 0;
            }
            else
            {
                var selectQuery = @" 
            SELECT COUNT(*) 
            FROM DetalleOrden
            WHERE ComboId = @ProductoId
        ";

                return conn.QuerySingle<int>(selectQuery, new { ProductoId = productoId }, tran) > 0;
            }
        }

        public bool Existe(Producto producto, SqlConnection conn, SqlTransaction? tran = null)
        {
            if (producto is Combo combo)
            {
                const string queryCombo = @"
            SELECT COUNT(*) FROM Combos
            WHERE NombreCombo = @Nombre AND Tamaño = @Tamaño
            AND ComboId <> @ProductoId
        ";

                return conn.QuerySingle<int>(queryCombo, new
                {
                    Nombre = combo.Nombre,
                    Tamaño = combo.TamañoId,
                    ProductoId = combo.ProductoId
                }, tran) > 0;
            }

            const string queryProducto = @"
        SELECT COUNT(*) FROM Productos
        WHERE Producto=@Nombre AND TamañoId=@TamañoId
        AND ProductoId<>@ProductoId
    ";

            return conn.QuerySingle<int>(queryProducto, new
            {
                Nombre = producto.Nombre,
                producto.TamañoId,
                producto.ProductoId
            }, tran) > 0;
        }
        public int GetCantidad(SqlConnection conn, TipoProducto tipo, Categorias? categorias = null, SqlTransaction? tran = null)
        {
            if (tipo == TipoProducto.Combo)
                return conn.ExecuteScalar<int>("SELECT COUNT(*) FROM Combos", null, tran);

            string query = "SELECT COUNT(*) FROM Productos";

            if (categorias is not null)
                query += " WHERE CategoriaId=@CategoriaId";

            return conn.ExecuteScalar<int>(query, new { CategoriaId = categorias?.CategoriaId }, tran);
        }


        public List<ProductoDtos> GetLista(
            SqlConnection conn,
            int currentPage,
            int pageSize,
            TipoProducto tipo,
            Orden? orden = Orden.Ninguno,
            Categorias? categorias = null,
            SqlTransaction? tran = null)
        {
            var listaProductos = new List<ProductoDtos>();
            int offset = (currentPage - 1) * pageSize;

            if (tipo == TipoProducto.Combo)
            {
                var selectQueryCombos = $@"
SELECT 
    c.ComboId AS ProductoId,
    c.NombreCombo AS Nombre,
    t.Tamaño AS Tamaño,
    c.Precio AS Precio,
    c.Stock AS Stock,
    'Combo' AS Categoria
FROM Combos c
INNER JOIN Tamaños t ON t.TamañoId = c.Tamaño
";

                string orderBy = orden switch
                {
                    Orden.NombreAZ => " ORDER BY c.NombreCombo",
                    Orden.NombreZA => " ORDER BY c.NombreCombo DESC",
                    Orden.PrecioAZ => " ORDER BY c.Precio",
                    Orden.PrecioZA => " ORDER BY c.Precio DESC",
                    _ => " ORDER BY c.ComboId",
                };

                selectQueryCombos += orderBy + " OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

                var listCombo = conn.Query<ProductoDtos>(selectQueryCombos, new { Offset = offset, PageSize = pageSize }, tran).ToList();
                listaProductos.AddRange(listCombo);
                return listaProductos;
            }

            // Productos
            var selectQuery = $@"
SELECT 
    p.ProductoId,
    p.Producto AS Nombre,
    t.Tamaño,
    p.Precio,
    c.Categoria,
    p.Stock
FROM Productos p
INNER JOIN Tamaños t ON t.TamañoId = p.TamañoId
INNER JOIN Categorias c ON c.CategoriaId = p.CategoriaId
WHERE 1=1
";

            if (categorias != null)
            {
                selectQuery += " AND p.CategoriaId = @CategoriaId";
            }

            string orderByProd = orden switch
            {
                Orden.NombreAZ => " ORDER BY p.Producto",
                Orden.NombreZA => " ORDER BY p.Producto DESC",
                Orden.PrecioAZ => " ORDER BY p.Precio",
                Orden.PrecioZA => " ORDER BY p.Precio DESC",
                _ => " ORDER BY p.ProductoId",
            };

            selectQuery += orderByProd + " OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

            var listaProd = conn.Query<ProductoDtos>(
                selectQuery,
                new { CategoriaId = categorias?.CategoriaId, Offset = offset, PageSize = pageSize },
                tran).ToList();

            listaProductos.AddRange(listaProd);
            return listaProductos;
        }
        public List<Producto> GetListaProductoCombo(SqlConnection conn)
        {
            string query = @"
                SELECT 
                    ProductoId,
                    Producto AS Nombre,
                    Descripcion,
                    TamañoId,
                    Precio,
                    CategoriaId,
                    Imagen
                FROM Productos
                ORDER BY Producto
            ";

            return conn.Query<Producto>(query).ToList();
        }
        public List<Producto> GetListaProductos(SqlConnection conn, TipoProducto tipo)
        {
            if (tipo == TipoProducto.Producto)
            {
                return conn.Query<Producto>(@"
                    SELECT ProductoId, Producto AS Nombre, Descripcion,
                           TamañoId, Precio, CategoriaId, Imagen
                    FROM Productos
                    ORDER BY Producto
                ").ToList();
            }

            return conn.Query<Combo>(@"
                SELECT ComboId AS ProductoId, NombreCombo AS Nombre, Precio, Tamaño
                FROM Combos
                ORDER BY NombreCombo
            ").Cast<Producto>().ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, TipoProducto tipo, string nombre, int pageSize, SqlTransaction? tran = null)
        {
            string query = (tipo == TipoProducto.Producto)
                ? @"
                    WITH X AS (
                        SELECT ROW_NUMBER() OVER (ORDER BY Producto) AS RowNum, Producto
                        FROM Productos
                    )
                    SELECT RowNum FROM X WHERE Producto=@Nombre
                "
                : @"
                    WITH X AS (
                        SELECT ROW_NUMBER() OVER (ORDER BY NombreCombo) AS RowNum, NombreCombo
                        FROM Combos
                    )
                    SELECT RowNum FROM X WHERE NombreCombo=@Nombre
                ";

            int pos = conn.ExecuteScalar<int>(query, new { Nombre = nombre });

            return (int)Math.Ceiling(pos / (decimal)pageSize);
        }

        // ============================================================
        //                    GET PRODUCTO POR ID
        // ============================================================
        public Producto? GetProductoPorId(TipoProducto tipo, int productoId, SqlConnection conn)
        {
            if (tipo != TipoProducto.Combo)
            {
                string query = @"
                    SELECT ProductoId, Producto AS Nombre, Descripcion,Stock,
                           TamañoId, Precio, CategoriaId, Imagen
                    FROM Productos
                    WHERE ProductoId=@Id
                ";

                return conn.QuerySingleOrDefault<Producto>(query, new { Id = productoId });
            }

                string comboQuery = @"
                SELECT 
                    ComboId AS ProductoId,
                    NombreCombo AS Nombre,
                    Precio,
                    Descripcion,
                   Stock,
                    Tamaño
                FROM Combos
                WHERE ComboId=@Id
            ";
                return conn.QuerySingleOrDefault<Combo>(comboQuery, new { Id = productoId });
            

        }
    }
}
        
    
