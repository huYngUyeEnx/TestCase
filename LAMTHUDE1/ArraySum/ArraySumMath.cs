using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMTHUDE1.ArraySum
{
    public class ArraySumMath
    {
        public static int Sum(int[] arr)
        {
            if (arr == null) return 0;
            int s = 0;
            for (int i=0; i<arr.Length; i++) s += arr[i];
            return s;
                
            }
        }
    }
