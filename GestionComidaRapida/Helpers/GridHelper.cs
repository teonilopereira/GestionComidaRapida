using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;

namespace GestionComidaRapida.form.Helpers
{
    public static class GridHelper
    {
        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgv) where T : class
        {
            LimpiarGrilla(dgv);
            if (lista is not null)
            {
                foreach (var tipo in lista)
                {
                    var r = ConstruirFila(dgv);
                    SetearFila(r, tipo);
                    AgregarFila(r, dgv);
                }

            }
        }
        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {

            switch (obj)
            {

                case EmpleadosDtos empleados:
                    r.Cells[0].Value = empleados.EmpleadoId;
                    r.Cells[1].Value = empleados.Nombre;
                    r.Cells[2].Value = empleados.Apellido;
                    r.Cells[3].Value = empleados.Genero;
                    r.Cells[4].Value = empleados.DNI;
                    r.Cells[5].Value = empleados.Direccion;
                    r.Cells[6].Value = empleados.Telefono;
                    r.Cells[7].Value = empleados.Gmail;
                    r.Cells[8].Value = empleados.FechaNacimiento;

                    break;
                case ProductoDtos producto:
                    r.Cells[0].Value = producto.ProductoId;
                    r.Cells[1].Value = producto.Nombre;
                    r.Cells[2].Value = producto.Precio;
                    r.Cells[3].Value = producto.Stock;
                    r.Cells[4].Value = producto.Tamaño;

                    break;
                case Combo combo:
                    r.Cells[0].Value = combo.ProductoId;
                    r.Cells[1].Value = combo.Nombre;
                    r.Cells[2].Value = combo.Precio;
                    r.Cells[3].Value =  combo.Precio;
                    break;
                case Categorias c:
                    r.Cells[0].Value = c.CategoriaId;
                    r.Cells[1].Value = c.Categoria;
                    break;
                case DetalleCombo d:
                    r.Cells[0].Value = d.detallesComboId;
                    r.Cells[1].Value = d.producto!.Nombre;
                    r.Cells[2].Value = d.cantidad;
                    r.Cells[3].Value = d.sumatoriaPrecioventa;
                    break;
                default:
                    break;
            }

            r.Tag = obj;
        }

        public static void AgregarFila(DataGridViewRow r,
            DataGridView grid)
        {
            grid.Rows.Add(r);
        }
        public static void QuitarFila(DataGridViewRow r,
            DataGridView grid)
        {
            grid.Rows.Remove(r);
        }

        public static int ObtenerRowIndex(DataGridView dgv, int id)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var row = dgv.Rows[i];
                if ((int)row.Cells[0].Value == id)
                {
                    return i;
                }
            }
            return -1;

        }

        public static void MarcarRow(DataGridView dgvDatos, int rowIndex)
        {
            if (rowIndex >= 0)
            {
                dgvDatos.Rows[rowIndex].Selected = true;
                dgvDatos.FirstDisplayedScrollingRowIndex = rowIndex;
            }

        }

        internal static void QuitarFila(DataGridViewRow r)
        {
            throw new NotImplementedException();
        }
    }
}
