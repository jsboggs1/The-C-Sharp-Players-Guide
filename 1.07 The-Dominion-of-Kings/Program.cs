/* create a console app that increases the user's score based on their holdings 
 * estate = 1 pt, duchy = 3 pts, province = 6 pts
 * add up the user's score, then display the result */

int estate = 0;
int duchy = 0;
int province = 0;

Console.WriteLine("How many estates do you have?");
estate = Convert.ToInt32(Console.ReadLine());
estate *= 1; // this is the same as writing estate = estate * 1

Console.WriteLine("How many duchies do you have?");
duchy = Convert.ToInt32(Console.ReadLine());
duchy *= 3;

Console.WriteLine("How many provinces do you have?");
province = Convert.ToInt32(Console.ReadLine());
province *= 6;

Console.WriteLine($"Your total is: {estate + duchy + province}");