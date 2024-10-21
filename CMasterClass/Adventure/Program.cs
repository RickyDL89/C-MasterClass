// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the adventure game");
Console.WriteLine("Enter your character's name");

string playerName = Console.ReadLine();

Console.WriteLine("Choose your characer type (Warrior, Wizard, Archer)");

string characterType = Console.ReadLine();

Console.WriteLine($"You, {playerName} the {characterType} find yourself in front of the forest");
Console.WriteLine("Do you want to enter or camp outside?");

string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You enter the forest");
}
else
{
    Console.WriteLine("You camp outside");
}