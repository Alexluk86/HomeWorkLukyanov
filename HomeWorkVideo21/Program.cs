using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkVideo21
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumbers = 0;
            int oddNumbers = 0;

            Console.WriteLine("Введите первое число: ");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число: ");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbers++;
                }
                else
                {
                    oddNumbers++;
                }
                currentValue++;
            }


            Console.WriteLine("Количество нечетных чисел: " + evenNumbers);
            Console.WriteLine("Количество четных чисел: " + oddNumbers);
            Console.ReadKey();
        }
    }
}
