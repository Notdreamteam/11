using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task19
    {
        public string UntilNegative(int[] arr)
        {
            int negative_idx = -1;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    negative_idx = i;
            }

            if (negative_idx == -1)
                return "Отрицательного числа нету";

            for(int i = 0; i < negative_idx; ++i)
            {
                sum += arr[i];
            }
            return $"Сумма: {sum}";
        }
    }
}
