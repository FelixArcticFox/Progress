using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогрессия
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1;
            int step;
            int n;
            int sum = 0;
            Console.WriteLine("Введите первый элемент");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель прогрессии");
            step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число элементов");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum += a1 + i * step;
            }
            Console.WriteLine("Сумма членов прогрессии равна " + sum);
            Console.ReadKey();
        }
    }
}
