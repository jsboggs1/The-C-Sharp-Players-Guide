// use methods in this one

// setting up variables
int cityHealth = 15;
int manticoreHealth = 10;
int round = 1;


// calling a method to get player 1's number
// a variable must be made (range) to retrieve the result of the method, as variables within methods
// are inaccessible out of the method

int location = AskForTarget("Player 1, how far away from the city do you wish to station the Manticore? ", 0, 100);
Console.WriteLine("Player 2, it is your turn.");
Console.WriteLine("--------------------------");


// looping the game
while (true)
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    int damage = DamageCalculation();
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

    int guess = SecondPlayerGuess("Enter desired cannon range: ");

    round++;

    if (guess > location || guess < location)
    {
        cityHealth--;

        if (cityHealth <= 0)
        {
            break;
        }
    }
    else if (guess == location)
    {
        manticoreHealth = manticoreHealth - damage;

        if (manticoreHealth <= 0)
        {
            break;
        }
    }
}

bool winGame = cityHealth > 0;
GameCondition(winGame);

//------------------------------Method Setups-------------------------------------------------------

void GameCondition(bool winGame)
{
    if (winGame == false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city of Consolas has been destroyed. Everyone died and it's your fault.");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The city of Consolas has been saved! Hooray!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}

// function to get a number from player 1 between 0 and 100
int AskForTarget(string text, int min, int max)
{
    Console.Write(text);
    int target = Convert.ToInt32(Console.ReadLine());

    while (target < 0 || target > 100)
    {
        Console.Write("Please enter a number between 0 and 100. ");
        target = Convert.ToInt32(Console.ReadLine());
    }
    Console.Clear();
    return target;
}

// function to have player 2 guess the number that player 1 chose
int SecondPlayerGuess(string text)
{
    Console.WriteLine(text);
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess > location)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round OVERSHOT the target.");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("--------------------------");
    }
    else if (guess <  location)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round FELL SHORT of the target.");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("--------------------------");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT. ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("--------------------------");
    }
    return guess;
}

// function for determining how much damage the cannon will do
int DamageCalculation()
{
    int damage;

    if (round % 3 == 0 && round % 5 == 0)
    {
        damage = 10;
    }
    else if (round % 5 == 0)
    {
        damage = 3;
    }
    else if (round % 3 == 0)
    {
        damage = 3;
    }
    else
    {
        damage = 1;
    }
    return damage;
}

