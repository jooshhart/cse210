public class Income
{
    public double Calculate()
    {
        double totalIncome = 0;
        int end = 0;
            while (end != 1)
            {
                Console.WriteLine("Are you employed? (Write \"Y\" for Yes or \"N\" for No)");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    int ends = 0;
                    while (ends != 1)
                    {
                        Console.WriteLine("Which is your job?\n(1)Hourly\n(2)Salary\n(3)Commision\nPlease enter a number between 1-3:");
                        int enter = int.Parse(Console.ReadLine());
                        if (enter == 1)
                        {
                            Hourly h = new Hourly();
                            Console.WriteLine("How much do you make an hour?");
                            h.HourlyRate = double.Parse(Console.ReadLine());
                            Console.WriteLine("About how many hours do you work a month?");
                            h.HoursWorked = double.Parse(Console.ReadLine());
                            totalIncome = h.CalculateMonthlyIncome();
                            ends = 1;
                        }
                        else if (enter == 2)
                        {
                            Salary s = new Salary();
                            Console.WriteLine("What is your salary?");
                            s.yearlySalary = double.Parse(Console.ReadLine());
                            totalIncome = s.CalculateMonthlyIncome();
                            ends = 1;
                        }
                        else if (enter == 3)
                        {
                            Commission c = new Commission();
                            Console.WriteLine("What is your commission rate?");
                            c.CommissionRate = double.Parse(Console.ReadLine());
                            Console.WriteLine("What are your average sales?");
                            c.SalesAmount = double.Parse(Console.ReadLine());
                            totalIncome = c.CalculateMonthlyIncome();
                            ends = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number between 1-3: ");
                            Thread.Sleep(5000);
                        };
                        Console.Clear();
                    };
                    end = 1;
                }
                else if (answer == "N")
                {
                    totalIncome = 0;
                    Console.WriteLine("Your total income is $0.00");
                    Thread.Sleep(5000);
                    end = 1;
                }
                else
                {
                    Console.WriteLine("Please enter an answer between \"Y\" or \"N\"");
                    Thread.Sleep(5000);
                };
                Console.Clear();
            };
        return totalIncome;
    }
}