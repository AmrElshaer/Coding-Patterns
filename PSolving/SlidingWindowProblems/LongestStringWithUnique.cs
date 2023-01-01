namespace PSolving.SlidingWindowProblems
{
    public class LongestStringWithUnique
    {
        //aabbcc k=2
        //step 1 aa k=1
        // step 2 bb k=2
        public static int LongestWithUnique(char[] s, int k)
        {
            int n = s.Length;
            int answer = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    HashSet<char> distinct
                        = new HashSet<char>();
                    for (int x = i; x < j; x++)
                    {
                        distinct.Add(s[x]);
                    }
                    if (distinct.Count == k)
                    {
                        answer = Math.Max(answer, j - i);
                    }
                }
            }
            return answer;
        }
    }
}
