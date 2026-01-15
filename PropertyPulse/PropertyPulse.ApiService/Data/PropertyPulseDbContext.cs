using Microsoft.EntityFrameworkCore;
using PropertyPulse.ApiService.Models;

namespace PropertyPulse.ApiService.Data;

public class PropertyPulseDbContext(DbContextOptions<PropertyPulseDbContext> options) : DbContext(options)
{
    public DbSet<PropertyListing> Properties => Set<PropertyListing>();
    public DbSet<Agent> Agents => Set<Agent>();
    public DbSet<UserInteraction> UserInteractions => Set<UserInteraction>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.HasPostgresExtension("vector");

        modelBuilder.Entity<PropertyListing>()
            .Property(p => p.DescriptionEmbedding)
            .HasColumnType("vector(1536)");
    }
}
