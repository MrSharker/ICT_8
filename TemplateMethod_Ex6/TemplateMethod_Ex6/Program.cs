using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm H1 = new HaircutN(10, 2);
            Algorithm H2 = new HaircutIR(1, 5);
            Algorithm H3 = new HaircutAS(8, 10);
            H1.Process();
            H2.Process();
            H3.Process();
            System.Console.ReadKey();

            //Был реализован сложный алгоритм 
            //Были созданы конкретные классы, унаследованыные от абстрактного класса.
        }
    }
}
