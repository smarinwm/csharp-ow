using Datos.Infrastructure;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;

namespace Negocio.Management
{
    public class LibroManagement
    {

        public List<LibrosDto> ObtenerLibros()
        {

            List<Libro> LibrosDatos = new Datos.Repository.LibrosRepositorio().ObtenerLibros();
            List<LibrosDto> ListadoRetorno = new List<LibrosDto>();

            foreach (var item in LibrosDatos)
            {
                LibrosDto librosDTO = new LibrosDto();

                Negocio.Utils.parse(item, ref librosDTO);


                ListadoRetorno.Add(librosDTO);

            }
            return ListadoRetorno;
        }


        public List<CategoriaDto> ObtenerCategorias()
        {

            List<Categoria> LibrosDatos = new Datos.Repository.LibrosRepositorio().ObtenerCategorias();
            List<CategoriaDto> ListadoRetorno = new List<CategoriaDto>();

            foreach (var item in LibrosDatos)
            {
                CategoriaDto categoriaDTO = new CategoriaDto();

                Negocio.Utils.parse(item, ref categoriaDTO);

                ListadoRetorno.Add(categoriaDTO);

            }
            return ListadoRetorno;
        }

        public void AltaLibro(LibrosDto libroAlta)
        {

            Libro libro = new Libro();

            Negocio.Utils.parse(libroAlta, ref libro);

            new Datos.Repository.LibrosRepositorio().AltaLibro(libro);
        }

        public void ModificarLibro(LibrosDto libroModificado)
        {
            Libro libro = new Libro();

            Negocio.Utils.parse(libroModificado, ref libro);

            new Datos.Repository.LibrosRepositorio().ModificarLibro(libro);

        }


        public void EliminarLibro(LibrosDto libroEliminar)
        {
            new Datos.Repository.LibrosRepositorio().EliminarLibro(libroEliminar.idLibro);


        }


        public Boolean VerificarUnidades(Int32 idLibro)
        {
            return new Datos.Repository.LibrosRepositorio().VerificarUnidades(idLibro);

        }


        public List<LibroConUnidadesDto> ObtenerLibrosUnidades()
        {

            List<ObtenerLibrosConUnidades_Result> LibrosDatos = new Datos.Repository.LibrosRepositorio().ObtenerLibrosConUnidades();
            List<LibroConUnidadesDto> ListadoRetorno = new List<LibroConUnidadesDto>();

            foreach (var item in LibrosDatos)
            {
                LibroConUnidadesDto librosDTO = new LibroConUnidadesDto();

                Negocio.Utils.parse(item, ref librosDTO);

                ListadoRetorno.Add(librosDTO);

            }
            return ListadoRetorno;
        }

    }
}
