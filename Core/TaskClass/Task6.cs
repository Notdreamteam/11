using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.Core.TaskClass
{
    public class Task6
    {
        public string Define(int[] arr)
        {
            int countEven = 0;
            int countOdd = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    countEven++;
                else
                    countOdd++;
            }

            if (countEven > countOdd) return "Четных больше";
            else if (countOdd == countEven) return "Одинаковое кол-во";
            else return "Нечетных больше";
        }
    }
}
