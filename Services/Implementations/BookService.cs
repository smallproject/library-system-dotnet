using library_system_dotnet.Data;
using library_system_dotnet.Models.Dto.Book;
using library_system_dotnet.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace library_system_dotnet.Services.Implementations
{
    public class BookService: IBookService
    {
        private readonly AppDbContext _context;

        public BookService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<BookReadDto>> GetAllAsync(CancellationToken ct = default)
        {
            var books = await _context.Books.ToListAsync(ct);
            return await 
        }
    }
}
