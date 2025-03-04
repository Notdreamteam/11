using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task24
    {
        public string SumAndCount(double[] arr)
        {
            double last = arr[arr.Length - 1];
            double sum = 0;
            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < last)
                {
                    sum += arr[i];
                    count++;
                }
            }
            return $"Сумма: {sum}\nКол-во: {count}";
        }
    }
}
