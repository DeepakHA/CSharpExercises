using System.Globalization;

Console.WriteLine("Enter a month number:");
int monthNumber = int.Parse(Console.ReadLine());
string monthName = "";

//switch (monthNumber)
//{
//    case 1:
//        monthName = "January";
//        break;
//    case 2:
//        monthName = "February";
//        break;
//    case 3:
//        monthName = "March";
//        break;
//    case 4:
//        monthName = "April";
//        break;
//    case 5:
//        monthName = "May";
//        break;
//    case 6:
//        monthName = "June";
//        break;
//    case 7:
//        monthName = "July";
//        break;
//    case 8:
//        monthName = "August";
//        break;
//    case 9:
//        monthName = "September";
//        break;
//    case 10:
//        monthName = "October";
//        break;
//    case 11:
//        monthName = "November";
//        break;
//    case 12:
//        monthName = "December";
//        break;
//    default:
//        Console.WriteLine("Not a valid month number");
//        break;
//}

//DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo();
//monthName = dateTimeFormatInfo.GetMonthName(monthNumber);

//monthName = DateTimeFormatInfo.InvariantInfo.GetMonthName(monthNumber);

monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(monthNumber);

Console.WriteLine(monthName);