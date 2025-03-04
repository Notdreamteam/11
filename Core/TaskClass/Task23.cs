using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task23
    {
        public string SumAndProduct(int[] arr)
        {
            int sum = 0;
            int product = 1;

            for(int i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    sum += arr[i];
                }
                else
                {
                    product *= arr[i];
                }
            }
            return $"Сумма четных: {sum}\nПроизведение нечетных: {product}";
        }
    }
}
