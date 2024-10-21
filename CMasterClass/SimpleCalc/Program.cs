// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the first number:");

int userInput1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");

int userInput2 = int.Parse(Console.ReadLine());

Console.WriteLine("Choose an operation: +, -, *, /");

string userOperator = Console.ReadLine();

int result = 0;

switch (userOperator)
{
    case "+":
        result = userInput1 + userInput2;
        break;
    case "-":
        result = userInput1 - userInput2;
        break;
    case "*":
        result = userInput1 * userInput2;
        break;
    case "/":
        if (userInput2 != 0)
        {
            result = userInput1 / userInput2;
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        break;
    default:
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
        return;
}

Console.WriteLine($"Result: {result}");
