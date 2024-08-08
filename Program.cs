
double num1;
double num2;
string answer;
double result=0;

Console.WriteLine("enter the first number");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the secound number");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("choose the operation: a for Add,S for subtraction ,M for multiply , D for division");
answer = Console.ReadLine().ToUpper();

if (answer == "A")
{
    result = num1 + num2;
}
else if (answer == "S")
{
    result = num1 - num2;
}
else if (answer == "M")
{
    result = num1 * num2;
}
else if (answer == "D")
{
    if (num2 !=0)
    {
        result = num1 / num2;
    }
    else
    {
        Console.WriteLine("num2 should't be 0");
        return;
    }
}
else
{
    Console.WriteLine("choose valid operation");
    return;
}

Console.WriteLine("the result is " +result);


    




