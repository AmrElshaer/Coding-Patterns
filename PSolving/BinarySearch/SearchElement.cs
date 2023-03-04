using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving.BinarySearch
{
    internal class SearchElement : IExecutableCode
    {
        void IExecutableCode.MainBruteForceWay()
        {
            Console.WriteLine("Linear search");
        }

        void IExecutableCode.MainByPattern()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;

            int result = binarySearch(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
        }

        private int binarySearch(int[] arr, int l, int r, int x)
        {
            if (l<r)
            {
                int mid = l + (r - 1) / 2;
                if (x == arr[mid]) return mid;
                if (x > arr[mid]) return binarySearch(arr, mid + 1, r, x);
                return binarySearch(arr, l, mid-1, x);
            }
            return -1;
            
        }

        string IExecutableCode.Pattern()
        {
            return "Binary Search";
        }

        string IExecutableCode.Problem()
        {
            return "Search for element in sorted array";
        }
    }
}
