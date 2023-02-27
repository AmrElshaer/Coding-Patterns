using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace PSolving.SlidingWindowProblems
{
    //https://www.geeksforgeeks.org/window-sliding-technique/
    //Use sliding window technique
    //for problems that involve
    //handling the input data in a
    //specific window size.
    //where the size of window for computation is fixed throughout the complete nested loop
    /// <summary>
    /// Window Sliding Technique is a computational technique 
    /// which aims to reduce the use of nested loop and replace it with a single loop,
    /// thereby reducing the time complexity.
    /// Find the size of window required 
    ///Compute the result for 1st window, i.e.from start of data structure
    ///Then use a loop to slide the window by 1, and keep computing the result window by window
    /// </summary>

    public  class MaximumSumProblem:IExecutableCode
    {

        // Returns maximum sum in a
        // subarray of size k.
        private int maxSum(int[] arr, int n, int k)
        {
            int sum = 0;
            for (int i = 0; i < n-k+1; i++)
            {
                var currentSum = 0;
                for (int j = 0; j < k; j++)
                {
                    currentSum= currentSum + arr[j+i];
                }
                sum=Math.Max(sum, currentSum);
            }
            return sum;
        }

       

        string IExecutableCode.Pattern()
        {
            return "Sliding window";
        }

        string IExecutableCode.Problem()
        {
            return "max sum by K element";
        }

        void IExecutableCode.MainBruteForceWay()
        {
            int[] arr = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
            int k = 4;
            int n = arr.Length;
            Console.WriteLine(maxSum(arr, n, k));
        }
        private int maxSumByPattern(int[] arr, int n, int k)
        {

            // n must be greater
            if (n < k)
            {
                Console.WriteLine("Invalid");
                return -1;
            }

            // Compute sum of first window of size k
            int max_sum = 0;
            for (int i = 0; i < k; i++)
                max_sum += arr[i];

            // Compute sums of remaining windows by
            // removing first element of previous
            // window and adding last element of
            // current window.
            int window_sum = max_sum;
            for (int i = k; i < n; i++)
            {
                window_sum += arr[i] - arr[i - k];
                max_sum = Math.Max(max_sum, window_sum);
            }

            return max_sum;
        }
        void IExecutableCode.MainByPattern()
        {
            int[] arr = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
            int k = 4;
            int n = arr.Length;
            Console.WriteLine(maxSumByPattern(arr, n, k));
        }
    }

}
