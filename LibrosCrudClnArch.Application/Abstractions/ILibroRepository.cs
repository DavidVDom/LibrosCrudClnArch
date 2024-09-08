using LibrosCrudClnArch.Domain.Entities;

namespace LibrosCrudClnArch.Application.Abstractions
{
    public interface ILibroRepository
    {
        Task<List<Libro>> GetLibrosAsync();
        Task<Libro> GetLibroAsync(int id);
        Task<Libro> AddLibroAsync(Libro libro);
        Task<Libro> UpdateLibroAsync(int id, Libro libro);
        Task DeleteLibroAsync(int id);
    }
}
