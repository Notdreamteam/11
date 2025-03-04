using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task8
    {
        public string Coords(int[] arr)
        {
            int max = 0;
            int min = arr[0];
            int idx_max = 0;
            int idx_min = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    idx_max = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    idx_min = i;
                }
            }
            return $"Индекс минимального элемента: {idx_min}\nИндекс максимального элемента: {idx_max}";
        }
    }
}
