Console.WriteLine("Enter a string:");
string str = Console.ReadLine().ToLower();

char[] chars = str.ToCharArray();

bool isIdentical = true;

//for (int i = 1; i < chars.Length; i++)
//{
//    if (chars[i] != chars[0])
//    {
//        isIdentical = false;
//        break;
//    }
//}

//IEnumerable<char> charCount = chars.Distinct();
//isIdentical = charCount.Count() == 1 ? true : false;

HashSet<char> set = new HashSet<char>();
for (int i = 0; i < chars.Length; i++)
    set.Add(chars[i]);

isIdentical = set.Count() == 1 ? true : false;

Console.WriteLine(isIdentical);