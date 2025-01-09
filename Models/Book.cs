namespace BiblioWorld.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public int PublishedYear { get; set; }
        public string Summary { get; set; }
    }
}