﻿// See https://aka.ms/new-console-template for more information
string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

for (int counter = 10; counter >= 0; counter--)
{
    Console.Clear();
    Console.WriteLine("Counter is " + counter);
    Console.WriteLine(rocket);
    rocket = "\r\n" + rocket;
    Thread.Sleep(1000);
}
Console.WriteLine("The Rocket has Landed!");

Console.ReadKey();