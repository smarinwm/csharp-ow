using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.EntitiesDTO;
using Negocio.Management;

namespace Presentacion.Views
{
    public partial class AltaLibro : Form
    {
        public AltaLibro()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LibrosDTO libro = new LibrosDTO();
            libro.Nombre = txtNombre.Text;
            libro.Autor = txtAutor.Text;
            libro.idCategoria = new Negocio.Management.LibroManagement().ObtenerCategorias().Where(b => b.Nombre == cmbCategoriaLibro.Text).First().idCategoria;
            libro.FechaPublicacion = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaLibro_Load(object sender, EventArgs e)
        {
            cmbCategoriaLibro.DataSource = new Negocio.Management.LibroManagement().ObtenerCategorias().Select(b => b.Nombre).ToList();
        }
    }
}
