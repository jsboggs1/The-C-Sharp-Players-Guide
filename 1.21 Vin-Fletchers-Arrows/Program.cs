
// creation of a new object based on the arrow class
Arrow myArrow = GetArrow();
Console.WriteLine($"That {myArrow} will cost {myArrow.GetCost()}");

// method that returns an arrow OBJECT after using other methods to obtain the arrow's properties
Arrow GetArrow()
{
    ArrowHead theArrowHead = GetArrowHead();
    ArrowFletching theArrowFletching = GetArrowFletching();
    float length = GetArrowLength();

    // This creates a new arrow object!
    return new Arrow (theArrowHead, theArrowFletching, length);
}

// method for obtaining arrow head from the user
ArrowHead GetArrowHead()
{
    Console.WriteLine("Choose an arrow head: wood, obsidian, or steel.");
    Console.WriteLine("Wood costs 3 gold, obsidian costs 5 gold, and steel costs 10 gold.");
    Console.WriteLine("------------------------------");

    string choice = Console.ReadLine();
    return choice switch
    {
        "wood" => ArrowHead.Wood,
        "obsidian" => ArrowHead.Obsidian,
        "steel" => ArrowHead.Steel,
    };

}

// method for obtaining arrow fletching from user
ArrowFletching GetArrowFletching()
{
    Console.WriteLine("Choose an arrow fletching: goose feather, turkey feather, or plastic.");
    Console.WriteLine("Goose feather costs 3 gold, turkey feather costs 5 gold, and plastic costs 10 gold.");
    Console.WriteLine("------------------------------");

    string choice = Console.ReadLine();
    return choice switch
    {
        "goose feather" => ArrowFletching.GooseFeather,
        "turkey feather" => ArrowFletching.TurkeyFeather,
        "plastic" => ArrowFletching.Plastic,
    };
}

// method to obtain arrow length from user
float GetArrowLength()
{
    Console.WriteLine("Choose an arrow length between 60 cm and 100 cm.");
    Console.WriteLine("Length costs 0.05 gold per cm.");
    Console.WriteLine("------------------------------");

    float choice = Convert.ToSingle(Console.ReadLine());
    return choice;
    
}

// class creation
class Arrow
{
    // using public now for practice, not supposed to do this later on 
    // class fields typically have underscores in their names to differentiate
    public ArrowHead _head;
    public ArrowFletching _fletching;
    public float _length;

    // constructor to add default values, building off of the constructor below without needing to create
    // an object
    public Arrow(): this(ArrowHead.Wood, ArrowFletching.GooseFeather, 60)
    {

    }

    // constructor to set parameters
    public Arrow(ArrowHead head, ArrowFletching fletching, float length)
    {
        _head = head;
        _fletching = fletching;
        _length = length;
    }

    // method of determining price of arrow
    // needs to be public to be accessible outside of class
    // I'm guessing this is within the class to produce line 4
    public float GetCost()
    {
        float headCost = _head switch
        {
            ArrowHead.Wood => 3,
            ArrowHead.Obsidian => 5,
            ArrowHead.Steel => 10,
        };

        float fletchingCost = _fletching switch
        {
            ArrowFletching.GooseFeather => 3,
            ArrowFletching.TurkeyFeather => 5,
            ArrowFletching.Plastic => 10,
        };

        float lengthCost = _length * 0.05f;

        return (headCost + fletchingCost + lengthCost);
    }
}

enum ArrowHead { Wood, Obsidian, Steel }
enum ArrowFletching { GooseFeather, TurkeyFeather, Plastic }