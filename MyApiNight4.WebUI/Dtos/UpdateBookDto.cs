

namespace MyApiNight4.WebUI.Dtos 
{
    public class UpdateBookDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal BookPrice { get; set; }
        public int BookPageCount { get; set; }
        public string BookImageUrl { get; set; }






        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
