using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using Xunit;


int userChoices = 0;

Console.WriteLine(" Recipe Ingredients Scaler Program\n");

bool users;
string answer, recipe;
int originalServing, newServing;
double scaleFactor;
int ingredientNumber;
string ingredientName, ingredientString, ingredientUnit, newAmount;
double ingredientAmount;

Dictionary<string, string> oldIngredient = new Dictionary<string, string>();
Dictionary<string, string> newIngredient = new Dictionary<string, string>();



users = true;

while(user)
{
    answer = "";
    recipe = "";
    originalServing = 0;
    newServing = 0;
    scaleFactor = 1.0;
    ingredientNumber = 0;
    ingredientName = "";
    ingredientString = "";
    ingredientAmount = 0.0;
    ingredientUnit = "";
    newAmount = "";

    oldIngredients.Clear();
    newIngredients.Clear();

    Console.WriteLine();
    while (answer != "Y" && answer != "N")
    {
        Console.Write(" Do you wish to enter a new recipe? (Y/N): ");
        try
        {
            answer = (Console.ReadLine() ?? "").Trim().Substring(0, 1).ToUpper();
        }
        catch
        {
            continue;
        }
    }
    if (answer == "N")
    {
        users = false;
        continue;
    }

    Console.WriteLine();
    while (recipe == "")
    {
        Console.Write(" Enter the name of your recipe: ");
        recipe = (Console.ReadLine() ?? "").Trim();
    }

    Console.WriteLine();
    while (originalServing <= 0) 
    {
        Console.Write(" How many servings does the original recipe makes? ");
        try
        {
            originalServing = int.Parse((Console.ReadLine() ?? "").Trim());
            if(originalServing <= 0)
            {
                Console.WriteLine(" Error, Please enter a positive whole number. ");
            }
        }
        catch
        {
            Console.WriteLine("Error, You need to enter a whole number of serving. Please try again! ");
        }

    }

    Console.WriteLine();
    while(newServing <= 0)
    {
        Console.Write(" HOw many serving do you want to be adjusted? ");
        try
        {
            newServing = int.Parse((Console.ReadLine() ?? "").Trim());
        }
    }
    catch
    {
        Console.WriteLine(" Error, You need to enter a whole number of serving, Please try again! ");
    }

    scaleFactor = Convert.ToDouble(newServing) / Convert.ToDouble(originalServing);
    Console.WriteLine(" You want to scale a recipe for " + originalServing +
        " serving of " + recipe + " to feed " + newServing +
        "instead.");

    Console.WriteLine(" Enter the original recipe ingredients and quantities bew. " + "Type DONE if you are done. \n");

    while (ingredientName.ToUpper != "DONE")
    {
        ingredientNumber = ingredientNumber + 1;
        ingredientName = "";
        ingredientString = "";
        ingredientAmount = 0.0;
        ingredientUnit = "";
        while (ingredientName == "")
        {

        }
    }









}

