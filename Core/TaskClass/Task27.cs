using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task27
    {
        public int[] Replacement(int[] arr)
        {
            int max = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[i] = max;
                }
            }
            return arr;
        }
    }
}
