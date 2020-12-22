using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Ex6
{
    class HaircutN : Algorithm
    {
        public HaircutN(int ST, int FI) : base(ST, FI) { }

        public override void Process()
        {
            while (Start > Finish)
            {
                Console.WriteLine("Длина волос {0} см", Start - 1);
                Start = Start - 1;
            }

            Console.WriteLine("Нормальная стрижка готова");
        }
    }
}
