using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving.DynamicProgramming
{
    /// <summary>
    /// Dynamic Programming is mainly an optimization over plain recursion.
    /// Wherever we see a recursive solution that has repeated calls for same inputs, we can optimize it using Dynamic Programming. The idea is to simply store the results of subproblems, so that we do not have to re-compute them when needed later. 
    /// This simple optimization reduces time complexities from exponential to polynomial.
    /// optimize recursive solutions.
    /// Use dynamic programming or memoization to optimize recursive solutions.
    /// </summary>
    public class FibonacciNumber : IExecutableCode
    {
        private int Fib(int n)
        {
            Console.WriteLine(n);
            if (n <= 1) return 1;
            return Fib(n - 1)+Fib(n-2);
        }
        void IExecutableCode.MainBruteForceWay()
        {
            Console.WriteLine($"Fib of 5 {Fib(5)}");
        }

        void IExecutableCode.MainByPattern()
        {
            Console.WriteLine($"Fib of 5 {FibUsingDP(5)}");
        }
        private int FibUsingDP(int n)
        {
            int[] data = new int[n+1];
            data[0] = 1;
            data[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                data[i] = data[i - 1] + data[i - 2];
            }
            return data[n];
        }
        string IExecutableCode.Pattern()
        {
            return "Dynamic Programming";
        }

        string IExecutableCode.Problem()
        {
            return "FibonacciNumber using Dynamic Programming";
        }
    }
}
