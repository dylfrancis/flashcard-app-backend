using FlashcardApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FlashcardApp.Data;

public class ApplicationDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<User> User { get; set; }
}