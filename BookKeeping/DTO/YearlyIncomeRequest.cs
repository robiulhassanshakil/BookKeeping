using BookKeeping.Entities;

namespace BookKeeping.DTO;

public class YearlyIncomeRequest
{
    public int Year { get; set; }
    public decimal TotalIncome { get; set; }
    public ICollection<MonthlyIncomeRequest> MonthlyIncomes { get; set; }
    public ICollection<MonthlyCostRequest> MonthlyCosts { get; set; }
    public ICollection<IncomeDynamicRequest> IncomeDynamics{ get; set; }
    public ICollection<CostDynamicRequest> CostDynamics { get; set; }
}

public class CostDynamicRequest
{
    public string CostName { get; set; }
    public string CostValueJson { get; set; }
}

public class IncomeDynamicRequest
{
    public string IncomeName { get; set; }
    public string IncomeValueJson { get; set; }
}

public class MonthlyCostRequest
{
    public int Month { get; set; }
    public decimal Cost { get; set; }
}

public class MonthlyIncomeRequest
{
    public int Month { get; set; }
    public decimal Income { get; set; }
}