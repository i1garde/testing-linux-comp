using System;
using EazyCalculationLibrary.Abstract;
using EazyCalculationLibrary.Impl;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            ISquareFinder squareFinder = new SquareFinder();
            Console.WriteLine(squareFinder.FindSquare(num));
        }
    }
}