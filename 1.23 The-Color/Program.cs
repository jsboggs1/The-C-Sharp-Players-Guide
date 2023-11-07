/* Tasks: 
 * 1. Define a new Color class with properties for its red, green, and blue channels.
 * 2. Add appropriate constructors that you feel make sense for creating new Color objects.
 * 3. Create static properties to define the eight commonly used colors for easy access.
 * 4. In your main method, make two Color-typed variables. Use a constructor to create a color instance
      and use a static property for the other. Display each of their red, green, and blue channel values.
 */

// executing step 4
Color a = new Color(127, 58, 99);
Color b = Color.Red;

Console.WriteLine($"Color A's RGB code is ({a.red}, {a.green}, {a.blue})");
Console.WriteLine($"Color B's RBG code is ({b.red}, {b.green}, {b.blue})");

// class creation
class Color
{
    // fields
    private byte _red;
    private byte _green;
    private byte _blue;

    // properties (auto-properties DO NOT give field-level access because they create their own fields)
    public byte red
    {
        get { return _red; }
        set { _red = value; }
    }
    public byte green
    {
        get { return _green; }
        set { _green = value; }
    }
    public byte blue
    {
        get { return _blue; }
        set { _blue = value; }
    }

    // constructors

    // object initialization
    public Color()
    {
        // byte's default start number is zero, no need to set properties/fields to zero here
    }
    // assigning fields to properties. REMEMBER that constuctors use camelCase for properties.
    public Color (byte red, byte green, byte blue)
    {
        _red = red;
        _green = green;
        _blue = blue;
    }

    // static colors using properties (kind of showcases how properties can be similar to methods)
    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 255, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);
}