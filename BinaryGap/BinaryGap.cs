using System;

namespace BinaryGap
{
    public class Solution
    {
        enum State 
        {
            Need1,
            Got1,
            InGap
        }

        public int solution(int N)
        {
            int n = N;
            int gap = 0;
            int maxgap = 0;
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

            }
            return maxgap;
        }
    }
}
