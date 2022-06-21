using Presentacion.Views;
using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            if (new Negocio.Management.PruebaDeConexion().pruebaDeConexion())
            {
                lblResultado.Text = "La conexión SI es correcta";
            }
            else
            {
                lblResultado.Text = "La conexión NO es correcta";
            }
            lblResultado.Visible = true;
        }


        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            AltaLibro pantallaAlta = new AltaLibro();
            pantallaAlta.ShowDialog();
            dgwLibros.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Negocio.EntitiesDTO.LibrosDTO libroSeleccionado = dgwLibros.CurrentRow.DataBoundItem as Negocio.EntitiesDTO.LibrosDTO;
            AltaLibro pantallaAlta = new AltaLibro(libroSeleccionado);
            pantallaAlta.ShowDialog();
            dgwLibros.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();

        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgwLibros.Rows.Count > 0)
            {
                Negocio.EntitiesDTO.LibrosDTO libroSeleccionado = dgwLibros.CurrentRow.DataBoundItem as Negocio.EntitiesDTO.LibrosDTO;

                if (new Negocio.Management.LibroManagement().VerificarUnidades(libroSeleccionado.idLibro))
                {
                    DialogResult Respuesta = MessageBox.Show("Este libro contiene unidades" + System.Environment.NewLine + "¡Estas seguro de eliminarlo?", "Validar eliminar", MessageBoxButtons.YesNo);
                    if (Respuesta == DialogResult.Yes)
                    {
                        new Negocio.Management.LibroManagement().EliminarLibro(libroSeleccionado);
                    }
                }
                else
                {
                    new Negocio.Management.LibroManagement().EliminarLibro(libroSeleccionado);
                }

                dgwLibros.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();
            }
        }

        private void btnConsultaLibros_Click(object sender, EventArgs e)
        {

            dgwLibros.DataSource = new Negocio.Management.LibroManagement().ObtenerLibros();

        }

        private void btnConsultaLibrosUnidades_Click(object sender, EventArgs e)
        {
            dgwLibros.DataSource = new Negocio.Management.LibroManagement().ObtenerLibrosUnidades();
        }
    }
}
