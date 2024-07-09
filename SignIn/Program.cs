// Simple sign in program
// User can choose between registering and logging in

// For registering
    // User will be prompted for their username and password
    // User will then be added to a collection of users

// For logging in
    // User will be prompted for their username and password
    // If it matches an already defined set, access is granted
    // Otherwise, access is denied


using System.Runtime.Serialization.Formatters;
using SignIn;

string menuSelection = "";
bool inputCheck = false;
byte attempts = 5;
Dictionary<string, string> users = new Dictionary<string, string>();
users.Add("ruby_qube", "tang0Orange93");

// menu will keep popping up until the user types exit, or they have no more login attempts
do
{
    Console.WriteLine("""
                      Welcome to sign in program!
                      Your options are:
                      1. Register 
                      2. Login
                      """);

    Console.WriteLine("Enter your selection number or type Exit to exit the program");
    string? readResult = Console.ReadLine();
    if (!string.IsNullOrEmpty(readResult))
    {
        menuSelection = readResult.ToLower();
    }

    bool validEntry = false;
    string? inputUsername;
    string? inputPassword;
    switch (menuSelection)
    {
        case "1":
            Console.WriteLine("""
                              
                              Welcome to the register page
                              Please enter your username and password
                              NOTE: You username and password must not be empty!

                              """);

            do
            {
                Console.WriteLine("Enter your username: ");
                inputUsername = Console.ReadLine();
                validEntry = Validation.InputValidateUsername(inputUsername);
            } while (!validEntry);

            do
            {
                Console.WriteLine("Enter your password: ");
                inputPassword = Console.ReadLine();
                validEntry = Validation.InputValidatePassword(inputPassword);
            } while (!validEntry);

            users.Add(inputUsername, inputPassword);
            Console.WriteLine($"\nThe user {inputUsername} has successfully been added!");
            Console.WriteLine("You may now choose to login\n");
            break;

        case "2":
            Console.WriteLine("""
                              Welcome to the login page
                              Please enter your username and password
                              NOTE: You username and password must not be empty!

                              """);
            Console.WriteLine($"You have {attempts} attempts\n");
            while (!inputCheck && attempts > 0)
            {
                do
                {
                    Console.WriteLine("Enter your username: ");
                    inputUsername = Console.ReadLine();
                    menuSelection = inputUsername;

                    validEntry = Validation.InputValidateUsername(inputUsername);
                } while (!validEntry);

                do
                {
                    Console.WriteLine("Enter your password: ");
                    inputPassword = Console.ReadLine();
                    menuSelection = inputUsername;

                    validEntry = Validation.InputValidatePassword(inputPassword);
                } while (!validEntry);
                if (users.ContainsKey(inputUsername) && users.ContainsValue(inputPassword))
                {
                    Console.WriteLine("Access granted!");
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
            break;

        default:
            break;
    }



} while (menuSelection != "exit" && attempts > 0 && !inputCheck);

if (attempts <= 0)
    Console.WriteLine("You have no attempts left and are now locked out");






