/* create a console app that divides an amount of chocolate eggs evenly between 4 sisters,
 * leaving the remainder for a pet to consume*/


int eggsGathered;

Console.WriteLine("How many chocolate eggs were gathered today?");
eggsGathered = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sisters should each receive {eggsGathered / 4} eggs.");
Console.WriteLine($"The Duckbear should receive {eggsGathered % 4} eggs.");

/* because division is done using an int, floating point values are not given
 * so the remainder operation is used to determine how many left over eggs go to the pet */




