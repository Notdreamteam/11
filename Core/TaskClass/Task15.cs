using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task15
    {
        public double[] Sort(double[] arr)
        {
            Array.Sort(arr, 0, 6);
            Array.Sort(arr, 7, 13);
            Array.Reverse(arr, 7, 13);
            return arr;
        }
    }
}
