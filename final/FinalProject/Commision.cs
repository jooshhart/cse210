public class Commission : Employee
{
    public double CommissionRate { get; set; }
    public double SalesAmount { get; set; }

    public override double CalculateMonthlyIncome()
    {
        return CommissionRate * SalesAmount;
    }
}