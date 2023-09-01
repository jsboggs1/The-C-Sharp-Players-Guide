// creation of a method
// a method is a repeatable block of code that executes when called

// the "int" in front of the method name tells what value it will be returning. Use "void" if a method doesn't
// need to return a value.

int AskForNumber(string text) // parameters within the parentheses set up the format of future method calls
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result; // return exits the method
}

// calling the AskForNumber method, uses the "text" string parameter shown before

// methods GET THEIR OWN VARIABLES, this is why we can use the "result" variable again
int result = AskForNumber("What is the airspeed velocity of an unladen swallow?"); 

int AskForNumberInRange (string text, int min, int max)
{
    Console.WriteLine (text);
    int numberInRange = Convert.ToInt32(Console.ReadLine());

    while (numberInRange < min || numberInRange > max)
    {
        Console.WriteLine("Please enter a number within the range of values given.");
        numberInRange = Convert.ToInt32(Console.ReadLine());
    }
    return numberInRange;
}

// calling the AskForNumberInRange method
int numberInRange = AskForNumberInRange("Give me a number between 1 and 10.", 1, 10);