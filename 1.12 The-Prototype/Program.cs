/* Ask user 1 for a number between 0-100, keep asking if the number is out of range
 * Clear screen once a valid number is chosen, then give an option for another user to guess the number
 * Keep asking user 2 for the number that user 1 chose until they get it right.*/

Console.Write("User 1, choose a number between 0 and 100: ");

// getting a number from user
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0 && number <= 100) // if the number is correct on the first try, move on to user 2 section
{
    Console.Clear();
}

while (number < 0 || number > 100) // while the number is out of range, keep asking
{
    Console.Write("That is not a valid number. Please try again: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number >= 0 && number <= 100) // if the number is in range, break the loop
    {
        Console.Clear();
        break;
    }

}

// getting number from user 2
Console.Write("User 2, guess the number: ");

int guess  = Convert.ToInt32(Console.ReadLine());

while (guess != number) // while the guess is inequal to the number, loop and keep asking
{
    if (guess > number)
    {
        Console.WriteLine($"{guess} is too high.");
        Console.Write("What is your next guess? ");
        guess = Convert.ToInt32(Console.ReadLine());
    }
    else if (guess < number)
    {
        Console.WriteLine($"{guess} is too low.");
        Console.Write("What is your next guess? ");
        guess = Convert.ToInt32(Console.ReadLine());
    }
}

// user 2 will only get here if they don't trigger the loop by entering an incorrect guess
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("You guessed the number!");
Console.ForegroundColor = ConsoleColor.Gray;