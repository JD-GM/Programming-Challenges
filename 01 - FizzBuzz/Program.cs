﻿internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("fizzbuzz");
            
            else if (i % 5 == 0 ) Console.WriteLine("buzz");
            
            else if (i % 3 == 0) Console.WriteLine("fizz");

            else Console.WriteLine(i);
        }
    }
}