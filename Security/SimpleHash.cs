using System.Security.Cryptography;
using System.Text;

namespace library.Security
{
    public static class SimpleHash
    {
        // Small, educational SHA-256 helper. Production apps should add salt + Identity.
        public static string Sha256(string input)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder();
            foreach (var b in bytes) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
    }
}
