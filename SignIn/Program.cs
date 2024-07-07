// Simple sign in program
// User will be prompted for their username and password
// If it matches an already defined set, access is granted
// Otherwise, access is denied

const string realUsername = "ruby_qube";
const string realPassword = "tang0Orange93";


Console.WriteLine("Welcome to the sign in page.\n");
Console.WriteLine("Please enter your username and password\n");
Console.WriteLine("NOTE: You username and password must not be empty!\n");

bool inputCheck = false;
byte attempts = 5;

Console.WriteLine($"You have {attempts} attempts\n");

while (!inputCheck && attempts != 0)
{
    Console.WriteLine("Username:");
    string? inputUsername = Console.ReadLine();
    Console.WriteLine("\nPassword:");
    string? inputPassword = Console.ReadLine();


    //Console.WriteLine($"You have entered: {inputUsername} and {inputPassword}");

    // checks if username or password are not a valid input,
    // if not, then checks if username and password are correct
    // if yes, loop condition is broken
    // otherwise, it is a bad attempt and have one less attempt
    if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
    {
        Console.WriteLine("Username and/or password is empty!\n");
        Console.WriteLine("Please enter a username and password that are not empty\n");
    }
    else if ((inputUsername.Equals(realUsername) && inputPassword.Equals(realPassword)))
    {
        inputCheck = true;
    }
    else
    {
        Console.WriteLine("\nUsername or password is incorrect");
        Console.WriteLine("Please try again\n");
        attempts--;
        Console.WriteLine($"You have {attempts} attempts left");
    }
}

// Message depending on if user inputs correct password or used all allotted attempts
Console.WriteLine(attempts <= 0 ? "You have used all of your attempts and are now locked out." : "Access granted!");





