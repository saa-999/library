using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using library.Data;
using library.Security;

namespace library.Controllers
{
    public class AuthController : Controller
    {
        private readonly LibraryContext _db;
        public AuthController(LibraryContext db) => _db = db;

        [HttpGet]
        public IActionResult Login()
        {
            // shows the login form
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Login")]
        public async Task<IActionResult> LoginPost(string username, string password)
        {
            // hash the incoming password (simple demo)
            var hash = SimpleHash.Sha256(password); 


            // basic lookup for a matching user
            var user = await _db.Users.AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username == username && u.PasswordHash == hash);

            if (user == null)
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }

            // keep the username in session to know who's in
            HttpContext.Session.SetString("user", user.Username);

            // go to books page after a successful login
            return RedirectToAction("Index", "Books");
        }

        // Small sign-out just in case you need it later.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
