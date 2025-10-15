namespace library_system_dotnet.Models.Dto.Book
{
    public class BookUpdateDto
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public int? PublishedYear { get; set; }
        public string? Genre { get; set; }
        public int? CopiesAvailable { get; set; }
        public int? TotalCopies { get; set; }
        public string? Location { get; set; }
        public string? CoverImageUrl { get; set; }
    }
}
