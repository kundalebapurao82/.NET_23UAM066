using System;
using System.Collections.Generic;
using System.Linq;

public class Lambda
{
    public static void Main()
    {
        
        List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };
        var oddNumbers = numbers.Count(n => n % 2 == 1);

        Console.WriteLine(oddNumbers);
    }
}