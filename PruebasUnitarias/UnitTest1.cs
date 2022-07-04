using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
                Negocio.EntitiesDTO.LibrosDto libroEjemplo = new Negocio.EntitiesDTO.LibrosDto();
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
