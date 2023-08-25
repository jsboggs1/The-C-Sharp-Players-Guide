Console.Title = "The Defense of Consolas";

int row;
int column;

Console.Write("Target row? ");
row = Convert.ToInt32(Console.ReadLine());

Console.Write("Target column? ");
column = Convert.ToInt32(Console.ReadLine());

Console.Write("Deploy to: \n");

// display results in a different color
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"({row}, {column - 1})"); // western coordinate
Console.WriteLine($"({row - 1}, {column})"); // southern coordinate
Console.WriteLine($"({row}, {column + 1})"); // eastern coordinate
Console.WriteLine($"({row + 1}, {column})"); // northern coordinate

// make a beep sound when results have been displayed
Console.Beep();

// return to normal color after results
Console.ForegroundColor = ConsoleColor.Gray;

