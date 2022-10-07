Console.WriteLine("Enter a string:");
string str = Console.ReadLine().ToLower();

char[] chars = str.ToCharArray();
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

int count = 0;

foreach (char c in chars)
{
    if (vowels.Contains(c))
    {
        count++;
    }
}

Console.WriteLine($"Number of vowels in {str} is/are {count}");