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
    //The two pointer approach involves the use of multiple pointers.That’s it. Simple, right?! We use these multiple pointers to keep track of multiple indices of our input. This is useful because it allows us to look at the values of two different indices at the same time. We can then make a decision based on the two values.
    public class PalindromeString
    {
        public static bool IsPalindrome(char[] text,int l,int r)
        {
            if (l==r)
            {
                return true;
            }
            if (text[l] == text[r])
            {
               return IsPalindrome(text,l+1,r-1);
            }
            else
            {
                return false;
            }
        }
    }
}
