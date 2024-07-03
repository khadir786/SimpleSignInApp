// Simple sign in program
// User will be prompted for their username and password
// If it matches an already defined set, access is granted
// Otherwise, access is denied

string realUsername = "ruby_qube";
string realPassword = "tang0Orange93";


Console.WriteLine("Welcome to the sign in page.\n");
Console.WriteLine("Please enter your username and password\n");
Console.WriteLine("NOTE: You username and password must not be empty!\n");

bool inputCheck = false;

while (!inputCheck)
{
    Console.WriteLine("Username:");
    string? inputUsername = Console.ReadLine();
    Console.WriteLine("\nPassword:");
    string? inputPassword = Console.ReadLine();


    //Console.WriteLine($"You have entered: {inputUsername} and {inputPassword}");

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
    }
}

Console.WriteLine("Access granted!");


// Notes: Could have an internal attempt counter?
//          Where the user is locked out after a certain amount of tries



