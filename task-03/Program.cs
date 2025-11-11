Console.Write("Enter the age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age < 13)
{
    Console.WriteLine("Child");
}
else if (age >= 13 && age <= 19)
{
    Console.WriteLine("Teenager");
}
else
{
    Console.WriteLine("Adult");
}