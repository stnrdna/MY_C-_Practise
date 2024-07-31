﻿/*
 * C# Program to Print the Sum of all the Multiples of 3 and 5
 */
using System;
class Program
{
    public static void Main()
    {
        int number, i, k, count = 1;
        Console.Write("Enter number of rows : ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        count = number - 1;
        for (k = 1; k <= number; k++) //using the nested loop
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count--;
            for (i = 1; i <= 2 * k - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        count = 1;
        for (k = 1; k <= number - 1; k++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count++;
            for (i = 1; i <= 2 * (number - k) - 1; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}