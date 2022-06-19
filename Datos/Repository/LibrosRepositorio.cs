using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Repository
{
    public class LibrosRepositorio
    {
        public List<Libro> ObtenerLibros()
        {
            List<Libro> listadoRetorno = new List<Libro>();
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    listadoRetorno = contexto.Libroes.ToList();
                }
                return listadoRetorno;
            }
            catch
            {

                return listadoRetorno;
            }
        }

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> listadoRetorno = new List<Categoria>();
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    listadoRetorno = contexto.Categorias.ToList();
                }
                return listadoRetorno;
            }
            catch
            {

                return listadoRetorno;
            }
        }


        public List<ObtenerLibrosConUnidades_Result> ObtenerLibrosConUnidades()
        {
            List<ObtenerLibrosConUnidades_Result> listadoRetorno = new List<ObtenerLibrosConUnidades_Result>();
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    listadoRetorno = contexto.ObtenerLibrosConUnidades().ToList();
                }
                return listadoRetorno;
            }
            catch
            {

                return listadoRetorno;
            }
        }

        public void AltaLibro(Libro libroAlta)
        {

            using (var contexto = new BibliotecaEntities())
            {
                contexto.Libroes.Add(libroAlta);
                contexto.SaveChanges();
            }
        }

        public void ModificarLibro(Libro nuevoLibro)
        {
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    Libro libroOriginal = contexto.Libroes.Where(b => b.idLibro == nuevoLibro.idLibro).First();
                    libroOriginal.Nombre = nuevoLibro.Nombre;
                    libroOriginal.Autor = nuevoLibro.Autor;
                    libroOriginal.idCategoria = nuevoLibro.idCategoria;

                    contexto.Entry(libroOriginal).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }


        public void EliminarLibro(Int32 idLibro)
        {

            using (var contexto = new BibliotecaEntities())
            {
                List<LibrosUnidades> libroConUnidades = contexto.LibrosUnidades.Where(b => b.idLibroUnidades == idLibro).ToList();
                Libro libroEliminar = contexto.Libroes.Where(b => b.idLibro == idLibro).First();

                if (libroConUnidades.Count > 0)
                {
                    contexto.LibrosUnidades.RemoveRange(libroConUnidades);
                    contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;

                }
                else
                {
                    contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }


            }

        }



    }
}
