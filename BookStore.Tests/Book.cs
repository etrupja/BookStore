namespace BookStore.Tests
{
    public class Book
    {
        public Book() { }
        public Book(int id, string title, int numberOfPages)
        {
            Id = id;
            Title = title;
            NrOfPages = numberOfPages;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int NrOfPages { get; set; }


        public string GetBookDetails(string title, int numberOfPages)
        {
            return $"Title: {title}, Nr of Pages: {numberOfPages}";
        }
    }
}
