public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            int number = Convert.ToInt32(input);
            Console.WriteLine("You entered the number: " + number);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number format.");
        }
        finally
        {
            Console.WriteLine("Program Executed.");
        }

        //! Program 2 
        try
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}