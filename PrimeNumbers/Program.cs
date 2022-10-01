Console.WriteLine("Prime numbers are numbers for which factors are 1 and itself!");
Console.WriteLine("Enter a positive number:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Entered number is {number}");
int count = 0;
List<int> factors = new() { 1, number };

if (number == 0 || number == 1)
    Console.WriteLine("Not Prime");
else if (number == 2)
    Console.WriteLine("Prime");
else
{
    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
        {
            count++;
            factors.Insert(count, i);
        }
    }

    string message = count != 0 ? "Not Prime" : "Prime";
    Console.WriteLine(message);
}

Console.WriteLine($"Factors of a number {number}");
factors.ForEach(f => Console.WriteLine(f));
