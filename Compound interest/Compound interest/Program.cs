﻿using System;
namespace compund
{
    class compound
    {
        static void Main()
        {
            double Total = 0, interestRate, years, annualCompound, Amount;
            Console.Write("Enter the Initial Amount : ");
            Amount = Double.Parse(Console.ReadLine());
            Console.Write("Enter the Rate of Interest : ");
            interestRate = Double.Parse(Console.ReadLine()) / 100;
            Console.Write("Enter the Number of Years : ");
            years =Double.Parse(Console.ReadLine());
            Console.Write("Number of Times the Interest will be Compounded : ");
            annualCompound =Double.Parse(Console.ReadLine());
            for (int t = 1; t < years + 1; t++)
            {
                Total = Amount * Math.Pow((1 + interestRate / annualCompound),
                                         (annualCompound * t));
                Console.Write("Your Total for Year {0} " + "is {1:F0}. \n", t, Total);

            }

            Console.ReadLine();
        }
    }
}