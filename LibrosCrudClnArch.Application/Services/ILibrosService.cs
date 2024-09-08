using LibrosCrudClnArch.Application.DTO;

namespace LibrosCrudClnArch.Application.Services
{
    public interface ILibrosService
    {
        Task<List<LibroDto>> GetLibrosAsync();
        Task<LibroDto> AddLibroAsync(LibroDto libro);
        Task<LibroDto> GetLibroAsync(int id);
        Task<LibroDto> UpdateLibroAsync(int id, LibroDto libro);
        Task DeleteLibroAsync(int id);
    }
}
