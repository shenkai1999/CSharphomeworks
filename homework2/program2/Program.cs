using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 14, 57, 9, 22, 36 };
            double max=array[0];
            double min=array[0];
            double average=0;
            double sum=0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];  
                }
                else
                {
                    min = array[i];
                }
                sum += array[i];
            }
            average = sum / array.Length;
            Console.WriteLine("该数组的最大值为：" + max);
            Console.WriteLine("该数组的最小值为：" + min);
            Console.WriteLine("该数组的元素之和为：" + sum);
            Console.WriteLine("该数组的元素平均值为：" + average);
        }
    }
}
