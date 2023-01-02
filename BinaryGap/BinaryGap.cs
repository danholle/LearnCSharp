using System;

namespace BinaryGap
{
    public class Solution
    {
        public int solution(int N)
        {
            // We scan the bit string N, viewing the rightmost (least significant) bit,
            // updating counts and state, and shifting right to expose the next bit.
            int n = N; // The shifted bit string
            int gap = 0; // When we're inside a gap, we count the 0's here.
            int maxgap = 0; // When we hit an end of gap, we keep the count if it's largest,

            // The state of the scan (at the top of the while loop)
            enum State 
            {
                Need1, // We haven't encountered a 1 yet so no gaps in sight
                Got1,  // We HAVE seen a 1 so now we are looking for a gap to start
                InGap  // We are in a gap, counting how many 0's there are
            }
            State state = State.Need1;

            while (n!=0)
            {
                bool bit = ((n & 1) == 1);
                // States at the top of this loop:
                // 0 means we are scanning for a 1 bit as the right bound of the series.
                // 1 means we are looking for a 0 to the left of a 1 bit
                // 2 means we are in a gap, and have counted 'gap' 0s so far
                switch (state)
                {
                    case State.Need1:
                        if (bit) state = State.Got1;   
                        break;
                    case State.Got1:
                        if (!bit) { gap = 1; state = State.InGap; }
                        break;
                    case State.InGap:
                        if (bit)
                        {
                            state = State.Got1;
                            if (gap > maxgap) { maxgap = gap; }
                        }
                        else
                        {
                            gap += 1;
                        }
                        break;
                    default:
                        break;
                }
                n = n >> 1;

            } // while still have bits to look at
            return maxgap;
        } // solution method
    } // Solution class
} // namespace
