// See https://aka.ms/new-console-template for more information

string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

Console.WriteLine("Length of array is : " + weekDays.Length);

for (int i = 0; i < weekDays.Length; i++)
{
    Console.WriteLine(weekDays[i]);
}

foreach (string day in weekDays)
{
    Console.WriteLine(day);
}