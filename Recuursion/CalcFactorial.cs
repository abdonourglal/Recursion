using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuursion
{
     static class CalcFactorial
    {
         public static int CalculateFactorial(int number)
        {
            // if the number is 1 or less we will return the number again
            if (number <= 1) return number;
            // if the number more than 1  we will multiply the in n-1 * n-2 * n-3 .. 
            return number* CalculateFactorial(number - 1);

        }
    }
}
