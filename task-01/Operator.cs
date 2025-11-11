public class Operator
{
    public void Add(int a, int b)
    {
        Console.WriteLine($"Sum of {a} and {b} is: {a + b}");
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine($"Difference of {a} and {b} is: {a - b}");
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine($"Product of {a} and {b} is: {a * b}");
    }

    public void Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine($"Division of {a} and {b} is: {a / (double)b}");
        }
    }

    public void OddEvenFinder(int number)
    {
        string result = (number % 2 == 0) ? $"The number {number} is even." : $"The number {number} is odd";
        Console.WriteLine(result);
    }

}
