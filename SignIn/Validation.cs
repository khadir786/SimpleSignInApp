namespace SignIn;

public class Validation
{
    public static bool InputValidate(string? inputUsername, string? inputPassword)
    {
        if (!string.IsNullOrEmpty(inputUsername) && !string.IsNullOrEmpty(inputPassword)) return true;
        Console.WriteLine("Username and/or password is empty!\n");
        Console.WriteLine("Please enter a username and password that are not empty\n");
        return false;
    }
    public static bool InputValidateUsername(string? inputUsername)
    {
        if (!string.IsNullOrEmpty(inputUsername)) return true;
        Console.WriteLine("Username is empty!\n");
        Console.WriteLine("Please enter a username that is not empty\n");
        return false;
    } 
    public static bool InputValidatePassword(string? inputPassword)
    {
        if (!string.IsNullOrEmpty(inputPassword)) return true;
        Console.WriteLine("Password is empty!\n");
        Console.WriteLine("Please enter a password that is not empty\n");
        return false;
    }
}