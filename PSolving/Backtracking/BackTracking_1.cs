using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving.Backtracking
{
    public class Solution
    {
        public IList<string> res = new List<string>();
        char[][] data = new char[10][];
        public Solution()
        {
            data[2] = new char[] { 'a', 'b', 'c' };
            data[3] = new char[] { 'd', 'e', 'f' };
            data[4] = new char[] { 'g', 'h', 'i' };
            data[5] = new char[] { 'j', 'k', 'i' };
            data[6] = new char[] { 'm', 'n', 'o' };
            data[7] = new char[] { 'p', 'q', 'r', 's' };
            data[8] = new char[] { 't', 'u', 'v' };
            data[9] = new char[] { 'w', 'x', 'y', 'z' };
        }

        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }
            var digit = digits.ToCharArray();
            Solve(0, string.Empty, digit);
            return res;
        }
        void Solve(int pos, string val, char[] digit)
        {

            if (val.Length == digit.Length)
            {
                res.Add(val);
            }
            else
            {
                var num = digit[pos].ToString();
                var index = int.Parse(num);
                var chars = data[index];
                foreach (var item in chars) //foreach valid option
                {
                    val += item; // do
                    Solve(pos + 1, val, digit); // recursive
                    val = val.Remove(val.Length - 1); // undo
                }



            }
        }
    }
}
