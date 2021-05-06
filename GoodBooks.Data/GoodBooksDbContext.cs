using Microsoft.EntityFrameworkCore;
// using Npgsql.EntityFrameworkCore;
// using Npgsql;
// using Microsoft.EntityFrameworkCore.Design;
using GoodBooks.Data.Models;



namespace GoodBooks.Data {
    public class GoodBooksDbContext : DbContext
    {
        public GoodBooksDbContext() {}
        public GoodBooksDbContext(DbContextOptions options) : base(options) {}


        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookReview> BookReviews { get; set; }

    }
}
