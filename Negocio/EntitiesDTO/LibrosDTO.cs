namespace Negocio.EntitiesDTO
{
    public class LibrosDto
    {
        public int idLibro { get; set; }
        public int idCategoria { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public System.DateTime FechaPublicacion { get; set; }
    }
}
