namespace LibrosCrudClnArch.Application.DTO
{
    public record LibroDto
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public string? Descripcion { get; set; }

        public string? Autor { get; set; }

        public int Paginas { get; set; }

        public double Precio { get; set; }

        public DateTime Fecha { get; set; }
    }
}
