using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task16
    {
        public int Count(double[] arr)
        {
            int sum = 0;
            double max = 0;
            double min = arr[0];
            int maxIdx = 0;
            int minIdx = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIdx = i;
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIdx = i;
                }
            }

            if (maxIdx > minIdx)
            {
                for (int i = minIdx + 1; i < maxIdx; ++i)
                {
                    ++sum;
                }
            }
            else
            {
                for (int i = maxIdx + 1; i < minIdx; ++i)
                {
                    ++sum;
                }
            }
            return sum;
        }
    }
}
