using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Infrastructure;

namespace Datos.Repository
{
    public class LibrosRepositorio
    {
        public List<Libro> ObtenerLibros()
        {
            List<Libro> listadoRetorno = new List<Libro>();
            try
            {
                using( var contexto = new BibliotecaEntities())
                {
                   listadoRetorno= contexto.Libroes.ToList();
                }
                return listadoRetorno;
            }
            catch
            {

                return listadoRetorno;
            }
        }
        public List<Libro> 
    }
}
