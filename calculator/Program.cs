// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("This is a calculator");

    Console.WriteLine("Input first number:");
    string firstInput = Console.ReadLine();
    int first_number = Convert.ToInt32(firstInput);

    Console.WriteLine("Input sign:");
    string? sign = Console.ReadLine();

    Console.WriteLine("Input second number:");
    string secondInput = Console.ReadLine();
    int second_number = Convert.ToInt32(secondInput);
    if ((sign == "/" || sign == "%") && second_number == 0)
    {
        throw new DivideByZeroException("Error: you cannot divide by 0");
    }

    double result;

    switch (sign)
    {
        case "+":
            Console.WriteLine($"{first_number} + {second_number} = {first_number + second_number}");
            break;
        case "-":
            Console.WriteLine($"{first_number} - {second_number} = {first_number - second_number}");
            break;
        case "*":
            Console.WriteLine($"{first_number} * {second_number} = {first_number * second_number}");
            break;
        case "/":
            Console.WriteLine($"{first_number} / {second_number} = {(double)first_number / second_number}");
            break;
        case "%":
            Console.WriteLine($"{first_number} % {second_number} = {first_number % second_number}");
            break;
        default:
            throw new InvalidOperationException("Error: invalid operation");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Incorrectly entered number");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: you cannot divide by 0.");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception)
{
    Console.WriteLine("Error");
}
