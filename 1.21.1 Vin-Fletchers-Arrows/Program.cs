Console.WriteLine("Would you like to create a custom arrow, or order one of our specialty pre-made arrows?");
Console.Write("Type \"custom\" for a custom arrow, and \"specialty\" for specialty arrows.\n>> ");

string answer = Console.ReadLine();

if (answer == "custom")
{
    Arrow myArrow = GetArrow();
    Console.Write($"That arrow is gonna cost ya {myArrow.GetCost()} gold each.");
}
if (answer == "specialty")
{
    Console.WriteLine("Choose one of our specialty arrows: beginner, marksman, or elite.");

    string specialtyChoice = Console.ReadLine();

    if (specialtyChoice == "beginner")
    {
        Arrow beginnerArrow = Arrow.CreateBeginnerArrow();
        Console.Write($"That arrow is gonna cost ya {beginnerArrow.GetCost()} gold each.");
    }
    else if (specialtyChoice == "marksman")
    {
        Arrow marksmanArrow = Arrow.CreateMarksmanArrow();
        Console.Write($"That arrow is gonna cost ya {marksmanArrow.GetCost()} gold each.");
    }
    else if (specialtyChoice == "elite")
    {
        Arrow eliteArrow = Arrow.CreateEliteArrow();
        Console.Write($"That arrow is gonna cost ya {eliteArrow.GetCost()} gold each.");
    }
}


Arrow GetArrow()
{

    Console.Write("Choose an arrow head: wood (3 gold), obsidian (5 gold), or steel (10 gold).\n>> ");
    string theHead = Console.ReadLine();
    ArrowHead headChoice = theHead switch
    {
        "wood" => ArrowHead.Wood,
        "obsidian" => ArrowHead.Obsidian,
        "steel" => ArrowHead.Steel,
    };

    Console.Write("Choose an arrow fletching: goose feather (3 gold), turkey feather (5 gold), or plastic (10 gold).\n>> ");
    string theFletching = Console.ReadLine();
    ArrowFletching fletchChoice = theFletching switch
    {
        "goose feather" => ArrowFletching.GooseFeather,
        "turkey feather" => ArrowFletching.TurkeyFeather,
        "plastic" => ArrowFletching.Plastic,
    };

    Console.Write("Choose an arrow length between 60 cm and 100 cm at a cost of 0.05 per cm.\n>> ");
    float theLength = Convert.ToSingle(Console.ReadLine());
    if (theLength < 60 || theLength > 100)
    {
        Console.WriteLine("Please enter a length between 60 cm and 100 cm.");
    }

    return new Arrow (headChoice, fletchChoice, theLength);
}

class Arrow
{

    private ArrowHead _head;
    private ArrowFletching _fletching;
    private float _length;

    // constructor to set default valuess
    public Arrow() : this(ArrowHead.Wood, ArrowFletching.GooseFeather, 60)
    {

    }

    // constructor to set parameters
    public Arrow(ArrowHead head, ArrowFletching fletching, float length)
    {
        _head = head;
        _fletching = fletching;
        _length = length;
    }

    // property setting
    // properties give field-level access while still protecting data
    public ArrowHead Head
    {
        get { return _head; }
        set { _head = value; }
    }

    public ArrowFletching Fletching
    {
        get { return _fletching; }
        set { _fletching = value; }
    }

    public float Length
    {
        get { return _length; }
        set { _length = value; }
    }

    // notice this method using the properties instead of the actual fields
    public float GetCost()
    {
        float headCost = Head switch
        {
            ArrowHead.Wood => 3,
            ArrowHead.Obsidian => 5,
            ArrowHead.Steel => 10,   
        };

        float fletchCost = Fletching switch
        { 
            ArrowFletching.GooseFeather => 3,
            ArrowFletching.TurkeyFeather => 5,
            ArrowFletching.Plastic => 10,
        };

        float lengthCost = Length * 0.05f;

        return headCost + fletchCost + lengthCost;
    }

    // the static modifier creates things that belong to the class itself and not each individual object
    // in this case, these static methods create predetermined arrows made by the shop

    public static Arrow CreateEliteArrow()
    {
        return new Arrow(ArrowHead.Steel, ArrowFletching.Plastic, 95f);
    }

    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(ArrowHead.Wood, ArrowFletching.GooseFeather, 75f);
    }

    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(ArrowHead.Steel, ArrowFletching.GooseFeather, 65f);
    }
}

enum ArrowHead { Wood, Obsidian, Steel }
enum ArrowFletching { GooseFeather, TurkeyFeather, Plastic }

