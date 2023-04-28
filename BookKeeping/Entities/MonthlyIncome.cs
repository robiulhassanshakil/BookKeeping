namespace BookKeeping.Entities;

public class MonthlyIncome
{
    public int Id { get; set; }
    public int Month { get; set; }
    public decimal Income { get; set; }
    public int YearlyIncomeId { get; set; }
    public YearlyIncome YearlyIncome { get; set; }
}
