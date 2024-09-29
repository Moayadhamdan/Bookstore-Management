using Bookstore_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore_Management.Data
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
