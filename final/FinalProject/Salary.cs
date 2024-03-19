public class Salary : Employee
{
    public double yearlySalary { get; set; }

    public override double CalculateMonthlyIncome()
    {
        return yearlySalary/12;
    }
}