using AutoMapper;
using LibrosCrudClnArch.Application.Abstractions;
using LibrosCrudClnArch.Application.DTO;
using LibrosCrudClnArch.Domain.Entities;

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

        public async Task<LibroDto> AddLibroAsync(LibroDto libro)
        {
            var libroNuevo = await _libroRepository.AddLibroAsync(_mapper.Map<Libro>(libro));
            return _mapper.Map<LibroDto>(libroNuevo);
        }

        public async Task<LibroDto> GetLibroAsync(int id)
        {
            var libro = await _libroRepository.GetLibroAsync(id);
            return _mapper.Map<LibroDto>(libro);
        }

        public async Task<LibroDto> UpdateLibroAsync(int id, LibroDto libro)
        {
            var libroUpdate = await _libroRepository.UpdateLibroAsync(id, _mapper.Map<Libro>(libro));
            return _mapper.Map<LibroDto>(libroUpdate);
        }

        public async Task DeleteLibroAsync(int id)
        {
            await _libroRepository.DeleteLibroAsync(id);
        }
    }
}
