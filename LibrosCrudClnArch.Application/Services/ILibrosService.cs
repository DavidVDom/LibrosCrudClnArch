using LibrosCrudClnArch.Application.DTO;

namespace LibrosCrudClnArch.Application.Services
{
    public interface ILibrosService
    {
        Task<List<LibroDto>> GetLibrosAsync();
    }
}
