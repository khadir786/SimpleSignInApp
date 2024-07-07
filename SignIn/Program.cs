// Simple sign in program
// User will be prompted for their username and password
// If it matches an already defined set, access is granted
// Otherwise, access is denied
// The user can also choose to swap between registering and signing in

using SignIn;

string currentPage = "login";

const string realUsername = "ruby_qube";
const string realPassword = "tang0Orange93";
const string welcomeMessage = """
                              Welcome to the sign in page
                              Please enter your username and password
                              NOTE: You username and password must not be empty!
                              """;

bool inputCheck = false;
byte attempts = 5;

Console.WriteLine(welcomeMessage);
Console.WriteLine("Type \"register\" in the username field to switch to the registration page\n");
Console.WriteLine($"You have {attempts} attempts\n");
while ((!inputCheck && attempts != 0))

{
    // If the current page is 'login', the user is prompted for a username and password
    if (currentPage.Equals("login"))
    {
        Console.WriteLine("Username:");
        string? inputUsername = Console.ReadLine();
        // Check if username is valid (not empty or null)
        // If not, warning messages are shown and user is prompted again
        if (!Validation.InputValidateUsername(inputUsername)) continue;
        // If the user inputs the "!register" command, they are taken to the registration page
        if (inputUsername.Equals("!register"))
        {
            currentPage = "register";
            Console.WriteLine("Switching to the registration page...\n");
            Console.WriteLine(welcomeMessage);
            Console.WriteLine("Type \"!login\" in the username field to switch the sign in page");
        }
        else if (inputUsername.Equals("!login")) Console.WriteLine("You are already on the sign in page!\n");
        // Any other input is categorised as incorrect, warning messages are shown with attempt counter
        else
        {
            Console.WriteLine("\nPassword:");
            string? inputPassword = Console.ReadLine();


            if (!Validation.InputValidatePassword(inputPassword)) continue;

            if (inputUsername.Equals(realUsername) && inputPassword.Equals(realPassword)) inputCheck = true;
            else
            {
                Console.WriteLine("\nUsername or password is incorrect");
                Console.WriteLine("Please try again\n");
                attempts--;
                Console.WriteLine($"You have {attempts} attempts left");
            }
        }
    }
    else
    {
        // Registration page
        Console.WriteLine("\nWhat will your username be? ");
        string? inputUsername = Console.ReadLine();
        // Check if username is valid (not empty or null)
        // If not, warning messages are shown and user is prompted again
        if (!Validation.InputValidateUsername(inputUsername)) continue;
        // If the user inputs the "!login" command, they are taken to the sign in page
        if (inputUsername.Equals("!login"))
        {
            currentPage = "login";
            Console.WriteLine("Switching to the sign in page...\n");
            Console.WriteLine(welcomeMessage);
            Console.WriteLine("Type \"!register\" in the username field to switch the registration page");
        }
        else if (inputUsername.Equals("!login")) Console.WriteLine("You are already on the sign in page!\n");
        else
        {
            Console.WriteLine("\nWhat will your password be?");
            string? inputPassword = Console.ReadLine();


            Validation.InputValidatePassword(inputPassword);
        }
    }


}

// Message depending on if user inputs correct password or used all allotted attempts
Console.WriteLine(attempts <= 0 ? "You have used all of your attempts and are now locked out." : "Access granted!");





