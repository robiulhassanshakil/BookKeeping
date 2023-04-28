namespace BookKeeping.Entities;

public class MonthlyCost
{
    public int Id { get; set; }
    public int Month { get; set; }
    public decimal Cost { get; set; }
    public int YearlyIncomeId { get; set; }
    public YearlyIncome YearlyIncome { get; set; }
}
