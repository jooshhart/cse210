public class Expense
{
    public double Calculate()
    {
        Console.WriteLine("Enter your rent/housing: \n(If you don't pay this, then enter \"0\")");
        double home = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter your utilities/internet/cable: \n(If you don't pay this, then enter \"0\")");
        double util = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter your groceries: \n(If you don't pay this, then enter \"0\")");
        double groceries = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter your gas: \n(If you don't pay this, then enter \"0\")");
        double gas = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter your phone plan: \n(If you don't pay this, then enter \"0\")");
        double phone = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter your child care: \n(If you don't pay this, then enter \"0\")");
        double child = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter your average monthly entertainment expense: \n(If you don't pay this, then enter \"0\")");
        double entertain = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter your monthly insurance expense: \n(If you don't pay this, then enter \"0\")");
        double insure = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter your any money you owe: \n(If you don't pay this, then enter \"0\")");
        double owe = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter your monthly college tuition: \n(If you don't pay this, then enter \"0\")");
        double tuition = double.Parse(Console.ReadLine());
        Console.Clear();
        double expense = home + util + groceries + gas + phone + child + entertain + insure + owe + tuition;
        return expense;
    }
}