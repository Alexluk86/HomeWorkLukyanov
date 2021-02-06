using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkVideo28_4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите высоту треугольника: ");
                int visota = int.Parse(Console.ReadLine());

                for (int i = 0; i < visota; i++)
                {
                    Console.SetCursorPosition(visota - i, i + 1);
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                }

                Console.ReadLine();
                Console.ReadKey();

            }
        }
    }
}
