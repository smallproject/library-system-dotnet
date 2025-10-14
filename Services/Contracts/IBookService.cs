using library_system_dotnet.Models.Dto.Book;

namespace library_system_dotnet.Services.Contracts
{
    public interface IBookService
    {
        Task<IEnumerable<BookReadDto>> GetAllAsync(CancellationToken ct = default);
    }
}
