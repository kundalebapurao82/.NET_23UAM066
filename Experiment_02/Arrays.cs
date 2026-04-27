using System;

// Arrays are usd to store multiple values

// Storing multiple numbers

class MyArrayClass
{
    public static void Main()
    {
        
        int[] numbers = {1,2,3,4,5};
        Console.WriteLine("Array elemets: ");
        for(int i=0; i< numbers.Length; i++)
        {
            Console.Write(numbers[i]+" ");
        }
        Console.WriteLine();


        // Declaring array with new keyword

        int[] array2 = new int[5];
        Console.Write("Enter 5 numbers: ");
        for(int i=0; i< array2.Length;i++)
        {
            array2[i] = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}

