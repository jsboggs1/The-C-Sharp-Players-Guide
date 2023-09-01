// write a program that counts down from 10 to 1 using recursion (a method calling itself)

// for recursion you need to have a "base case," something that stops the recursion from repeating infinitely

int CountDown (int startNumber)
{
    if (startNumber == 0)
    {
        return 0;
    }
    else
    {
        // this could be written as startNumber = 10 - 1 and then calling the method to continue running
        // until startNumber reaches 1

        Console.WriteLine(startNumber);
        return startNumber = CountDown(startNumber - 1); 
    }
}

int startNumber = CountDown (10); // setting the startNumber to be equal to 10 so the method will count down 