// setting up inventory choices, book isn't as clear on this one, the web soltion clears it up though

Console.WriteLine("The following items are available: \n");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

// asking the user for a number choice from the list
Console.Write("What number do you want to see the price of? ");

// converting the user's response to an int
int itemNumber  = Convert.ToInt32(Console.ReadLine()); 

// using a switch to assign an the number entered to a string value
string item = itemNumber switch 
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Whatever that is, it isn't on the menu."
};

// using the string value and then assigning an int value
int itemPrice = item switch 
{
    "Rope" => 10,
    "Torches" => 16,
    "Climbing Equipment" => 24,
    "Clean Water" => 2,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 2,
};

Console.Write("What is your name? ");
string name = Console.ReadLine();

// if the person's name is Jerry, they get a 50% discount
if (name == "Jerry")
{
    itemPrice = itemPrice / 2;
}

Console.WriteLine($"{item} costs {itemPrice} gold.");