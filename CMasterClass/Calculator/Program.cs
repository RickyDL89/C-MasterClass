Console.WriteLine("Calculator");

Console.WriteLine("Pick 1st Number");
double userInput = double.Parse(Console.ReadLine());

Console.WriteLine("You Entered " + userInput);

Console.WriteLine("Pick 2nd Number");
double userInput2 = double.Parse(Console.ReadLine());

Console.WriteLine("You Entered " + userInput2);

Console.WriteLine("Sum of Inputs is...");
Console.WriteLine(Math.Round(userInput,2) + Math.Round(userInput2, 2));