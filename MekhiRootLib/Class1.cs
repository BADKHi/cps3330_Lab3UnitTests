namespace MekhiRootLib;

public class Class1
{
    public static double MyMax(double number1, double number2)
    {
        double max;
        if (number1 > number2)
            max = number1;
        else
            max = number2;

        Console.WriteLine($"The MAX value between {number1} and {number2} is {max}");
        return max;
    }
}
