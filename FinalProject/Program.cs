using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using Xunit;


Console.WriteLine("Recipe Ingredients Scaler Program\n");

int userChoices = 0;


List<string> users = new List<string>();


do
{
    Console.Write("1) Enter a recipe name: \n2) Display your favorite recipe servings: \n0) Exit \n");
    try
    {
        userChoices = int.Parse(Console.ReadLine().Trim());
    }
    catch
    {
        userChoices = -1;
    }
    Console.Clear();

    switch (userChoices)
    {
        case 1:
            Console.Write("Enter recipe name: ");// Name your favorite recipe
            users.Add(Console.ReadLine().Trim());

            Console.Write("Original recipe serving size: "); // user input 1.5 will prompt error: do up functions
            double max = 10;
            users.Add(Console.ReadLine().Trim());

            //Error prompt = Please enter a whole and positive number!

            Console.Write("Desired serving size scaling: ");// Correct number in whole not decimals
            users.Add(Console.ReadLine().Trim());
            // if
            Console.Write("Ingredient name (enter DONE when ingredients list complete,ie:beef broth, chicken broth, pho broth etc: "); // Name of broth
            users.Add(Console.ReadLine().Trim());

            Console.Write("Ingredient amount (please enter the amount followed by a space, and then the units:"); // Which unit the user input mL, grams, lbs
            users.Add(Console.ReadLine().Trim());


            // If no for scaling should terminate and go back to main menu
            Console.Write("Would you like to enter another recipe for scaling (Yes/No)?:");//No
            users.Add(Console.ReadLine().Trim());
            break;


        case 2:
            foreach (string user in users) Console.WriteLine(user);
            break;

        case 0:
            break;
        default:
            // Display an error if the menu choice is invalid.
            Console.WriteLine("Please enter a valid input.");
            break;

    }

    Console.WriteLine();


} while (userChoices != 0);

// functions
void RecipeIngredient(ref string toDisplay)
{

}

/*
 double Scale(int value, int min, int max, int minScale, int maxScale)
{
    double scaled = minScale + (double)(value - min) / (max - min) * (maxScale - minScale);
    return scaled;
} */

