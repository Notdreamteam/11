using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task4
    {
        public int[] Swap(int[] arr)
        {
            int max = 0;
            int first = arr[0];
            int idx = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    idx = i;
                }
            }

            arr[0] = max;
            arr[idx] = first;

            return arr;
        }
    }
}
