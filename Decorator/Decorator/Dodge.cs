using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Dodge : AutoBase
    {
        public Dodge(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }
        public override double GetCost()
        {
            return CostBase * 1.45;
        }
    }
}
