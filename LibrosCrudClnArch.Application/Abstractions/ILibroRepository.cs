using LibrosCrudClnArch.Domain.Entities;

namespace LibrosCrudClnArch.Application.Abstractions
{
    public interface ILibroRepository
    {
        public Task<List<Libro>> GetLibrosAsync();
        public Task<Libro> GetLibroAsync(int id);
        public Task<Libro> AddLibroAsync(Libro libro);
        public Task<Libro> UpdateLibroAsync(int id, Libro libro);
        public Task DeleteLibroAsync(int id);
    }
}
