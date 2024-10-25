// Methods are structured like this
// Modifiers returnType MethodName(Parameters){
// Code Block
// }

//No Parameter
void MyFirstMethod()
{
    Console.WriteLine("Method execution");
}

//Calling the method
MyFirstMethod();

Console.WriteLine("Outside Method");

//1 Paramter
void WriteSomething(string myString)
{
    Console.WriteLine(myString);
}

WriteSomething("This is my string");

//2 Parameter
void AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    Console.WriteLine(result);
}

AddTwoValues(1, 2);