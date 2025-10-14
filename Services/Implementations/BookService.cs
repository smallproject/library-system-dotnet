using AutoMapper;
using library_system_dotnet.Data;
using library_system_dotnet.Models.Dto.Book;
using library_system_dotnet.Services.Contracts;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace library_system_dotnet.Services.Implementations
{
    public class BookService: IBookService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public BookService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<BookReadDto>> GetAllAsync(CancellationToken ct = default)
        {
            var books = await _context.Books.ToListAsync(ct);
            return _mapper.Map<IEnumerable<BookReadDto>>(books);
        }
    }
}
