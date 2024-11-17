// See https://aka.ms/new-console-template for more information
Console.WriteLine("This is a calculator");
Console.WriteLine("Input first numder:");
int forst_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input sign:");
string? sign = Console.ReadLine();
Console.WriteLine("Input second numder:");
int second_number = Convert.ToInt32(Console.ReadLine());
if ((sign == "/" || sign=="%") && second_number == 0)
{
    Console.WriteLine("Error, you cannot divide by 0");
}
else
{
    switch(sign)
    {
        case "+":
            Console.WriteLine($"{forst_number} + {second_number} = {forst_number+second_number}");
            break;
        case "-":
            Console.WriteLine($"{forst_number} - {second_number} = {forst_number - second_number}");
            break;
        case "*":
            Console.WriteLine($"{forst_number} * {second_number} = {forst_number * second_number}");
            break;
        case "/":
            Console.WriteLine($"{forst_number} / {second_number} = {(double)forst_number / second_number}");
            break;
        case "%":
            Console.WriteLine($"{forst_number} % {second_number} = {forst_number % second_number}");
            break;
    }
}
