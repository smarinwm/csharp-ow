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


    }
}
