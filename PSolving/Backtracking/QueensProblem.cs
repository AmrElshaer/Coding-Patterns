using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving.Backtracking
{
    /// <summary>
    /// always 2^n grow expontenal  if you go to all solution of subset problem n is size equal 10 
    /// the result will be 1024 if size increase by one it will be 2048
    /// A backtracking algorithm is a problem-solving algorithm that uses a brute force approach 
    /// for finding the desired output.
    /// The Brute force approach tries out all the possible solutions and chooses 
    /// the desired/best solutions.
    /// The term backtracking suggests that if the current solution is not suitable, then backtrack and try other solutions. 
    /// Thus, recursion is used in this approach.
    /// This approach is used to solve problems that have multiple solutions. 
    /// If you want an optimal solution, you must go for dynamic programming.
    /// State Space Tree
    /// A space state tree is a tree representing all the possible states(solution or nonsolution)
    /// of the problem from the root as an initial state to the leaf as a terminal state.
    /// Use backtracking or brute force to generate all possible solutions and then filter them based on constraints.
    /// </summary>
    public class QueensProblem : IExecutableCode
    {
        void IExecutableCode.MainBruteForceWay()
        {
            Console.WriteLine("is brute force");
        }

        void IExecutableCode.MainByPattern()
        {
            Arrange(new int[3], 0);
        }
        void Arrange(int[] arrangement, int index)
        {
            // Base case: if we have placed all 3 people in the arrangement, print it
            if (index == 3)
            {
                Console.WriteLine(string.Join(" ", arrangement));
                return;
            }

            // Recursive case: try placing each person on the next bench
            for (int i = 0; i < 3; i++)
            {
                // Check if the bench is empty
                if (arrangement[i] == 0)
                {
                    // Try placing the girl on this bench, but only if it's not the middle bench
                    if (index != 1)
                    {
                        arrangement[i] = 1;
                        Arrange(arrangement, index + 1);
                        arrangement[i] = 0;
                    }

                    // Try placing a boy on this bench
                    arrangement[i] = 2;
                    Arrange(arrangement, index + 1);
                    arrangement[i] = 0;
                }
            }
        }
        string IExecutableCode.Pattern()
        {
            return "BackTracking algorithm";
        }

        string IExecutableCode.Problem()
        {
            return "rearrange two boys and one girl in three place Girl should not be on the middle bench";
        }
    }
}
