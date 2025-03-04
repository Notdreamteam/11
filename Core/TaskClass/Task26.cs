using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task26
    {
        public double Difference(double[] arr)
        {
            double difference = 0;
            double productPositive = 1;
            double productNegative = 1;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    productPositive *= arr[i];
                }
                else
                {
                    productNegative *= Math.Abs(arr[i]);
                }
            }

            difference = productPositive - productNegative;

            return difference;
        }
    }
}
