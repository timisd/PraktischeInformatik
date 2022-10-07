namespace Vorlesung3;

internal class Calculator
{
    public delegate int CalculateHandler(int number1, int number2);

    private static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    private static int Subtract(int number1, int number2)
    {
        return number1 - number2;
    }

    public static void Run()
    {
        var number1 = Convert.ToInt32(Console.ReadLine());
        var number2 = Convert.ToInt32(Console.ReadLine());
        var oper = Console.ReadLine();

        CalculateHandler calc = oper switch
        {
            "+" => Add,
            "-" => Subtract,
            "*" => (i, j) => i * j,
            "/" => (i, j) => i / j,
            _ => null!
        };

        var result = calc(number1, number2);
        Console.WriteLine(result);
    }
}