using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SiparisAdisyon.Entity.Models;

namespace SiparisAdisyon.Entity.Databases.Mssql;

public class ProjectDbContext : DbContext
{

    private readonly IConfiguration _config;

    public ProjectDbContext(IConfiguration config)
    {
        _config = config;
    }

    public ProjectDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _config.GetConnectionString("Default");
        optionsBuilder.UseSqlServer(connectionString);

    }


    public DbSet<Auth> Auth { get; set; }

    public DbSet<Role> Role { get; set; }

    public DbSet<Category> Category { get; set; }

    public DbSet<Company> Company { get; set; }

    public DbSet<City> City { get; set; }

    public DbSet<MenuItem> MenuItem { get; set; }

    public DbSet<Order> Order { get; set; }

    public DbSet<OrderItem> OrderItem { get; set; }

    public DbSet<Table> Table { get; set; }





}