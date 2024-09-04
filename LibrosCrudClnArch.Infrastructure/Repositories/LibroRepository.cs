using LibrosCrudClnArch.Domain.Entities;
using LibrosCrudClnArch.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibrosCrudClnArch.Infrastructure.Repositories
{
    public class LibroRepository : ILibroRepository
    {
        private readonly ApplicationDbContext _context;

        public LibroRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Libro> AddLibroAsync(Libro libro)
        {
            if (libro == null)
            {
                throw new ArgumentNullException(nameof(libro));
            }

            libro.Fecha = DateTime.Now;
            await _context.AddAsync(libro);
            await _context.SaveChangesAsync();

            return libro;

        }

        public async Task DeleteLibroAsync(int id)
        {
            var libroBd = await _context.FindAsync<Libro>(id);
            if (libroBd == null)
            {
                throw new Exception("No se ha encontrado el libro para borrar");
            }

            _context.Remove(libroBd);
            await _context.SaveChangesAsync();
        }

        public async Task<Libro> GetLibroAsync(int id)
        {
            var libroBd = await _context.Libro.FindAsync(id);
            if (libroBd == null)
            {
                throw new Exception("No se ha encontrado el libro");
            }

            return libroBd;
        }

        public async Task<List<Libro>> GetLibrosAsync()
        {
            return await _context.Libro.ToListAsync();
        }

        public async Task<Libro> UpdateLibroAsync(int id, Libro libro)
        {
            var libroBd = await _context.Libro.FindAsync(id);
            if (libroBd == null)
            {
                throw new Exception("No se ha encontrado el libro para actualizar");
            }

            libroBd.Titulo = libro.Titulo;
            libroBd.Descripcion = libro.Descripcion;
            libroBd.Autor = libro.Autor;
            libroBd.Paginas = libro.Paginas;
            libroBd.Precio = libro.Precio;

            await _context.SaveChangesAsync();

            return libroBd;
        }
    }
}
