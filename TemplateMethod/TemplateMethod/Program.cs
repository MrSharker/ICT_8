using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 3 числа: ");
            int f = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());

            Progression val = new ArithmeticProgression(f, l, h);
            val.TemplateMethod();
            Progression val1 = new GeometricProgression(f, l, h);
            val1.TemplateMethod();
            System.Console.ReadKey();
        }
    }
}
