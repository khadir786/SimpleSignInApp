namespace SignIn;

public class Validation
{
    public static bool InputValidate(string? inputUsername, string? inputPassword)
    {
        if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
        {
            Console.WriteLine("Username and/or password is empty!\n");
            Console.WriteLine("Please enter a username and password that are not empty\n");
            return false;
        }
        return true;
    }
    public static bool InputValidateUsername(string? inputUsername)
    {
        if (string.IsNullOrEmpty(inputUsername))
        {
            Console.WriteLine("Username is empty!\n");
            Console.WriteLine("Please enter a username that is not empty\n");
            return false;
        }
        return true;
    } 
    public static bool InputValidatePassword(string? inputPassword)
    {
        if (string.IsNullOrEmpty(inputPassword))
        {
            Console.WriteLine("Password is empty!\n");
            Console.WriteLine("Please enter a password that is not empty\n");
            return false;
        }
        return true;
    }
}