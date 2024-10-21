// See https://aka.ms/new-console-template for more information

Random random = new Random();

int randomNumber = random.Next(1, 11);
//Console.WriteLine(randomNumber);

Console.WriteLine("Guess a number between 1 and  10");
int userInput = int.Parse(Console.ReadLine());  

if(userInput == randomNumber )
{
    Console.WriteLine("Well Done");
    Console.WriteLine($"The number was {randomNumber}");
}
else
{
    Console.WriteLine("Bad Luck");
    Console.WriteLine($"The number was {randomNumber}");
}


Console.ReadKey();  