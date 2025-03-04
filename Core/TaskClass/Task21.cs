using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task21
    {
        public double[] NewArr(double[] arr)
        {
            double min = arr[0];
            int minIdx = 0;
            double last = arr[arr.Length - 1];

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIdx = i;
                }
            }

            min *= 3;
            arr[minIdx] = last;
            arr[arr.Length - 1] = min;

            return arr;
        }
    }
}
