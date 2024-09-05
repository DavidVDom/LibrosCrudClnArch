using AutoMapper;
using LibrosCrudClnArch.Application.Abstractions;
using LibrosCrudClnArch.Application.DTO;

namespace LibrosCrudClnArch.Application.Services
{
    public class LibrosService : ILibrosService
    {
        private readonly IMapper _mapper;
        private readonly ILibroRepository _libroRepository;

        public LibrosService(IMapper mapper, ILibroRepository libroRepository)
        {
            _mapper = mapper;
            _libroRepository = libroRepository;
        }

        public async Task<List<LibroDto>> GetLibrosAsync()
        {
            var libros = await _libroRepository.GetLibrosAsync();
            var librosDto = _mapper.Map<List<LibroDto>>(libros);

            return librosDto;
        }
    }
}
