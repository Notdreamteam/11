using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task29
    {
        public double Quotient(double[] arr)
        {
            double positiveProduct = 1;
            double negativeSum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    positiveProduct *= arr[i];
                else negativeSum += arr[i];
            }

            double quotient = positiveProduct / negativeSum;

            return quotient;
        }
    }
}
