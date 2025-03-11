namespace Parcial1.Models
{
    public class Carreras
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Rector { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
    }
}
