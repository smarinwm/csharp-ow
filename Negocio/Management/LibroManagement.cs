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

                librosDTO.idLibro = item.idLibro;
                librosDTO.Nombre = item.Nombre;
                librosDTO.Autor = item.Autor;
                librosDTO.FechaPublicacion = item.FechaPublicacion;
                librosDTO.idCategoria= item.idCategoria;

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

                categoriaDTO.idCategoria = item.idCategoria;
                categoriaDTO.Nombre = item.Nombre;

                ListadoRetorno.Add(categoriaDTO);

            }
            return ListadoRetorno;
        }


        public List<LibroConUnidadesDTO> ObtenerLibrosUnidades()
        {

            List<ObtenerLibrosConUnidades_Result> LibrosDatos = new Datos.Repository.LibrosRepositorio().ObtenerLibrosConUnidades();
            List<LibroConUnidadesDTO> ListadoRetorno = new List<LibroConUnidadesDTO>();

            foreach (var item in LibrosDatos)
            {
                LibroConUnidadesDTO librosDTO = new LibroConUnidadesDTO();

                librosDTO.AutorDelLibro = item.AutorDelLibro;
                librosDTO.NombreDelLibro = item.NombreDelLibro;
                librosDTO.Unidades = item.Unidades;

                ListadoRetorno.Add(librosDTO);

            }
            return ListadoRetorno;
        }

    }
}
