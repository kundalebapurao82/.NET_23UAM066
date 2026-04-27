using System;

public class ArithDelegate
{
    public delegate double Operation(double a, double b);

    public static double Add(double a, double b)
    {
        return a+b;
    }

    public static double Subtract(double a, double b)
    {
        return a-b;
    }

    public static double Multiply(double a, double b)
    {
        return a*b;
    } 

    public static double Divide(double a, double b)
    {
        return a/b;
    }


    public static void Main()
    {
        Operation op = Add;

        Console.WriteLine("Sum of 10.15 and 23.11 is: "+op(10.15, 23.11));

        op = Subtract;

        Console.WriteLine("Subtraction of 23.11 and 10.15  is: "+op( 23.11, 10.15));



    }
}