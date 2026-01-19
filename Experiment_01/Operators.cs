// We use operators to perform operations on variables and values.

using System;

class MyArithmetic
{
    public static void Main()
    {
        // ========== Arithmetic    
        Console.WriteLine("Enter two values to perform arithmetic operations: ");
        Console.Write("Value 1: ");
        double firstVal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Value 2: ");
        double secondVal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Value 1: "+firstVal+" Value 2: "+secondVal);

        // Addition
        Console.WriteLine(firstVal+" + "+secondVal+" = "+(firstVal+secondVal));
        // Subtraction
        Console.WriteLine(firstVal+" - "+secondVal+" = "+(firstVal-secondVal));
        // Myltiplication
        Console.WriteLine(firstVal+" * "+secondVal+" = "+(firstVal*secondVal));
        // Divison
        Console.WriteLine(firstVal+" / "+secondVal+" = "+(firstVal/secondVal));
        // Modulus
        Console.WriteLine(firstVal+" % "+secondVal+" = "+(firstVal%secondVal));
        // Post Increment
        Console.WriteLine(firstVal+"++"+" = "+firstVal++);
        Console.WriteLine("firstVal = "+ firstVal);
        // Post Decrement
        Console.WriteLine(firstVal+"--"+" = "+firstVal--);
        Console.WriteLine("firstVal = "+ firstVal);

        // PreIncrement
        Console.WriteLine("++"+firstVal+" = "+(++firstVal));
        // PreDecrement
        Console.WriteLine("--"+firstVal+" = "+(--firstVal));

    }

}