using Microsoft.EntityFrameworkCore;
using StudentLibraryWPF.Models;

namespace StudentLibraryWPF.Data
{
    public class LibraryContext : DbContext
    {
        private static LibraryContext _instance;
        public static LibraryContext Instance => _instance ??= new LibraryContext();

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Читает connectionString из App.config
            optionsBuilder.UseSqlite(
                System.Configuration.ConfigurationManager
                    .ConnectionStrings["LibraryDb"]
                    .ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // По желанию: seed-данные
            base.OnModelCreating(modelBuilder);
        }
    }
}
