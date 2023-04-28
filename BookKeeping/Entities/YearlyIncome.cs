namespace BookKeeping.Entities;

public class YearlyIncome
{
    public int Id { get; set; }
    public int Year { get; set; }
    public decimal TotalIncome { get; set; }
    public ICollection<MonthlyIncome> MonthlyIncomes { get; set; }
    public ICollection<MonthlyCost> MonthlyCosts { get; set; }
    public ICollection<IncomeDynamic> IncomeDynamics { get; set; }
    public ICollection<CostDynamic> CostDynamics { get; set; }
}
