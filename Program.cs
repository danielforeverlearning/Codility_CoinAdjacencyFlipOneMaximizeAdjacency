using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_CoinAdjacencyFlipOneMaximizeAdjacency
{
    class Program
    {
        static int solution(int[] A)
        {
            if (A.Length == 1)
                return 0;

            int result = 0;
            // how many pairs of coins we have now 
            for (int ii = 0; ii <= (A.Length - 2); ii++)
            {
                if (A[ii] == A[ii + 1])
                    result++;
            }

            int revers = 0;
            for (int ii = 0; ii < A.Length; ii++)
            {
                int count = 0;
                if (ii > 0)
                {
                    count = (A[ii - 1] != A[ii]) ? count + 1 : count - 1;
                }
                if (ii < (A.Length - 1))
                {
                    count = (A[ii] != A[ii + 1]) ? count + 1 : count - 1;
                }
                revers = Math.Max(revers, count);
            }
            return result + revers;
        }

        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 1, 0, 1, 0, 0, 1, 1 };
            int[] B = new int[] { 1, 1, 1, 1, 1, 0, 1, 1 };
            int[] C = new int[] { 1, 0, 1 };
            int[] D = new int[] { 0, 1, 0 };
            int[] E = new int[] { 1, 1, 0, 0, 0 };
            Console.WriteLine(solution(A)); // 5
            Console.WriteLine(solution(B)); // 7
            Console.WriteLine(solution(C)); // 2
            Console.WriteLine(solution(D)); // 2
            Console.WriteLine(solution(E)); // 3
        }
    }
}
