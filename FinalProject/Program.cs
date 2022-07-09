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

while (users)
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

    oldIngredient.Clear();
    newIngredient.Clear();

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
            if (originalServing <= 0)
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
    while (newServing <= 0)
    {
        Console.Write(" HOw many serving do you want to be adjusted? ");
        try
        {
            newServing = int.Parse((Console.ReadLine() ?? "").Trim());
            if (newServing <= 0)
            {
                Console.WriteLine(" Error, You need to positive whole numbers.");
            }
        }

        catch
        {
            Console.WriteLine(" Error, You need to enter a whole number of serving, Please try again! ");
        }
    }

    scaleFactor = Convert.ToDouble(newServing) / Convert.ToDouble(originalServing);
    Console.WriteLine(" You want to scale a recipe for " + originalServing +
        " serving of " + recipe + " to feed " + newServing + " instead. ");

    Console.WriteLine(" Enter the original recipe ingredients and quantities below. " + "Type DONE if you are done. \n");

    while (ingredientName.ToUpper() != "DONE")
    {
        ingredientNumber = ingredientNumber + 1;
        ingredientName = "";
        ingredientString = "";
        ingredientAmount = 0.0;
        ingredientUnit = "";

        while (ingredientName == "")
        {
            Console.Write(" Name of ingredient # " + ingredientNumber + " : ");
            ingredientName = (Console.ReadLine() ?? "").Trim();
        }
        if (ingredientName.ToUpper() == "DONE")
        {
            Console.WriteLine(" End Of Ingredient for" + recipe + "");
            continue;
        }
        while (ingredientString == "" || ingredientAmount <= 0.0 || ingredientUnit == "")
        {
            Console.Write(" Amount of ingredient " + ingredientNumber + " , followed by units: ");
            if (ingredientString == "")
            {
                continue;
            }
            try
            {
                string numbersValidation = "0.123456789";
                string digits = new String(ingredientString.Where(c => numbersValidation.Contains(c)).ToArray());
                int i = digits.Count();

                ingredientAmount = Convert.ToDouble(ingredientString.Substring(0, i));
                ingredientUnit = ingredientString.Substring(i).Trim();
            }
            catch
            {
                Console.WriteLine(" Error, Enter a positive number followed by Characters representing a unit! ");
                ingredientAmount = 0.0;
                continue;
            }

            if (ingredientAmount <= 0.0 || ingredientUnit == "")

            {
                Console.WriteLine(" Error, You need a Positive amount and a unit for the ingredient. ");
                continue;
            }


            Console.WriteLine();
            Console.WriteLine("THe original recipe for " + recipe + " (serves " + originalServing + " ) ");
            foreach (KeyValuePair<string, string> thing in oldIngredient)
            {
                Console.WriteLine(" " + thing.Key + ": " + thing.Value);
            }
            Console.WriteLine("The new scaled recipe (serves " + newServing + "), printed to file" + recipe + ".txt");
            foreach (KeyValuePair<string, string> thing in newIngredient)
            {
                Console.WriteLine("" + thing.Key + ": " + thing.Value);
            }

            using (StreamWriter writer = File.CreateText(recipe + ".txt"))
            {
                writer.WriteLine("Recipe: " + recipe + "\n");
                writer.WriteLine("Original number of servings: " + originalServing);
                writer.WriteLine("Scaled number of servings: " + newServing + "\n");
                writer.WriteLine("Scaled ingredients and amounts =");

                foreach (KeyValuePair<string, string> thing in newIngredient) ;
            }
        }
    }
}
    Console.WriteLine("\n Thank you for using this program");