#nullable disable

using DomainLayer.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DataAccess.Contexts;

public class DebtorsContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var ConnectionString = new ConfigurationManager()
            .AddJsonFile("C:\\Users\\asus\\source\\repos\\StepPractices2\\DataAccess\\AppSettings\\AppSettingsForConnectionStrings.json")
            .Build()
            .GetConnectionString("DefaultConnection");


        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(ConnectionString);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Debtor> Debtors { get; set; }
}
