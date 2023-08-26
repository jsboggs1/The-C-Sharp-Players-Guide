
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 }; // from book

int currentSmallest = int.MaxValue; // from book

/* this is the original loop code from the book
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest)
        currentSmallest = array[index];
}
Console.WriteLine(currentSmallest);
*/

foreach (int value in array) // for every spot in array
{
    if (value < currentSmallest) // if the int value is less than the currentSmallest, that's the new smallest value
    {
        currentSmallest = value;
    }
}
Console.WriteLine(currentSmallest);



int[] array2 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 }; // from book

int total = 0; // from book

/* original loop from book
for (int index = 0; index < array.Length; index++)
    total += array2[index];
float average = (float)total / array.Length;
Console.WriteLine(average);
*/

foreach (int value in array2) // for every value in array 2
{
    total += value; // add every int value to the total, total = value + total, 
}
float average = (float)total / (float)array2.Length; // divide total of array by the length of the array
Console.WriteLine(average);