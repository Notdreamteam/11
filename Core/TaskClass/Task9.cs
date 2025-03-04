using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task9
    {
        public int[] NewArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];

            int arithmetic = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                arithmetic += arr[i];
            }
            arithmetic /= arr.Length;
            
            for(int i = 0; i < newArr.Length; ++i)
            {
                newArr[i] = arr[i] - arithmetic;
            }

            return newArr;
        }
    }
}
