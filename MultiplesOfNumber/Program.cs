Console.WriteLine("Enter a number:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a length of multiple:");
int len = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 1; i <= len; i++)
{
    Console.WriteLine(num*i);
}

