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


        public void EliminarLibro(Int32 idLibro)
        {

            using (var contexto = new BibliotecaEntities())
            {
                List<LibrosUnidade> libroUnidades = contexto.LibrosUnidades.Where(b => b.idLibro == idLibro).ToList();
                Libro libroEliminar = contexto.Libroes.Where(b => b.idLibro == idLibro).First();

                if (libroUnidades.Count > 0)
                {
                    contexto.LibrosUnidades.RemoveRange(libroUnidades);
                    contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }
                else
                {
                    contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }

            }

        }

        public Boolean VerificarUnidades(Int32 idLibro)
        {
            List<LibrosUnidade> libroConUnidades = new List<LibrosUnidade>();
            using (var contexto = new BibliotecaEntities())
            {
                libroConUnidades = contexto.LibrosUnidades.Where(b => b.idLibro == idLibro).ToList();
            }
            return libroConUnidades.Count > 0;
        }



    }
}
