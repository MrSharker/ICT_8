using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Ex6
{
    class HaircutAS : Algorithm
    {
        public HaircutAS(int ST, int FI) : base(ST, FI) { }

        public override void Process()
        {
            int RStart = Start;
            int LStart = Start;
            while ((RStart < Finish) || (LStart > 0))
            {
                Console.WriteLine("Длина волос на правой сторне головы {0} см", RStart + 1);
                Console.WriteLine("Длина волос на левой сторне головы {0} см", LStart - 1);
                RStart = RStart + 1;
                LStart = LStart - 1;
            }

            Console.WriteLine("Ассиметричная прическа готова");
        }
    }
}
