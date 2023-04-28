namespace BookKeeping.Entities;

public class CostDynamic
{
    public int Id { get; set; }
    public string CostName { get; set; }
    public string CostValueJson { get; set; }
    public int YearlyIncomeId { get; set; }
    public YearlyIncome YearlyIncome { get; set; }
}