// setting up variables

int manticoreLocation = 0;
int cityHealth  = 15;
int manticoreHealth = 10;
int currentRound = 1;
int damage = 0;
int guess = 0;

// collecting a number between 1 and 100 from player 1
Console.Write("Player 1, how far away do you want to station the Manticore? ");
manticoreLocation = Convert.ToInt32(Console.ReadLine());

// loop until a valid number is taken
while (manticoreLocation < 0 || manticoreLocation > 100)
{
    Console.Write("Please enter a number between 0 and 100. ");
    manticoreLocation = Convert.ToInt32(Console.ReadLine());
}

// Clear the screen after player 1 has entered a valid number
Console.Clear();

// Starting the second player's turn
Console.WriteLine("Player 2, it is your turn.");


// looping the game
while (true)
{
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"STATUS: Round: {currentRound} City: {cityHealth}/15 Mainticore: {manticoreHealth}/10 ");


    // damage modifier based the round being a multiple of 3, 5, or both
    if (currentRound % 5 == 0 && currentRound % 3 == 0)
    {
        damage = 10;
    }
    else if (currentRound % 5 == 0)
    {
        damage = 3;
    }
    else if (currentRound % 3 == 0)
    {
        damage = 3;
    }
    else
    {
        damage = 1;
    }

    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    Console.Write("Enter desired cannon range: ");
    guess = Convert.ToInt32(Console.ReadLine());
    
    if (guess != manticoreLocation )
    {
        if (guess > manticoreLocation)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("That round OVERSHOT the target.");
            Console.ForegroundColor = ConsoleColor.Gray;

            cityHealth = cityHealth - 1;

            if (cityHealth == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You failed to stop the Manticore and the city of Consolas has been destroyed.");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            }
        }
        else if (guess < manticoreLocation)
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("That round FELL SHORT of the target.");
            Console.ForegroundColor = ConsoleColor.Gray;

            cityHealth = cityHealth - 1;

            if (cityHealth == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You failed to stop the Manticore and the city of Consolas has been destroyed.");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            }
        }
    }
    else if (guess == manticoreLocation)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.Gray;

        manticoreHealth = manticoreHealth - damage;

        if (manticoreHealth <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        }
    }

        // Round finished, increase round number and loop again
        currentRound++;

}







