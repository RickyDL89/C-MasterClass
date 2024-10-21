// See https://aka.ms/new-console-template for more information
Random random = new Random();

int randomNumber = 1;
int userInput = 0;
int counter = 1;

while (userInput != randomNumber)
{
    Console.WriteLine("Guess a number between 1 and 10");

    randomNumber = random.Next(1, 11);
    Console.WriteLine(randomNumber);
    userInput = int.Parse(Console.ReadLine());
    
    if(userInput != randomNumber)
    {
        Console.WriteLine($"Bad Luck the number is {randomNumber}");
        counter++;  
    }
    else
    {
        Console.WriteLine($"Well Done the number is {randomNumber} it took you {counter} tries");
    }
}

