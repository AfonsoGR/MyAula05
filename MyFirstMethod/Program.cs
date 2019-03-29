using System;

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
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }

        /// <summary>
        /// a method that will use the previous method, CountToN, to count to 10
        /// </summary>
        static void CountTo10()
        {
            CountToN(10);
        }

        /// <summary>
        /// the method that calls the other methods in order do display the results
        /// </summary>
        /// <param name="args">used to give the methods the n value required</param>
        static void Main(string[] args)
        {

            int nCount = 2;
            int nCountA = 5;
            CountToN(nCount);
            CountToN(nCountA);

            CountTo10();
            CountTo10();
        }
    }
}
