int cannonBlast = 0; // starting this at 0 ensures the loop will run

while (cannonBlast >=0 && cannonBlast <= 99) // list numbers between 1 and 100
{
    // increment if number is under 100
    cannonBlast++; 
    Console.WriteLine($"{cannonBlast}: Normal"); // if number isn't evenly divisible by 3 or 5, it's normal

    if (cannonBlast % 3 == 0 && cannonBlast % 5 == 0) // if number is divisible by both, it's a combo
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{cannonBlast}: Combo");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else if (cannonBlast % 3 == 0) // just divisble by 3 is fire
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{cannonBlast}: Fire");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else if (cannonBlast % 5 == 0) // just divisible by 5 is electric
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{cannonBlast}: Electric");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

}