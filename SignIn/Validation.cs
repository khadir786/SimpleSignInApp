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
}