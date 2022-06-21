using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negocio;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AltaLibro()
        {

            try
            {
                Negocio.EntitiesDTO.LibrosDTO libroEjemplo = new Negocio.EntitiesDTO.LibrosDTO();
                libroEjemplo.Nombre = "Prueba";
                libroEjemplo.Autor = "Autor";
                libroEjemplo.FechaPublicacion = DateTime.Now;
                libroEjemplo.idCategoria = 1;

                new Negocio.Management.LibroManagement().AltaLibro(libroEjemplo);
            }
            catch (Exception)
            {
                Assert.IsTrue(false, "Alta de libro ERROR");
                throw;
            }
        }
    }
}
