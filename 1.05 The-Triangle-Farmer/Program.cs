// make a console app for calculating the area of a triangle and then display the result

// declare variables

decimal triangleBase;
decimal triangleHeight;
decimal triangleArea;

Console.WriteLine("Area = Base * Height / 2");
Console.WriteLine("What is the base of the triangle?");

// obtain variable values from user

triangleBase = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("What is the height of the triangle?");
triangleHeight = Convert.ToDecimal(Console.ReadLine());

// calculate result

triangleArea = (triangleBase * triangleHeight) / 2; 

Console.WriteLine($"The area of your triangle is {triangleArea}.");