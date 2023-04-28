namespace BookKeeping.Entities;

public class IncomeDynamic
{
    public int Id { get; set; }
    public string IncomeName { get; set; }
    public string IncomeValueJson { get; set; }
    public int YearlyIncomeId { get; set; }
    public YearlyIncome YearlyIncome { get; set; }
}
