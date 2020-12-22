using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Ex6
{
    abstract class Algorithm
    {
        public int Start { get; set; }
        public int Finish { get; set; }

        public Algorithm(int ST, int FI)
        {
            Start = ST;
            Finish = FI;
        }

        public void TemplateMethod()
        {
            SetParam(Start, Finish);
            Process();
        }

        private void SetParam(int ST, int FI)
        {
            Start = ST;
            Finish = FI;
        }

        public abstract void Process();
    }
}
