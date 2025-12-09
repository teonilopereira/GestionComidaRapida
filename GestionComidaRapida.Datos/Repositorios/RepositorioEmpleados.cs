using Dapper;
using GestionComidaRapida.Datos.Interfaces;
using GestionComidaRapida.Entidades;
using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
using System.Data.SqlClient;

namespace GestionComidaRapida.Datos.Repositorios
{
    public class RepositorioEmpleados:IRepositorioEmpleados
    {
        public RepositorioEmpleados() { }
        public void Agregar(Empleado tipo, SqlConnection conn, SqlTransaction? tran = null)
        {
            string insertQuery = @"INSERT INTO Empleados (Nombre,Apellido,GeneroId,DNI,Direccion,Telefono,Gmail,FechaNacimiento) 
                    VALUES(@Nombre,@Apellido,@GeneroId,@DNI,@Direccion,@Telefono,@Gmail,@FechaNacimiento); SELECT CAST(SCOPE_IDENTITY() as int)";

            var primaryKey = conn.QuerySingle<int>(insertQuery, tipo, tran);
            if (primaryKey > 0)
            {

                tipo.EmpleadoId = primaryKey;
                return;
            }

            throw new Exception("No se pudo agregar el empleado");
        }

        public void Borrar(int tipoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            string deleteQuery = @"DELETE FROM Empleados
                    WHERE EmpleadoId=@TipoId";
            int registrosAfectados = conn
                .Execute(deleteQuery, new { tipoId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo borrar el empleado");
            }
        }

        public void Editar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null)
        {
            string updateQuery = @"UPDATE Empleados 
                    SET Nombre=@Nombre,
                    Apellido=@Apellido,
                    GeneroId=@GeneroId,
                    DNI=@DNI,
                    Direccion=@Direccion,
                    Telefono=@Telefono,
                    Gmail=@Gmail,
                   FechaNacimiento=@FechaNacimiento
                    WHERE EmpleadoId=@EmpleadoId";

            int registrosAfectados = conn.Execute(updateQuery, empleado, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo edita el empleado");
            }
        }

        public bool EstaRelacionado(int empleadoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            string selectQuery = @"SELECT COUNT(*) 
                            FROM Empleados 
                                WHERE EmpleadoId=@EmpleadoId";
            return conn.
                QuerySingle<int>(selectQuery, new { empleadoId }) > 0;
        }

        public bool Existe(Empleado tipo, SqlConnection conn, SqlTransaction? tran = null)
        {
            try
            {
                string selectQuery = @"SELECT COUNT(*) FROM Empleados ";
                string finalQuery = string.Empty;
                string conditional = string.Empty;
                if (tipo.EmpleadoId == 0)
                {
                    conditional = "WHERE DNI=@DNI ";
                }
                else
                {
                    conditional = @"WHERE DNI = @DNI
                            AND EmpleadoId<>@EmpleadoId";
                }
                finalQuery = string.Concat(selectQuery, conditional);
                return conn.QuerySingle<int>(finalQuery, tipo) > 0;

            }
            catch (Exception)
            {

                throw new Exception("No se pudo comprobar si existe el empleado");
            }
        }

        public int GetCantidad(SqlConnection conn, Generos? GeneroSeleccionado, SqlTransaction? tran = null)
        {
            var selectQuery = "SELECT COUNT(*) FROM Empleados";
            List<string> conditions = new List<string>();
            if (GeneroSeleccionado != null)
            {
                conditions.Add("GeneroId= @GeneroId");
            }
            if (conditions.Any())
            {
                selectQuery += string.Join(" AND ", conditions);
                return conn.ExecuteScalar<int>(selectQuery, new
                {
                    GeneroId = GeneroSeleccionado?.GeneroId,
                });

            }
            return conn.ExecuteScalar<int>(selectQuery);

        }

        public Empleado? GetEmpleadoPorId(int empleadoId, SqlConnection conn)
        {
            string selectQuery = @"SELECT EmpleadoId,Nombre,Apellido,GeneroId,DNI,Direccion,Telefono,Gmail,FechaNacimiento
                FROM Empleados 
                WHERE EmpleadoId=@EmpleadoId";
            return conn.QuerySingleOrDefault<Empleado>(
                selectQuery, new { @EmpleadoId = empleadoId });
        }

        public List<EmpleadosDtos> GetLista(SqlConnection conn,Orden orden, SqlTransaction? tran = null)
        {
            string selectQuery="";
            switch (orden)
            {
                case Orden.NombreAZ:
                    selectQuery = @"SELECT 
                     E.EmpleadoId,
                     E.Nombre,
                     E.Apellido,
                     G.Genero,
                     E.DNI,
                     E.Direccion,
                     E.Telefono,
                     E.Gmail,
                     E.FechaNacimiento
                     FROM Empleados E 
                     inner join Generos G on G.GeneroId=E.GeneroId
                     Order BY E.Nombre ";
                    break;
                case Orden.NombreZA:
                    selectQuery = @"SELECT 
                     E.EmpleadoId,
                     E.Nombre,
                     E.Apellido,
                     G.Genero,
                     E.DNI,
                     E.Direccion,
                     E.Telefono,
                     E.Gmail,
                     E.FechaNacimiento
                     FROM Empleados E 
                     inner join Generos G on G.GeneroId=E.GeneroId
                     Order BY E.Nombre desc";
                    break;
                case Orden.ApellidoAZ:
                    selectQuery = @"SELECT 
                     E.EmpleadoId,
                     E.Nombre,
                     E.Apellido,
                     G.Genero,
                     E.DNI,
                     E.Direccion,
                     E.Telefono,
                     E.Gmail,
                     E.FechaNacimiento
                     FROM Empleados E 
                     inner join Generos G on G.GeneroId=E.GeneroId
                     Order BY E.Apellido ";
                    break;
                case Orden.ApellidoZA:
                    selectQuery = @"SELECT 
                     E.EmpleadoId,
                     E.Nombre,
                     E.Apellido,
                     G.Genero,
                     E.DNI,
                     E.Direccion,
                     E.Telefono,
                     E.Gmail,
                     E.FechaNacimiento
                     FROM Empleados E 
                     inner join Generos G on G.GeneroId=E.GeneroId
                    Order BY E.Apellido desc";
                    break;
                default:
                    selectQuery = @"SELECT 
                     E.EmpleadoId,
                     E.Nombre,
                     E.Apellido,
                     G.Genero,
                     E.DNI,
                     E.Direccion,
                     E.Telefono,
                     E.Gmail,
                     E.FechaNacimiento
                     FROM Empleados E 
                     inner join Generos G on G.GeneroId=E.GeneroId";
                    break;
            }
            return conn.Query<EmpleadosDtos>(selectQuery).ToList();
        }

        public List<Empleado> GetListaCombo(SqlConnection conn, Generos generoSeleccionado)
        {
            string selectQuery = @"SELECT EmpleadoId, Nombre, 
                GeneroId FROM Empleados 
                WHERE GeneroId=@GeneroId ";
            return conn.Query<Empleado>(selectQuery, new
            {
                @GeneroId = generoSeleccionado.GeneroId,
            }).ToList();
        }
    }
}
