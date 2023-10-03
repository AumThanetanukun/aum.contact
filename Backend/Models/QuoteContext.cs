using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

public class QuoteContext : DbContext
{
    public QuoteContext(DbContextOptions<QuoteContext> options)
        : base(options)
    {
    }

    public DbSet<QuoteItem> QuoteItems { get; set; } = null!;
}