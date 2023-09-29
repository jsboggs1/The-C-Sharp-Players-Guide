// creation of tuple, names DO NOT MATTER but help code readability
(string type, string ingredient, string seasoning) soup = CombineSoup();

// tuple name is "soup", use the names listed in parentheses to access specific variable within tuple

// writing the tuple variables out
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{soup.seasoning} {soup.ingredient} {soup.type}");
Console.ForegroundColor = ConsoleColor.Gray;

// method to call other methods to return values for the tuple
(string, string, string) CombineSoup()
{
    string type = SoupCategory();
    string ingredient = SoupIngredient();
    string seasoning = SoupSeasoning();

    return (type, ingredient, seasoning);
}

// method for getting the type of soup
string SoupCategory()
{
    Console.Write("Choose a soup type: soup, stew, or gumbo. ");

    string choice = Console.ReadLine();

    return choice switch
    {
        "soup" => SoupType.Soup.ToString(),
        "stew" => SoupType.Stew.ToString(),
        "gumbo" => SoupType.Gumbo.ToString(),
    };
}

// method for getting the soup main ingredient
string SoupIngredient()
{
    Console.Write("Choose a main ingredient: mushroom, chicken, carrot, or potato. ");

    string choice = Console.ReadLine();

    return choice switch
    {
        "mushroom" => MainIngredient.Mushroom.ToString(),
        "chicken" => MainIngredient.Chicken.ToString(),
        "carrot" => MainIngredient.Carrot.ToString(),
        "potato" => MainIngredient.Potato.ToString(),
    };
}

// method for getting the soup seasoning
string SoupSeasoning()
{
    Console.Write("Choose a seasoning: spicy, salty, or sweet. ");

    string choice = Console.ReadLine();

    return choice switch
    {
        "spicy" => Seasoning.Spicy.ToString(),
        "salty" => Seasoning.Salty.ToString(),
        "sweet" => Seasoning.Sweet.ToString(),
    };
}


enum SoupType { Soup, Stew, Gumbo }
enum MainIngredient { Mushroom, Chicken, Carrot, Potato }
enum Seasoning { Spicy, Salty, Sweet }

/* the author of the book used methods that returned actual enumeration types instead of their string value
example for the Seasoning enum:

Seasoning GetSeasoning()
{
    Console.Write("Seasoning (spicy, salty, sweet): ");
    string input = Console.ReadLine();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet,
    };
}

so I could have used enumerations as the method return instead of strings that need to be converted
from the enums
*/

