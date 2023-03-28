using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving.BinarySearch
{
    internal class PowerPowder
    {
        bool CanPick(int cookies, int[] needed, int[] got, int k, int n)
        {
            int md = 0;
            for (int i = 0; i < n; i++)
            {
                if (got[i] >= needed[i] * cookies) continue;
                md += needed[i] * cookies - got[i];
                if (md > k) return false;
            }
            return md <= k;
        }

        int BinarySearch(int[] needed, int[] got, int n, int k)
        {
            int s = 0;
            int en = (int)Math.Pow(10, 9);

            while (s < en)
            {
                int mid = s + (en - 1) / 2;
                // validate with binary seaerch all before is accepted all after is not accepted
                if (CanPick(mid, needed, got, k, n))
                {
                    s = mid;
                }
                else
                {
                    en = mid - 1;
                }
            }
            return s;
        }

        void Run()
        {
            var fsLine = Console.ReadLine();
            var fs = fsLine.Split(' ').Select(int.Parse).ToArray();
            var scLine = Console.ReadLine();
            var needed = scLine.Split(' ').Select(int.Parse).ToArray();
            var tcLine = Console.ReadLine();
            var got = tcLine.Split(' ').Select(int.Parse).ToArray();
            var n = fs[0];
            var k = fs[1];
            Console.WriteLine(BinarySearch(needed, got, n, k));
        }
    }
}
