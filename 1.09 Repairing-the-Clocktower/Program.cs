// take a number from user, display "tick" for even and "tock" for odd

Console.Write("Input number: ");
int clockNumber = Convert.ToInt32(Console.ReadLine());



if (clockNumber % 2 == 0)
{
    Console.Write("Tick");
    // no remainder results in an even number
}
else
{
    Console.Write("Tock");
    // remainder results in an odd number
}