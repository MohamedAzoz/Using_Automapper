namespace APP_Using__Automapper.DTOs
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateOnly Date { get; set; }
        public string Author { get; set; }
    }
}
