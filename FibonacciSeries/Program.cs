Console.WriteLine("Program to print the Fibanacci sequence of numbers below the inputted number");
Console.WriteLine("Enter a positive number:");
string? input = Console.ReadLine();
if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("You need to input a number!");
    return;
}
int number = int.Parse(input);

int firstNum = 1, secondNum = 1;
int sum = 0;
Console.WriteLine($"Fibonacci sequence below {number}:");
if(number <= 1)
{
    Console.WriteLine("Enter a number greater than 1");
    return;
}

Console.WriteLine(firstNum);
Console.WriteLine(secondNum);
while (sum < number)
{
    sum = firstNum + secondNum;
    if (sum >= number)
    {
        break;
    }
    firstNum = secondNum;
    secondNum = sum;
    Console.WriteLine(sum);
}

//Below code is to print n number of fibonacci numbers
//for (int i = 0; i < number; i++)
//{
//    sum = firstNum + secondNum;
//    firstNum = secondNum;
//    secondNum = sum;
//    Console.WriteLine(sum);
//}