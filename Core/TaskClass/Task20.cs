using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task20
    {
        public (int[] arr, int replacement) Replacement(int[] arr)
        {
            int replacement = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    arr[i] = 0;
                    ++replacement;
                }
            }

            return (arr, replacement);
        }
    }
}
