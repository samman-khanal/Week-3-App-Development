public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any number: ");

        int N = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        //! Using For Loop
        for (int i = 1; i <= N; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("The sum of the first " + N + " numbers is: " + sum);

        //! Using While Loop
        int number = 1;
        while (number <= 20)
        {
            if (number % 4 == 0)
            {
                number++;
                continue;
            }
            if (number == 15)
            {
                break;
            }
            Console.Write(number + ", ");
            number++;
        }

        int[] numberArray = { 10, 20, 30, 40, 50 };
        sum = 0;
        foreach (int num in numberArray)
        {
            sum = sum + num;
        }
        Console.WriteLine("\nThe sum of the array elements is: " + sum);
    }

}