using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task14
    {
        public double[] Replacement(double[] arr)
        {
            double sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    sum += arr[i];
            }

            for(int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 3 == 0)
                    arr[i] = sum;
            }
            return arr;
        }
    }
}
