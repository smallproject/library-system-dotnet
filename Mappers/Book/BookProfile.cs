using AutoMapper;
using library_system_dotnet.Models.Dto.Book;

namespace library_system_dotnet.Mappers.Book
{
    public class BookProfile: Profile
    {
        public BookProfile()
        {
            CreateMap<Models.Book, BookReadDto>();
        }
    }
}
