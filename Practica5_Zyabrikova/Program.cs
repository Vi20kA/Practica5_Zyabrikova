using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5_Zyabrikova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работу выполнила Зябрикова Виктория");
        
            Console.Write("Введите значения параметра х = ");
            int x = Convert.ToInt32(Console.ReadLine());

            double F = (Math.Sin(x) - Math.Cos(x))/5;
            Console.WriteLine("Ответ функции (Sin(x)-Cos(x))/5 = " + F);

            Console.ReadKey();
        }
    }
}
