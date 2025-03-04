using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task28
    {
        public string SumAndCount(double[] arr)
        {
            double arithmetic = 0;
            int countPositive = 0;
            double sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > 0)
                {
                    arithmetic += Math.Abs(arr[i]);
                    countPositive++;
                }
            }
            arithmetic /= countPositive;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (Math.Abs(arr[i]) > arithmetic)
                {
                    sum += arr[i];
                    count++;
                }
            }
            return $"Сумма: {sum}\nКол-во: {count}";
        }
    }
}
