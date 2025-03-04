using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task17
    {
        public string Count(int[] arr)
        {
            int countNegative = 0;
            int productPositive = 1;
            int countZero = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    ++countNegative;
                if (arr[i] > 0)
                    productPositive *= arr[i];
                if (arr[i] == 0)
                    ++countZero;
            }

            return $"Кол-во отрицательных элементов: {countNegative}\nПроизведение положительных: {productPositive}\nКол-во нулевых элементов: {countZero}";
        }
    }
}
