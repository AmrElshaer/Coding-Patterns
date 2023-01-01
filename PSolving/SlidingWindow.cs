namespace PSolving
{
    //is a computational technique which aims to reduce the use of nested loop and replace it with a single loop,
    //thereby reducing the time complexity. 
    internal class SlidingWindow
    {
        //
        // data [1,2,3,4,5,6,7,8]
        // k=3
        // longest concestive sum
        // 1,2,3,4  - 2,3,4,5 - 3,4,5,6 - 4,5,6,7 ...
        public static int MaxSum(int[] data, int k)
        {
            return Window_Slide(data, k);
        }

        private static int Window_Slide(int[] data, int k)
        {
            // compute sum of first slide
            int firstSum = 0;
            for (int i = 0; i < k; i++)
            {
                firstSum += data[i];
            }
            var x = firstSum;
            for (int i = k; i < data.Length; i++)
            {
                x += data[i] - data[i - k];
                firstSum = Math.Max(x, firstSum);
            }
            return firstSum;
        }
        public static int Brut_forcex(int[] data, int k)
        {
            int maxSum = 0;
            for (int i = 0; i < data.Length-k+1; i++)
            {
                int end = (i+k);
                int tempsum = 0;
                int start = i;
                while (start< end)
                {
                    tempsum+= data[start];
                    start++;
                }
               maxSum=Math.Max(tempsum, maxSum);
            }
            return maxSum;
        }
        public static int Brut_force(int[] data, int k)
        {
            int sum = int.MinValue;
            for (int i = 0; i < data.Length - k + 1; i++)
            {
                int y = 0;
                int tempSum = 0;
                while (y < k)
                {
                    tempSum += data[y + i];
                    y++;
                }

                sum = Math.Max(tempSum, sum);
            }

            return sum;
        }
    }
}
