namespace library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }           // book title
        public string Author { get; set; }          // author name
        public bool Signed { get; set; }            // signed copy (موقعة)
        public string? Description { get; set; }    // longer text about the book
        public string? ImagePath { get; set; }      // absolute/relative image url
        public double Rating { get; set; }          // 0.0 - 5.0
    }
}

