using System;

namespace Negocio.Management
{
    public class PruebaDeConexion
    {
        public Boolean pruebaDeConexion()
        {
            return new Datos.Repository.PruebaDeConexion().ProbarConexion();
        }


    }
}
