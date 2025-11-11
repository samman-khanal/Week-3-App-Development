using System;
public class Program
{
    public static void Main(string[] args)
    {
        Operator op = new Operator();

        op.Add(10, 5);
        op.Subtract(10, 5);
        op.Multiply(10, 5);
        op.Divide(10, 5);
        op.Divide(10, 1);
        op.OddEvenFinder(7);
    }
}