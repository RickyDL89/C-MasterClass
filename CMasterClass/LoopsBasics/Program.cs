// See https://aka.ms/new-console-template for more information


for (int i = 10; i >= 0; i--)
{
    Console.WriteLine($"i is {i}");
    Thread.Sleep(500);
}

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"i is {i}");
    Thread.Sleep(500);
}

Console.ReadKey();  