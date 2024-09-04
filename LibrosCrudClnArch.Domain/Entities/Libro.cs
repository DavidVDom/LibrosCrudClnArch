using System.ComponentModel.DataAnnotations;

namespace LibrosCrudClnArch.Domain.Entities
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        public string? Autor { get; set; }

        [Required(ErrorMessage = "La cantidad de páginas es obligatoria")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public double Precio { get; set; }

        public DateTime Fecha { get; set; }
    }
}
