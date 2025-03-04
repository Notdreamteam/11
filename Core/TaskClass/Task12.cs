using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task12
    {
        public double[] Sort(double[] arr)
        {
            Sort(arr);
            Array.Reverse(arr);
            return arr;
        }

        public double Sum(double[] arr)
        {
            double sum = 0;
            double max = 0;
            double min = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < min)
                    min = arr[i];
                if(arr[i] > max)
                    max = arr[i];
            }

            sum += max + min;

            return sum;
        }
    }
}
