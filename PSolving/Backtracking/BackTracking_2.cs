using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving.Backtracking
{
    internal class BackTracking_2
    {
        int[] digits = new int[] { 1, 2, 3, 5, 8, 13, 21, 34 };
        int[] res = new int[8];
        void Solve(int pos, int cn)
        {
            if (pos == digits.Length)
            {
                if (cn == 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write(res[i]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                res[cn] = digits[pos];
                // pick
                Solve(pos + 1, cn + 1);
                // leave
                Solve(pos + 1, cn);
            }
        }

    }
}
