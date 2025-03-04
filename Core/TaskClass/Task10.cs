using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task10
    {
        public int Sum(int[] arr)
        {
            int arithmetic = 0;
            int countNegative = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < 0)
                {
                    arithmetic += Math.Abs(arr[i]);
                    countNegative++;
                }
            }
            arithmetic /= countNegative;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (Math.Abs(arr[i]) > arithmetic)
                    sum += arr[i];
            }
            return sum;
        }
    }
}
