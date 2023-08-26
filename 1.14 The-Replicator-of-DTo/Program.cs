// this creates a new array with 5 values, all at 0 because I didn't assign specific values
int[] array1 = new int[5];

// collecting 5 array values from the user
Console.WriteLine("Please enter 5 numbers. ");
array1 [0] = Convert.ToInt32(Console.ReadLine());
array1 [1] = Convert.ToInt32(Console.ReadLine());
array1 [2] = Convert.ToInt32(Console.ReadLine());
array1 [3] = Convert.ToInt32(Console.ReadLine());
array1 [4] = Convert.ToInt32(Console.ReadLine());

// creating a second array
int[] array2 = new int[5];

// copying the index of array 1 into array 2
// index starts at 0, so it copies the values out of array1 starting at 0 until it reaches the length of
// the original array
for (int index = 0; index < 5; index++) 
{
    array2[index] = array1[index];
}

// line separator 
Console.WriteLine("---------------------");

// display array 1 contents in green
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Array 1: {array1[0]}, {array1[1]}, {array1[2]}, {array1[3]}, {array1[4]}");
Console.ForegroundColor = ConsoleColor.Gray;

// display array 2 contents in cyan
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Array 2: {array2[0]}, {array2[1]}, {array2[2]}, {array2[3]}, {array2[4]}");
Console.ForegroundColor = ConsoleColor.Gray;


