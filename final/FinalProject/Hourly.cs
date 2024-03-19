public class Hourly : Employee
{
    public double HourlyRate { get; set; }
    public double HoursWorked { get; set; }

    public override double CalculateMonthlyIncome()
    {
        return HourlyRate * HoursWorked;
    }
}