using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task25
    {
        public int[] NewArr(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int positiveSum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= 0)
                    positiveSum += arr[i];
            }

            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i] - positiveSum;
            }

            return newArr;
        }
    }
}
