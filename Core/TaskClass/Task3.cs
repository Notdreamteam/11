using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task3
    {
        public int Count(int[] arr)
        { 
            int arithmetic = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                arithmetic += arr[i];
            }
            arithmetic /= arr.Length;

            for(int i = 0; i < arr.Length; ++i)
            {
                if (Math.Abs(arr[i]) > arithmetic)
                    ++count;
            }
            return count;
        }
    }
}
