using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repository;
using Datos.Infrastructure;
using Negocio.EntitiesDTO;

namespace Negocio.Management
{
    public class LibroManagement
    {

        public List<LibrosDTO> ObtenerLibros()
        {

            List<Libro> LibrosDatos = new Datos.Repository.LibrosRepositorio().ObtenerLibros();
            List<LibrosDTO> ListadoRetorno = new List<LibrosDTO>();

                foreach (var item in LibrosDatos)
            {
                LibrosDTO librosDTO = new LibrosDTO();

                Negocio.Utils.parse(item, ref librosDTO);

                //librosDTO.idLibro = item.idLibro;
                //librosDTO.Nombre = item.Nombre;
                //librosDTO.Autor = item.Autor;
                //librosDTO.FechaPublicacion = item.FechaPublicacion;
                //librosDTO.idCategoria= item.idCategoria;

                ListadoRetorno.Add(librosDTO);

            }
            return ListadoRetorno;
        }


        public List<CategoriaDTO> ObtenerCategorias()
        {

            List<Categoria> LibrosDatos = new Datos.Repository.LibrosRepositorio().ObtenerCategorias();
            List<CategoriaDTO> ListadoRetorno = new List<CategoriaDTO>();

            foreach (var item in LibrosDatos)
            {
                CategoriaDTO categoriaDTO = new CategoriaDTO();

                Negocio.Utils.parse(item, ref categoriaDTO);

                //categoriaDTO.idCategoria = item.idCategoria;
                //categoriaDTO.Nombre = item.Nombre;

                ListadoRetorno.Add(categoriaDTO);

            }
            return ListadoRetorno;
        }

        public void AltaLibro(LibrosDTO libroAlta)
        {

            Libro libro = new Libro();

            Negocio.Utils.parse(libroAlta, ref libro);

            //libro.idCategoria = libroAlta.idCategoria;
            //libro.Nombre = libroAlta.Nombre;
            //libro.Autor = libroAlta.Autor;
            //libro.FechaPublicacion = libroAlta.FechaPublicacion;

            new Datos.Repository.LibrosRepositorio().AltaLibro(libro);
        }

        public void ModificarLibro(LibrosDTO libroModificado)
        {
            Libro libro = new Libro();

            Negocio.Utils.parse(libroModificado, ref libro);

            //libro.idLibro = libroModificado.idLibro;
            //libro.idCategoria = libroModificado.idCategoria;
            //libro.Nombre = libroModificado.Nombre;
            //libro.Autor = libroModificado.Autor;
            //libro.FechaPublicacion = libroModificado.FechaPublicacion;

            new Datos.Repository.LibrosRepositorio().ModificarLibro(libro);

        }


        public void EliminarLibro(LibrosDTO libroEliminar)
        {
            new Datos.Repository.LibrosRepositorio().EliminarLibro(libroEliminar.idLibro);


        }


        public Boolean VerificarUnidades(Int32 idLibro)
        {
            return new Datos.Repository.LibrosRepositorio().VerificarUnidades(idLibro);

        }


        public List<LibroConUnidadesDTO> ObtenerLibrosUnidades()
        {

            List<ObtenerLibrosConUnidades_Result> LibrosDatos = new Datos.Repository.LibrosRepositorio().ObtenerLibrosConUnidades();
            List<LibroConUnidadesDTO> ListadoRetorno = new List<LibroConUnidadesDTO>();

            foreach (var item in LibrosDatos)
            {
                LibroConUnidadesDTO librosDTO = new LibroConUnidadesDTO();

                Negocio.Utils.parse(item, ref librosDTO);

                //librosDTO.AutorDelLibro = item.AutorDelLibro;
                //librosDTO.NombreDelLibro = item.NombreDelLibro;
                //librosDTO.Unidades = item.Unidades;

                ListadoRetorno.Add(librosDTO);

            }
            return ListadoRetorno;
        }

    }
}
