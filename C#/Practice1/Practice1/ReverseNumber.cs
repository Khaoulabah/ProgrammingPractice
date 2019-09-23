using System;

namespace Practice1
{
    public class ReverseNumber
    {
        //Given a 32-bit signed integer, reverse digits of an integer.
        public static int Reverse(int x)
        {
            string output = "";
            int quotient = x;
            int remainder = 0;
            int result = 0;
            if (x == 0)
            {
                return 0;
            }

            if (x < 0)
            {
                output = "-";
                quotient = quotient * -1;
            }
            while (quotient / 10 != 0)
            {
                remainder = quotient % 10;
                quotient = quotient / 10;
                output = output + remainder;
            }
            output = output + quotient;

            try
            {
                result = checked(Convert.ToInt32(output));
            }
            catch
            {
                result = 0;
            }
            return result;
        }
    }
}
