using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving._75_Blind_leetcode_questions
{
    internal class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            int[] charCount = new int[26]; // assuming input strings only contain lowercase English letters
            for (int i = 0; i < s.Length; i++)
            {
                charCount[s[i] - 'a']++; // increment count for character in s
                charCount[t[i] - 'a']--; // decrement count for character in t
            }
            for (int i = 0; i < charCount.Length; i++)
            {
                if (charCount[i] != 0)
                {
                    return false; // if any count is not 0, then s and t are not anagrams
                }
            }
            return true;
        }
        public bool AnotherIsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            var ds = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (ds.ContainsKey(c))
                {
                    ds[c]++;
                }
                else
                {
                    ds.Add(c, 1);
                }
            }
            foreach (var c in t)
            {
                if (ds.ContainsKey(c))
                {
                    ds[c]--;

                }
                else
                {
                    ds.Add(c, -1);

                }

            }
            foreach (var item in ds)
            {
                if (item.Value != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
