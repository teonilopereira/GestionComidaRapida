using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.form.Helpers;
using GestionComidaRapida.Servicios;
using Microsoft.Extensions.DependencyInjection;

namespace GestionDePedidos.form
{
    public partial class FrmProductoAE : Form
    {

        private readonly IServiceProvider _serviceProvider;
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imágenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imágenes\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\Imágenes\";

        public FrmProductoAE(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        private Producto? producto;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboCategoria(ref CBCategoria, _serviceProvider);
            CombosHelper.CargarComboTamaño(ref CBTamaño, _serviceProvider);
            if (producto is not null)
            {
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                CBCategoria.SelectedValue = producto.CategoriaId;
                CBTamaño.SelectedValue = producto.TamañoId;
                txtPrecio.Text = producto.Precio.ToString();
                nudStock.Value = producto.Stock;
                if (producto.Imagen != string.Empty)
                {
                    if (!File.Exists($"{carpetaImagen}{producto.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{producto.Imagen}");
                        archivoImagen = producto.Imagen;
                    }
                }
                else
                {
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }

            }
        }
        public Producto? GetProducto()
        {

            return producto;
        }
        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto is null)
                {
                    producto = new Producto();
                }
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;

                producto.TamañoId = (int)CBTamaño.SelectedValue!;
                producto.CategoriaId = (int)CBCategoria.SelectedValue!;
                producto.Precio = decimal.Parse(txtPrecio.Text);
                producto.Stock = (int)nudStock.Value;
                if (!string.IsNullOrEmpty(archivoImagen))
                {
                    string nombreArchivo = Path.GetFileName(archivoImagen);
                    string destino = Path.Combine(carpetaImagen, nombreArchivo);
                    producto.Imagen = nombreArchivo;

                }
                if (producto.Imagen != string.Empty || producto.Imagen is not null)
                {
                    if (!File.Exists($"{carpetaImagen}{producto.Imagen}"))
                    {
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{producto.Imagen}");
                        archivoImagen = producto.Imagen;
                    }
                }
                else
                {
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }

                DialogResult = DialogResult.OK;

            }

        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "El nombre del producto es requerido");
            }
            if ((!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z ]+$")))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras");
            }
            if (CBTamaño.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CBTamaño, "Debe seleccionar un tamaño");
            }
            if (CBCategoria.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CBCategoria, "Debe seleccionar una categoria");
            }
            return valido;
        }
        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + @"\Imágenes\";
            openFileDialog1.Filter = @"Archivos jpg (*.jpg) | *.jpg | 
                Archivos png (*.png)  | *.png | 
                Archivos jfif (*.jfif) | *.jfif | 
                Todos (*.*) | *.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult dr = openFileDialog1.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                if (openFileDialog1.FileName == null)
                {
                    return;
                }
                picImagen.Image = Image.FromFile(openFileDialog1.FileName);
                archivoImagen = openFileDialog1.FileName;
            }

        }

        private void nudStock_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
