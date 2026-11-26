int num = 3, score = 85;
string day;

switch (num)
{
    case 1:
        day = "Monday";
        break;
    case 2:
        day = "Tuesday";
        break;
    case 3:
        day = "Wednesday";
        break;
    case 4:
        day = "Thursday";
        break;
    case 5:
        day = "Friday";
        break;
    case 6:
        day = "Saturday";
        break;
    case 7:
        day = "Sunday";
        break;
    default:
        day = "Invalid day";
        break;
}

Console.WriteLine($"Day{num} : {day}");

switch (score)
{
    case  > 80 and <= 100:
        Console.WriteLine("Grade: A");
        break;
    case > 60 and <= 80:
        Console.WriteLine("Grade: B");
        break;
    case > 40 and <= 60:
        Console.WriteLine("Grade: C");
        break;
    default:
        Console.WriteLine("Invalid Score");
        break;
}