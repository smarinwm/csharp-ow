using Negocio.EntitiesDTO;
using Negocio.Management;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Views
{
    public partial class AltaLibro : Form
    {
        public LibrosDto libroMod;
        public AltaLibro(LibrosDto libro)
        {
            libroMod = libro;
            InitializeComponent();
        }


        public AltaLibro()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {


            if (libroMod != null)
            {
                libroMod.Nombre = txtNombre.Text;
                libroMod.Autor = txtAutor.Text;
                libroMod.idCategoria = new LibroManagement().ObtenerCategorias().First(b => b.Nombre == cmbCategoriaLibro.Text).idCategoria;
                libroMod.FechaPublicacion = DateTime.Now;

                new Negocio.Management.LibroManagement().ModificarLibro(libroMod);

            }
            else
            {
                LibrosDto libro = new LibrosDto();
                libro.Nombre = txtNombre.Text;
                libro.Autor = txtAutor.Text;
                libro.idCategoria = new LibroManagement().ObtenerCategorias().First(b => b.Nombre == cmbCategoriaLibro.Text).idCategoria;
                libro.FechaPublicacion = DateTime.Now;

                new Negocio.Management.LibroManagement().AltaLibro(libro);

            }

            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaLibro_Load(object sender, EventArgs e)
        {
            cmbCategoriaLibro.DataSource = new Negocio.Management.LibroManagement().ObtenerCategorias().Select(b => b.Nombre).ToList();

            if (libroMod != null)
            {
                txtNombre.Text = libroMod.Nombre;
                txtAutor.Text = libroMod.Autor;
                cmbCategoriaLibro.Text = new LibroManagement().ObtenerCategorias().First(b => b.idCategoria == libroMod.idCategoria).Nombre;

            }

        }
    }
}
