// define a new point class with properties for x and y
// Add a constructor to create a point from a specific x and y coordinates
// Add a parameterless constructor to create a point at the origin (0, 0)
// In your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the
// console window in the format (x, y) to illustrate that the class works



// this is an alternative to writing
// Point myPoint = new Point()
// myPoint.X = 2;
// myPoint.Y = 3
Point myPoint = new Point // accomplishes the same thing, just cleaner
{
    X = 2,
    Y = 3,
};


Console.WriteLine ($"({myPoint.X}, {myPoint.Y})");

myPoint.X = -4;
myPoint.Y = 0;

Console.WriteLine($"({myPoint.X}, {myPoint.Y})");

class Point
{
    private int _x;
    private int _y;
 
    /* auto-implemented properties are an alternative to this:
    public int X
    {
        get { return _x; }
        set { _x = value; }
    }
    public int Y
    {
        get { return _y; }
        set { _y = value; }
    }
    */
   
    // auto-omplemented properties
    public int X { get; set; }
    public int Y { get; set; }

    // parameterless constructor (nothing in parentheses) to set point at (0,0)
    public Point()
    {
        // default int values are zero, so no need to set a default value here
    }

    // constructor to initialize fields
    public Point (int X, int Y)
    {
        _x = X;
        _y = Y;

        // ALWAYS write the fields on the left
    }

}