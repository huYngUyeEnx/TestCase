using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMTHUDE1
{
    public class MathCal
    {
        public int SumOddNumber(int n)
        {
            if (n < 1) return 0; // xử lý biên âm
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            return sum;
        }
    }
}
