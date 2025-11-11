using System.Runtime.CompilerServices;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string username = null;

        string display = (username == null) ? "Username is not available." : username;
        Console.WriteLine(display);

        //! Using null-coalescing operator
        Console.WriteLine(username ?? "Username is not available.");

        username ??= "User";
        Console.WriteLine($"Updated username: {username}");
    }
}
