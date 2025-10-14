using library_system_dotnet.Models.Dto.Book;

namespace library_system_dotnet.Mappers.Book
{
    public class BookMapper
    {
        public static BookReadDto ToReadDto(Models.Book book)
        {
            return new BookReadDto
            {
                Id = book.Id,
                ISBN = book.ISBN,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                PublishedYear = book.PublishedYear,
                Genre = book.Genre,
                CopiesAvailable = book.CopiesAvailable,
                TotalCopies = book.TotalCopies,
                Location = book.Location,
                CoverImageUrl = book.CoverImageUrl
            };
        }
    }
}
