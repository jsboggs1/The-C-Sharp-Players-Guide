Console.WriteLine("What kind of thing are we talking about?");

string a = Console.ReadLine(); // this variable stores the name of the thing entered in by the user

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

string b = Console.ReadLine(); // this variable stores the description of the thing entered in by the user
string c = "of Doom"; /* This variable stores the words "of Doom" */
string d = "3000"; /* This variable stores the number 3000 in text format */

Console.WriteLine($"The {b} {a} {c} {d}!");