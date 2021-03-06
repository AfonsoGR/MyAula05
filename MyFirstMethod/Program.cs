﻿using System;

namespace MyFirstMethod
{
    /// <summary>
    /// class program that has the to be executed code
    /// </summary>
    class Program
    {
        /// <summary>
        /// a method that counts all the way to a number n and prints it
        /// </summary>
        /// <param name="n">an int that the method will count up to</param>
        static void CountToN(int n)
        {
            //counts all the way up to provided n number
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }

        /// <summary>
        /// a method that counts from a number n1 to a number n2
        /// </summary>
        /// <param name="n1">the variable that will be the starting number</param>
        /// <param name="n2">the variable that will be the ending number</param>
        static void CountToN(int n1, int n2)
        {
            //counts all the way from n1 to n2 provided
            for (int i = n1; i <= n2; i++)
                Console.WriteLine(i);
        }

        /// <summary>
        /// a method that will use the previous method, CountToN, to count to 10
        /// </summary>
        static void CountTo10()
        {
            //calls method CountT0N in order to count to 10
            CountToN(10);
        }

        /// <summary>
        /// the method that calls the other methods in order do display the results
        /// </summary>
        /// <param name="args">used to give the methods the n value required</param>
        static void Main(string[] args)
        {
            //variables int, used in method nCount
            int nCount = 2;
            int nCountA = 5;

            //variables for CountToN with different signatures - overloading
            int n1 = 3;
            int n2 = 8;

            //calls nCount twice with variables int provided
            CountToN(nCount);
            CountToN(nCountA);

            //calls CountTo10
            CountTo10();
            CountTo10();

            //calls method CountToN with 2 int signature instead of regular CountToN
            CountToN(n1, n2);

        }
    }
}
