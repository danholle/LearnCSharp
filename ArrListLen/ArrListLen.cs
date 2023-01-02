using System;

namespace ArrListLen
{
    public class Solution
    {
        // describe the problem here
        public int solution(int[] A)
        {
            int i = 0;
            int len = 0;
            while (i>=0)
            {
                len++;
                i = A[i];
            }
            return len;
        } // solution method
    } // Solution class
} // namespace
