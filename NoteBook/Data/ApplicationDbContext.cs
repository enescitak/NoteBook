using Microsoft.EntityFrameworkCore;
using NoteBook.Models;

namespace NoteBook.Data
{
	public class ApplicationDbContext: DbContext
	{
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=NoteBookDB;User ID=sa;Password=Ens.4591");
        }
    }
}