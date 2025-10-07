using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using library.Data;
using library.Models;

namespace library.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryContext _db;
        public BooksController(LibraryContext db) => _db = db;

        // Card grid with search/filter
        public async Task<IActionResult> Index(string? q, bool? onlySigned, double? minRating)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("user")))
                return RedirectToAction("Login", "Auth");

            var query = _db.Books.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(q))
                query = query.Where(b => b.Title.Contains(q) || b.Author.Contains(q));

            if (onlySigned == true)
                query = query.Where(b => b.Signed);

            if (minRating.HasValue)
                query = query.Where(b => b.Rating >= minRating.Value);

            var books = await query
                .OrderByDescending(b => b.Rating)
                .ThenBy(b => b.Title)
                .ToListAsync();

            ViewBag.Q = q;
            ViewBag.OnlySigned = onlySigned == true;
            ViewBag.MinRating = minRating ?? 0;

            return View(books);
        }

        // Details page with big cover and readable text
        public async Task<IActionResult> Details(int id)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("user")))
                return RedirectToAction("Login", "Auth");

            var book = await _db.Books.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
            if (book == null) return NotFound();

            return View(book);
        }

        
    }
}
