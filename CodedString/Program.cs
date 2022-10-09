using System.Text;

Console.WriteLine("Enter a string:");
string str = Console.ReadLine().ToLower();
//List<char> chars = new List<char>();

//for (int i = 0; i < str.Length; i++)
//{
//    switch (str[i])
//    {
//        case 'a':
//            chars.Add('4');
//            break;
//        case 'e':
//            chars.Add('3');
//            break;
//        case 'i':
//            chars.Add('1');
//            break;
//        case 'o':
//            chars.Add('0');
//            break;
//        case 's':
//            chars.Add('5');
//            break;
//        default:
//            chars.Add(str[i]);
//            break;
//    }
//}

//StringBuilder stringBuilder = new StringBuilder();
//chars.ForEach(c => stringBuilder.Append(c));
//Console.WriteLine(stringBuilder.ToString());

//chars.ForEach(c => Console.Write(c));

//str = str.Replace('a', '4');
//str = str.Replace('e', '3');
//str = str.Replace('i', '1');
//str = str.Replace('o', '0');
//str = str.Replace('s', '5');

str = str.Replace('a', '4').Replace('e', '3').Replace('i', '1').Replace('o', '0').Replace('s', '5');
Console.WriteLine(str);

