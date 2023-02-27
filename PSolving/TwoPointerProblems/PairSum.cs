using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
namespace PSolving.TwoPointerProblems
{
    /// <summary>
    /// is really an easy and effective technique that is typically used for searching 
    /// pairs in a sorted array.
    /// </summary>
    //The two pointer approach involves the use of multiple pointers.That’s it. Simple, right?!
    //We use these multiple pointers to keep track of multiple indices of our input.
    //This is useful because it allows us to look at the values of two different indices at the same time. We can then make a decision based on the two values.
    public class PairSum : IExecutableCode
    {
        private  int isPairSum(int[] A, int N, int X)
        {

            // Nested for loops for iterations
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {

                    // As equal i and j means same element
                    if (i == j)

                        // continue keyword skips the execution
                        // for following condition
                        continue;

                    // Condition check if pair exists
                    if (A[i] + A[j] == X)
                        return 1;

                    // By now the array is sorted
                    if (A[i] + A[j] > X)

                        // Break keyword to hault the execution
                        break;
                }
            }

            // No pair found with given sum.
            return 0;
        }
        void IExecutableCode.MainBruteForceWay()
        {
            int[] arr = { 2, 3, 5, 8, 9, 10, 11 };

            int val = 17;

            Console.WriteLine(isPairSum(arr, arr.Length, val));
        }
        private  int isPairSumPattern(int[] A, int N, int X)
        {
            // represents first pointer
            int i = 0;

            // represents second pointer
            int j = N - 1;

            while (i < j)
            {

                // If we find a pair
                if (A[i] + A[j] == X)
                    return 1;

                // If sum of elements at current
                // pointers is less, we move towards
                // higher values by doing i++
                else if (A[i] + A[j] < X)
                    i++;

                // If sum of elements at current
                // pointers is more, we move towards
                // lower values by doing j--
                else
                    j--;
            }
            return 0;
        }
        void IExecutableCode.MainByPattern()
        {
            int[] arr = { 2, 3, 5, 8, 9, 10, 11 };

            // value to search
            int val = 17;

            // size of the array
            int arrSize = arr.Length;

            // Function call
            Console.WriteLine(isPairSumPattern(arr, arrSize, val));
        }

        string IExecutableCode.Pattern()
        {
            return ("Two Pointer");
        }

        string IExecutableCode.Problem()
        {
            return ("Find the sum of two pairs to get x value");
        }
    }
}
