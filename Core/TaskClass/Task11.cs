using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task11
    {
        public string Count(int[] arr)
        {
            int count = 0;
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0 && arr[i] >= 0)
                {
                    count++;
                    sum += arr[i];
                }
            }

            return $"Количество элементов: {count}\nСумма элементов: {sum}";
        }
    }
}
