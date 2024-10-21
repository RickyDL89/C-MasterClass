// See https://aka.ms/new-console-template for more information

string question1 = "What is the capital of Germany";
string answer1 = "Berlin";

string question2 = "What is 2+2";
string answer2 = "4";

string question3 = "What is 3+3";
string answer3 = "6";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if(userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct");
    score++;  
}
else
{
    Console.WriteLine("Incorret, the answer is "+ answer1);
}
Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2 == answer2)
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Incorret, the answer is " + answer2);
}
Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3 == answer3)
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Incorret, the answer is " + answer3);
}
Console.WriteLine($"You scored {score}/3");
if(score == 3)
{
    Console.WriteLine("You got everything right");
}
else
{
    Console.WriteLine($"Here are the answers\n{question1}\n{answer1}\n{question2}\n{answer2}\n{question3}\n{answer3}\n");
}
Console.ReadKey();

