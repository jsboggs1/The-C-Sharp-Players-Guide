// ask for an x and y value and use if statements to deterimine the direction the enemy is coming from

int x;
int y;

Console.Write("X coordinate? "); // obtain x coord from user and convert to int
x = Convert.ToInt32(Console.ReadLine());

Console.Write("Y coordinate? "); // same as x coord step
y = Convert.ToInt32(Console.ReadLine());

if (x < 0) // could also write these as if (x < 0 && y > 0) individually
{
    Console.ForegroundColor = ConsoleColor.Green; // change color of enemy direction announcement

    if (y > 0)
    {
        Console.Write("The enemy is to the Northwest!");
    }
    if (y == 0)
    {
        Console.Write("The enemy is to the West!");
    }
    if (y < 0)
    {
        Console.Write("The enemy is to the Southwest!");
    }
    Console.ForegroundColor = ConsoleColor.Gray; // change the color back to normal after direction announcement
}

else if (x == 0) // if x < 0 is false, move on
{
    Console.ForegroundColor = ConsoleColor.Green;

    if (y > 0)
    {
        Console.Write("The enemy is to the North!");
    }
    if (y == 0)
    {
        Console.Write("They're right on top of us!");
    }
    if (y < 0)
    {
        Console.Write("The enemy is to the South!");
    }

    Console.ForegroundColor = ConsoleColor.Gray;
}

else if (x > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;

    if (y > 0)
    {
        Console.Write("The enemy is to the Northeast!");
    }
    if (y == 0)
    {
        Console.Write("The enemy is to the East!");
    }
    if (y < 0)
    {
        Console.Write("The enemy is to the Southeast!");
    }

    Console.ForegroundColor = ConsoleColor.Gray;
}

