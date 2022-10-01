Console.WriteLine("Program to calculate number of times a number repeats in a given array!");

int[] numbers = { 1, 2, 7, 3, 2, 2, 5, 9, 0, 5, 6, 7, 3, 2, 1, 0 };
Console.WriteLine($"Total number of elements in the array - {numbers.Length}");

List<int> numbersWithoutDuplicates = new();

for (int i = 0; i < numbers.Length; i++)
{
    int count = 1;

    if (numbersWithoutDuplicates.Contains<int>(numbers[i]))
        continue;
    else
    {
        numbersWithoutDuplicates.Add(numbers[i]);
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] == numbers[j])
                count++;
        }
    }

    Console.WriteLine($"Number {numbers[i]} - {count} times");
}