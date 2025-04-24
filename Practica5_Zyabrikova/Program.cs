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
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);

            double F = 2 * Math.Cos(x);
            Console.WriteLine($"Для значения х = {x}, F = {F}");
        }
    }
}
