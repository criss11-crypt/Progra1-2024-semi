namespace proyecto_2024.Models
{
    public class Bomberos
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Direccion { get; set; }

        public string Dui { get; set; } = null!;
        public string? DescripcionCaso { get; set; } // Nueva propiedad
    }
}

