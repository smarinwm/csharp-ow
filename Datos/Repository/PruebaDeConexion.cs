using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Datos.Repository
{
    public class PruebaDeConexion

    {
        public Boolean ProbarConexion()
        {
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    List<Libro> librosRetorno = contexto.Libroes.ToList();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
