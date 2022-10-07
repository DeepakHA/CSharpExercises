Console.WriteLine("Enter First name and last name separated by empty space:");
string str = Console.ReadLine();

string[] splitString = str.Split(' ');
string temp = splitString[0];
splitString[0] = splitString[1];
splitString[1] = temp;
//Console.WriteLine(splitString[0] + " " + splitString[1]);
string joinedString = string.Join(' ', splitString);
Console.WriteLine(joinedString);
