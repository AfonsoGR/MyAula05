using System;

namespace Fibonacci
{
    class Program
    {
        static int Fibonacci(int n)
        {
            int res;
            if (n <= 2)
            {
                res = 1;
            }
            else
            {
                res = Fibonacci(n-1) + Fibonacci(n-2);
            }
            return res;
        }
        

        static void Main(string[] args)
        {
            string numeroS;
            int n;

            Console.WriteLine("Insira um número inteiro.");
            numeroS = Console.ReadLine();
            
            n = Convert.ToInt32(numeroS);

            Console.WriteLine("O número na posição pedida é o {0}", Fibonacci(n));
        }
    }
}
