// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input day of the week number:");
int day = Convert.ToInt32(Console.ReadLine());
//2 Варіан закоментований
if (day == 0 || day > 7){
    Console.WriteLine("Error,there is no such day");
}

else {
    string day_name = day switch
    {
        1 => "Monday",
        2 => "Tuesday",
        3 => "Wednesday",
        4 => "Thursday",
        5 => "Friday",
        6 => "Saturday",
        7 => "Sunday"
    };
    Console.WriteLine($"It is", day_name);
}
/*switch (day)
{
    case 1:
        Console.WriteLine("It is Monday");
        break;
    case 2: 
        Console.WriteLine("It is Tuesday");
        break;
    case 3:
        Console.WriteLine("It is Wednesday");
        break;
    case 4:
        Console.WriteLine("It is Thursday");
        break;
    case 5:
        Console.WriteLine("It is Friday");
        break;
    case 6:
        Console.WriteLine("It is Saturday");
        break;
    case 7:
        Console.WriteLine("It is Sunday");
        break;
    default:
        Console.WriteLine("Error,there is no such day");
        break;
}*/
