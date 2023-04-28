using BookKeeping.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookKeeping.Contexts;


public class BookKeepingContext : DbContext
{
    public BookKeepingContext(
        DbContextOptions<BookKeepingContext> options)
        : base(options)
    {
    }

    public DbSet<YearlyIncome> YearlyIncomes { get; set; } = default!;
    public DbSet<MonthlyIncome> MonthlyIncomes { get; set; } = default!;
    public DbSet<MonthlyCost> MonthlyCosts { get; set; } = default!;
    public DbSet<IncomeDynamic> IncomeDynamics { get; set; } = default!;
    public DbSet<CostDynamic> CostDynamics { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}