Console.WriteLine("Input the first number:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the Second number:");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Before swapping \n First Number: {number1} \n Second Number: {number2}");

int temp = number1;
number1 = number2;
number2 = temp;

Console.WriteLine($"After swapping \n First Number: {number1} \n Second Number: {number2}");