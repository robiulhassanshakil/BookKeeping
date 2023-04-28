using BookKeeping.Contexts;
using BookKeeping.DTO;
using BookKeeping.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookKeeping.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookKeepingController : ControllerBase
{
    public BookKeepingContext _context { get; }

    public BookKeepingController(BookKeepingContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> InsertYearlyIncome([FromBody] YearlyIncomeRequest model)
    {
        try
        {
            var yearlyIncome = new YearlyIncome
            {
                Year = model.Year,
                TotalIncome = model.TotalIncome,
                MonthlyIncomes = model.MonthlyIncomes.Select(mi => new MonthlyIncome
                {
                    Month = mi.Month,
                    Income = mi.Income
                }).ToList(),
                MonthlyCosts = model.MonthlyCosts.Select(mc => new MonthlyCost
                {
                    Month = mc.Month,
                    Cost = mc.Cost
                }).ToList(),
                IncomeDynamics = model.IncomeDynamics.Select(mid => new IncomeDynamic 
                {
                    IncomeName = mid.IncomeName,
                    IncomeValueJson = mid.IncomeValueJson
                }).ToList(),
                CostDynamics = model.CostDynamics.Select(mid => new CostDynamic
                {
                    CostName = mid.CostName,
                    CostValueJson = mid.CostValueJson
                }).ToList(),
            };

            await _context.YearlyIncomes.AddAsync(yearlyIncome);
            await _context.SaveChangesAsync();

            return Created("", null);
        }
        catch (Exception ex)
        {
            return (StatusCode(500));
        }

    }

    [HttpGet("years")]
    public async Task<IActionResult> GetIncomeYears()
    {
        var incomeYears = await _context
            .YearlyIncomes
            .Select(x => x.Year)
            .ToListAsync();

        if (incomeYears is null)
        {
            return NotFound();
        }

        return Ok(incomeYears);
    }

    [HttpGet("{year}")]
    public async Task<IActionResult> GetByYear(int year)
    {
        var yearlyIncome = await _context
            .YearlyIncomes
            .Include(yi => yi.MonthlyIncomes)
            .Include(yi => yi.MonthlyCosts)
            .Include(yi => yi.IncomeDynamics)
            .Include(yi => yi.CostDynamics)
            .FirstOrDefaultAsync(yi => yi.Year == year);

        if (yearlyIncome == null)
        {
            return NotFound();
        }

        return Ok(yearlyIncome);
    }

    [HttpPost("updateDynamicValue")]
    public async Task<IActionResult> UpdateDynamicIncomeOrCost([FromBody] YearlyIncome model)
    {
        var p = model;
        try
        {
           

            return Ok(null);
        }
        catch (Exception ex)
        {
            return (StatusCode(500));
        }

    }

}
