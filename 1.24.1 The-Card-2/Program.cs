

CardColor[] colors = (CardColor[])Enum.GetValues(typeof(CardColor));
CardRank[] cardRanks = (CardRank[])Enum.GetValues(typeof(CardRank));

foreach (CardColor color in colors)
{
    foreach (CardRank rank in cardRanks)
    {
        Card card = new Card(color, rank);

        string rankType = card.IsFaceCard() ? "face" : "number";
        Console.Write($"The {card.Color} {card.Rank}");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($" {rankType}\n");
        Console.ResetColor();
    }
}

class Card
{
    // fields
    private CardColor _color;
    private CardRank _rank;

    // properties
    public CardColor Color
    {
        get { return _color; }
    }

    public CardRank Rank
    {
        get { return _rank; }
    }

    // constructors 
    // initialization 
    public Card(CardColor color, CardRank rank)
    {
        _color = color; // IN THESE CONSTRUCTORS, THE PARAMATERS NEED TO BE SET TO THE FIELDS ___NOT___ THE PROPERTIES!!
        _rank = rank;
    }

    // default values upon object creation
    public Card()
    {
        _color = CardColor.Red;
        _rank = CardRank.One;
    }

    public bool IsFaceCard()
    {
        return Rank > CardRank.Ten;
    }
}

enum CardColor: byte { Red, Green, Blue, Yellow }
enum CardRank: byte { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand }