using library.Models;
using Microsoft.EntityFrameworkCore;

namespace library.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books => Set<Book>();
        public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // keep the demo user
            const string saudHash = "5ecf004a27f10e2ec9350207cb1cc45134e9be971a48ca0dd04f309933759075";
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Saud",
                Username = "saud",
                PasswordHash = saudHash
            });

            // seed 50 books with images/ratings/descriptions
            var books = new List<Book>();
            string[] sampleTitles = new[]
            {
        "The Silent Library","Pages of Time","Ink & Ideas","Beyond The Stacks","Patterns of Code",
        "Sands of Memory","Hidden Chapters","The Archivist","Refactor Your Mind","Designing Harmony"
    };
            string[] sampleAuthors = new[]
            {
        "A. Reynolds","M. Castillo","R. Bennett","L. Nakamura","H. Ibrahim",
        "C. Martin","S. Patel","N. Alvarez","Y. Chen","D. Howard"
    };
            string[] sampleBlurbs = new[]
            {
        "A concise, human-friendly guide that turns complex ideas into daily tools.",
        "Short chapters, practical insights, and zero fluff—made for busy readers.",
        "A field note from the front desk: what to keep, what to search, and when.",
        "Tiny patterns that scale from a single page to a whole system.",
        "Calm explanations with examples you can try the same day."
    };

            var rand = new Random(2025);
            for (int i = 1; i <= 50; i++)
            {
                var title = $"{sampleTitles[i % sampleTitles.Length]} #{i}";
                var author = sampleAuthors[i % sampleAuthors.Length];
                var rating = Math.Round(rand.NextDouble() * 2 + 3, 1); // 3.0 ~ 5.0
                var signed = rand.Next(0, 2) == 1;

                books.Add(new Book
                {
                    Id = i,
                    Title = title,
                    Author = author,
                    Signed = signed,
                    Rating = rating,
                    Description = sampleBlurbs[i % sampleBlurbs.Length],
                    // deterministic cover via picsum
                    ImagePath = $"https://picsum.photos/seed/library_book_{i}/600/900"
                });
            }

            modelBuilder.Entity<Book>().HasData(books.ToArray());
        }

    }
}
