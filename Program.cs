using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using Xunit;


Console.WriteLine("Recipe Ingredients Scaler Program");

int userChoices = 0;

List<string> users = new List<string>();


do
{
    Console.Write("1) Select a recipe name, ie: beef broth, chicken broth, pho broth etc: \n2) Exit");
    try
    {
        userChoices = int.Parse(Console.ReadLine().Trim());
    }
    catch
    {
        userChoices = -1;
    }
    Console.Clear();

    switch(userChoices)
    {
        case 1:
            Console.Write("Enter recipe name ie:beef broth, chicken broth, pho broth etc: ");// Name your broth
            users.Add(Console.ReadLine().Trim());

            Console.Write("Original recipe serving size: "); // user input 1.5 will prompt error: do up functions
            users.Add(Console.ReadLine().Trim());

            //Error prompt = Please enter a whole and positive number!

            Console.Write("Desired serving size scaling: ");// Correct number in whole not decimals
            users.Add(Console.ReadLine().Trim());

            Console.Write("Ingredient name (enter DONE when ingredients list complete: "); // Name of broth
            users.Add(Console.ReadLine().Trim());

            Console.Write("Ingredient amount (please enter the amount followed by a space, and then the units:"); // Which unit the user input mL, grams, lbs
            users.Add(Console.ReadLine().Trim());

            Console.Write("Ingredient name (enter DONE when ingredients list complete):");
            users.Add(Console.ReadLine().Trim());

            Console.Write("Ingredient amount (please enter the amount followed by a space, and then the units):");// Which unit the user input mL, grams, lbs
            users.Add(Console.ReadLine().Trim());

            Console.Write("Ingredient name (enter DONE when ingredients list complete):");//Chicken chunks
            users.Add(Console.ReadLine().Trim());

            Console.Write("Ingredient amount (please enter the amount followed by a space, and then the units):");//100g
            users.Add(Console.ReadLine().Trim());

            Console.Write("Ingredient amount (please enter the amount followed by a space, and then the units):");//Done
            users.Add(Console.ReadLine().Trim());

            Console.Write("Would you like to enter another recipe for scaling (Yes/No)?:");//No
            users.Add(Console.ReadLine().Trim());

            break;

        case 0:
            break;
    }

    Console.WriteLine();


} while (userChoices != 0);


/* int userChoice;

List<string> users = new List<string>();

do
{
    Console.Write("1) Create a new profile: \n2) View previous profile: \n0) Exit: ");
    try
    {
        userChoice = int.Parse(Console.ReadLine().Trim());
    }
    catch
    {
        userChoice = -1;
    }

    Console.Clear();
    switch (userChoice)
    {
        case 1:
            Console.Write("Please enter your first name: ");
            users.Add(Console.ReadLine().Trim());

            Console.Write("Please enter your last name: ");
            users.Add(Console.ReadLine().Trim());

            Console.Write("Please enter your address: ");
            users.Add(Console.ReadLine().Trim());

            Console.Write("Please enter your date of purchase YYYY-MM-DD: ");
            users.Add(Console.ReadLine().Trim());

            Console.Write("Please enter your brand of vehicle: ");
            users.Add(Console.ReadLine().Trim());

            Console.Write("Please enter your choice of model: ");
            users.Add(Console.ReadLine().Trim());

            Console.Write("Please enter your vehicle DOB: ");
            users.Add(Console.ReadLine().Trim());

            Console.Write("Please enter your vehicle VIN: \n");
            users.Add(Console.ReadLine().Trim());


            break;

        case 2:
            foreach (string user in users) Console.WriteLine(user);
            break;

        case 0:
            break;

    }

    Console.WriteLine();




} while (userChoice != 0);

    bool useRegex(String input)
    {
        return new Regex("\\([0-9]+\\)[0-9]+-[0-9]+", RegexOptions.IgnoreCase).IsMatch(input);
    } */