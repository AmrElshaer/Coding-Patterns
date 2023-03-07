using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving.GreadyAlgorithm
{
    /// <summary>
    /// is an approach for solving a problem by selecting the best option available at the moment.
    /// It doesn't worry whether the current best result will bring the overall optimal result.
    /// If the optimal overall solution to the problem corresponds to the optimal solution to its subproblems,
    /// then the problem can be solved using a greedy approach. 
    /// This property is called optimal substructure.
    /// </summary>
    public class MaxSum : IExecutableCode
    {
        void IExecutableCode.MainBruteForceWay()
        {
            Console.WriteLine("Main Brute Force");
        }

        void IExecutableCode.MainByPattern()
        {
            Console.WriteLine("Main by pattern");
            int[] num= { 5,2,1 };
            Console.WriteLine("Enter the amount");
            int amount = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int remainingAmount = amount;
            List<int> resultList = new List<int>();

            for (int i = 0; i < num.Length; i++)
            {
                int currentNum = num[i];
                int numCount = remainingAmount / currentNum;

                if (numCount > 0)
                {
                    resultList.AddRange(Enumerable.Repeat(currentNum, numCount));
                    totalSum += numCount * currentNum;
                    remainingAmount = amount - totalSum;
                }
            }

            Console.WriteLine(string.Join(",", resultList));




        }

        string IExecutableCode.Pattern()
        {
            return "Greedy Algorithm";
        }

        string IExecutableCode.Problem()
        {
            return "You have to make a change of an amount using the smallest possible number of coins.";
        }
    }
}
