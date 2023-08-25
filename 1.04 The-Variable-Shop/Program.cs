// create 14 variables discussed in the chapter and assign them all correct literal values

string theString = "This is a string variable"; // stores text
char theChar = 'a'; // stores a single character

bool theBool = false; // stores a value of true or false

float theFloat = 9.67228f; // 4 bytes, decent accuracy
double theDouble = 20.000012732; // 8 bytes, decent accuracy, simply placing a decimal point makes it a double literal
decimal theDecimal = 0.92168483626728465m; // 16 bytes, slower than floats or doubles, but offers extreme precision

byte theByte = 1; // no negative values, from 0-255
short theShort = 32_000; // positive and negative values to about 32,000 in each direction
int theInt = -2_000_000_000; // positive and negative values to about 2 billion in each direction
long theLong = -9_000_000_000_000_000_000L; // positive and negative values to about 9 quintillion in each direction

sbyte theSByte = -100; // a byte, but sacrifices positive upper limit to allow about half of that to negative values
ushort theUShort = 60_000; // a short, but sacrifices negative limit and adds to positive limit
uint theUInt = 4_000_000_000U; // an int, but sacrifices negative limit and adds to positive limit
ulong theULong = 18_000_000_000_000_000_000; // a long, sacrifices negative limit and adds to positive limit

// display the contents of the variables with the WriteLine method

Console.WriteLine($"{theString}\n{theChar}\n{theBool}\n{theFloat}\n{theDouble}\n{theDecimal}\n");
Console.WriteLine($"{theByte}\n{theShort}\n{theInt}\n{theLong}\n");
Console.WriteLine($"{theSByte}\n{theUShort}\n{theUInt}\n{theULong}\n");

// update the values of the variables, then display them with WriteLine again

theString = "This is an updated version of the string variable";
theChar = 'b';
theBool = true;
theFloat = 2.22127f;
theDouble = 41.073474818;
theDecimal = -0.2147623456098769m;
theByte = 255;
theShort = -32_000;
theInt = 2_000_000_000;
theLong = 9_000_000_000_000_000_000L;
theSByte = -50;
theUShort = 50_000;
theUInt = 3_000_000_000U;
theULong = 10_000_000_000_000_000_000UL;

Console.WriteLine("------------------------------------------------");
Console.WriteLine($"{theString}\n{theChar}\n{theBool}\n{theFloat}\n{theDouble}\n{theDecimal}\n");
Console.WriteLine($"{theByte}\n{theShort}\n{theInt}\n{theLong}\n");
Console.WriteLine($"{theSByte}\n{theUShort}\n{theUInt}\n{theULong}");

Console.WriteLine("------------------------------------------------");

// variables can also be converted between types via the Convert class or the Parse method
theString = Console.ReadLine();
Convert.ToInt32(theString);
Console.WriteLine($"{theString} is a great number!");

