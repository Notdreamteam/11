using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task2
    {
        public int[] NewArray(int[] arr)
        {
            int[] newArr = arr;

            int arithmetic = 0;
            for(int i = 0; i < arr.Length; ++i)
            {
                arithmetic += arr[i];
            }
            arithmetic /= arr.Length;

            newArr[4] = arithmetic;

            return newArr;
        }
    }
}
