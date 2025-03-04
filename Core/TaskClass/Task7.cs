using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task7
    {
        public int Count(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > arr[0])
                    ++count;
            }
            return count;
        }
    }
}
